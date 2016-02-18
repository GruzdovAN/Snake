using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Drow();

            Point p2 = new Point(4, 5, '#');
            p2.Drow();

            HorizontalLine lineH = new HorizontalLine(5,10,8,'+');
            lineH.Drow();
            VerticalLine lineV = new VerticalLine(9, 20, 10, '+');
            lineV.Drow();

            HorizontalLine lineH2 = new HorizontalLine(5, 10, 20, '+');
            lineH2.Drow();
            VerticalLine lineV2 = new VerticalLine(9, 20, 5, '+');
            lineV2.Drow();

            Console.ReadLine();
        }


    }
}
