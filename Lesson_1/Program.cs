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
            Console.WriteLine("Вы ввели число - " + ReadInt());
        }

        static int ReadInt()
        {
            int userNumber =0;
            string userInput;
            bool convertIsFallen = true;
            while(convertIsFallen)
            {
                Console.Write("Введите число для конвертации - ");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out userNumber))
                {
                    convertIsFallen = false;
                }
            }
            return userNumber;
        }
    }
}
