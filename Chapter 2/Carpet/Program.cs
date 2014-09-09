using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 20, width = 35;
            double PriceOfCarpeting = 4.3;
            double cost = PriceOfCarpeting * length * width;

            Console.WriteLine("The cost of carpeting is {0}", cost.ToString("C"));
        }
    }
}
