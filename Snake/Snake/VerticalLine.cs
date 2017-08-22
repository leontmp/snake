using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine {
        List<Point> pline;
        public VerticalLine(int x, int yTop, int yBottom, char sym) {
            pline = new List<Point>();
            for (int i = yTop; i < yBottom; i++) {
                Point p = new Point(x, i, sym);
                pline.Add(p);
            }
        }
        public void Draw() {
            foreach (Point i in pline) {
                i.Draw();
            }
        }
    }
}
