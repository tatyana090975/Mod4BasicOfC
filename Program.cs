using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4BasicOfC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                var a = 6;
                var b = 7;

                if (a == b && b > 1)
                {
                    Console.WriteLine("Условие истинно");
                }

                else if (b > 10 || b == 7)
                {
                    Console.WriteLine("Значение b = {0} больше 10 или равно 7", b);
                }
                else
                {
                    Console.WriteLine("Значение b = {0}", b);
                }
                Console.ReadKey();
            }
        }
    }
}
