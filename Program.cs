﻿using System;
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

                if (a == b)
                {
                    Console.WriteLine("Условие истинно");
                }
                else
                {
                    Console.WriteLine("Условие ложно");
                }
                Console.ReadKey();
            }
        }
    }
}
