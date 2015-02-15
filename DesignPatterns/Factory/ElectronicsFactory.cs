namespace DesignPatterns.Factory
{
    public abstract class ElectronicsFactory
    {
        public abstract IElectronicDevice GetDevice(DeviceTypes device);
    }
}