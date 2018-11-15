using System;

namespace DesignPatterns.Factory
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Q50: IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Q50 : " + miles.ToString() + "km");
        }
    }
}
