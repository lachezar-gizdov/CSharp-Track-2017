namespace SchoolSystem.Models
{
    using Contracts;
    using Enums;
    using System;
    using System.Text.RegularExpressions;

    public class Teacher : ITeacher
    {
        private string firstName;
        private string lastName;
        private Subject subject;

        public Teacher(string firstName, string lastName, Subject subject)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Subject = subject;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                string reg = @"^[A-Za-z]+$";

                if (value.Length < 2 || value.Length > 31 || !Regex.Match(value, reg).Success)
                {
                    throw new ArgumentException("Invalid student First Name");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                string reg = @"^[A-Za-z]+$";

                if (value.Length < 2 || value.Length > 31 || !Regex.Match(value, reg).Success)
                {
                    throw new ArgumentException("Invalid student First Name");
                }

                this.lastName = value;
            }
        }

        public Subject Subject
        {
            get
            {
                return this.subject;
            }

            set
            {
                if (Enum.IsDefined(typeof(Subject), value))
                {
                    this.subject = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Subject");
                }
            }
        }

        public void AddMark(Student student, float mark)
        {
            var currentMark = new Mark(this.subject, mark);
            student.Marks.Add(currentMark);
        }
    }
}