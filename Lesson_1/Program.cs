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
                        try
                        {
                            dataBase.Ban();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ошибка удаления.");
                        }

                        break;
                    case "unban":
                        try
                        {
                            dataBase.Unban();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ошибка удаления.");
                        }
                        break;
                    case "del":
                        try
                        {
                            dataBase.DeletePlayer();
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("Ошибка удаления.");
                        }
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
        public void AddList(string firstName, int lvl, int id)
        {
            _players.Add(new Player(firstName, lvl, id));
        }

        public void Ban()
        {
            _players[FindID(_players)].Ban();
        }

        public void Unban()
        {
           _players[FindID(_players)].Unban();
        }

        public void DeletePlayer()
        {

            _players.RemoveAt(FindID(_players));
            
        }

        private int FindID(List<Player> players)
        {
            int playerID = 0;
            bool IsParseOK = int.TryParse(Console.ReadLine(), out int value);
            if (IsParseOK && value <= players[players.Count-1].ID)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    if (players[i].ID == value)
                    {
                        playerID = i;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Пользователь с таким ID не найден");
                playerID = int.MaxValue;
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
