using System;

//Let this .cs file see the methods in the other .cs file
using static CallingMethods.Methods;


namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for input
            Console.WriteLine("Enter a whole number to do math operations on:");
            int input = Convert.ToInt32(Console.ReadLine());

            //Call each method, pass in the user input, and display the result
            Console.WriteLine(input + " plus 42 is " + Add42(input));
            Console.WriteLine(input + " times 100 is " + Mult100(input));
            Console.WriteLine(input + " minus 27 is " + Sub27(input));
            Console.ReadLine();
        }
    }
}
