using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.DP
{
    public abstract class Worker
    {
        public void DoRoutine()
        {
            WakeUp();
            MorningRoutine();
            EatBreakfast();
            GoToWork();
            Work();
            GoHome();
            Relax();
            GoToSleep();
        }

        private void WakeUp()
        {
            Console.WriteLine($"{this} @ 5:00 AM: Good morning!");
        }

        private void MorningRoutine()
        {
            Console.WriteLine($"{this} @ 5:15 AM: Take a shower and brush your teeth.");
        }

        public abstract void EatBreakfast();
        
        public virtual void GoToWork()
        {
            Console.WriteLine($"{this} @ 6:00 AM: Drive to work.");
        }

        public abstract void Work();

        private void GoHome()
        {
            Console.WriteLine($"{this} @ 3:00 PM: Time to come home.");
        }

        public abstract void Relax();

        private void GoToSleep()
        {
            Console.WriteLine($"{this} @ 9:00 PM: Bedtime!");
        }
    }
}
