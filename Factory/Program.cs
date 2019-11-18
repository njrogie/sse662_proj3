using System;
using System.Collections.Generic;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Without using the Factory Design Pattern
            SpeedUp speedUp = new SpeedUp(55);      
            SlowDown slowDown = new SlowDown(45);

            speedUp.ChangeSpeed();
            slowDown.ChangeSpeed();
            Console.WriteLine("\n" + "Below is the Factory Pattern Implementation"
                + "\n");

            //Using the Factory Design Pattern
            CruiseControl
                .InitFactories()
                .ExecuteCreation(Actions.SpeedUp, 55)
                .ChangeSpeed();
        }
    }
}
