﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine : Figure {
        public VerticalLine(int x, int yTop, int yBottom, char sym) {
            pline = new List<Point>();
            for (int i = yTop; i < yBottom; i++) {
                Point p = new Point(x, i, sym);
                pline.Add(p);
            }
        }
        
    }
}
