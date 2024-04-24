using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz3
{
    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string content { get; set; }
        public Book(string Title, string Author) 
        {
            this.title = Title;
            this.author = Author;
        }
        public void showBook()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Name: {title}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Author: {author}");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Content: {content}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void changeAuthor(string newAuthor)
        {
            this.author = newAuthor;
        }
        public void changeContent(string newContent)
        {
            this.content = newContent;
        }

    }
}
