using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    //Abstract class
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Abstract method
        public abstract void SayName();
    }
}
