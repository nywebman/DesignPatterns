using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Camera : IElectronicDevice
    {
        public bool batteries { get; }
        public Camera()
        {
            batteries = true;
        }
    }
}
