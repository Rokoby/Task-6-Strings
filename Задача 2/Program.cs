using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string s = Console.ReadLine();
            string[] stringArray = s.Split(' ');
            string p = "";

            foreach (string str in stringArray)
            {
                p += str;
            }
            p = p.ToLower();

            bool k = true;

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] != p[p.Length - 1 - i])
                    k = false;                
            }

            if (k == true)
                Console.WriteLine("Палиндром");
            else
                Console.WriteLine("Не палиндром");
            Console.ReadKey();
        }
    }
}
