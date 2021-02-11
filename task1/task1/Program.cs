using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static string itoBase(uint nb, string baSe)
        {
            uint bin = 2;
            uint oct = 8;
            uint hex = 16;
            uint res = 0;
            string result = "";

            if (baSe == "01" || baSe == "2")
            {
                while (nb > 0)
                {
                    res = nb % bin;
                    nb = nb / bin;
                    result = $"{res}{result}";
                }
                return result;
            }
            else if (baSe == "8")
            {
                while (nb > 0)
                {
                    res = nb % oct;
                    nb = nb / oct;
                    result = $"{res}{result}";
                }
                return result;
            }
            else if (baSe == "16" || baSe == "hex" || baSe == "HEX")
            {
                while (nb > 0)
                {
                    res = nb % hex;
                    nb = nb / hex;
                    result = $"{res}{result}";
                }
                return result;
            }
            else
            {
                return $"{nb}";
            }    
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для перевода: ");
            uint num = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите систему счисления: ");
            string baSe = Console.ReadLine();
            Console.WriteLine("Полученное число:\n" + itoBase(num, baSe));
            Console.ReadLine();
        }

        // в процессе перевод в 16 ричную
    }
}
