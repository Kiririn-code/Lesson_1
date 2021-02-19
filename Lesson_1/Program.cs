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
            Player player = new Player(5, 1);
            Drawer drawer = new Drawer();
            drawer.DrawPlayer(player.GetY(), player.GetX());
        }
    }
    class Player
    {
        private int _x;
        private int _y;

        public int GetX()
        {
            return _x;
        }
        public int GetY()
        {
            return _y;
        }

        public Player(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }

    class Drawer
    {
        public void DrawPlayer(int x, int y)
        {
            Console.SetCursorPosition(y, x);
            Console.WriteLine("@");
            Console.CursorVisible = false;
            Console.ReadKey(true);
            
        }
    }
}
