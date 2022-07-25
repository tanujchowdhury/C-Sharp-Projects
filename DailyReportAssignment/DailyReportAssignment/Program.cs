using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy\nStudent Daily Report\nWhat is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();

        Console.WriteLine("What page number?");
        string page = Console.ReadLine();
        int p = Int32.Parse(page);

        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
        string help = Console.ReadLine();
        bool h = bool.Parse(help);

        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string experiences = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string feedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        string hours = Console.ReadLine();
        decimal hrs = decimal.Parse(hours);

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
    }
}

