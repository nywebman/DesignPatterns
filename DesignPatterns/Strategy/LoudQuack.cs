using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
