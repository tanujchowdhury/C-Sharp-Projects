using System;

namespace StructAssignment
{
    class Program
    {
        struct Number
        {
            public decimal Amount;


        }

        static void Main(string[] args)
        {
            Number myNum;
            myNum.Amount = 10.5m;
            Console.WriteLine(myNum.Amount);

        }
    }
}
