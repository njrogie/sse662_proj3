using Observer.DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DP
{
    class Book2 : ISubjectInterface
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public bool IsAvailable { get; private set; }
        private Queue<Person2> WaitList { get; set; }

        public Book2(string title, string auth, string isbn)
        {
            Title = title;
            Author = auth;
            ISBN = isbn;
            IsAvailable = true;
            WaitList = new Queue<Person2>();
        }

        public void RegisterObserver(object person)
        {
            WaitList.Enqueue(person as Person2);
        }

        public void RemoveObserver(object person)
        {
            Queue<Person2> temp = new Queue<Person2>();
            Person2 p = person as Person2;
            while(WaitList.Count > 0 && p != null)
            {
                Person2 next = WaitList.Dequeue();
                if (next.Equals(p))
                    break;
                else
                    temp.Enqueue(p);
            }

            if (temp.Count > 0)
            {
                while (WaitList.Count > 0)
                    temp.Enqueue(WaitList.Dequeue());
                WaitList = temp;
            }
        }

        public void NotifyObservers()
        {
            if (WaitList.Count > 0)
            {
                Queue<Person2> temp = new Queue<Person2>();
                while(WaitList.Count > 0)
                {
                    Person2 nextInLine = WaitList.Dequeue();
                    if (!nextInLine.HasBook)
                    {
                        nextInLine.Update();
                        RemoveObserver(nextInLine);
                        break;
                    }
                    else
                        temp.Enqueue(nextInLine);
                }

                if(temp.Count > 0)
                {
                    while(WaitList.Count > 0)
                        temp.Enqueue(WaitList.Dequeue());
                    WaitList = temp;
                }
            }
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
            NotifyObservers();
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
