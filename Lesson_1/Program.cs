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
            float userUsd;
            float userRub;
            float userEur;
            int userChoise;
            float amountOfMoney;
            string userOutput = "";

            while (userOutput!= "Y" && userOutput!="y" )
            {
                Console.Write("Введите колчиестов рублей ");
                userRub = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количесто долларов ");
                userUsd = Convert.ToInt32(Console.ReadLine());
                Console.Write("введите количесто евро ");
                userEur = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Что вы хотите обменять:");
                Console.WriteLine("1- рубли на доллары");
                Console.WriteLine("2 -рубли на евро");
                Console.WriteLine("3 - доллары на рубли");
                Console.WriteLine("4 - доллары на евро");
                Console.WriteLine("5 - евро на рубли");
                Console.WriteLine("6 - евро на доллары");

                userChoise = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Сколько валюты вы хотите купить");
                amountOfMoney = Convert.ToInt32(Console.ReadLine());

                switch (userChoise)
                {
                    case 1:
                        if (userRub >= amountOfMoney /0.0174f)
                        {
                            userRub -= amountOfMoney /0.0174f;
                            userUsd += amountOfMoney;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно денег,попробуйте еще раз");
                        }
                        break;
                    case 2:
                        if (userRub >= amountOfMoney / 0.0111f)
                        {
                            userRub -= amountOfMoney /0.0111f;
                            userEur += amountOfMoney;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно денег,попробуйте еще раз");
                        }
                        break;
                    case 3:
                        if (userUsd >= amountOfMoney / 74.36f)
                        {
                            userUsd -= amountOfMoney / 74.36f;
                            userRub += amountOfMoney;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно денег,попробуйте еще раз");
                        }
                        break;
                    case 4:
                        if (userUsd >= amountOfMoney * 0.82f)
                        {
                            userEur += amountOfMoney * 0.82f;
                            userUsd -= amountOfMoney;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно денег,попробуйте еще раз");
                        }
                        break;
                    case 5:
                        if (userEur >= amountOfMoney)
                        {
                            userEur -= amountOfMoney;
                            userRub += amountOfMoney * 91.2f;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно денег,попробуйте еще раз");
                        }
                        break;
                    case 6:
                        if (userEur >= amountOfMoney* 1.21f)
                        {
                            userEur -= amountOfMoney *1.21f;
                            userUsd += amountOfMoney;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно денег,попробуйте еще раз");
                        }
                        break;
                }

                Console.WriteLine("Ваш баланс: " + userRub + " рублей ," + userUsd + " долларов, и " + userEur + " евро");

                Console.WriteLine("Желаете выйти из программы: Y/N");
                userOutput = Console.ReadLine();
                Console.Clear();

            }

        }
    }
}
