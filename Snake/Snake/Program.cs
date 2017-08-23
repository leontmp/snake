using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            VerticalLine v1 = new VerticalLine(10, 0, 5, '%');
            Draw(v1);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p,4,Direction.RIGHT);
            Draw(fSnake);
            fSnake = (Snake)fSnake;

            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');
            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);
            foreach (Figure item in figures) {
                item.Draw();
            }

            Console.ReadLine();
        }
        static void Draw(Figure figure) {
            figure.Draw();
        }
    }
}