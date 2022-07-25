using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalParam
{
    class Methods
    {
        //Method with an optional second param. Takes int as params, returns int
        public static int Multiply(int num1, int num2 = 10)
        {
            int res = num1 * num2;
            return res;
        }
    }
}
