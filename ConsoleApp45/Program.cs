using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3, }, { 4, 5, 6 }, { 7, 8, 9 } };

            int sum = SumOfArray(matrix);

            Console.WriteLine("Amount of all elements in the array: " + sum);

        }

        static int SumOfArray(int[,] arr)
        {
            int sum = 0;
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += arr[i, j];
                }
            }

            return sum;
        }
    }
}
