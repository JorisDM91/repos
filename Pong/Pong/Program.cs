using System;
using System.Threading;

class Program
{
    static int screenWidth = 40;
    static int screenHeight = 20;
    static int paddle1X = 2;
    static int paddle1Y = screenHeight / 2 - 2;
    static int paddle2X = screenWidth - 3;
    static int paddle2Y = screenHeight / 2 - 2;
    static int ballX = screenWidth / 2;
    static int ballY = screenHeight / 2;
    static int ballDirectionX = 1;
    static int ballDirectionY = 1;
    static int playerLives = 5;
    static int playerScore = 0;
    static int cpuScore = 0;

    static void Main()
    {
        Console.WindowHeight = screenHeight;
        Console.WindowWidth = screenWidth;
        Console.BufferHeight = screenHeight;
        Console.BufferWidth = screenWidth;
        Console.CursorVisible = false;

        while (playerLives > 0)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.W && paddle1Y > 0)
                {
                    paddle1Y--;
                }
                else if (key == ConsoleKey.S && paddle1Y < screenHeight - 4)
                {
                    paddle1Y++;
                }
            }

            MoveComputerPaddle();
            MoveBall();
            Draw();
            Thread.Sleep(50);
        }

        Console.Clear();
        Console.SetCursorPosition(screenWidth / 2 - 10, screenHeight / 2);
        Console.WriteLine("Game Over!");
        Console.SetCursorPosition(screenWidth / 2 - 10, screenHeight / 2 + 1);
        Console.WriteLine($"Your Score: {playerScore}  CPU Score: {cpuScore}");
    }

    static void MoveComputerPaddle()
    {
        // Basic AI: The computer's paddle follows the ball vertically.
        if (ballY < paddle2Y + 1 && paddle2Y > 0)
        {
            paddle2Y--;
        }
        else if (ballY > paddle2Y + 1 && paddle2Y < screenHeight - 4)
        {
            paddle2Y++;
        }
    }

    static void MoveBall()
    {
        ballX += ballDirectionX;
        ballY += ballDirectionY;

        // Ball collision with top and bottom walls
        if (ballY == 0 || ballY == screenHeight - 1)
        {
            ballDirectionY *= -1;
        }

        // Ball collision with paddles
        if (ballX == paddle1X + 1 && ballY >= paddle1Y && ballY < paddle1Y + 3)
        {
            ballDirectionX *= -1;
            playerScore++;
        }

        if (ballX == paddle2X - 1 && ballY >= paddle2Y && ballY < paddle2Y + 3)
        {
            ballDirectionX *= -1;
            cpuScore++;
        }

        // Ball out of bounds
        if (ballX == 0 || ballX == screenWidth - 1)
        {
            playerLives--;
            ResetBall();
        }
    }

    static void ResetBall()
    {
        ballX = screenWidth / 2;
        ballY = screenHeight / 2;
        ballDirectionX = 1;
        ballDirectionY = 1;
        Thread.Sleep(1000); // Pause for a moment before starting the next round
    }

    static void Draw()
    {
        Console.Clear();

        // Draw paddles
        for (int i = 0; i < 3; i++)
        {
            Console.SetCursorPosition(paddle1X, paddle1Y + i);
            Console.Write("■");
            Console.SetCursorPosition(paddle2X, paddle2Y + i);
            Console.Write("■");
        }

        // Draw ball
        Console.SetCursorPosition(ballX, ballY);
        Console.Write("●");

        // Draw lives, scores, and instructions
        Console.SetCursorPosition(0, 0);
        Console.Write($"Lives: {playerLives}  Your Score: {playerScore}  CPU Score: {cpuScore}");
        Console.SetCursorPosition(0, screenHeight - 1);
        Console.Write("Use 'W' and 'S' to control your paddle.");
    }
}