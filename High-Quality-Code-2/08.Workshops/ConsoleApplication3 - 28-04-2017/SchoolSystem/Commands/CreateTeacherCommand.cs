namespace SchoolSystem.Commands
{
    using Contracts;
    using Core;
    using Enums;
    using Models;
    using System;
    using System.Collections.Generic;

    public class CreateTeacherCommand : ICommand
    {
        private static int id = 0;

        public string Execute(IList<string> parameters)
        {
            Engine.Teachers.Add(id, new Teacher(parameters[0], parameters[1], (Subject)Enum.Parse(typeof(Subject), parameters[2])));

            string message = $"A new teacher with name {parameters[0]} {parameters[1]}, subject {(Subject)Enum.Parse(typeof(Subject), parameters[2])} and ID {id++} was created.";

            return message;
        }
    }
}
