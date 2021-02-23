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
                        if (dataBase.TryFindID())
                            dataBase.Ban();
                        break;
                    case "unban":
                        if (dataBase.TryFindID())
                            dataBase.Unban();
                        break;
                    case "del":
                        if (dataBase.TryFindID())
                            dataBase.DeletePlayer();
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
        private int _playerID;
        private List<Player> _players = new List<Player>();

        public void AddList(string firstName, int lvl, int id)
        {
            _players.Add(new Player(firstName, lvl, id));
        }

        public void Ban()
        {
            _players[_playerID].Ban();
        }

        public void Unban()
        {
            _players[_playerID].Unban();
        }

        public void DeletePlayer()
        {
            _players.RemoveAt(_playerID);
        }

        public bool TryFindID()
        {
            bool isIndexFind = false;
            string playerID = Console.ReadLine();
            Console.WriteLine("Введите ID игрока: ");
            bool isConverted = int.TryParse(playerID, out int value) && value <= _players[_players.Count - 1].ID;
            if (isConverted)
            {
                for (int i = 0; i < _players.Count; i++)
                {
                    isIndexFind = _players[i].ID == value;
                    if (_players[i].ID == value)
                    {
                        _playerID = i;
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
