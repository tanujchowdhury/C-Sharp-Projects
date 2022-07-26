using System;
using static NamedParam.Methods;

namespace NamedParam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calls the method
            TwoNums(10, 15);
            //Call the method, with param names specified
            TwoNums(num1: 10, num2: 15);
        }
    }
}
