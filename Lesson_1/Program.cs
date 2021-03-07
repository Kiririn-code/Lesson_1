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
            DataBase dataBase = new DataBase();

            dataBase.TransportSoliders();
        }
    }

    class DataBase
    {
        private List<Solider> _firstPlatoon = new List<Solider>();
        private List<Solider> _secondPlatoon = new List<Solider>();

        public DataBase()
        {
            _firstPlatoon.Add(new Solider("Петров"));
            _firstPlatoon.Add(new Solider("Баширов"));
            _firstPlatoon.Add(new Solider("Кузьмин"));
            _firstPlatoon.Add(new Solider("Баранов"));
            _firstPlatoon.Add(new Solider("Бойко"));
            _firstPlatoon.Add(new Solider("Пугачев"));
            _firstPlatoon.Add(new Solider("Березуцкий"));
            _firstPlatoon.Add(new Solider("Абрамов"));
            _firstPlatoon.Add(new Solider("Яйцев"));

            _secondPlatoon.Add(new Solider("Авдаченок"));
            _secondPlatoon.Add(new Solider("Лебедев"));
            _secondPlatoon.Add(new Solider("Максимоа"));
            _secondPlatoon.Add(new Solider("Пасечник"));
        }

        public void TransportSoliders()
        {
            var correctPlatoon =_secondPlatoon.Union(_firstPlatoon.Where(solider => solider.Surname.StartsWith("Б"))).OrderBy(solider=> solider.Surname);

            foreach (var solider in correctPlatoon)
            {
                Console.WriteLine(solider.Surname);
            }
        }
    }

    class Solider
    {
        public string Surname { get;private set; }

        public Solider(string surname)
        {
            Surname = surname;
        }
    }
}
