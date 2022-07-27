using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading
{
    class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        //Operator overloading, == checks for 2 employee ids being equal
        public static bool operator== (Employee employee1, Employee employee2)
        {
            if (employee1.ID == employee2.ID)
            {
                return true;

            //Else statement is required or we get "not all code paths return a value"
            } else
            {
                return false;
            }
        }

        //Operator overloading, != checks for 2 employee ids being different
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            if (employee1.ID != employee2.ID)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
