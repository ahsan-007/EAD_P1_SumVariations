using System;
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
            simulateSumVariation6();
            Console.ReadKey();
        }
        static void simulateSumVariation1()
        {
            Console.Write("Enter Operand 1: ");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Operand 2: ");
            int operand2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum Variation 1: " + (operand1 + operand2));
        }
        static void simulateSumVariation2()
        {
            Console.Write("Enter Operand 1: ");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Operand 2: ");
            int operand2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum Variation 2: " + getSum(operand1,operand2));
        }
        static void simulateSumVariation3(int operand1,int operand2)
        {
            Console.Write("Sum Variation 3: " + getSum(operand1, operand2));
        }
        static void simulateSumVariation4(int operand1, int operand2)
        {
            Console.Write("Sum Variation 4: " + (operand1 + operand2));
        }
        static void simulateSumVariation5()
        {
            Console.Write("Enter Operand 1: ");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Operand 2: ");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sum Variation 5: " + (operand1 + operand2));
        }
        static void simulateSumVariation6()
        {
            Console.Write("Enter Operand 1: ");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Operand 2: ");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sum Variation 6: " + getSum(operand1,operand2));
        }
        static int getSum(int operand1, int operand2)
        {
            return operand1 + operand2;
        }
        static double getSum(double operand1, double operand2)
        {
            return operand1 + operand2;
        }
    }
}
