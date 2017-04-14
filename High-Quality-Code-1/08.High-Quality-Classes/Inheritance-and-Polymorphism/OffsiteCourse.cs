namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using Abstracts;
    using Contracts;

    public class OffsiteCourse : Course, ICourse
    {
        private string town;

        public OffsiteCourse(string courseName)
            : base(courseName)
        {
        }

        public OffsiteCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Town = null;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                this.town = value;
            }
        }

        public override string ToString()
        {
            string result = base.ToString();

            if (this.Town != null)
            {
                result += string.Format("; Town = {0}", this.Town) + " }";
            }
            else
            {
                result += " }";
            }

            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}