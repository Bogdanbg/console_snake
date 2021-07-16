using System;
using System.Collections.Generic;

namespace console_snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'@');
            Point p2 = new Point(2,4,'#');

            HorizontalLine horizontalLine = new HorizontalLine(0,16,8,'+');
            horizontalLine.Draw();

            VerticalLine verticalLine = new VerticalLine(0,16,8,'+');
            verticalLine.Draw();

            Console.ReadLine();
        }

        
    }
}
