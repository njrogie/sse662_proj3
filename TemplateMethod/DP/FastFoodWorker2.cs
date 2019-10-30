using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.DP
{
    class FastFoodWorker2 : Worker
    {
        public FastFoodWorker2() { }

        public override void EatBreakfast()
        {
            Console.WriteLine($"{this} @ 5:50 AM: Make some yummy oatmeal and out the door.");
        }

        public override void Work()
        {
            Console.WriteLine($"{this} @ 8:00 AM: Would you like fries with that?");
            Console.WriteLine($"{this} @ 12:00 PM: Lunchtime!");
        }

        public override void Relax()
        {
            Console.WriteLine($"{this} @ 3:20 PM: Love to play Smash Bros!");
        }

        public override string ToString()
        {
            return "Fast Food Worker";
        }
    }
}
