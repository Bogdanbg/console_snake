using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction) 
        {
            direction = _direction;
            pointList = new List<Point>();
            for (int i = 0; i < length; i++) 
            {
                Point point = new Point(tail);
                point.Move(i, direction);
                pointList.Add(point);
            }
        }

        internal void Move()
        {
            Point tail = pointList.First();
            pointList.Remove(tail);
            Point head = GetNextPoint();
            pointList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pointList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.symbol = head.symbol;
                pointList.Add(food);
                return true;
            }
            else { return false; }
        }

        public void HandleKey(ConsoleKey consoleKey) {
            switch (consoleKey)
            {
                case ConsoleKey.LeftArrow:
                    direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Direction.RIGTH;
                    break;
                case ConsoleKey.UpArrow:
                    direction = Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.DOWN;
                    break;
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Point point in pointList) {
                point.Draw();
            }
        }

        internal bool IsHitTail() {
            var head = pointList.Last();
            for (int i = 0; i < pointList.Count - 2; i++)
            {
                if (head.IsHit(pointList[i])) { return true; }

            }
            return false;
        }
    }
}
