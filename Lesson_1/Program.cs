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
            string exitLoop = "";
            while (exitLoop != "exit")
            {
                Console.Write("Введите коловое слово: ");
                exitLoop = Console.ReadLine();
            }
        }
    }
}
