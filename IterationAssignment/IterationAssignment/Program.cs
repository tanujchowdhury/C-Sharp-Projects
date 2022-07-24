using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Add user's input to each element of the list, then display using a separate for loop
        string[] colors = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
        Console.WriteLine("Please enter some text:");
        string input1 = Console.ReadLine();
        for (int i = 0; i < colors.Length; i++)
        {
            colors[i] += input1;
        }
        for (int i = 0; i < colors.Length; i++)
        {
            Console.WriteLine(colors[i]);
        }

        //Possible Infinite Loop
        int x = 1;
        while (x <= 5)
        {
            Console.WriteLine("x = " + x);

            //Adding the line below will fix the infinite loop
            x++;
        }

        //Loop with < operator
        int y = 1;
        while (y < 4)
        {
            Console.WriteLine("y = " + y);
            y++;
        }

        //Loop with <= operator
        int z = 1;
        while (z <= 10)
        {
            Console.WriteLine("z = " + z);
            z++;
        }


        //Return index where user's input matches element in a list
        string[] nato = { "Alpha", "Beta", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel", "India", "Juliet" };
        List<string> natoList = new List<string>(nato);
        Console.WriteLine("Input text to search (1st 10 of the NATO Alphabet):");
        string input2 = Console.ReadLine();

        //i < 11 is needed for the way my loop checks for matches
        for (int i = 0; i < natoList.Count + 1; i++)
        {
            //The last index of the list is 9, so if i gets to 10, the input is not in the list
            if (i == 10)
            {
                Console.WriteLine("Your input was not in the list");

            //If the input is found, display the index, and stop the for loop
            } else if (natoList[i] == input2)
            {
                Console.WriteLine(i);

                //Setting i to 10 ends the for loop and doesn't let the above if statement go through
                i = 10;
            }
        }


        //String list with two identical elements
        string[] names = { "Tanuj", "Brian", "Brian", "Bryan", "Victoria", "Sharang", "Dora" };
        List<string> namesList = new List<string>(names);
        Console.WriteLine("Input a name to search:");
        string input3 = Console.ReadLine();

        //Make a counter to keep track if a match was found
        int match = 0;
        for (int i = 0; i < namesList.Count; i++)
        {
            //If a match is found, display the index and increment the counter
            if (namesList[i] == input3)
            {
                Console.WriteLine(i);
                match++;

            //At the last index, if no match was found, the input is not in the list
            } else if (i == 6 && match == 0)
            {
                Console.WriteLine("Your input was not in the list");
            }

        }


        //Another string list with two identical elements
        string[] letters = { "A", "B", "C", "D", "C" };
        List<string> letterList = new List<string>(letters);

        //Make an empty string list to hold new elements
        List<string> matchList = new List<string>();
        
        //Use a foreach loop to check for duplicates and display the correct message
        foreach(string st in letterList)
        {
            
            //If there's a match, use the duplicate message
            if (matchList.Contains(st))
            {
                string duplicate = " - this item is a duplicate";
                Console.WriteLine(st + duplicate);

            //If there's no match, use the unique message, and add the element to the match list
            } else
            {
                string unique = " - this item is unique";
                Console.WriteLine(st + unique);
                matchList.Add(st);
            }
            
        }
               
    }
}
