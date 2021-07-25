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

        public Point(int x, int y, char symbol) {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        public Point(Point point) {

            x = point.x;
            y = point.y;
            symbol = point.symbol;
        }

        public bool IsHit(Point point) {
            return point.x == this.x && point.y == this.y;
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
