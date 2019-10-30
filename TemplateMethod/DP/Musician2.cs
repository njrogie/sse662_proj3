using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.DP
{
    class Musician2 : Worker
    {
        public Musician2() { }

        public override void EatBreakfast()
        {
            Console.WriteLine($"{this} @ 5:50 AM: Cold brew coffee and out the door.");
        }

        public override void Work()
        {
            Console.WriteLine($"{this} @ 8:00 AM: Practice, practice, practice.");
            Console.WriteLine($"{this} @ 12:00 PM: Lunchtime!");
        }

        public override void Relax()
        {
            Console.WriteLine($"{this} @ 3:20 PM: Practice, practice, practice.");
        }

        public override string ToString()
        {
            return "Musician";
        }
    }
}
