namespace SchoolSystemTests.Models.Teacher
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem.Enums;
    using SchoolSystem.Models;

    [TestClass]
    public class ConstructorShould
    {
        [TestMethod]
        public void AssignCorrectlyFirstNameValue()
        {
            // Assign & Act
            var sut = new Teacher("fname", "lname", Subject.English);

            // Assert
            Assert.AreEqual("fname", sut.FirstName);
        }

        [TestMethod]
        public void AssignCorrectlyLastNameValue()
        {
            // Assign & Act
            var sut = new Teacher("fname", "lname", Subject.English);

            // Assert
            Assert.AreEqual("lname", sut.LastName);
        }

        [TestMethod]
        public void AssignCorrectlySubjectValue()
        {
            // Assign & Act
            var sut = new Teacher("fname", "lname", Subject.English);

            // Assert
            Assert.AreEqual("English", sut.Subject.ToString());
        }
    }
}
