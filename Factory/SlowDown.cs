using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class SlowDown : ICruiseControl
    {
        private readonly double _speed;

        public SlowDown(double speed)
        {
            _speed = speed;
        }

        public void ChangeSpeed()
        {
            Console.WriteLine($"Increasing car speed to {_speed} mph");
        }
    }
}
