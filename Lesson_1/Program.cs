using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Station station = new Station();
            station.DoWork();
        }
    }

    class Station
    {
        private List<Vagon> _trains;
        private bool _isCreated;
        private bool _isFull;

        public Station()
        {
            _isCreated = false;
            _isFull = false;
            _trains = new List<Vagon>();

        }

        public void DoWork()
        {
            bool isProgramRun = true;
            while (isProgramRun)
            {

                if (_isCreated && _isFull)
                    Console.WriteLine($"Поезд из {_trains.Count} вагонов готов к отправке по маршруту Байск - Барнаул\n");
                else if (_isCreated)
                    Console.WriteLine("Поезд Байск - Барнаул ожидает пассажиров на перроне\n");
                else
                    Console.WriteLine("Информация не доступна\n");

                Console.WriteLine("1 - сформировать направление");
                Console.WriteLine("2 - Начать посадку на поезд");
                Console.WriteLine("3 - отправить поезд");
                Console.WriteLine("4 - выйти из программы");
                int userChiose = int.Parse(Console.ReadLine());

                switch (userChiose)
                {
                    case 1:
                        if (_isCreated==false)
                            CreateDirection();
                        break;
                    case 2:
                        if (_isFull ==false && _isCreated == true)
                            GetPerson();
                        break;
                    case 3:
                        if (_isCreated && _isFull)
                        {
                            _trains.Clear();
                            Console.WriteLine("Поезд усешно отправлен");
                            _isCreated = false;
                            _isFull = false;
                        }
                        break;
                    case 4:
                        isProgramRun = false;
                        break;
                    default:
                        Console.WriteLine("Проверьте правильность введенных данных");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void CreateDirection()
        {
            Console.WriteLine("Поезд проследует по маршруту Байск - Барнаул");
            _isCreated = true;
        }

        private void GetPerson()
        {
            Random random = new Random();

            int numberOfPeople = random.Next(200, 500);
            int numberOfOccupedVagon = numberOfPeople / 50;
            Console.WriteLine($"На поезд Байск - Барнаул заявлено {numberOfPeople} пассажиров");
            for (int i = 0; i <= numberOfOccupedVagon; i++)
            {
                if (numberOfPeople >=50)
                {
                    _trains.Add(new Vagon(50));
                    numberOfPeople -= 50;
                }
                else
                {
                    _trains.Add(new Vagon(numberOfPeople));
                }
            }
            _isFull = true;
        }

    }

    class Vagon
    {
        public int FreePlace { get; private  set; }
        public int OccupedPlace { get; private set; }

        public Vagon(int occupedPlace)
        {
            FreePlace = 50;
            FreePlace -= occupedPlace;
            OccupedPlace += occupedPlace;

        }
    }
}
