using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFunctions
{
    class Program
    {

        public int RetrieveFibonacciTerm(int n, int x, int y)               //This is also a recursive function, but it works iteratively. The call stack is what is used to keep track of the current iteration. Efficiency is on the scale of O(n).
        {

            if (n == 0)         //n-2 here because the function must be given the first two starting terms in order to generate a fibonacci sequence, and so the number of times it must run to get the nth term will always be 2 less than n.
            {
                return x;
            }
            else if (n == 1)
            {
                return y;
            }
            else
            {
                return RetrieveFibonacciTerm(n - 1, y, x + y);
            }

        }

        public int ProperFibonacci(int n)           //This is a recursive function that finds the nth term of the fib sequence according to its mathematical definition. Efficiency is on the scale of O(2^n)
        {

            if (n > 1)
            {
                return (ProperFibonacci(n - 1) + ProperFibonacci(n - 2));
            }
            else
            {
                return n;
            }

        }

        public int IterativeFibonacci(int n)        //Iterative fibonacci algorithm. Efficiency is on the scale of O(n).
        {

            int x = 0, i, y = 1;
            if (n > 1)
            {
                for (i = 1; i < n; i++)
                {
                    y = y + x;
                    x = y - x;
                }
                return y;
            }
            else
            {
                return n;
            }  

        }

        private int? ConvertStringToInt(string intString)   //Function to convert a string to an integer, returns null if the passed string does not parse into a valid integer.
        {

            int i = 0;
            return (Int32.TryParse(intString, out i) ? i : (int?)null);

        }

        static void Main(string[] args)
        {
     
            Program program = new Program();

            Console.WriteLine("Do we want to use function 1, 2 or 3?");
            int i = (int)program.ConvertStringToInt(Console.ReadLine());

            while (i != 1 & i != 2 & i != 3)
            {
                Console.WriteLine("\"" + i + "\"" + " is not a valid input. Try again.");
                i = (int)program.ConvertStringToInt(Console.ReadLine());
            }

            Console.WriteLine("# of term in the Fibonacci sequence to retrieve: ");
            string input = Console.ReadLine();

            if (i == 1)
            {
                while (program.ConvertStringToInt(input) == null)
                {

                    Console.WriteLine("\"" + input + "\"" + " is not a valid integer. Try again.");
                    input = Console.ReadLine();

                }
                Console.WriteLine(program.RetrieveFibonacciTerm((int)program.ConvertStringToInt(input), 0, 1));
                Console.ReadLine();
            }
            else if (i == 2)
            {
                while (program.ConvertStringToInt(input) == null)
                {

                    Console.WriteLine("\"" + input + "\"" + " is not a valid integer. Try again.");
                    input = Console.ReadLine();

                }
                Console.WriteLine(program.ProperFibonacci((int)program.ConvertStringToInt(input)));
                Console.ReadLine();
            }
            else
            {
                while (program.ConvertStringToInt(input) == null)
                {

                    Console.WriteLine("\"" + input + "\"" + " is not a valid integer. Try again.");
                    input = Console.ReadLine();

                }
                Console.WriteLine(program.IterativeFibonacci((int)program.ConvertStringToInt(input)));
                Console.ReadLine();
            }


        }
    }
}
