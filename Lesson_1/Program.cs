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
            string userPassword = "";
            string correctPassword = "флекс";
            for (int i = 3; i >0; i--)
            {
                Console.WriteLine("Введи параоль,челик");
                userPassword = Console.ReadLine();
                if(userPassword == correctPassword)
                {
                    Console.WriteLine("Молодец,челик,вот ты флексишь");
                    break;
                }
                else
                {
                    Console.WriteLine("УуУу,пароль не верный,ну ты кринж");
                    Console.WriteLine("У тебя осталось " + (i-1)+ " попыток");
                }
            }
        }
    }
}
