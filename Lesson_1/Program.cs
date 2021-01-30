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
            string userAction;
            bool userOutput = true;
            int[] array = new int[1];
            int arraySum = 0;

            Console.WriteLine("Список комманд:");
            Console.WriteLine("drop - отчистить массив");
            Console.WriteLine("sum - вывести сумму элементов ранне введенного массива");

            while (userOutput)
            {
                Console.Write("Введите комманду: ");
                userAction = Console.ReadLine();

                switch (userAction)
                {
                    case ("exit"):
                        userOutput = false;
                        Console.WriteLine("Всего ХО-РО-ШЕ-ГО");
                        break;
                    case ("sum"):
                        for (int i = 0; i < array.Length; i++)
                        {
                            arraySum += array[i];
                        }
                        Console.WriteLine("Сумма элементов вашего массива "+arraySum);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "drop":
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] = 0;
                            arraySum = 0;
                        }
                        break;
                    default:
                        int[] expArray = new int[array.Length + 1];
                        for (int i = 0; i < array.Length; i++)
                        {
                            expArray[i] = array[i];
                        }
                        expArray[expArray.Length - 1] = Convert.ToInt32(userAction);
                        array = expArray;
                        break;
                }
            }
        }
    }
}
