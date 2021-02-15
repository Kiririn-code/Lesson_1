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
            Player player = new Player("эльф", "Аристарх", 22);
            player.ShowInfo();
        }
    }
    public class Player 
    {
        private string _race;
        public string Name;
        public int Age;

        public Player(string race, string name, int age)
        {
            _race = race;
            Name = name;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Вас зовоут {Name} Вы {_race} и Вам {Age} лет");
        }
    }

}
