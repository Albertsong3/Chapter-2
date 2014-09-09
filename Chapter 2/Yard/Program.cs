using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yard
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 25, width = 42;
            double PriceOfCarpeting = 4.3;
            double cost = PriceOfCarpeting * length * width;

            Console.WriteLine("The cost of carpeting is {0}", cost.ToString("C"));
        }
    }
}
