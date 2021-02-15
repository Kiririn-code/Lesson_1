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
        public string _name;
        public int _age;

        public Player(string race, string name, int age)
        {
            _race = race;
            _name = name;
            _age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Вас зовоут {_name} Вы {_race} и Вам {_age} лет");
        }
    }

}
