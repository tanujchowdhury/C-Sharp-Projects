using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAssignment
{
    public class User
    {
        public string Name;
        public int Age;

        //Chaining constructors
        public User() : this("", 0)
        {
        }
        public User(string Name) : this(Name, 0)
        {
        }
        public User(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
