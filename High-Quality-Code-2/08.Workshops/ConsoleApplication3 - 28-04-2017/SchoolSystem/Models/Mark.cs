namespace SchoolSystem.Models
{
    using SchoolSystem.Enums;
    using System;

    public class Mark
    {
        private Subject subject;
        private float studentMark;

        public Mark(Subject subject, float mark)
        {
            this.Subject = subject;
            this.StudentMark = mark;
        }

        public Subject Subject
        {
            get
            {
                return this.subject;
            }

            set
            {
                this.subject = value;
            }
        }

        public float StudentMark
        {
            get
            {
                return this.studentMark;
            }

            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Invalid Mark");
                }

                this.studentMark = value;
            }
        }
    }
}
