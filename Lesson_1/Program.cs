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
            int maxValue = int.MinValue;
            int[,] arrayA = new int[10, 10];
            Random random = new Random();

            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayA.GetLength(1); j++)
                {
                    arrayA[i, j] = random.Next(100, 1000);
                    if (arrayA[i, j] > maxValue)
                    {
                        maxValue = arrayA[i, j];
                    }
                    Console.Write(arrayA[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Самое большое число - " + maxValue);

            Console.WriteLine("Конечный массив");

            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayA.GetLength(1); j++)
                {
                    if(maxValue == arrayA[i,j])
                    {
                        arrayA[i, j] = 0;
                    }

                    Console.Write(arrayA[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
