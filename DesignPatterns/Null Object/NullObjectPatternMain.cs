namespace DesignPatterns.Null_Object
{
    public class NullObjectPatternMain
    {
        public NullObjectPatternMain()
        {
            var autoRepository = new AutoRepository();
            var auto = autoRepository.Find("Mini Cooper");

            auto.Start();
            auto.Stop();
        }
    }
}
