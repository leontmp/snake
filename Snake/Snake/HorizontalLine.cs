using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontalLine : Figure {
        public HorizontalLine(int xLeft, int xRight, int y, char sym) {
            pline = new List<Point>();
            for (int i = xLeft; i < xRight; i++) {
                Point p = new Point(i, y, sym);
                pline.Add(p);
            }
        }
    }
}
