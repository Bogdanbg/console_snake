using System;

namespace console_snake
{

    
    class Program 
    {
        
        static void Main(string[] args)
        {
            

            Point p1 = new Point(1,3,'@');
            for (int k = 0; k < 20; k+=2)
            {
                p1.x = k;
                p1.y = k;
                p1.symbol = '%';
                p1.Draw();
                for (int i = 0; i < k; i+=3)
                {
                    p1.x = i;
                    p1.y = i;
                    p1.symbol = '^';
                    p1.Draw();
                    for (int j = 0; j < i; j+=3)
                    {
                        p1.x = i;
                        p1.y = j;
                        p1.symbol = '@';
                        p1.Draw();
                    }
                }
            }
            //p1.Draw();

            Point p2 = new Point(4,5,'%');
            

           // p2.Draw();


            Console.ReadLine();

        }

        
    }
}
