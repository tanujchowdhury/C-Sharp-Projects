using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverloading
{
    class Methods
    {
        //Passes in int, does addition, returns int
        public static int Math10(int num)
        {
            int res = num + 10;
            return res;
        }

        //Passes in decimal, does multiplication, converts decimal to int, returns int
        public static int Math10(decimal num)
        { 
            decimal res = num * 10;
            int resInt = Convert.ToInt32(res);
            return resInt;
        }

        //Passes in string, converts string to int, does subtraction, returns int
        public static int Math10(string num)
        {
            int numInt = Convert.ToInt32(num);
            int res = numInt - 10;
            return res;
        }
    }
}
