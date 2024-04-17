using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz2
{
    public class Task1
    {
        public void task1run()
        {
            int[] numbers =new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"\nEnter the number for the position {i}:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0;i < numbers.Length;i++) 
            {
                if (numbers[i] >=1 && numbers[i]<=19) 
                {
                    Console.WriteLine($"{numbers[i]} Belongs to an array [1, 19] ");
                }
            }

        }
    }
}
