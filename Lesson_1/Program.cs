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
            int sum = 0;
            Queue<int> purchase = new Queue<int>();

            purchase.Enqueue(0);
            purchase.Enqueue(4);
            purchase.Enqueue(2);
            purchase.Enqueue(5);
            purchase.Enqueue(7);
            purchase.Enqueue(9);
            purchase.Enqueue(100);
            purchase.Enqueue(150);
            purchase.Enqueue(200);


            while(purchase.Count>0)
            { 
                sum += purchase.Dequeue();
                Console.WriteLine(sum);
                Console.ReadKey();
                Console.Clear();
            }
                    
        }
    }
}
