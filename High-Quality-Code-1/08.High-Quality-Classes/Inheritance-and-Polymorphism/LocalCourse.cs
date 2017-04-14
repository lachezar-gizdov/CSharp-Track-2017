namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using Abstracts;
    using Contracts;

    public class LocalCourse : Course, ICourse
    {
        private string lab;

        public LocalCourse(string courseName)
            : base(courseName)
        {
        }

        public LocalCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Lab = null;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                this.lab = value;
            }
        }

        public override string ToString()
        {
            string result = base.ToString();

            if (this.Lab != null)
            {
                result += string.Format("; Lab = {0}", this.Lab) + " }";
            }
            else
            {
                result += " }";
            }

            return result;
        }
    }
}