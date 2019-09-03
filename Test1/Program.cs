using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Description of programs function
            Console.Write("This program can give the result of base^exponent");
            Console.WriteLine();
            //Asking the user for a base variable
            Console.Write("\nEnter the value of the base: ");
            //Converting base variable into double
            double num1 = double.Parse(Console.ReadLine());

            //Asking user for exponent variable and converting into interger
            Console.Write("Enter the value of exponent: ");
            int num2 = int.Parse(Console.ReadLine());

            //Converting result of for statement into double
            double result = num1;
            for (int i = 1; i < num2; i++)
            {
                //Calculation for function
                result = result *num1;
                
            }
            //Display answer in context
            Console.WriteLine($"\n{num1}^{num2} = {result}");
            Console.ReadLine();
        }
    }
}
