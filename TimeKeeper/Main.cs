using UIKit;

using Autofac;

using TimeKeeper.ConsoleWriting;
using TimeKeeper.DateWriting;

namespace TimeKeeper
{
    public class Application
    {
        public static IContainer container { get; set; }

        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // Create the container builder
            ContainerBuilder builder = new ContainerBuilder();

            // Only expose the types via their interfaces
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDateWriter>();

            // Build the container
            container = builder.Build();

            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
