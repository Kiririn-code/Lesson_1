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
            War war = new War();
            war.MakeBattle();
        }
    }

    class War
    {
        private List<Human> _firstBatallion;
        private List<Human> _secondBatalion;
        private static Random _random;

        public War()
        {
            _firstBatallion = new List<Human>();
            _secondBatalion = new List<Human>();
            _random = new Random();

            for (int i = 0; i < _random.Next(50,100); i++)
            {
                _firstBatallion.Add(new Solider());
                _secondBatalion.Add(new Solider());
                if (i < 5)
                {
                    _firstBatallion.Add(new Sniper());
                    _secondBatalion.Add(new Sniper());

                    _firstBatallion.Add(new Paramedic());
                    _secondBatalion.Add(new Paramedic());
                }
            }
        }
        public void MakeBattle()
        {
            while (_firstBatallion.Count != 0 && _secondBatalion.Count != 0)
            {
                int firstMan = _random.Next(_firstBatallion.Count);
                int secondMan = _random.Next(_secondBatalion.Count);

                _firstBatallion[firstMan].DoSpecialAttack();
                _firstBatallion[firstMan].GetDamage(_secondBatalion[secondMan].Attack);
                _secondBatalion[secondMan].DoSpecialAttack();
                _secondBatalion[secondMan].GetDamage(_firstBatallion[firstMan].Attack);

                if (_firstBatallion[firstMan].Health < 0)
                    _firstBatallion.RemoveAt(firstMan);
                if (_secondBatalion[secondMan].Health < 0)
                    _secondBatalion.RemoveAt(secondMan);

                Console.WriteLine($"Бойцов первого дивизиона осталось - {_firstBatallion.Count}\nБойцов вотрого дивизиона остальось - {_secondBatalion.Count}\n");
            }
            Console.WriteLine("Битва завершена, нажмите любую клавишу,чтобы узнать результаты");
            Console.ReadKey();
            Console.Clear();
            
            if(_firstBatallion.Count>_secondBatalion.Count)
                Console.WriteLine("Победил первый дивизион");
            else
                Console.WriteLine("Победил вотрой дивизион");
        }
    }

     abstract class Human
    {
        public int Health { get; protected set; }
        public int Armor { get;protected set; }
        public int Attack { get;protected set; }

        public Human(int health,int armor,int attack)
        {
            Health = health;
            Armor = armor;
            Attack = attack;
        }

        public void GetDamage(int attack)
        {
            Health -= attack -Armor;
        }

        public abstract void DoSpecialAttack();
        
    }

    class Solider : Human
    {
        public Solider() : base(100, 10, 40) { }

        public override void DoSpecialAttack()
        {
            if (Armor == 10)
                Armor += 20;
            else
                Armor = 10;
        }
    }

    class Sniper : Human
    {
        public Sniper() : base(80, 10, 130) { }
        public override void DoSpecialAttack()
        {
            if (Attack == 130)
                Attack += 20;
            else
                Attack = 130;
        }
    }
    class Paramedic: Human
    {
        public Paramedic() : base(200, 5, 10) { }

        public override void DoSpecialAttack()
        {
            if(Health<200)
                Health += 20;
        }
    }
}
