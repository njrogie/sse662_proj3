using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.NonDP
{
    class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public bool IsAvailable { get; private set; }

        public Book(string title, string auth, string isbn)
        {
            Title = title;
            Author = auth;
            ISBN = isbn;
            IsAvailable = true;
        }

        public void CheckOut()
        {
            if (IsAvailable)
            {
                Console.WriteLine($"{this} has been checked out.");
                IsAvailable = false;
            }
            else
                throw new Exception($"{Title} was not available to check out.");
        }

        public void CheckIn()
        {
            Console.WriteLine($"{this} has been checked in.");
            IsAvailable = true;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
