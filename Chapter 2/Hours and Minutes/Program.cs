using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hours_and_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 212;
            int display = minutes / 60;
            int display2 = minutes % 60;
            Console.WriteLine("{0} Hours {1} Minutes", display, display2);
        }
    }
}
