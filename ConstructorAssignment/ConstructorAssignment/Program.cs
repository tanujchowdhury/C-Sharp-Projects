using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a constant
            const string fullName = "Tanuj Chowdhury";

            //Declare a variable using "var"
            var yearsOld = 27;

            //Instantiate 3 users, each with different parameters so different constructors will be used
            User user1 = new User();
            User user2 = new User(fullName);
            User user3 = new User(fullName, yearsOld);

            //Test to see if users were instantiated properly
            Console.WriteLine("{0}, {1}", user1.Name, user1.Age);
            Console.WriteLine("{0}, {1}", user2.Name, user2.Age);
            Console.WriteLine("{0}, {1}", user3.Name, user3.Age);
        }
    }
}
