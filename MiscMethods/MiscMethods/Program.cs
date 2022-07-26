using System;
using static MiscMethods.Methods;

namespace MiscMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //The method is called on the user's input
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            string Message;
            Div2(num, out Message);

        }
    }
}
