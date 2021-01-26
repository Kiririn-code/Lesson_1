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
            bool isProgramExit = true;
            float rubToUsd = 0.0174f,rubToEur = 0.0111f;
            float usdToRub = 74.36f, usdToEur = 0.82f;
            float eurToRub = 91.2f, eurToUsd = 1.21f;

            while (isProgramExit)
            {

                Console.Write("Введите колчиестов рублей ");
                userRub = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количесто долларов ");
                userUsd = Convert.ToInt32(Console.ReadLine());
                Console.Write("введите количесто евро ");
                userEur = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Что вы хотите обменять:");
                Console.WriteLine("1 - рубли на доллары");
                Console.WriteLine("2 - рубли на евро");
                Console.WriteLine("3 - доллары на рубли");
                Console.WriteLine("4 - доллары на евро");
                Console.WriteLine("5 - евро на рубли");
                Console.WriteLine("6 - евро на доллары");
                Console.WriteLine("7 - выйти из программы");

                userChoise = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (userChoise)
                {
                    case 1:
                        Console.WriteLine("Сколько долларов вы хотите купить:");
                        amountOfMoney = Convert.ToInt32(Console.ReadLine());
                        if (userRub >= amountOfMoney /rubToUsd)
                        {
                            userRub -= amountOfMoney /rubToUsd;
                            userUsd += amountOfMoney;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно денег,попробуйте еще раз");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Сколько евро вы хотите купить:");
                        amountOfMoney = Convert.ToInt32(Console.ReadLine());
                        if (userRub >= amountOfMoney / rubToEur)
                        {
                            userRub -= amountOfMoney /rubToEur;
                            userEur += amountOfMoney;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно денег,попробуйте еще раз");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Сколько рублей вы хотите купить:");
                        amountOfMoney = Convert.ToInt32(Console.ReadLine());
                        if (userUsd >= amountOfMoney / usdToRub)
                        {
                            userUsd -= amountOfMoney / usdToRub;
                            userRub += amountOfMoney;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно денег,попробуйте еще раз");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Сколько евро вы хотите купить:");
                        amountOfMoney = Convert.ToInt32(Console.ReadLine());
                        if (userUsd >= amountOfMoney / usdToEur)
                        {
                            userUsd -= amountOfMoney / usdToEur;
                            userEur += amountOfMoney;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно денег,попробуйте еще раз");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Сколько рублей вы хотите купить:");
                        amountOfMoney = Convert.ToInt32(Console.ReadLine());
                        if (userEur >= amountOfMoney/eurToRub)
                        {
                            userEur -= amountOfMoney/eurToRub;
                            userRub += amountOfMoney;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно денег,попробуйте еще раз");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Сколько долларов вы хотите купить:");
                        amountOfMoney = Convert.ToInt32(Console.ReadLine());
                        if (userEur >= amountOfMoney/ eurToUsd)
                        {
                            userEur -= amountOfMoney / eurToUsd;
                            userUsd += amountOfMoney;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно денег,попробуйте еще раз");
                        }
                        break;

                    case 7:
                        isProgramExit = false;
                        Console.Clear();
                        break;
                }
                Console.WriteLine("Ваш баланс: " + userRub + " рублей ," + userUsd + " долларов, и " + userEur + " евро");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Всего доброго,спасибо что воспользовались нашими услугами");
        }
    }
}
