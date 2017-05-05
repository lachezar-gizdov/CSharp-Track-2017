namespace SchoolSystemTests.Models.Teacher
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem.Enums;
    using SchoolSystem.Models;
    using System;

    [TestClass]
    public class Property
    {
        [TestMethod]
        public void FirstNameShouldThrowWhenShortNameIsPassed()
        {
            // Assign
            string fname = "a";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Teacher(fname, "lname", Subject.English));
        }

        [TestMethod]
        public void FirstNameShouldThrowWhenLongerNameIsPassed()
        {
            // Assign
            string fname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Teacher(fname, "lname", Subject.English));
        }

        [TestMethod]
        public void LastNameShouldThrowWhenShortNameIsPassed()
        {
            // Assign
            string lname = "a";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Teacher("fname", lname, Subject.English));
        }

        [TestMethod]
        public void LastNameShouldThrowWhenLongerNameIsPassed()
        {
            // Assign
            string lname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Teacher("fname", lname, Subject.English));
        }

        [TestMethod]
        public void SubjectShouldThrowWhenPassedValueIsInvalid()
        {
            // Assign
            int grade = 4;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Teacher("fname", "lname", (Subject)grade));

        }
    }
}
