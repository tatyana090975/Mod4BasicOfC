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
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int sum = 0;

            foreach (var item in arr)
            {
                sum = sum + item;               
            }

            Console.WriteLine(sum);
            Console.ReadKey();
         
        }
    }
}

