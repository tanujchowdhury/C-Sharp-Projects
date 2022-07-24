using System;
using System.Text;

class Program
{
    static void Main()
    {
        //Make 3 strings, s = sentence
        string s1 = "The sky is blue.";
        string s2 = " The grass is green.";
        string s3 = " The water's fine.";

        //Concatenate 3 strings, p = paragraph
        string p1 = s1 + s2 + s3;
        Console.WriteLine(p1);

        //Convert string to uppercase
        string upperp1 = p1.ToUpper();
        Console.WriteLine(upperp1);

        //Stringbuilder to make a paragraph one sentence at a time
        StringBuilder p2 = new StringBuilder();
        p2.Append(s1);
        p2.Append(s2);
        p2.Append(s3);
        p2.Append("\nYou may close the console");
        Console.WriteLine(p2);

        Console.ReadLine();
    }
}

