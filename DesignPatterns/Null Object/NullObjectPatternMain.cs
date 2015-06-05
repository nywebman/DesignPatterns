using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Null_Object
{
    public class NullObjectPatternMain
    {
        static void Main()
        {
            var autoRepository = new AutoRepository();
            var auto = autoRepository.Find("Mini Cooper");

            auto.Start();
            auto.Stop();
        }
    }

    public class AutoRepository
    {
        public AutomobileBase Find(string carName)
        {
            if (carName.Contains("mini"))
                return new MiniCooper();
            //HERE is the key part which return singleton null Automobile
            return AutomobileBase.NULL;
        }
    }
    public class MiniCooper : AutomobileBase
    {

        internal void Start()
        {
            throw new NotImplementedException();
        }

        internal void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class AutomobileBase
    {
        public abstract Guid Id { get; }
        public abstract string Name { get; }

        public abstract void Start();
        public abstract void Stop();

        #region NULL
        //singleton
        //reason why this is abstract instead of interface so can create implementation of singleton
        static readonly NullAutomobile nullAutomobile = new NullAutomobile(); 

        public static NullAutomobile NULL
        {
            get
            {
                return nullAutomobile;
            }
        }

        public class NullAutomobile : AutomobileBase
        {
            public override Guid Id
            {
                get { return Guid.Empty; }
            }
            public override string Name
            {
                get { return string.Empty; }
            }
            public override void Start() {}
            public override void Stop() {}
        }
        #endregion
    }

}
