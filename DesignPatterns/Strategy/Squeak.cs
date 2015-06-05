using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
