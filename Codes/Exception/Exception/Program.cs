using System;
using System.Collections.Generic;
namespace Exception
{
    struct  BCS4B {
        public int x;
        public int y;
    }

    class Program
    {

        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0]  = new int [3]{ 12,14,15};
            arr[1]  = new int[3] { 16, 17, 18 };
          
            for(int i = 0; i < arr.Length; i++)
            {
                 
                Console.WriteLine("Elements of the array({0}):" + i);
                for(int j=0; j < arr[i].Length; j++)
                   
                {
                    System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press Any key to Exit");
            Console.ReadKey();
        }
    }
}
