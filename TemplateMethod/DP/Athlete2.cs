using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.DP
{
    class Athlete2 : Worker
    {
        public Athlete2() { }

        public override void EatBreakfast()
        {
            Console.WriteLine($"{this} @ 5:50 AM: Cook some pancakes and out the door.");
        }

        public override void Work()
        {
            Console.WriteLine($"{this} @ 8:00 AM: Hey now, you're an all-star.");
            Console.WriteLine($"{this} @ 12:00 PM: Lunchtime!");
        }

        public override void Relax()
        {
            Console.WriteLine($"{this} @ 3:20 PM: Watch the recording of the game.");
        }

        public override string ToString()
        {
            return "Athlete";
        }
    }
}
