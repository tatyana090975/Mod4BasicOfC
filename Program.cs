﻿using System;
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
            /*
            Console.WriteLine("Введите возраст питомца: ");
            pet.age = Convert.ToDouble(Console.ReadLine());
            
                        
            Console.WriteLine($"Имя вашего питомца: {pet.name}\nВид вашего питомца: {pet.type}\nВозраст вашего питомца: {pet.age}\nДлина имени питомца: {pet.nameCount}");
            */


            Console.ReadKey();
         
        }
    }
}

