using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figure {
        protected List<Point> pline;
        public void Draw() {
            foreach (Point i in pline) {
                i.Draw();
            }
        }
    }
}
