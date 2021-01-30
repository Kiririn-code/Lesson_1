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
            int[] array = new int[30];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(50);
                Console.WriteLine($"элемент - {(i + 1)} Число - {array[i]}");
            }
            if (array[0] >= array[1])
            {
                Console.WriteLine($"Локальный максимум {array[0]} обнаружен под номером 1");
            }

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i - 1] && array[i] >= array[i + 1])
                {
                    Console.WriteLine($"Локальный максимум {array[i]} обнаружен под номером {i + 1}");
                }
            }
            if (array[array.Length - 1] >= array[array.Length - 2])
            {
                Console.WriteLine($"Локальный максимум {array[array.Length-1]} обнаружен под номером {array.Length}");
            }
        }
    }
}
