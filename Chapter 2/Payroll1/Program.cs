﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll1
{
    class Program
    {
        static void Main(string[] args)
        {
            String SSN, Name, input;
            double Pay, Hours;
            double gross;

            Console.Write("Enter your name here: ");
            Name = Console.ReadLine();

            Console.Write("Social Security Number: ");
            SSN = Console.ReadLine();
            
            Console.Write("Hourly pay rate: " );
            input = Console.ReadLine();
            Pay = Convert.ToDouble(input);

            Console.Write("Hours worked: ");
            input = Console.ReadLine();
            Hours = Convert.ToDouble(input);
            
            gross = Pay * Hours;


            double Payint = Convert.ToDouble(Pay);
            
            Console.WriteLine("Payroll summary for:{0}", Name);
           
            Console.WriteLine("SSN{0}", SSN);

            Console.WriteLine("You earned{0}",gross.ToString("C"),"at {1}",Payint.ToString("C"),"per hour");

            

            double Tax = .15, Tax2 = .05;

            Double FedWithholding = gross * Tax, StateWithholding = gross * Tax2;

            Console.WriteLine("Gross pay:{0}", gross.ToString("C"));

            Console.WriteLine("Federal Withholding{0}", (gross * Tax).ToString("C"));

            Console.WriteLine("State Withholding{0}", (gross * Tax2).ToString("C"));

            Console.WriteLine("-----------------------------");

            Console.WriteLine("Net pay:{0}", (gross - (FedWithholding - StateWithholding)));

        }
    }
}
