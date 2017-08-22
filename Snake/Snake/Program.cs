using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(2, 4, '#');
            Point p3 = new Point(5, 6, '-');
            Point p4 = new Point(8, 9, '/');

            List<Point> list = new List<Point>();
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);

            foreach (Point i in list) {
                i.Draw();
            }
            
            Console.ReadLine();
        }
    }
}