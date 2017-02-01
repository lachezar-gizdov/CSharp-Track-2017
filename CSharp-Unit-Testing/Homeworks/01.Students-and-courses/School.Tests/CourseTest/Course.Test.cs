namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using Contracts;
    using School;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void ThrowErrorIfCourseNameIsEmpty()
        {
            IList<IStudent> students = new List<IStudent>();
            Course course = new Course("Math", students);

            Assert.ThrowsException<ArgumentException>(() => course.Name = "");
        }

        [TestMethod]
        public void ThrowErrorIfCourseNameIsNull()
        {
            IList<IStudent> students = new List<IStudent>();
            Course course = new Course("Math", students);

            Assert.ThrowsException<ArgumentException>(() => course.Name = null);
        }

        [TestMethod]
        public void CheckIfCourseNameisSetProperly()
        {
            string courseName = "Math";
            IList<IStudent> students = new List<IStudent>();
            Course course = new Course(courseName, students);

            Assert.AreEqual(courseName, course.Name);
        }

        [TestMethod]
        public void CheckifCourseCanTakeOnlyASetNumberOfStudents()
        {
            IList<IStudent> students = new List<IStudent>();
            const int maxNumberOfStudents = 30;

            for (int i = 1; i <= 31; i++)
            {
                students.Add(new Student("test", 10000 + i));
            }
            Course course = new Course("Math", students);

            Assert.IsTrue(students.Count > maxNumberOfStudents);
        }

        [TestMethod]
        public void CheckIfStudentWithTheSameIDCanBeAdded()
        {
            IList<IStudent> students = new List<IStudent>();
            Student go6o = new Student("go6o", 10005);
            Student pesho = new Student("pesho", 10005);

            students.Add(go6o);
            students.Add(pesho);

            Assert.ThrowsException<ArgumentException>(() => new Course("Math", students));
        }
    }
}
