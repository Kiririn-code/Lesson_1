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
            Shop shop = new Shop();
            bool isProgramRun = true;
            string userChoise;
            while (isProgramRun)
            {
                userChoise = Console.ReadLine();
                switch (userChoise)
                {
                    case "add":
                        shop.AddItems();
                        break;
                    case "show":
                        shop.ShowItems();
                        break;
                    case "buy":
                        shop.BuyItem();
                        break;
                    case "inv":
                        shop.ShowInventory();
                        break;
                    case "ext":
                        isProgramRun = false;
                        break;
                }
            }
        }

    }

    class Shop
    {
       private Vendor vendor = new Vendor(1000);
       private Player player = new Player(300);


        public void AddItems()
        {
            vendor.AddItems();
        }

        public void ShowItems()
        {
            vendor.ShowItem();
        }

        public void ShowInventory()
        {
            player.ShowItem();
        }

        public void BuyItem()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Item item = vendor.GetItem(id, (player.GetMoney()));
            if (item != null && player.GetMoney() >= item.Coast)
            {
                player.BuyItem(item);
                Console.WriteLine($"Покупка совершена Осталось - {player.GetMoney()} гривен");
            }
            else
            {
                Console.WriteLine("Ошибка,проверьте правильность введенных данных");
            }
        }
    }

    abstract class Human
    {
        protected float Money {get; private set; }
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

        public void GetMoney(float money)
        {
            Money += money;
        }

        public void AwayMoney(float money)
        {
            Money -= money;
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

        public Item GetItem(int id,float playerMoney)
        {
            Item item =null;
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Id == id && playerMoney>= Items[i].Coast)
                {
                    item = Items[i];
                    GetMoney(Items[i].Coast);
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
            AwayMoney(item.Coast);
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
        public float Coast { get; private set; }

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
