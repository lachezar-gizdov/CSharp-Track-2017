namespace SchoolSystem.Commands
{
    using Contracts;
    using Core;
    using System.Collections.Generic;

    public class RemoveTeacherCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            Engine.Teachers.Remove(int.Parse(parameters[0]));

            string message = $"Teacher with ID {int.Parse(parameters[0])} was sucessfully removed.";

            return message;
        }
    }
}
