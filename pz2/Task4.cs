using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz2
{
    public class Task4
    {
        public void task4run()
        {
            Random random = new Random();
            int[] numbersX = new int[19];
            for (int i = 0; i < numbersX.Length; i++)
            {
                numbersX[i] = random.Next(-100, 100);
            }
            int[] numbersY = new int[19];
            for (int i = 0; i < numbersX.Length; i++)
            {
                numbersY[i] = 0;
            }

            Console.Write("Write the M:");
            int M = Convert.ToInt32(Console.ReadLine());

            for (int i = 0;i < numbersY.Length; i++) 
            {
                if ((Math.Abs(numbersX[i])>M))
                {
                    numbersY[i] = numbersX[i];
                }
            }

            Console.Write("X=[");
            for (int i = 0; i < numbersX.Length; i++)
            {
                Console.Write(" " + numbersX[i] + ",");
            }
            Console.Write(" ]");
            Console.Write($"\nM={M}\nY=[");
            for (int i = 0; i < numbersY.Length; i++)
            {
                Console.Write(" " + numbersY[i] + ",");
            }
            Console.Write(" ]");


        }
    }
}
