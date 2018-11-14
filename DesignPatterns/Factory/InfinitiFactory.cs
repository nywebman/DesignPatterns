using System;

namespace DesignPatterns.Factory
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class InfinitiFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "G37":
                    return new G37();
                case "Q50":
                    return new Q50();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            }
        }

    }
}
