namespace SchoolSystem
{
    using Core;
    using Core.Providers;

    public class Startup
    {
        public static void Main()
        {
            var reader = new ConsoleReader();
            var logger = new ConsoleLogger();

            var service = new BusinessLogicService();

            service.Execute(reader, logger);
        }
    }
}
