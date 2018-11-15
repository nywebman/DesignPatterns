using System;
using Autofac;
using DesignPatterns.Factory;
using DesignPatterns.IOC;
using DesignPatterns.Null_Object;
using DesignPatterns.Observer;
using DesignPatterns.Repository;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    public class Program
    {
        private static IContainer Container { get; set; }
        private static IDesignPatternTemplateMain DesignPatternMain { get; set; }
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDateWriter>();
            builder.RegisterType<StrategyExample>().As<IDesignPatternTemplateMain>();

            Container = builder.Build();

            // The WriteDate method is where we'll make use
            // of our dependency injection. We'll define that
            // in a bit.
            WriteDate();

            DesignPatternMain = Container.Resolve<IDesignPatternTemplateMain>();
            DesignPatternMain.Execute();
            var a=
            Console.Read();
        }

        private static void WriteDate()
        {
            // Create the scope, resolve your IDateWriter,
            // use it, then dispose of the scope.
            using (var scope = Container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IDateWriter>();
                writer.WriteDate();
            }
        }
    }
}
