using System;

namespace InheritanceAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student =
            new Student(1, "Anupam", "Bhopal", 765757876, "CS-1", 87, "A+", 60000);
            Console.WriteLine("Student Details :");
            Console.WriteLine("-----------------");
            student.Details();
            Console.WriteLine("=====================");
            Console.WriteLine();
            

            TeachingStaff teachingstaff = 
            new TeachingStaff(101, "Akshay", "Bhopal", 76976868, "Faculty", 40000, "PHD", "DSA");
            Console.WriteLine("Teaching Staff Details :");
            Console.WriteLine("------------------------");
            teachingstaff.Details();
            Console.WriteLine("=====================");
            Console.WriteLine();

            NonTeachingStaff nonteachingstaff = 
            new NonTeachingStaff(201, "Danish", "Mumbai", 65757588, "HOD", 100000, "CSE",1001);
            Console.WriteLine("Non Teaching Staff Details :");
            Console.WriteLine("----------------------------");
            nonteachingstaff.Details();
            Console.WriteLine();
        }
    }
}
