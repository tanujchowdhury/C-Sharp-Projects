using System;

class Program
{
    static void Main()
    {
        //Get input from the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nPlease enter the package weight:");
        string mass = Console.ReadLine();

        //If input is greater than 50, end the program
        int m = Int32.Parse(mass);
        if (m > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

        //Otherwise, get more input from the user
        } else
        {
            Console.WriteLine("Please enter the package width:");
            string width = Console.ReadLine();
            Console.WriteLine("Please enter the package height:");
            string height = Console.ReadLine();
            Console.WriteLine("Please enter the package length:");
            string length = Console.ReadLine();

            //If the 3 inputs total to greater than 50, end the program
            int w = Int32.Parse(width);
            int h = Int32.Parse(height);
            int l = Int32.Parse(length);
            int total = w + h + l;
            if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");

            //Otherwise, give the quote
            } else 
            {
                decimal quote = w * l * h * m / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00") + "\nThank you!");
            }
        }
    }
}