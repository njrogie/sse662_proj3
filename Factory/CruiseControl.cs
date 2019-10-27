using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public enum Actions
    {
        SpeedUp,
        SlowDown
    }

    public class CruiseControl
    {
        private readonly Dictionary<Actions, CruiseControlFactory> _factories;

        private CruiseControl()
        {
            _factories = new Dictionary<Actions, CruiseControlFactory>();

            foreach (Actions action in Enum.GetValues(typeof(Actions)))
            {
                var factory = (CruiseControlFactory)Activator.CreateInstance(
                    Type.GetType("FactoryMethod." + Enum.GetName(
                        typeof(Actions), action) + "Factory"
                        )
                    );
                _factories.Add(action, factory);
            }
        }

        public static CruiseControl InitFactories() => new CruiseControl();

        public ICruiseControl ExecuteCreation(Actions action, double speed)
            => _factories[action].Create(speed);
    }
}
