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
            Market market = new Market();
            market.Work();
        }
    }

    class Market
    {
        private Queue<Person> _people = new Queue<Person>();
        private Random _random = new Random();
        public int Money { get;private set; }

        public Market()
        {
            for (int i = 0; i < 6; i++)
            {
                _people.Enqueue(new Person(_random.Next(400,900)));
            }
        }

        public void Work()
        {
            while (_people.Count > 0)
            {
                Person people = _people.Dequeue();
                Console.WriteLine($"Добрый день, посетитель, удачных покупок");
                loop:
                    if (people.Money > people.GetCoast())
                    {
                        Console.WriteLine("Покупки успешно оплачены\nВаш список покупок:");
                        people.ShowList();
                    }
                    else
                    {
                        Console.WriteLine($"У вас всего { people.Money} рублей,а продуктовая корзина стоит {people.GetCoast()} рублей");
                        Console.WriteLine("Вам не зватает денег, придется выбросить что то");
                        people.DeleteProduct();
                        goto loop;
                    }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
   class Person
    {
        public int Money { get;private set; }
        private List<Product> _products = new List<Product>();
        private static Random _random = new Random();

        public Person(int money)
        {
            Money = money;

            for (int i = 0; i < _random.Next(5,11); i++)
            {
                int id = _random.Next(7);
                _products.Add(new Product(Product.BaseOfCoast(id), Product.BaseOfName(id)));
            }
        }

        public int GetCoast()
        {
            int coast = 0;
            foreach (var product in _products)
            {
                coast += product.Coast;
            }
            return coast;
        }

        public void DeleteProduct()
        {
            _products.RemoveAt(_random.Next(_products.Count));
        }

        public void ShowList()
        {
            foreach (var product in _products)
            {
                Console.WriteLine(product.Name);
            }
        }
    }

    class Product
    {
        public int Coast { get; private set; }
        public string Name { get; private set; }

        public Product(int coast, string name)
        {
            Coast = coast;
            Name = name;
        }
       static public string BaseOfName(int id)
        {
            string[] typeOfProducts = { "Колбаса", "Макароны", "Сыр", "Водка", "Печенье","Сосиски","Кетчуп"};
            return typeOfProducts[id];
        }
        static public int BaseOfCoast(int id)
        {
            int[] coastofProducts = { 150, 66, 189, 370, 55, 78, 36 };
            return coastofProducts[id];
        }
    }
}
