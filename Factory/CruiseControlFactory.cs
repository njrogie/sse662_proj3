using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class CruiseControlFactory
    {
        public abstract ICruiseControl Create(double speed);
    }
}
