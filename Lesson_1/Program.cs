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
            int textRepeat;
            string textMassage;

            Console.WriteLine("Добрый день,Введите ваше сообщение");
            textMassage = Console.ReadLine();
            Console.WriteLine("Введите количество повторений");
            textRepeat = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < textRepeat; i++)
            {
                Console.WriteLine(textMassage);
            }
        }
    }
}
