using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DP
{
    interface ISubjectInterface
    {
        public abstract void RegisterObserver(object observer);
        public abstract void RemoveObserver(object obsrever);
        public abstract void NotifyObservers();
    }
}
