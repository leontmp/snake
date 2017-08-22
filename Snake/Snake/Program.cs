using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(2,4,'#');
            p2.Draw();

            HorizontalLine hline = new HorizontalLine(1, 10, 5, '-');
            VerticalLine vline = new VerticalLine(8, 6, 10, '|');

            hline.Draw();
            vline.Draw();

            Console.ReadLine();
        }
    }
}