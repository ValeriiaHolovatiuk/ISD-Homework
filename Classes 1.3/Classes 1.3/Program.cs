using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_1._3
{
    class Program
    {
        class Title
        {
            public string name;

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Title: {0}", name);
            }
        }

        class Author
        {
            public string name;

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Author: {0}", name);
            }
        }

        class Content
        {
            public string name;

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Content: {0}", name);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        class Book
        {
            Title title = new Title();
            Author author = new Author();
            Content content = new Content();

            public Book(string titleName, string authorName, string contentName)
            {
                title.name = titleName;

                author.name = authorName;

                content.name = contentName;
            }

            public void Show()
            {
                title.Show();
                author.Show();
                content.Show();
            }
        }

        static void Main(string[] args)
        {
            Book book = new Book("Little Prince", " ‎Antoine de Saint-Exupery", "Chapter 1\nChapter 2\nChapter 3");
            book.Show();
        }
    }
}
