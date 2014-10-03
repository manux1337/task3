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
            int[] arr = new int[6]{28,22,32,60,40,26};
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(
                              "Метод Евклида = {0}\n"+
                              "Бинарный метод = {1}\n"+
                              "Метод с массивом = {2}", 
                               Euclide.GetGCD(a, b),
                               Euclide.GetBGCD(a,b),
                               Euclide.GetGCD(arr)
                              );
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

        public static int GetGCD(int[] a)
        {
            int min = a.Min();
            while (min != 1) 
            {
                var _digits = from val in a
                                  where (int)val % min == 0
                                  select val;
                if (_digits.Count() == a.Length) break;
                min--;
            }
            return min;
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
