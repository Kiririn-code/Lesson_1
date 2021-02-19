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
            Player player = new Player("bob", 120, false, 001);
            int banID = int.Parse(Console.ReadLine());
        }
    }
    class Player
    {
        private string _name;
        private int _lvl;
        private bool _isBanned;
        private int _id;

        public int GetID()
        {
            return _id;
        }

        public Player( string name, int lvl, bool isBanned,int id)
        {
            _name = name;
            _lvl = lvl;
            _isBanned = isBanned;
            _id = id;
        }

        public void Ban()
        {
            if(_isBanned = false)
            {
                _isBanned = true;
                Console.WriteLine("Пользователь забанен");
            }
        }
    }
}
