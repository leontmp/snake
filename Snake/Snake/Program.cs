using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            
            HorizontalLine upLine = new HorizontalLine(0,78,0,'+');
            HorizontalLine downLine = new HorizontalLine(0,78,24,'+');
            VerticalLine leftLine = new VerticalLine(0,0,24,'+');
            VerticalLine rightLine = new VerticalLine(78,0,24,'+');

            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(2, 4, '#');
            p2.Draw();

            Console.ReadLine();
        }
    }
}