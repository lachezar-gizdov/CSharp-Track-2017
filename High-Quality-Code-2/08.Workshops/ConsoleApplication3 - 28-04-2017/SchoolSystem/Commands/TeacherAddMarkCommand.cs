namespace SchoolSystem.Commands
{
    using Contracts;
    using Core;
    using System.Collections.Generic;

    public class TeacherAddMarkCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            var teecherid = int.Parse(parameters[0]);
            var studentid = int.Parse(parameters[1]);

            // Please work 
            var student = Engine.Students[studentid];
            var teacher = Engine.Teachers[teecherid];
            teacher.AddMark(student, float.Parse(parameters[2]));

            string message = $"Teacher {teacher.FirstName} {teacher.LastName} added mark {float.Parse(parameters[2])} to student {student.FirstName} {student.LastName} in {teacher.Subject}.";

            return message;
        }
    }
}
