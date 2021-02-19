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
            int iD;
            int lvl;
            string firstName;
            bool isProgramRun = true;
            List<Player> players = new List<Player>();

            while (isProgramRun)
            {
                Console.WriteLine("Выберете действия");
                string userChoise = Console.ReadLine();
                switch (userChoise)
                {
                    case "add":
                        Console.Write("Имя: ");
                        firstName = Console.ReadLine();
                        Console.Write("Уровень: ");
                        lvl = int.Parse(Console.ReadLine());
                        Console.Write("ID: ");
                        iD = int.Parse(Console.ReadLine());
                        players.Add(new Player(firstName, lvl, iD));
                        break;
                    case "ban":
                        players[FindID(players)].Ban();
                        break;
                    case "unban":
                        players[FindID(players)].Unban();
                        break;
                    case "del":
                        players.RemoveAt(FindID(players));
                        break;
                    case "exit":
                        isProgramRun = false;
                        break;
                }
            }
        }

        public static int FindID(List<Player> players)
        {
            int playerID = int.Parse(Console.ReadLine());

            for (int i =0; i < players.Count; i++)
            {
                if (players[i].ID == playerID)
                {
                    playerID = i;
                    break;
                }
            }
            return playerID;
        }
    }
    class Player
    {
        private string _name;
        private int _lvl;
        private bool _isBanned;
        public int ID { get; private set; }

        public Player(string name, int lvl, int id, bool isBanned = false)
        {
            _name = name;
            _lvl = lvl;
            ID = id;
            _isBanned = isBanned;
        }

        public void Ban()
        {
            if (_isBanned == false)
            {
                _isBanned = true;
                Console.WriteLine("Пользователь успешно заблокирован");
            }
            else
            {
                Console.WriteLine("Пользователь уже был заблокирован");
            }
        }

        public void Unban()
        {
            if (_isBanned == true)
            {
                _isBanned = false;
                Console.WriteLine("Пользователь успешно разблокирован");
            }
            else
            {
                Console.WriteLine("Пользователь не заблокирован");
            }
        }
    }
}
