﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD_P1_VariationsOfSum
{
    class Program
    {
        static void Main(string[] args)
        {
            simulateSumVaritarion1();
            Console.ReadKey();
        }
        static void simulateSumVaritarion1()
        {
            Console.Write("Enter Operand 1: ");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Operand 2: ");
            int operand2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum Variation 1: " + (operand1 + operand2));
        }
    }
}