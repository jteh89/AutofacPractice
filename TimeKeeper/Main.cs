using UIKit;

using Autofac;

// using TimeKeeper.ConsoleWriting;
// using TimeKeeper.DateWriting;
using TimeKeeper.DateRetrieval;

namespace TimeKeeper
{
    public class Application
    {
        public static IContainer Container { get; set; }

        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // Create the container builder
            ContainerBuilder builder = new ContainerBuilder();

            // Only expose the types via their interfaces
            // builder.RegisterType<ConsoleOutput>().As<IOutput>();
            // builder.RegisterType<TodayWriter>().As<IDateWriter>();
            builder.RegisterType<TodayDateRetriever>().As<IDateRetreiver>();

            // Build the container
            Container = builder.Build();

            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
