using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter any number:");
        string number1 = Console.ReadLine();
        int result1 = Int32.Parse(number1) * 50;
        Console.WriteLine(number1 + " times 50 is " + result1);

        Console.WriteLine("Enter another number:");
        string number2 = Console.ReadLine();
        int result2 = Int32.Parse(number2) + 25;
        Console.WriteLine(number2 + " plus 25 is " + result2);

        Console.WriteLine("Enter another number:");
        string number3 = Console.ReadLine();
        double result3 = Int32.Parse(number3) / 12.5;
        Console.WriteLine(number3 + " divided by 12.5 is " + result3);

        Console.WriteLine("Enter another number:");
        string number4 = Console.ReadLine();
        bool result4 = Int32.Parse(number4) > 50;
        Console.WriteLine(number4 + " is greater than 50 is " + result4);

        Console.WriteLine("Enter another number:");
        string number5 = Console.ReadLine();
        int result5 = Int32.Parse(number5) % 7;
        Console.WriteLine(result5 + " is the remainder when " + number5 + " is divided by 7");
    }
}

