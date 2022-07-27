using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAssignment
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Displays full name to console
        public void SayName()
        {
            Console.WriteLine(String.Format("Name: {0} {1}", FirstName, LastName));
        }

    }
}
