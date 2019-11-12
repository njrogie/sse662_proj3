using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DP
{
    class Person2 : IObserverInterface
    {
        public string Name { get; private set; }
        public int ID { get; private set; }
        private static int nextID = 1;
        public Book2 RequestedBook { get; private set; }
        public Book2 CheckedOutBook { get; private set; }

        public bool HasBook => CheckedOutBook != null;

        public Person2(string name)
        {
            Name = name;
            ID = nextID;
            nextID++;
        }

        public void Update()
        {
            GiveRequestedBook();
        }

        public void RequestBook(Book2 bk)
        {
            if (!HasBook && bk.IsAvailable)
                CheckOutBook(bk);
            else if (RequestedBook == null)
            {
                Console.WriteLine($"{Name} has requested {bk}.");
                bk.RegisterObserver(this);
                RequestedBook = bk;
            }
            else
                throw new Exception("Person cannot have more than one book requested.");
        }

        private void CheckOutBook(Book2 bk)
        {
            Console.WriteLine($"{this} has checked out {bk}.");
            bk.CheckOut();
            CheckedOutBook = bk;
        }

        public void ReturnBook()
        {
            if (!HasBook)
                throw new Exception($"{this} cannot return this book because they do not have a book!");

            //Else, return the book
            Console.WriteLine($"{this} has returned {CheckedOutBook}.");
            CheckedOutBook.CheckIn();
            CheckedOutBook = null;
            if (RequestedBook != null)
                GiveRequestedBook();
        }

        public void GiveRequestedBook()
        {
            if (HasBook)
                throw new Exception($"{this} already has a book!");
            if (RequestedBook == null)
                throw new Exception($"{this} does not have a book requested.");
            //Else, the book is good to go
            Console.WriteLine($"{this} has gotten their requested book, {RequestedBook}.");
            CheckedOutBook = RequestedBook;
            RequestedBook = null;
        }

        public override bool Equals(object obj)
        {
            Person2 p = obj as Person2;
            return !(p == null || p.ID != this.ID);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
