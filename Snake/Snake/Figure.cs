using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figure {
        protected List<Point> pline;
        public Figure() {
            pline = new List<Point>();
        }
        public void Draw() {
            foreach (Point i in pline) {
                i.Draw();
            }
        }
        internal bool IsHit(Figure figure) {
            foreach (var p in pline) {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point) {
            foreach (var p in pline) {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
