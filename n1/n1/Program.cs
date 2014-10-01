using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace n1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Task3-#1";
            Console.Write("Введите A = ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите B = ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Метод Евклида = {0}",Euclide.GetGCD(a,b));
            Console.WriteLine("Бинарный метод = {0}",Euclide.GetBGCD(a,b));
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }

    class Euclide
    {

        public static int GetGCD(int a, int b)
        {
            return ((a!=0)&&(b!=0))?(a > b) ? GetGCD(a - b, b) : GetGCD(a, b - a):a+b;
        }

        public static int GetBGCD(int a, int b)
        {
            if (a == b) return a;
            if (a == 0) return b;
            if (b == 0) return a;
            if ((a&1)==0) 
            {
                if ((b&1)!=0)
                    return GetBGCD(a >> 1, b);
                else
                    return GetBGCD(a >> 1, b >> 1) << 1;
            }
            if((b&1)==0)
                return GetBGCD(a, b >> 1);
            if (a > b)
                return GetBGCD((a - b) >> 1, b);
            return GetBGCD((b - a) >> 1, a);
        }
    }
}
