using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    /// <summary>
    /// The 'Strategy' abstract class
    /// </summary>
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
