using System;

class Program
{
    static void Main()
    {
        //Get input from user and save the responses
        Console.WriteLine("What is your age?");
        string age = Console.ReadLine();
        Console.WriteLine("Have you ever had a DUI? (Please answer \"true\" or \"false\")");
        string dui = Console.ReadLine();
        Console.WriteLine("How many speeding tickets do you have?");
        string tickets = Console.ReadLine();

        //Convert dui variable to boolean
        bool bdui = bool.Parse(dui);

        //Restrictions are age 15 or over, no DUIs, and no more than 3 tickets
        bool result = Int32.Parse(age) >= 15 && bdui == false && Int32.Parse(tickets) <= 3;

        //Display result
        Console.WriteLine("Qualified?\n" + result);
    }
}

