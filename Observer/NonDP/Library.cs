using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.NonDP
{
    class Library
    {
        List<Person> users;
        List<Book> bookList;

        public Library()
        {
            users = new List<Person>();
            bookList = new List<Book>();
        }

        public Library(List<Person> initUsers, List<Book> initBooks)
        {
            users = initUsers ?? new List<Person>();
            bookList = initBooks ?? new List<Book>();
        }

        public void AddUser(Person p)
        {
            users.Add(p);
        }

        public void AddBook(Book b)
        {
            bookList.Add(b);
        }

        public bool CheckAvailability(Book b)
        {
            return b.IsAvailable;
        }

        public void HandleBookRequest(Person p, string bookName) 
        {
            Book b = bookList.Find(bk => bk.Title == bookName);
            p.RequestBook(b);
        }

        public void CheckOutBook(Book bk)
        {
            bk.CheckOut();
        }

        public void CheckInBook(Person p)
        {
            p.ReturnBook();
            BookListChanged();
        }

        /// <summary>
        /// When a book becomes available,
        /// check to see if any user has that book requested.
        /// If so, give them their requested book.
        /// </summary>
        private void BookListChanged()
        {
            foreach(Book b in bookList.Where(bk => bk.IsAvailable).ToList())
            {
                foreach(Person p in users.Where(per => !per.HasBook && per.RequestedBook != null).ToList())
                {
                    if(b.Title == p.RequestedBook.Title)
                        p.GiveRequestedBook();
                }
            }
        }
    }
}
