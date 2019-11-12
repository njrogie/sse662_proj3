using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.DP
{
    class Police2 : Worker
    {
        public Police2() { }

        public override void EatBreakfast()
        {
            Console.WriteLine($"{this} @ 5:50 AM: Donuts, coffee, and out the door.");
        }

        public override void Work()
        {
            Console.WriteLine($"{this} @ 8:00 AM: Sergeant O'Leary is walking the beat.");
            Console.WriteLine($"{this} @ 12:00 PM: Lunchtime!");
        }

        public override void Relax()
        {
            Console.WriteLine($"{this} @ 3:20 PM: Love to watch Dick van Dyke reruns.");
        }

        public override string ToString()
        {
            return "Police";
        }
    }
}
