namespace DesignPatterns.Null_Object
{
    public class NullObjectPatternMain: IDesignPatternTemplateMain
    {
        public void Execute()
        {
            var autoRepository = new AutoRepository();
            var auto = autoRepository.Find("Mini Cooper");

            auto.Start();
            auto.Stop();

            auto = autoRepository.Find("mini");

            auto.Start();
            auto.Stop();
        }
    }
}
