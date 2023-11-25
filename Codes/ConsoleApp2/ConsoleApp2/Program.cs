using System;

namespace ConsoleApp2
{
    public enum WeekDays
    {
      mon,tue,wed,thur,fri,sat,sun
    }

    class Program
    {
    
        static void Main(string[] args)
        {
            WeekDays week = WeekDays.tue;
            Console.WriteLine(week);
            //Console.Read();
            
        }
    }
  
}
