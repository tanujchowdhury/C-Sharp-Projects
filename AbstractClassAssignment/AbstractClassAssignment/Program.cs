using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling the abstract method on an Employee object
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            //employee.SayName();

            //Calling the interface method on an Employee object
            employee.Quit();




        }
    }
}
