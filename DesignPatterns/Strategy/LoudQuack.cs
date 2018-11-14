using System;

namespace DesignPatterns.Strategy
{
    public class LoudQuack : IQuackBehavior
    {
        public LoudQuack()
        {

        }
        public void Quack()
        {
            Console.WriteLine("Load Quack");
        }
    }
}
