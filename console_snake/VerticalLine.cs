using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yBottom, int x, char sym) {
            pointList = new List<Point>();
            for (int y = yUp; y <= yBottom; y++) {
                Point point = new Point(x, y, sym);
                pointList.Add(point);
            }
        }
    }
}
