using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int t;
            x = 5;
            y = 2;
            z = x * y;
            Console.WriteLine("Заданы значения x=5, y=2. При умножении этих значений мы получим переменную z");
            Console.WriteLine("z={0}", z);
            if (z > 0)
            {
                Console.WriteLine("Число z положительное");
            }
            else
            {
                Console.WriteLine("Число z отрицательное");
            }
            if (z % 2 == 0)
            {
                Console.WriteLine("Четное");
            }
            else
            {
                Console.WriteLine("Нечетное");
            }
            if (z % 5 == 0)
            {
                Console.WriteLine("Число делиться на 5 без остатка");
            }
            else
            {
                Console.WriteLine("Число не делиться на 5 без остатка");
            }
            if (z % 10 == 0)
            {
                Console.WriteLine("Число делиться на 10 без остатка");
            }
            else
            {
                Console.WriteLine("Число не делиться на 10 без остатка");
            }
            if (z % 20 == 0)
            {
                Console.WriteLine("Число делиться на 20 без остатка");
            }
            else
            {
                Console.WriteLine("Число не делиться на 20 без остатка");
            }
            Console.WriteLine("Отнимем от z единицу");
            t = z - 1;
            Console.WriteLine("z={0}", t);
        Start:
            t--;
        if (t > 0)
        {
            Console.WriteLine("z={0}", t);
            goto Start;
        }
        else
        {
            Console.WriteLine("z={0}", t);
        }
            Console.ReadKey();
        }
    }
}
