using System;
using System.Collections.Generic;
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
            int[] array = new int[] {1, 2, 3, 4, 5, 6, -5, -6 };

            int summ = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    summ += 1;
                }
            }

                     
            Console.WriteLine(summ);
            
            Console.ReadKey();
         
        }
    }
}

