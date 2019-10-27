using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class SpeedUpFactory : CruiseControlFactory
    {
        public override ICruiseControl Create(double speed)
            => new SpeedUp(speed);
    }
}
