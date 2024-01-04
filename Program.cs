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
            int[,] array = new int[,] { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int temp;

            for (int i = 0; i < array.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1)+1; j++)
                {
                    for (int k = j + 1; k < array.GetUpperBound(1)+1; k++)
                        if (array[i, j] > array[i, k])
                        {
                            temp = array[i, k];
                            array[i, k] = array[i, j];
                            array[i, j] = temp;
                        }
                   
                }
                
            }
            
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                 for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                     Console.Write(array[i, k] + " ");
                 Console.WriteLine();
            }
                  
                     
                        
            Console.ReadKey();
         
        }
    }
}

