using System;

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
            Console.WriteLine($"Decreasing car speed to {_speed} mph");
        }
    }
}
