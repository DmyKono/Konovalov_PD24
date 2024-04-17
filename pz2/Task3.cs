using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz2
{
    public class Task3
    {
        public void task3run()
        {
            Random random = new Random();
            int[] numbers = new int[19];
            for (int i = 0; i < numbers.Length; i++) 
            {
                numbers[i] = random.Next(0,10);
            }

            int min = 100;
            int max = 0;

            for (int i = 0;i < numbers.Length;i++) 
            {
                if (numbers[i] <= min)
                {
                    min = numbers[i];
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] >= max))
                {
                    max = numbers[i];
                }
            }
            Console.Write('[');
            for (int i = 0; i<numbers.Length ; i++)
            {
                Console.Write(" "+numbers[i]+",");
            }
            Console.Write(" ]");
            Console.WriteLine("\nmin:"+min+"\nmax:"+max);
        }
    }
}
