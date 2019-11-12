using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DP
{
    class Library2
    {
        List<Person2> users;
        List<Book2> bookList;

        public Library2()
        {
            users = new List<Person2>();
            bookList = new List<Book2>();
        }

        public Library2(List<Person2> initUsers, List<Book2> initBooks)
        {
            users = initUsers ?? new List<Person2>();
            bookList = initBooks ?? new List<Book2>();
        }

        public void AddUser(Person2 p)
        {
            users.Add(p);
        }

        public void AddBook(Book2 b)
        {
            bookList.Add(b);
        }

        public bool CheckAvailability(Book2 b)
        {
            return b.IsAvailable;
        }

        public void HandleBookRequest(Person2 p, string bookName) 
        {
            Book2 b = bookList.Find(bk => bk.Title == bookName);
            p.RequestBook(b);
        }

        public void CheckOutBook(Book2 bk)
        {
            bk.CheckOut();
        }

        public void CheckInBook(Person2 p)
        {
            p.ReturnBook();
        }
    }
}
