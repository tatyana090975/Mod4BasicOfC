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
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Введите число");
                var number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    continue;
                }
                else if (number == 0)
                {
                    break;
                }

                // number > 0
                sum += number;
            }

            Console.WriteLine("Итоговая сумма: {0}", sum);
        
            Console.ReadKey();
            
        }
    }
}
