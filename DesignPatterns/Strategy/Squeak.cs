using System;

namespace DesignPatterns.Strategy
{
    public class Squeak : IQuackBehavior
    {
        public Squeak()
        {

        }
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
