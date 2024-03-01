using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string s = Console.ReadLine();
            string[] stringArray = s.Split(' ');
            string max = stringArray[0];
            foreach(string str in stringArray)
            {
                if (str.Length > max.Length)
                {
                    max = str;
                }
            }
            Console.WriteLine("{0}", max);
            Console.ReadKey();
        }
    }
}
