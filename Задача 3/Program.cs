using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string s = Console.ReadLine();
            char startDelete = Convert.ToChar("{");
            char endDelete = Convert.ToChar("}");
            int counter = 0;
            string newString = "";

           foreach (char c in s)
            {
                if (c == startDelete)
                    counter++;
                if (counter == 0)
                    newString += c;
                if (c == endDelete)
                    counter--;
            }
            foreach (char c in newString)
                Console.Write(c);
            Console.ReadKey();
        }
    }
}
