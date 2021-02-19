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
            Vendor vendor = new Vendor();
            Player player = new Player();

            string userChoise;
            while (true)
            {
                userChoise = Console.ReadLine();
                switch (userChoise)
                {
                    case "show":
                        vendor.ShowItem();
                        break;
                    case "bye":
                        
                        break;
                    case "inv":
                        break;
                }
            }
        }

    }
    
    class Vendor
    {
        private float _money;
        public List<Item> items = new List<Item>(); 
        public void ShowItem()
        {
            for (int i = 0; i < items.Count; i++)
            {
                items[i].ShowStats();
            }
        }
        
    }
    class Player
    {
        private float _money;
        private List<Item> items = new List<Item>();
    }
    class Item
    {
        private int _id;
        private string _name;
        private float _coast;

        public Item(int iD,string name,float coast)
        {
            _id = iD;
            _name = name;
            _coast = coast;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Название: {_name} цена - {_coast} гривен");
        }
    }
}
