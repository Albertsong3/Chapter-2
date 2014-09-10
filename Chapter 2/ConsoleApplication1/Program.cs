using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken1 = 23;
            int chicken2 = 27;
            int chicken3 = 25;  
            int chicken4 = 20; 

            int sum = chicken1 + chicken2 + chicken3 + chicken4; 
            int dozen = sum;
            int dozen2 = sum / 12;
            Console.WriteLine("The chickens laid a total of {0} eggs, which is {1} dozen and 11 eggs", dozen, dozen2);
        }
    }
}
