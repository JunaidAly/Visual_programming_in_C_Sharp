using System;
using System.IO;
namespace ConsoleApp3
{


    class program
    {
        public void ageCheck(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access deined you must be atleast 18 years old");
            }
            else
            {
                Console.WriteLine("Access granted you are  old enough");
            }
        }
        static void Main(string[] args)
        {
            program p = new program();
            p.ageCheck(18);
        }
    }
}

