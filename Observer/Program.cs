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
        private static readonly List<Book> NonDPInitBookList = new List<Book>() {
            new Book("Great Expectations", "Charles Dickens", "978-0141439563"),
            new Book("The Lord of the Rings: The Fellowship of the Ring", "J.R.R. Tolkien", "978-0547928210"),
            new Book("1984", "George Orwell", "978-0451524935"),
            new Book("Ender's Game", "Orson Scott Card", "978-0812550702"),
            new Book("American Gods", "Neil Gaiman", "978-1117970486")
        };

        private static readonly List<Book2> DPInitBookList = new List<Book2>() {
            new Book2("Great Expectations", "Charles Dickens", "978-0141439563"),
            new Book2("The Lord of the Rings: The Fellowship of the Ring", "J.R.R. Tolkien", "978-0547928210"),
            new Book2("1984", "George Orwell", "978-0451524935"),
            new Book2("Ender's Game", "Orson Scott Card", "978-0812550702"),
            new Book2("American Gods", "Neil Gaiman", "978-1117970486")
        };

        static void Main(string[] args)
        {
            NonDP_Program();
            DP_Program();
        }

        static void NonDP_Program()
        {
            Console.WriteLine("--------------------------------------------\n" +
                              "            Non-Observer Program            \n" +
                              "--------------------------------------------");
            Library tarver = new Library(null, NonDPInitBookList);
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
            //While Brad is reading Great Expectations,
            //  he wants to reserve American Gods.
            tarver.HandleBookRequest(brad, "American Gods");
            //Meanwhile, Charlie checks out American Gods.
            tarver.HandleBookRequest(charles, "American Gods");
            //Anna requests American Gods.
            tarver.HandleBookRequest(anna, "American Gods");
            //Even though Brad is on the wait list for American Gods,
            //  Anna receives it when Charlie returns it.
            tarver.CheckInBook(charles);
            //Anna returns American Gods.
            tarver.CheckInBook(anna);
            //Now Brad returns Great Expectations.
            //Then, Brad gets American Gods right away.
            tarver.CheckInBook(brad);

            Console.ReadLine();
            return;
        }

        static void DP_Program()
        {
            Console.WriteLine("--------------------------------------------\n" +
                              "              Observer Program              \n" +
                              "--------------------------------------------");
            Library2 tarver = new Library2(null, DPInitBookList);
            Person2 anna = new Person2("Anna Smith");
            Person2 brad = new Person2("Brad Cooper");
            Person2 charles = new Person2("Charles Brown");
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
            //While Brad is reading Great Expectations,
            //  he wants to reserve American Gods.
            tarver.HandleBookRequest(brad, "American Gods");
            //Meanwhile, Charlie checks out American Gods.
            tarver.HandleBookRequest(charles, "American Gods");
            //Anna requests American Gods.
            tarver.HandleBookRequest(anna, "American Gods");
            //Even though Brad is on the wait list for American Gods,
            //  Anna receives it when Charlie returns it.
            tarver.CheckInBook(charles);
            //Anna returns American Gods.
            tarver.CheckInBook(anna);
            //Now Brad returns Great Expectations.
            //Then, Brad gets American Gods right away.
            tarver.CheckInBook(brad);

            Console.ReadLine();
            return;
        }
    }
}
