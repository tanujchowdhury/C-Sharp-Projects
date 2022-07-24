using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Create an array of strings, display the element at the index the user chooses
        string[] cities = { "San Francisco", "Los Angeles", "Portland", "Seattle", "New York" };
        Console.WriteLine("Select an index (0 - 4):");
        string index1 = Console.ReadLine();
        int i1 = Int32.Parse(index1);
        if ( i1 > 4 || i1 < 0)
        {
            Console.WriteLine("The index you chose was out of range. Please try again");
        } else
        {
            Console.WriteLine(cities[i1]);
        }

        //Create an array of integers, display the element at the index the user chooses
        int[] nums = { 11, 22, 33, 44, 55 };
        Console.WriteLine("Select another index (0 - 4):");
        string index2 = Console.ReadLine();
        int i2 = Int32.Parse(index2);
        if (i2 > 4 || i2 < 0)
        {
            Console.WriteLine("The index you chose was out of range. Please try again");
        }
        else
        {
            Console.WriteLine(nums[i2]);
        }

        //Create an list of strings, display the element at the index the user chooses
        string[] toys = { "Rubik's Cube", "Pogostick", "Bop-It", "Kite", "Frisbee" };
        List<string> toysList = new List<string>(toys);
        Console.WriteLine("Select anoter index (0 - 4):");
        string index3 = Console.ReadLine();
        int i3 = Int32.Parse(index2);
        if (i3 > 4 || i3 < 0)
        {
            Console.WriteLine("The index you chose was out of range. Please try again");
        }
        else
        {
            Console.WriteLine(toysList[i3]);
        }
    }
}

