using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static string EqualString (string a, string b)
        {
            if (a == b)
            {
                return "OK";
            }

            else
            {
                return "KO";
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string c = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string d = Console.ReadLine();
            Console.WriteLine(EqualString(c, d));
            Console.ReadLine();
        }
        //не придумал как реализовать чтобы * заменял любые символы
    }
}
