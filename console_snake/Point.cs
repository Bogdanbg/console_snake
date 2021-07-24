using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_snake
{
    class Point
    {
        public int x; 
        public int y;
        public char symbol;


        public Point() { }

        public Point(int _x,int _y,char _symbol) {
            x = _x;
            y = _y;
            symbol = _symbol;
        }

        public Point(Point point) {

            x = point.x;
            y = point.y;
            symbol = point.symbol;
        }


        public void Move(int offset, Direction direction) {
            switch (direction) {

                case Direction.RIGTH:
                    x = x + offset;
                    break;
                case Direction.LEFT:
                    x = x - offset;
                    break;
                case Direction.UP:
                    y = y - offset;
                    break;
                case Direction.DOWN:
                    y = y + offset;
                    break;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public void Clear() {
            symbol = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + symbol;
        }



    }
}
