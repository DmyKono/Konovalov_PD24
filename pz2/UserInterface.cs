using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz2
{
    public class ConsoleInterface
    {
        public void UIrun()
        {
            char UserInput = '0';


            while (true)
            {
                Console.Clear();
                Console.WriteLine("" +
               "\nChoose the task:" +
               "\n=====================" +
               "\n[1] - numbers in array" +
               "\n[2] - triangle" +
               "\n[3] - min/max" +
               "\n[4] - new array" +
               "\n[0] - exit" +
               "\n=====================" +
               "\n");
                UserInput = Convert.ToChar(Console.ReadLine());
                switch (UserInput)
                {
                    case '1':
                        Task1 task1 = new Task1();
                        task1.task1run();
                        Console.ReadKey();
                        continue;
                    case '2':
                        Task2 task2 = new Task2();
                        task2.task2run();
                        Console.ReadKey();
                        continue;
                    case '3':
                        Task3 task3 = new Task3();
                        task3.task3run();
                        Console.ReadKey();
                        continue;
                    case '4':
                        Task4 task4 = new Task4();
                        task4.task4run();
                        Console.ReadKey();
                        continue;
                    case '0':
                        break;
                    default:
                        continue;
                }
            }
        }
    }
}
