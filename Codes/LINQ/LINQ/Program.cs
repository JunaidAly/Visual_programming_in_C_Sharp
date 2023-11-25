using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentlist = new List<Student>() 
            {
             new Student(){StudentID=1,StudentName="Junaid Ali",Age=19},
             new Student(){StudentID=2,StudentName="Ali",Age=18},
             new Student(){StudentID=3,StudentName="Atif",Age=20},
             new Student(){StudentID=4,StudentName="Aalishan",Age=18},
             new Student(){StudentID=5,StudentName="Kashif",Age=18},

            };
            var result = from s in studentlist group s by s.Age;
            foreach (var AgeGroup in result)
            {
                Console.WriteLine("Age Group is: "+AgeGroup.Key + "\n");

                foreach (Student s in AgeGroup)
                    Console.WriteLine("Student Name is:" + s.StudentName+ "\n");
            }


        }
    }
}
