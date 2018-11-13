using System;

namespace DesignPatterns.Null_Object
{
    public abstract class AutomobileBase
    {
        public abstract Guid Id { get; }
        public abstract string Name { get; }

        public abstract void Start();
        public abstract void Stop();

        #region NULL
        //singleton
        //reason why this is abstract instead of interface so can create implementation of singleton

        public static NullAutomobile NULL { get; } = new NullAutomobile();

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
            public override void Start() { }
            public override void Stop() { }
        }
        #endregion
    }
}
