namespace SchoolSystem.Models
{
    using Contracts;
    using Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Student : IStudent
    {
        private const string NoMarks = "This student has no marks.";
        private string firstName;
        private string lastName;
        private Grade grade;
        private List<Mark> marks;

        public Student(string firstName, string lastName, Grade grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
            this.Marks = new List<Mark>();
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

        public List<Mark> Marks
        {
            get
            {
                return this.marks;
            }

            set
            {
                this.marks = value;
            }
        }

        public Grade Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if ((int)value < 1 || (int)value > 12)
                {
                    throw new ArgumentException("Grade cannot be less than 1 or more than 12");
                }

                this.grade = value;
            }
        }

        public string ListMarks()
        {
            var marksTemplate = this.marks.Select(m => $"{m.Subject} => {m.StudentMark}").ToList();

            if (marksTemplate.Count == 0)
            {
                return NoMarks;
            }

            Console.WriteLine("The student has these marks:");

            string marks = string.Join("\n", marksTemplate);
            return marks;
        }
    }
}
