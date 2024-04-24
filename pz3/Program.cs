using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("1984", "George Orwell");
            book.content = ("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Proin fermentum leo vel orci porta. Morbi quis commodo odio aenean sed. Non blandit massa enim nec dui.");
            InputInfo user = new InputInfo();

            Task1UI UI = new Task1UI();
            UI.UIrun(book, user);
        }
    }
}
