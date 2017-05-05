namespace SchoolSystem.Commands
{
    using Contracts;
    using Core;
    using System.Collections.Generic;

    public class RemoveStudentCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            Engine.Students.Remove(int.Parse(parameters[0]));

            string message = $"Student with ID {int.Parse(parameters[0])} was sucessfully removed.";

            return message;
        }
    }
}
