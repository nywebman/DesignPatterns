using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class Duck
    {
        private IQuackBehavior QuackStrategy { get; set; }
        public Duck(IQuackBehavior q)
        {
            QuackStrategy = q;
        }

        public void Quack()
        {
            QuackStrategy.Quack();
        }
    }


}
