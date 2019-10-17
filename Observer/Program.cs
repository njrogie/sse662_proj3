using Observer.DP;
using Observer.NonDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        private static readonly List<Book> initBookList = new List<Book>() {
            new Book("Great Expectations", "Charles Dickens", "978-0141439563"),
            new Book("The Lord of the Rings: The Fellowship of the Ring", "J.R.R. Tolkien", "978-0547928210"),
            new Book("1984", "George Orwell", "978-0451524935"),
            new Book("Ender's Game", "Orson Scott Card", "978-0812550702"),
            new Book("American Gods", "Neil Gaiman", "978-1117970486")
        };
        static void Main(string[] args)
        {
            Library tarver = new Library(null, initBookList);
            Person anna = new Person("Anna Smith");
            Person brad = new Person("Brad Cooper");
            Person charles = new Person("Charles Brown");
            tarver.AddUser(anna);
            tarver.AddUser(brad);
            tarver.AddUser(charles);

            //Anna checks out Great Expectations.
            tarver.HandleBookRequest(anna, "Great Expectations");
            //Now, Brad wants to check out the book, but Anna still has it.
            tarver.HandleBookRequest(brad, "Great Expectations");
            //Then, Anna finishes Great Expectations and returns it.
            tarver.CheckInBook(anna);
            //At this point, Brad should get his book.

            Console.Read();
        }
    }
}
