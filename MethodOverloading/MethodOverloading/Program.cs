using System;
using static MethodOverloading.Methods;


namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstrates method overloading.
            //Each uses same method name, but a different data type is passed,
            //resulting in a different method being called
           
            //returns 20: 10 + 10
            Console.WriteLine(Math10(10));

            //returns 424: 42.42 x 10, truncated
            Console.WriteLine(Math10(42.42m));

            //returns 351: 361 - 10
            Console.WriteLine(Math10("361"));
        }
    }
}
