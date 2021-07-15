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
            Point p3 = new Point(3,5,'^');
            Point p4 = new Point(4,6,'&');
            


            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);
            pointList.Add(p4);

            foreach (Point p in pointList) {
                p.Draw();
            }
            

            Console.ReadLine();

        }

        
    }
}
