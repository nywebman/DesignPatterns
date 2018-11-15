using System;

namespace DesignPatterns
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class PatternMetadataAttribute : Attribute
    {
        public readonly string PatternName;
        public readonly string PatternCategory;
        public PatternMetadataAttribute(string _PatternName, string _PatternCategory)
        {
            PatternName = _PatternName;
            PatternCategory = _PatternCategory;
        }

        public static void PrintPatternInfo<T>()
        {
            var customAttributes = GetCustomAttributes(typeof(T));
            if (customAttributes != null)
            {
                var patternAttribute = (PatternMetadataAttribute)customAttributes[0];
                Console.WriteLine($"Design Pattern Name: {patternAttribute.PatternName}.");
                Console.WriteLine($"Design Pattern Category: {patternAttribute.PatternCategory}.");
            }
            Console.WriteLine("Pattern Metadata not defined");
        }
    }
}
