using System;

namespace DesignPatterns.Factory
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class G37:IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the G37 : " + miles.ToString() + "km");
        }
    }
}
