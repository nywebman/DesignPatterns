namespace DesignPatterns.Factory
{
    public class CarFactoryExample : IDesignPatternTemplateMain
    {
        public void Execute()
        {
            VehicleFactory factory = new InfinitiFactory();

            IFactory scooter = factory.GetVehicle("G37");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Q50");
            bike.Drive(20);
        }
    }
}
