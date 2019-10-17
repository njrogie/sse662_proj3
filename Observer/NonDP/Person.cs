using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.NonDP
{
    class Person
    {
        public string Name { get; private set; }
        public Book RequestedBook { get; private set; }
        public Book CheckedOutBook { get; private set; }

        public bool HasBook => CheckedOutBook != null;

        public Person(string name)
        {
            Name = name;
        }

        public void RequestBook(Book bk)
        {
            if (!HasBook && bk.IsAvailable)
                CheckOutBook(bk);
            else if (RequestedBook == null)
            {
                Console.WriteLine($"{Name} has requested {bk}.");
                RequestedBook = bk;
            }
            else
                throw new Exception("Person cannot have more than one book requested.");
        }

        private void CheckOutBook(Book bk)
        {
            Console.WriteLine($"{Name} has checked out {bk}.");
            bk.CheckOut();
            CheckedOutBook = bk;
        }

        public void ReturnBook()
        {
            if (!HasBook)
                throw new Exception($"{Name} cannot return this book because they do not have a book!");

            //Else, return the book
            Console.WriteLine($"{Name} has returned {CheckedOutBook}.");
            CheckedOutBook.CheckIn();
            CheckedOutBook = null;
        }

        public void GiveRequestedBook()
        {
            if (HasBook)
                throw new Exception($"{Name} already has a book!");
            if (RequestedBook == null)
                throw new Exception($"{Name} does not have a book requested.");
            //Else, the book is good to go
            Console.WriteLine($"{Name} has gotten their requested book, {RequestedBook}");
            CheckedOutBook = RequestedBook;
            RequestedBook = null;
        }
    }
}
