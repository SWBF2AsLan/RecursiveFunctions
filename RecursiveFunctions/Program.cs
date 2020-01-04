using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFunctions
{
    class Program
    {

        public int RetrieveFibonacciTerm(int n, int x, int y)               //This is the recursive function which finds the nth term of the fibonacci sequence. n is the number of the term we are trying to find, x is the previous term and y is the current term.
        {

            if ((n-2) == 0)         //n-2 here because the function must be given the first two starting terms in order to generate a fibonacci sequence, and so the number of times it must run to get the nth term will always be 2 less than n.
            {
                return y;
            }
            return RetrieveFibonacciTerm(n - 1, y, x + y);


        }

        private int? ConvertStringToInt(string intString)   //Function to convert a string to an integer, returns null if the passed string does not parse into a valid integer.
        {

            int i = 0;
            return (Int32.TryParse(intString, out i) ? i : (int?)null);

        }

        static void Main(string[] args)
        {

            Program program = new Program();

            Console.WriteLine("# of term in the Fibonacci sequence to retrieve: ");
            string input = Console.ReadLine();

            while (program.ConvertStringToInt(input) == null)
            {

                Console.WriteLine("\"" + input + "\"" + " is not a valid integer. Try again.");
                input = Console.ReadLine();

            }
            Console.WriteLine(program.RetrieveFibonacciTerm((int)program.ConvertStringToInt(input), 1, 1)); //If we wanted we could ask the user for inputs to use for the second two arguments to generate a fibonacci sequence from starting values of their choice.
            Console.ReadLine();




        }
    }
}
