namespace DesignPatterns.Strategy
{
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    public class StrategyExample : IDesignPatternTemplateMain
    {
        public void Execute()
        {
            //Example 1
            // Two contexts following different strategies
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            //Example 2
            var duck1 = new Duck(new LoudQuack());
            duck1.Quack();

            var duck2 = new Duck(new Squeak());
            duck2.Quack();
        }
    }
}