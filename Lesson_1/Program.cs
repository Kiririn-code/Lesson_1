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
            drawer.DrawPlayer(player);
        }
    }
    class Player
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Drawer
    {

        public void DrawPlayer(Player player)
        { 
            Console.SetCursorPosition(player.X,player.Y);
            Console.WriteLine("@");
            Console.CursorVisible = false;
            Console.ReadKey(true);
            
        }
    }
}
