using System.Data.Entity;

namespace EFCodeFirstDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyContext())
            {
                // Create and save a new Students
                Console.WriteLine("Adding new students");

                var student = new Student
                {
                    FirstMidName = "Bruce",
                    LastName = "Wayne",
                };

                context.Students.Add(student);

                var student1 = new Student
                {
                    FirstMidName = "Peter",
                    LastName = "Parker",
                };

                context.Students.Add(student1);
                context.SaveChanges();

                // Display all Students from the database
                var students = (from s in context.Students
                                orderby s.FirstMidName
                                select s).ToList<Student>();

                Console.WriteLine("Retrieve all Students from the database:");

                foreach (var stdnt in students)
                {
                    string name = stdnt.FirstMidName + " " + stdnt.LastName;
                    Console.WriteLine("ID: {0}, Name: {1}", stdnt.ID, name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
    }

    public class MyContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
    }

}