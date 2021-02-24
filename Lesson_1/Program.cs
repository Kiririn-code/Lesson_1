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
            int id = 0;
            int lvl;
            string firstName;
            bool isProgramRun = true;
            DataBase dataBase = new DataBase();
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
                        dataBase.AddList(firstName, lvl, ++id);
                        break;
                    case "ban":
                            dataBase.Ban();
                        break;
                    case "unban":
                            dataBase.Unban();
                        break;
                    case "del":
                            dataBase.DeletePlayer();
                        break;

                    case "show":
                        dataBase.ShowPlayer();
                        break;

                    case "exit":
                        isProgramRun = false;
                        break;
                }
            }
        }
    }

    class DataBase
    {
        private List<Player> _players = new List<Player>();

        public void ShowPlayer()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                _players[i].ShowPlayer();
            }
        }

        public void AddList(string firstName, int lvl, int id)
        {
            _players.Add(new Player(firstName, lvl, id));
        }

        public void Ban()
        {
            int playerID;
            if (TryFindID(out playerID))
                _players[playerID].Ban();
        }

        public void Unban()
        {
            int playerID;
            if (TryFindID(out playerID))
                _players[playerID].Unban();
        }

        public void DeletePlayer()
        {
            int playerID;
            if (TryFindID(out playerID))
                _players.RemoveAt(playerID);
        }

        private bool TryFindID(out int playerID)
        {
            bool isIndexFind = false;
            Console.WriteLine("Введите ID игрока: ");
            bool isConverted = int.TryParse(Console.ReadLine(), out playerID);
            if (isConverted)
            {
                for (int i = 0; i < _players.Count; i++)
                {
                    isIndexFind = _players[i].ID == playerID;
                    if (isIndexFind)
                    {
                        playerID = i;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Проверьте введенные данные");
            }
            return isIndexFind;
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

        public void ShowPlayer()
        {
            Console.WriteLine($"id - {ID}  flag - {GetBannedFlag()}");
        }

        private bool GetBannedFlag()
        {
            return _isBanned;
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
