using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuitabble
    {
        //Implementation of abstract method
        public override void SayName()
        {
            Console.WriteLine(String.Format("Name: {0} {1}", FirstName, LastName));
        }
        //Implementation of interface method
        public void Quit()
        {
            Console.WriteLine(String.Format("{0} {1} quit!", FirstName, LastName));
        }
    }
}
