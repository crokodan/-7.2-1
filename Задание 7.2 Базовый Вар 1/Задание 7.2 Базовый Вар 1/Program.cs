using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7._2_Базовый_Вар_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символы, содержащие букву \"А\"");
            string s = Console.ReadLine();
            s = s.ToUpper();
            int k = 0;
            foreach (char c in s)
            {
                if (c == 'А') k++;
            }
            Console.WriteLine("Количество букв А=" + k);
        }
    }
}
