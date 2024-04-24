using Microsoft.Win32;
using pz3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz3
{
    public class Task1UI
    {
        public void UIrun(Book userBook, InputInfo user)
        {
            string UserInput = "0";


            while (true)
            {
                Console.Clear();
                Console.WriteLine("" +
               "\nChoose the action:" +
               "\n=====================" +
               "\n[1] - change the author" +
               "\n[2] - change the content" +
               "\n[3] - check info" +
               "\n[0] - next task" +
               "\n=====================" +
               "\n");
                UserInput = Convert.ToString(Console.ReadLine());
                switch (UserInput)
                {
                    case "1":
                        Console.WriteLine(userBook.author);
                        userBook.changeAuthor(user.Input("author"));
                        continue;
                    case "2":
                        Console.WriteLine(userBook.author);
                        userBook.changeContent(user.Input("content"));
                        continue;
                    case "3":
                        userBook.showBook();
                        Console.ReadKey();
                        continue;
                    case "0":
                        break;
                    default:
                        continue;
                }
                Task2 task2 = new Task2();
                task2.Task2run();
                break;
            }
        }
    }
}
