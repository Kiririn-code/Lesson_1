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
            int textCount;
            string textMassage;

            Console.WriteLine("Добрый день,Введите ваше сообщение");
            textMassage = Console.ReadLine();
            Console.WriteLine("Введите количество повторений");
            textCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < textCount; i++)
            {
                Console.WriteLine(textMassage);
            }
        }
    }
}
