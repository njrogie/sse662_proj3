using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Non_DP
{
    class Teacher
    {
        public Teacher() { }

        public void DoRoutine()
        {
            WakeUp();
            MorningRoutine();
            EatBreakfast();
            GoToWork();
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
            Console.WriteLine($"{this} @ 5:50 AM: Have a nice English muffin and out the door.");
        }

        private void GoToWork()
        {
            Console.WriteLine($"{this} @ 6:00 AM: Yo, sound the bell, school's in sucka.");
        }

        private void Work()
        {
            Console.WriteLine($"{this} @ 8:00 AM: Reading, Writing, 'Rithmetic.");
            Console.WriteLine($"{this} @ 12:00 PM: Lunchtime!");
        }

        private void GoHome()
        {
            Console.WriteLine($"{this} @ 3:00 PM: ");
        }

        public override string ToString()
        {
            return "Teacher";
        }
    }
}
