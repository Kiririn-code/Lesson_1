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
            Vendor vendor = new Vendor(1000);
            Player player = new Player(300);

            string userChoise;
            while (true)
            {
                userChoise = Console.ReadLine();
                switch (userChoise)
                {
                    case "add":
                        vendor.AddItems();
                        break;
                    case "show":
                        vendor.ShowItem();
                        break;
                    case "buy":
                        Console.Write("Id: ");
                        int id = int.Parse(Console.ReadLine());
                        Item item = vendor.GetItem(id);
                        if (item != null && player.GetMoney() >= item.Coast)
                        {
                            player.BuyItem(item);
                            Console.WriteLine($"Покупка совершена Осталось - {player.GetMoney()} гривен");
                        }
                        else
                            Console.WriteLine("Такого предмета еще не сущестует");
                        break;
                    case "inv":
                        player.ShowItem();
                        break;
                }
            }
        }

    }


    abstract class Human
    {
        protected float Money {get; set; }
        protected List<Item> Items = new List<Item>();

        public Human(int money)
        {
            Money = money;
        }
        public void ShowItem()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].ShowStats();
            }
        }
    }

    class Vendor : Human
    {
        private int _id;

        public Vendor(int money) : base(money) { }

        public void AddItems()
        {
            Console.Write("name: ");
            string itemName = Console.ReadLine();
            Console.Write("Coast: ");
            int coast = int.Parse(Console.ReadLine());
            Items.Add(new Item(++_id, itemName, coast));
        }

        public Item GetItem(int id)
        {
            Item item =null;
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Id == id)
                {
                    item = Items[i];
                    Money += Items[i].Coast;
                    Items.RemoveAt(i);
                    break;
                }
            }
            return item;
        }
    }

    class Player:Human
    {
        public Player(int money): base(money) { }

        public void BuyItem(Item item)
        {
            Items.Add(item);
            Money -= item.Coast;
        }

        public float GetMoney()
        {
            return Money;
        }
    }

    class Item
    {
        
        private string _name;
        public int Id { get;private set; }
        public float Coast { get; set; }

        public Item(int id,string name,float coast)
        {
            Id = id;
            _name = name;
            Coast = coast;
        }

        public void ShowStats()
        {
            Console.WriteLine($"{Id} - Название: {_name} цена - {Coast} гривен");
        }
    }
}
