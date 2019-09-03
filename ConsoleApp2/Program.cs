using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. a. For the first part of this question you are to solve the following algebraic
            expression 2(x – 3) + x = 12 to find the value of x.
            You may use the blank lines provided below to scribble on to work out the answer. */
            /*           2(x - 3) + x = 12
             *           2x - 6 + x = 12
             *           3x = 18
                         x = 6        */

            //Description of programe function
            Console.Write("Can you solve the following algebraic expression:");
            //Algebraic expression for user to solve
            Console.WriteLine("2(x - 3) + x = 12");

            //User input for Answering the question and converting answer to interger
            Console.Write("\nEnter your guess at the value of x: ");
            int input = int.Parse(Console.ReadLine());

            //If else statement to check if answer is correct
            if (input == 6)
            {
                //Response for correct answer input
                Console.WriteLine("\nYay that is the correct answer!!");
            }
            else
            {
                //Response for incorrect answer input
                Console.WriteLine("\nSorry that is incorrect.");
            }
            Console.ReadLine();
        }
    }
}
