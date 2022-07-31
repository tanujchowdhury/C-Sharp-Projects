using System;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Store user input as a string for now
            Console.WriteLine("Enter the current day of the week:");
            string input = Console.ReadLine();

            try
            {
                //myDay has type DaysEnum; using Parse method to store user input in this var
                DaysEnum myDay = (DaysEnum)Enum.Parse(typeof(DaysEnum), input);
                Console.WriteLine(myDay);
            }
            catch
            {
                //If any error occurs, display this message
                Console.WriteLine("Please enter an actual day of the week");
            }
            


        }
    }
}
