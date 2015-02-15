using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public abstract class Cirt
    {
        private string _description;
        private DateTime _start;
        private string _status;
        private List<ICirtNotified> notifyers =new List<ICirtNotified>();

        public string Description { get { return _description; } }
        public DateTime Start { get { return _start; } }
        public string Status {
            get {
                return _status;
            }
            set {
                _status = value;
                Notify();
            }
        }

        public Cirt(string description, DateTime start)
        {
            _start = start;
            _description = description;
            _status = "open";
        }

        public void Attach(ICirtNotified toBeNotified)
        { notifyers.Add(toBeNotified); }

        public void Detach(ICirtNotified toBeNotified)
        { notifyers.Remove(toBeNotified); }

        public void Notify()
        {
            foreach(ICirtNotified notify in notifyers)
            {
                notify.Nofity(this);
            }
            Console.WriteLine("");
        }
    }
}
