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
            Euclide eu = new Euclide();
            Console.WriteLine("Введите A,B");
            eu.a = Convert.ToInt16(Console.ReadLine());
            eu.b = Convert.ToInt16(Console.ReadLine());
            Console.Write("{0}>{1}",eu.a,eu.b);
            while (eu.getNext())
            {
                Console.Write(">{0}",eu.b);
            }
            Console.WriteLine("\nНОД = {0}",eu.result);
            Console.WriteLine();
            eu.paint();
            Console.ReadKey();
        }
    }

    class Euclide
    {
        public int a, b;
        public int result;
        public bool getNext()
        {
            if (a % b == 0) { result = b; return false; }
            int c = a%b;
            a = b;
            b = c;
            return true;
        }

        public void paint()
        {
            string[] s = new string[12];
            s[0]+="  ____\n /|  /|\n/_|_/_|";
            for (int i = 1; i < 10; i++)
            {
                s[i] += "| | | |";
            }
            s[10]+="| /-|-/\n|/__|/\n";

            for (int i = 0; i < s.Length; i++)
            {

                Console.WriteLine(s[i]);
            }

        }
    }
}
