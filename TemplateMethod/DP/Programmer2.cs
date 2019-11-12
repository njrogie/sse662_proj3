using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.DP
{
    class Programmer2 : Worker
    {
        public Programmer2() { }

        public override void EatBreakfast()
        {
            Console.WriteLine($"{this} @ 5:50 AM: Make some scrambled eggs and out the door.");
        }

        public override void Work()
        {
            Console.WriteLine($"{this} @ 8:00 AM: Code, code, code.");
            Console.WriteLine($"{this} @ 12:00 PM: Lunchtime!");
        }

        public override void Relax()
        {
            Console.WriteLine($"{this} @ 3:20 PM: Call of Duty time.");
        }

        public override string ToString()
        {
            return "Programmer";
        }
    }
}
