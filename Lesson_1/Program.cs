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
