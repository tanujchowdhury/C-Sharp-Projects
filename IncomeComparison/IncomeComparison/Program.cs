using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program\nPerson 1\nWhat is your hourly rate?");
        string rate1 = Console.ReadLine();
        Console.WriteLine("How many hours do you work per week?");
        string hours1 = Console.ReadLine();
        Console.WriteLine("Person 2\nWhat is your hourly rate?");
        string rate2 = Console.ReadLine();
        Console.WriteLine("How many hours do you work per week?");
        string hours2 = Console.ReadLine();

        int salary1 = Int32.Parse(rate1) * Int32.Parse(hours1) * 52;
        int salary2 = Int32.Parse(rate2) * Int32.Parse(hours2) * 52;
        bool comp = salary1 > salary2;

        Console.WriteLine("Annual salary of person 1:\n" + salary1);
        Console.WriteLine("Annual salary of person 2:\n" + salary2);
        Console.WriteLine("Does Person 1 make more money than Person 2?\n" + comp);
    }
}

