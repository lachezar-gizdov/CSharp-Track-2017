namespace SchoolSystem.Core
{
    using Contracts;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class Engine
    {
        private IReader reader;
        private ILogger logger;

        public Engine(IReader reader, ILogger logger)
        {
            if (reader == null)
            {
                throw new NullReferenceException("Reader cannot be null");
            }

            if (logger == null)
            {
                throw new NullReferenceException("Logger cannot be null");
            }

            this.reader = reader;
            this.logger = logger;
        }

        internal static Dictionary<int, Teacher> Teachers { get; set; } = new Dictionary<int, Teacher>();

        internal static Dictionary<int, Student> Students { get; set; } = new Dictionary<int, Student>();

        public void Start()
        {
            while (true)
            {
                try
                {
                    var command = reader.Read();

                    if (command == "End" || command == "end")
                    {
                        break;
                    }

                    var currentCommand = command.Split(' ')[0];
                    var assembli = GetType().GetTypeInfo().Assembly;
                    var foundCommand = assembli.DefinedTypes
                        .Where(type => type.ImplementedInterfaces.Any(inter => inter == typeof(ICommand)))
                        .Where(type => type.Name.ToLower().Contains(currentCommand.ToLower()))
                        .FirstOrDefault();

                    if (foundCommand == null)
                    {
                        throw new ArgumentException("The passed command is not found!");
                    }

                    var aadesh = Activator.CreateInstance(foundCommand) as ICommand;
                    var parameters = command.Split(' ').ToList();
                    parameters.RemoveAt(0);
                    this.logger.Log(aadesh.Execute(parameters));
                }
                catch (Exception ex)
                {
                    this.logger.Log(ex.Message);
                }
            }
        }
    }
}
