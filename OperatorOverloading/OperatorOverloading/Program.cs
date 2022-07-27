using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test to see if new operator works
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            e1.ID = 1;
            e2.ID = 2;
            e3.ID = 2;
            

            Console.WriteLine(e1 == e2); //False
            Console.WriteLine(e1 != e2); //True
            Console.WriteLine(e2 == e3); //True

        }
    }
}
