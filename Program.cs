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
            (string name, string surname, string login, int loginCount, bool pet, double age, string[] favcolors) anketa;
            string pet;
            Console.WriteLine("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            anketa.surname = Console.ReadLine();
            Console.WriteLine("Введите логин: ");
            anketa.login = Console.ReadLine();
            anketa.loginCount = anketa.login.Length;
            Console.WriteLine("Есть ли у вас животные? Да или Нет: ");
            pet = Console.ReadLine();
            if (pet == "Да")
            {
                anketa.pet = true;
            }
            else
            {
                anketa.pet = false;
            }
            Console.WriteLine("Введите возраст: ");
            anketa.age = Convert.ToDouble(Console.ReadLine());
            anketa.favcolors = new string[3];
            Console.WriteLine("Введите три любимых цвета: ");
            for (int i = 0; i < 3; i++)
            {
                anketa.favcolors[i] = Console.ReadLine();
            }
            /*
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(anketa.favcolors[i]);
            }*/
            
           


            Console.ReadKey();
         
        }
    }
}

