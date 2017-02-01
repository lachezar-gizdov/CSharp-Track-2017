namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;

    public class Course : ICourse
    {
        private IList<IStudent> students;
        private string courseName;
        private const int MaxStudentsInCourse = 30;

        public Course(string courseName, IList<IStudent> students)
        {
            this.courseName = courseName;
            this.Students = students;
        }

        public IList<IStudent> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if ((value.Count != MaxStudentsInCourse) || !(value.GroupBy(x => x.ID).Any(g => g.Count() > 1)))
                {
                    this.students = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public string Name
        {
            get
            {
                return this.courseName;
            }

            set
            {
                if (value != string.Empty && value != null)
                {
                    this.courseName = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Course Name.");
                }
            }
        }

        public void JoinCourse(IStudent student)
        {
            if (students.Count > MaxStudentsInCourse)
            {
                throw new IndexOutOfRangeException("The Course is full!");
            }
            else if (this.Students.GroupBy(x => x.ID).Any(y => y.Key == student.ID))
            {
                throw new ArgumentException("Student with this ID already exist");
            }

            students.Add(student);
        }

        public void LeaveCourse(IStudent student)
        {
            if (this.Students.Count == 0)
            {
                throw new Exception("No students exist in this course.");
            }
            else if (this.Students.IndexOf(student) == -1)
            {
                throw new Exception("This student does not exist.");
            }

            students.Remove(student);
        }
    }
}
