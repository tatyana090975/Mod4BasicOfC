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
            Console.WriteLine("Введите свое имя");
            string name = Console.ReadLine();

            char[] namearr = name.ToCharArray();
                        
            foreach (char i in namearr)
            {
                Console.Write($"{i} ");
            }
            Console.Write("Последняя буква вашего имени: {0}", namearr[namearr.Length - 1]);
            


             Console.ReadKey();
         
        }
    }
}
