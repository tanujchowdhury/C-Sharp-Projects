using System;
using static OptionalParam.Methods;

namespace OptionalParam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get an input from the user, user must give input here
            Console.WriteLine("Enter a number (1/2):");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //Ask user for another input, this is optional
            Console.WriteLine("Enter another number *optional* (2/2):");

            //If user does not give 2nd input, a FormatException will occuer
            try
            {
                //If both inputs are given, use both inputs as params
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result: " + Multiply(num1, num2));
            }
            catch
            {
                //If only 1st input is given, use that input as the only param
                Console.WriteLine("Result:" + Multiply(num1));
            }
            Console.ReadLine();
        }
    }
}
