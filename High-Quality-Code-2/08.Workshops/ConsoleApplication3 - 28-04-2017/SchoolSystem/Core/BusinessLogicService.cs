using SchoolSystem.Contracts;

namespace SchoolSystem.Core
{
    public class BusinessLogicService
    {
        public void Execute(IReader reader, ILogger logger)
        {
            var engine = new Engine(reader, logger);
            engine.Start();
        }
    }
}
