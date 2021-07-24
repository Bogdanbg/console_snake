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

            HorizontalLine upLine = new HorizontalLine(0,78,0,'+');
            HorizontalLine downLine = new HorizontalLine(0,78,24,'+');
           
            VerticalLine leftLine = new VerticalLine(0,24,0,'+');
            VerticalLine rigthLine = new VerticalLine(0,24,78,'+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rigthLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGTH);
            snake.Draw();
            while (true) 
            {
                if (Console.KeyAvailable)
                {
                   ConsoleKeyInfo consoleKey = Console.ReadKey();
                    snake.HandleKey(consoleKey.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
            Console.ReadLine();
        }  
    }
}
