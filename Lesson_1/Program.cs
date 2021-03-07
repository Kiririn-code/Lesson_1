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
            DataBase dataBase = new DataBase();

            Console.WriteLine("Топ самых сильных игроков");
            dataBase.FindTopForce();
            Console.WriteLine("Топ самых высокоуровневых игроков");
            dataBase.FindTopLevel();
        }
    }

    class DataBase
    {
        private List<Player> _players = new List<Player>();

        public DataBase()
        {
            _players.Add(new Player("Дмитрий",120,970));
            _players.Add(new Player("Василий",117,800));
            _players.Add(new Player("Олег",100,820));
            _players.Add(new Player("Гулдан",111,721));
            _players.Add(new Player("Обама",98,654));
            _players.Add(new Player("Петр",99,701));
            _players.Add(new Player("Колясик",21,121));
            _players.Add(new Player("Ивасик",77,666));
            _players.Add(new Player("Черчиль",77,666));
            _players.Add(new Player("Саня",89,709));
            _players.Add(new Player("Сотона",140,999`));
        }

        public void FindTopLevel()
        {
            ShowTop(_players.OrderByDescending(player => player.Level).Take(3).ToList());
        }

        public void FindTopForce()
        {
            ShowTop(_players.OrderByDescending(player => player.Force).Take(3).ToList());
        }

        private void ShowTop(List<Player> list)
        {
            foreach (var player in list)
            {
                Console.WriteLine($"имя - { player.Name} сила - { player.Force} уровень - { player.Level}");
            }
            Console.WriteLine();
        }
    }

    class Player
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public int Force { get; private set; }

        public Player(string name, int level, int force)
        {
            Name = name;
            Level = level;
            Force = force;
        }
    }
}
