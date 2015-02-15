using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    /// <summary>
    /// The Product interface
    /// </summary>
    public interface IFactory
    {
        void Drive(int miles);
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class G37 : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the G37 : " + miles.ToString() + "km");
        }
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Q50 : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Q50 : " + miles.ToString() + "km");
        }
    }

    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);

    }

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

    /// <summary>
    /// Factory Pattern Demo
    /// </summary>
    class Program
    {
        static void Main_(string[] args)
        {
            VehicleFactory factory = new InfinitiFactory();

            IFactory scooter = factory.GetVehicle("G37");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Q50");
            bike.Drive(20);

            Console.ReadKey();

        }
    }
}
