namespace DesignPatterns.Null_Object
{
    public class AutoRepository
    {
        public AutomobileBase Find(string carName)
        {
            if (carName.Contains("mini"))
                return new MiniCooper();
            //HERE is the key part which return singleton null Automobile
            return AutomobileBase.NULL;
        }
    }
}
