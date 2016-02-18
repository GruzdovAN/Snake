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
            Console.SetBufferSize(80, 25);

            HorizontalLine lineH = new HorizontalLine(0,78,0,'+');
            lineH.Drow();
            VerticalLine lineV = new VerticalLine(0, 24, 0, '+');
            lineV.Drow();

            HorizontalLine lineH2 = new HorizontalLine(0, 78, 24, '+');
            lineH2.Drow();
            VerticalLine lineV2 = new VerticalLine(0, 24, 78, '+');
            lineV2.Drow();

            Console.ReadLine();
        }


    }
}
