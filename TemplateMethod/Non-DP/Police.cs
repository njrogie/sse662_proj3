using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Non_DP
{
    class Police
    {
        public Police() { }

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

        private void EatBreakfast()
        {
            Console.WriteLine($"{this} @ 5:50 AM: Donuts, coffee, and out the door.");
        }

        private void GoToWork()
        {
            Console.WriteLine($"{this} @ 6:00 AM: Drive to work.");
        }

        private void Work()
        {
            Console.WriteLine($"{this} @ 8:00 AM: Sergeant O'Leary is walking the beat.");
            Console.WriteLine($"{this} @ 12:00 PM: Lunchtime!");
        }

        private void GoHome()
        {
            Console.WriteLine($"{this} @ 3:00 PM: Time to come home.");
        }

        private void Relax()
        {
            Console.WriteLine($"{this} @ 3:20 PM: Love to watch Dick van Dyke reruns.");
        }

        private void GoToSleep()
        {
            Console.WriteLine($"{this} @ 9:00 PM: Bedtime!");
        }

        public override string ToString()
        {
            return "Police";
        }
    }
}
