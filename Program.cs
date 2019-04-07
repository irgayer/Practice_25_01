using System;

namespace Practice_25_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "Yerbol",
                FullName = "Xisire",
                Grades = new int[]
                {
                    12,10,8,7
                }
            };

            Console.WriteLine($"Name       : {student.GetName()}");
            Console.WriteLine($"Full Name  : {student.GetFullName()}");
            Console.WriteLine($"Avg. Grade : {student.GetAvgGrade()}");
        }
    }
}
