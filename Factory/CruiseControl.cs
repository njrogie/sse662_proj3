using System;
using System.Collections.Generic;

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
            _factories = new Dictionary<Actions, CruiseControlFactory>
            {
                {Actions.SpeedUp, new SpeedUpFactory() },
                {Actions.SlowDown, new SlowDownFactory() }
            };
        }

        public static CruiseControl InitFactories() => new CruiseControl();

        public ICruiseControl ExecuteCreation(Actions action, double speed)
            => _factories[action].Create(speed);
    }
}
