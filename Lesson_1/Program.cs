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
            int fullHealth = 10;
            int currentHealth = 5;
            int healthDivider = 1;
            DrawBar(fullHealth,currentHealth,healthDivider,ConsoleColor.Red);
        }

        static void DrawBar(int fullHealth, int currentHealth, int healthDivider, ConsoleColor consoleColor)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < currentHealth / healthDivider; i++)
            {
                bar += "#";
            }
            Console.SetCursorPosition(0, 20);
            Console.Write('[');
            Console.BackgroundColor = consoleColor;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = "";

            for (int i = currentHealth/healthDivider; i < fullHealth / healthDivider; i++)
            {
                bar += "_";
            }
            Console.Write(bar);
            Console.Write(']');
        }
    }
}
