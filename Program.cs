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
            Console.WriteLine("Введите свое имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свой возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            var anketa = (name, age);
            Console.WriteLine($"Ваше имя: {anketa.name}\nВаш возраст: {anketa.age}");
                           
                    
                        
            Console.ReadKey();
         
        }
    }
}

