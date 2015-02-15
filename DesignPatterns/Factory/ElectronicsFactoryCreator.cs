using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class ElectronicsFactoryCreator : ElectronicsFactory
    {
        public override IElectronicDevice GetDevice(DeviceTypes device) {
            switch (device)
            {
                case DeviceTypes.Stereo:
                    return new Stereo();
                case DeviceTypes.Television:
                    return new Television();
                case DeviceTypes.Camera:
                    return new Camera();
                default:
                    return null; //should probably be some default
            }
        }
    }

    public enum DeviceTypes
    {
        Stereo,
        Television,
        Camera
    }
}
