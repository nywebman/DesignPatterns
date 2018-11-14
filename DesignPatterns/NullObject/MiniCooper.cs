using System;

namespace DesignPatterns.Null_Object
{
    public class MiniCooper : AutomobileBase
    {
        public override Guid Id => Guid.NewGuid();

        public override string Name => "My mini";

        public override void Start()
        {
            Console.WriteLine("Mini Cooper start");
        }

        public override void Stop()
        {
            Console.WriteLine("Mini Cooper stop");
        }
    }
}
