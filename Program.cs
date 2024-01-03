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
            int[,] array = new int[,] { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int summ = 0;

            for (int i = 0; i < array.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1)+1; j++)
                {
                    if (array[i, j] > 0)
                    {
                        summ += 1;
                    }
                }
                
            }

                     
            Console.WriteLine(summ);
            
            Console.ReadKey();
         
        }
    }
}

