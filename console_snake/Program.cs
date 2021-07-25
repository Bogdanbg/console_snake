using System;
using System.Collections.Generic;
using System.Threading;

namespace console_snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGTH);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80,25, '@');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true) {
                if (walls.IsHit(snake) || snake.IsHitTail()) { break; }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }else {
                    snake.Move();
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo consoleKey = Console.ReadKey();
                    snake.HandleKey(consoleKey.Key);
                }


            }
            gameOver();
            Console.ReadLine();
            
        }

        private static void gameOver()
        {
            int xOffset = 35;
            int yOffset = 12;
            Console.SetCursorPosition(xOffset, yOffset);
            WriteText("GAME OVER", xOffset, yOffset);
        }

        private static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset,yOffset);
            Console.WriteLine(text);
        }
    }
}
