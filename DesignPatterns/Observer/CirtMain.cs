using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class CirtMain
    {
        public CirtMain()
        {
            var cirt = new ProductDefectCirt("Rave CF", DateTime.UtcNow);
            cirt.Attach(new CirtNotified("Exec"));
            cirt.Attach(new CirtNotified("CC"));

            cirt.Status = "update";
            cirt.Status = "closed";

            Console.ReadKey();

        }
    }
}
