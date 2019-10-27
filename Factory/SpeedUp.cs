using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class SpeedUp : ICruiseControl
    {
        private readonly double _speed;

        public SpeedUp(double speed)
        {
            _speed = speed;
        }

        public void ChangeSpeed()
        {
            Console.WriteLine($"Increasing car speed to {_speed} mph");
        }
    }
}
