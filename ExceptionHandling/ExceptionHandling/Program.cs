using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            //Make a list of integers
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> nums = new List<int>(numbers);

            //Get input from user
            Console.WriteLine("Please pick a number:");
            int input = Convert.ToInt32(Console.ReadLine());

            //Take each number in the list and divide it by the input
            for (int i = 0; i < nums.Count; i++)
            {
                decimal result = (decimal)nums[i] / (decimal)input;
                Console.WriteLine(result);
            }
        }
        //Catch divide by 0 errors
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by 0");
        }
        //Catch non-integer input errors
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number");
        }
        //Catch all other errors
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        //Message to let the user know the program is continuing
        Console.WriteLine("The program has emerged from the try/catch block");

    }
}

