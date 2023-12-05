using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2._17_Classes_and_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books();

            book1.title = "Harry Potter";
            book1.author = "J.K Rowling";
            book1.pages = 400;


            Books book2 = new Books();

            book2.title = "Lord of the rings";
            book2.author = "Tolkien";
            book2.pages = 900;

            Books book3 = new Books();

            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.title);


            Console.ReadKey();
        }
    }
}
