using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeedUp speedUp = new SpeedUp(55);
            SlowDown slowDown = new SlowDown(45);

            speedUp.ChangeSpeed();
            slowDown.ChangeSpeed();

            CruiseControl
                .InitFactories()
                .ExecuteCreation(Actions.SpeedUp, 55)
                .ChangeSpeed();
        }
    }
}
