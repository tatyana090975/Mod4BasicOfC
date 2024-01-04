using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4BasicOfC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("skdvk", 27);
            Console.WriteLine("Введите свое имя: ");

            name = Console.ReadLine();
            Console.WriteLine("Введите свой возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            

            //var anketa = (name, age);
            Console.WriteLine($"Ваше имя: {name}\nВаш возраст: {age}");
                           
                    
                        
            Console.ReadKey();
         
        }
    }
}

