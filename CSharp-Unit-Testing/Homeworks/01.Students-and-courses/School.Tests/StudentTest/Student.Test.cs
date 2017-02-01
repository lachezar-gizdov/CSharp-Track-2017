namespace School.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using Contracts;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void ThrowErrorIfStudentNameIsEmpty()
        {
            Student student = new Student("Go6o", 30000);

            Assert.ThrowsException<ArgumentException>(() => student.Name = "");
        }

        [TestMethod]
        public void ThrowErrorIfStudentNameIsNull()
        {
            Student student = new Student("Go6o", 30000);

            Assert.ThrowsException<ArgumentException>(() => student.Name = null);
        }

        [TestMethod]
        public void ThrowErrorIfStudentIDIsNotUnique()
        {
            Student student = new Student("Pesho", 40000);

            Assert.ThrowsException<ArgumentException>(() => student.ID = 40000);
        }

        [TestMethod]
        public void CheckIfStudentNameisSetProperly()
        {
            string studentName = "Stamat";
            Student student = new Student(studentName, 30000);

            Assert.AreEqual(studentName, student.Name);
        }

        [TestMethod]
        public void CheckIfStudentIDIsLessThanSpecified()
        {
            Student student = new Student("Stamat", 30001);

            Assert.ThrowsException<IndexOutOfRangeException>(() => student.ID = 15);
        }

        [TestMethod]
        public void CheckIfStudentIDIsMoreThanSpecified()
        {
            Student student = new Student("Stamat", 30005);

            Assert.ThrowsException<IndexOutOfRangeException>(() => student.ID = 9999999);
        }
    }
}