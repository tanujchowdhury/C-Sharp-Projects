using System;
using System.Collections.Generic;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string> { "test1", "test2", "test3" };

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int> { 1, 2, 3 };

            foreach (string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
