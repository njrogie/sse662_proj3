using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.DP
{
    class Teacher2 : Worker
    {
        public Teacher2() { }

        public override void EatBreakfast()
        {
            Console.WriteLine($"{this} @ 5:50 AM: Have a nice English muffin and out the door.");
        }

        public override void GoToWork()
        {
            Console.WriteLine($"{this} @ 6:00 AM: Yo, sound the bell, school's in sucka.");
        }

        public override void Work()
        {
            Console.WriteLine($"{this} @ 8:00 AM: Reading, Writing, 'Rithmetic.");
            Console.WriteLine($"{this} @ 12:00 PM: Lunchtime!");
        }

        public override void Relax()
        {
            Console.WriteLine($"{this} @ 3:20 PM: No time to relax, gotta grade papers!");
        }

        public override string ToString()
        {
            return "Teacher";
        }
    }
}
