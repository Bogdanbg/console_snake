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
            Console.SetBufferSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0,78,0,'+');
            HorizontalLine downLine = new HorizontalLine(0,78,24,'+');
           
            VerticalLine leftLine = new VerticalLine(0,24,0,'+');
            VerticalLine rigthLine = new VerticalLine(0,24,78,'+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rigthLine.Draw();

            Console.ReadLine();
        }

        
    }
}
