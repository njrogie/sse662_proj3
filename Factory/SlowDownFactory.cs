using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class SlowDownFactory : CruiseControlFactory
    {
        public override ICruiseControl Create(double speed)
            => new SlowDown(speed);
    }
}
