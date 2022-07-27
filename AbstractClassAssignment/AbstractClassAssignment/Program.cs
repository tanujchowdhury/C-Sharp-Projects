using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling the abstract method on an Employee object
            Employee employee1 = new Employee();
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            employee1.SayName();
            employee1.Quit();

            //Object of type IQuitabble, polymorphism
            IQuitabble employee2 = new Employee();
            employee2.Quit();


            





        }
    }
}
