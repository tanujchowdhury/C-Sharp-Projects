using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating 10 employee objects
            Employee e1 = new Employee(), e2 = new Employee(), e3 = new Employee(),
                e4 = new Employee(), e5 = new Employee(), e6 = new Employee(),
                e7 = new Employee(), e8 = new Employee(), e9 = new Employee(),
                e10 = new Employee();

            //Assign "Joe" as the FirstName for 2 of them
            e1.FirstName = e2.FirstName = "Joe";

            //Assign ID's for all of them
            e1.ID = 1; e2.ID = 2; e3.ID = 3; e4.ID = 4; e5.ID = 5;
            e6.ID = 6; e7.ID = 8; e8.ID = 8; e9.ID = 9; e10.ID = 10;

            //Make a list of all 10 employees to iterate through
            List<Employee> eList = new List<Employee>() { e1, e2, e3, e4, e5, e6, e7, e8, e9, e10 };

            //Add Joe's to a new list -- using a foreach loop
            List<Employee> joeList = new List<Employee>();
            foreach (Employee employee in eList)
            {
                if (employee.FirstName == "Joe")
                {
                    joeList.Add(employee);
                }
            }

            //Add Joe's to a new list -- using a lambda function
            List<Employee> coolJoeList = eList.Where(x => x.FirstName == "Joe").ToList();

            //Add employees with ID over 5 to a new list using a lambda function
            List<Employee> over5List = eList.Where(x => x.ID > 5).ToList();

            //Test to see if it works
            Console.WriteLine(joeList.Count()); //2
            Console.WriteLine(coolJoeList.Count()); //2
            Console.WriteLine(over5List.Count()); //5
        }
    }
}
