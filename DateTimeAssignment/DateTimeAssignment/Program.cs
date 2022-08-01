using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints current date and time to console
            Console.WriteLine(DateTime.Now);

            //Asks user for a number
            Console.WriteLine("Enter a number:");

            //Converts user input to double, then adds that many hours to current date and time
            Console.WriteLine(DateTime.Now.AddHours(Convert.ToDouble(Console.ReadLine())));
        }
    }
}
