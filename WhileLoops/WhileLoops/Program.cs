using System;

class Program
{
    static void Main()
    {
        //Create a counter
        int i = 1;

        //While loop to count 1, 2, 3
        while (i < 4)
        {
            Console.WriteLine(i + ",");
            i++;
        }

        //Says "Go" once because condition is already met
        do
        {
            Console.WriteLine("Go!");
        }
        while (i < 3);
    }
}

