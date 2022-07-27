using System;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code below to test SayName (it works)
            //Person person = new Person();
            //person.FirstName = "John";
            //person.LastName = "Doe";
            //person.SayName();

            //Calling superclass method on employee object
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
        }
    }
}
