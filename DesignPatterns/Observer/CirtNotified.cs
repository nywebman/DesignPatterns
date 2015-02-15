using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class CirtNotified : ICirtNotified
    {
        private string name;
        private Cirt cirt;

        public CirtNotified(string _name)
        {
            name = _name;
        }

        public void Nofity(Cirt cirt)
        {
            this.cirt = cirt;
            Console.WriteLine("Notified {0} of {1}'s " +
              "change to {2}", name, cirt.Description, cirt.Status);
        }
    }
}
