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
            Hospital hospital = new Hospital();
            bool isProgramRun = true;

            while (isProgramRun)
            {

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Отсортированный по ФИО список бльных");
                        hospital.SortSickAtPersonalData();
                        break;
                    case 2:
                        Console.WriteLine("Отсортированный по возрасту список больных");
                        hospital.SortSickAtAge();
                        break;
                    case 3:
                        Console.Write("Введите заболевание");
                        string disease = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Cписок больных с "+ disease);
                        hospital.FindSickAtDisease(disease);
                        break;
                    case 4:
                        break;
                }
            }
        }
    }

    class Hospital
    {
        private List<Sick> _sicks = new List<Sick>();

        public Hospital()
        {
            _sicks.Add(new Sick(1, "Петров Егор Сергеевич", "Шизофрения"));
            _sicks.Add(new Sick(20, "Егоров Сергей Петрович", "Паркинсон"));
            _sicks.Add(new Sick(34, "Сергеевич Петр Егорович", "Грипп"));
            _sicks.Add(new Sick(9, "Литвинов Александр Викторович", "Перелом"));
            _sicks.Add(new Sick(18, "Можайский Виктор Александрович", "Ковид"));
            _sicks.Add(new Sick(66, "Старый Андрей Васильевич", "Ковид"));
            _sicks.Add(new Sick(11, "Молодой Василий Андреевич", "Грипп"));
            _sicks.Add(new Sick(8, "Маленький Больной Ребенок", "Карликовость"));
            _sicks.Add(new Sick(23, "Аонстантинов Николай Константинович", "Тонзилит"));
            _sicks.Add(new Sick(32, "Запашный Эдвард Григорьевич", "Невроз"));
            _sicks.Add(new Sick(32, "Запашный Дмитрий Григорьевич", "Невроз"));
        }

        private void ShowList(List<Sick> newList)
        {
            foreach (var sick in newList)
            {
                Console.WriteLine(sick.PersonalData + " Лежит с заболеванием: " + sick.Disease + " и ему " + sick.Age + " лет");
            }
        }

        public void SortSickAtAge()
        {
            var newList = _sicks.OrderByDescending(sick => sick.Age).ToList();
            ShowList(newList);
        }

        public void SortSickAtPersonalData()
        {
            var newList = _sicks.OrderBy(sick => sick.PersonalData).ToList();
            ShowList(newList);
        }

        public void FindSickAtDisease(string disease)
        {
            var newList = _sicks.Where(sick => sick.Disease == disease).ToList();
            ShowList(newList);
        }
    }

    class Sick
    {
        public int Age { get;private set; }
        public string  PersonalData { get;private set; }
        public string Disease { get;private set; }

        public Sick(int age,string personalData, string disease)
        {
            Age = age;
            PersonalData = personalData;
            Disease = disease;
        }
    }
}
