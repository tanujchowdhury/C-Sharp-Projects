using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    public class Employee : Person
    {
        //Implementation of abstract method
        public override void SayName()
        {
            Console.WriteLine(String.Format("Name: {0} {1}", FirstName, LastName));
        }
    }
}
