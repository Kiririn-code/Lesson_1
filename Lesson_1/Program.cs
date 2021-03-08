using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase = new DataBase();

            dataBase.FindCriminal();
        }
    }

    class DataBase
    {
        private List<Criminal> _criminals = new List<Criminal>();

        public DataBase()
        {
            _criminals.Add(new Criminal("Лавров Геннадий Павлочич", "Кража"));
            _criminals.Add(new Criminal("Смердюков Аннатолий Аннатольевич", "Бандитизм"));
            _criminals.Add(new Criminal("Петров Егор Васильевич", "Убийство"));
            _criminals.Add(new Criminal("Смирнов Васил Егорьевич", "Антиправительственное"));
            _criminals.Add(new Criminal("Егоров Петр Смирнович", "Антиправительственное"));

        }

        public void FindCriminal()
        {
            Console.WriteLine("\tСписок всех преступников");

            for (int i = 0; i < _criminals.Count; i++)
            {
                Console.WriteLine(_criminals[i].PersonalData + " Сидит по статье: " + _criminals[i].Article);
            }
            Console.WriteLine("");
            var correctCriminalsList = _criminals.Except(_criminals.Where(criminal => criminal.Article == "Антиправительственное"));
            Console.WriteLine("\tСписок преступников после амнистии");

            foreach (var criminal in correctCriminalsList)
            {
                Console.WriteLine(criminal.PersonalData + " Cидит по статье: " + criminal.Article);
            }
        }
    }

    class Criminal
    {
        public string PersonalData { get; private set; }
        public string Article { get; set; }

        public Criminal(string personalData, string article)
        {
            PersonalData = personalData;
            Article = article;
        }
    }
}
