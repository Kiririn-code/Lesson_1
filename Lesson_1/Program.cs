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
            int cristal = 0;
            int goldInAccount = 0;
            int courseCristal = 30;
            Console.WriteLine("Добрый день,сколько золотых у вас есть?");
            goldInAccount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cколько кристалов вы хотите купить?");
            cristal = Convert.ToInt32(Console.ReadLine());
            if (goldInAccount>=cristal* courseCristal)
            {
                goldInAccount -= cristal * courseCristal;
                Console.WriteLine("Вы получили " + cristal + " кристалов по курсу 30 золотых за кристал");
                Console.WriteLine("У вас осталось " + goldInAccount + " золотых");
            }
            else
                Console.WriteLine("У вас недостаточно денег,приходите в другой раз");
            
        }
    }
}
