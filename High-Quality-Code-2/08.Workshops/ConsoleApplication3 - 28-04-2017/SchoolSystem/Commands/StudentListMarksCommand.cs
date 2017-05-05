﻿namespace SchoolSystem.Commands
{
    using Contracts;
    using Core;
    using System.Collections.Generic;

    public class StudentListMarksCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            return Engine.Students[int.Parse(parameters[0])].ListMarks();
        }
    }
}
