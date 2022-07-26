using System;
using System.Collections.Generic;
using System.Text;

namespace MiscMethods
{
    class Methods
    {
        //Void method that outputs an integer
        //Method has output param
        //Method is overloaded
        public static void Div2(int num, out string Message)
        {
            int res = num / 2;
            Message = "Your number was divided by 2";
            Console.WriteLine(res);
        }
        public static decimal Div2(decimal num)
        {
            decimal res = num / 2;
            return res;
        }

        //Class marked static
        public static class Foo {
            //code
        }
        
    }
}
