using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] array = new int[5, 5];
            int rowsSum = 0;
            int colsProd = 1;
            int numberOfCols = 0;
            int numberOfRows = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10);
                    Console.Write(array[i,j]);
                    if (i == numberOfRows)
                    {
                        rowsSum += array[i, j];
                    }
                    if (j == numberOfCols)
                    {
                        colsProd *= array[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Произведение первого столбца - " + colsProd);
            Console.WriteLine("Сумма второй строки - " + rowsSum);
        }
    }
}
