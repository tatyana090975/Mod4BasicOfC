using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mod4BasicOfC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, string type, double age) pet;
            Console.WriteLine("Введите имя питомца: ");
            pet.name = Console.ReadLine();
            Console.WriteLine("Введите вид питомца: ");
            pet.type = Console.ReadLine();
            Console.WriteLine("Введите возраст питомца: ");
            pet.age = Convert.ToDouble(Console.ReadLine());
            

            
            Console.WriteLine($"Имя вашего питомца: {pet.name}\nВид вашего питомца: {pet.type}\nВозраст вашего питомца: {pet.age}");
                           
                    
                        
            Console.ReadKey();
         
        }
    }
}

