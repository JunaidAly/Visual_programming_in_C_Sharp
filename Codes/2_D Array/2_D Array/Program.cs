using System;
using System.IO;
namespace _2_D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[10, 10];

            // Fills 2D array with random values and prints them out 
            Random r = new Random();
            for (int y = 0; y < arr.GetLength(0); y++)
            {
                for (int x = 0; x < arr.GetLength(1); x++)
                {
                    arr[y, x] = r.Next(1, 99);
                    Console.Write(arr[y, x] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Function that separates original array into 2 separate ones (even and odd) 
            sort(arr);

            Console.ReadLine();
        }
        public static void sort(int[,] array)
        {
            int j1 = 0;
            int i1 = 0;
            int j2 = 0;
            int i2 = 0;

            // Increases the size of the even/odd arrays whenever the value of the original array is even/odd respectively 
            // I think this is where the problem is
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    if (array[y, x] % 2 == 0)
                    {
                        i1 += 1;
                    }
                    else
                    {
                        i2 += 1;
                    }
                }
                j1 += 1;
                j2 += 1;
            }

            int[,] evenArr = new int[j1, i1];
            int[,] oddArr = new int[j2, i2];

            // Sets the values for the even/odd arrays 
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    if (array[y, x] % 2 == 0)
                    {
                        evenArr[y, x] = array[y, x];
                    }
                    else
                    {
                        oddArr[y, x] = array[y, x];
                    }
                }
            }

            // Prints the values for the even array
            for (int y = 0; y < evenArr.GetLength(0); y++)
            {
                for (int x = 0; x < evenArr.GetLength(1); x++)
                {
                    Console.Write(evenArr[y, x] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // Prints the values for the odd array 
            for (int y = 0; y < oddArr.GetLength(0); y++)
            {
                for (int x = 0; x < oddArr.GetLength(1); x++)
                {
                    Console.Write(oddArr[y, x] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
