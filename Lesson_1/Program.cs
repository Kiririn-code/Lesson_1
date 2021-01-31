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
            bool isProgramRun = true;
            int[] array = new int[0];
            int arraySum = 0;

            Console.WriteLine("Список комманд:");
            Console.WriteLine("sum - вывести сумму элементов ранне введенного массива");

            while (isProgramRun)
            {
                Console.Write("Введите комманду: ");
                userAction = Console.ReadLine();

                switch (userAction)
                {
                    case "exit":
                        isProgramRun = false;
                        Console.WriteLine("Всего ХО-РО-ШЕ-ГО");
                        break;
                    case "sum":
                        for (int i = 0; i < array.Length; i++)
                        {
                            arraySum += array[i];
                        }
                        Console.WriteLine("Сумма элементов вашего массива "+arraySum);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "0":
                        int[] expandArray = new int[array.Length + 1];
                        for (int i = 0; i < array.Length; i++)
                        {
                            expandArray[i] = array[i];
                        }
                        expandArray[expandArray.Length - 1] = Convert.ToInt32(userAction);
                        array = expandArray;
                        break;
                    default:
                        Console.WriteLine("Я не знаю,что вы написали");
                        break;
                }
            }
        }
    }
}
