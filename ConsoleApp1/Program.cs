using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Description of programs function
            Console.WriteLine("This program will give the sum total of 5 prices");
            Console.WriteLine();
            
            //Converting for statement total to decimal
            decimal total = 0;
            //For statement parameters
            for (int i = 1; i <= 5; i++)
            {
                //Asking user to enter relevent information
                Console.Write($"Enter the price of the item {i}: ");
                //Calculation for function
                total = total + decimal.Parse(Console.ReadLine());
            }
            //Display answer to function in context
            Console.WriteLine($"\nThe total of those items is ${total}");
            Console.ReadLine();
        }
    }
}
