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
            int fullHealth = 100;
            int currentHealth = 50;

            DrawBar(fullHealth,currentHealth,ConsoleColor.Red);
        }

        static void DrawBar(int fullHealth, int currentHealth, ConsoleColor consoleColor)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < currentHealth/10; i++)
            {
                bar += "#";
            }
            Console.SetCursorPosition(0, 20);
            Console.Write('[');
            Console.BackgroundColor = consoleColor;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = "";

            for (int i = currentHealth/10; i < fullHealth/10; i++)
            {
                bar += "_";
            }
            Console.Write(bar);
            Console.Write(']');
        }
    }
}
