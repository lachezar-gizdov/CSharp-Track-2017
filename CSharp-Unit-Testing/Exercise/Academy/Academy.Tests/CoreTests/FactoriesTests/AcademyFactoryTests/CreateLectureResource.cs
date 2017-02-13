namespace Academy.Tests.CoreTests.FactoriesTests.AcademyFactoryTests
{
    using Academy.Core.Factories;
    using Academy.Models.Utils.LectureResources;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class CreateLectureResource
    {
        [TestMethod]
        public void ShouldThrowArgumentExceptionWhenPassedTypeIsNull()
        {
            //Arrange
            var sut = AcademyFactory.Instance;

            //Act & Aseert
            Assert.ThrowsException<ArgumentException>(() => sut.CreateLectureResource(null, "valid name", "valid url"));
        }

        [TestMethod]
        public void ShouldThrowArgumentExceptionWhenPassedNameIsNull()
        {
            //Arrange
            var sut = AcademyFactory.Instance;

            //Act & Aseert
            Assert.ThrowsException<ArgumentException>(() => sut.CreateLectureResource("Valid Name", null, "valid url"));
        }

        [TestMethod]
        public void ShouldThrowArgumentExceptionWhenPassedURLIsNull()
        {
            //Arrange
            var sut = AcademyFactory.Instance;

            //Act & Aseert
            Assert.ThrowsException<ArgumentException>(() => sut.CreateLectureResource("Valid Name", "Valid name", null));
        }

        [TestMethod]
        public void ShouldCorrectlyAssignVideoResourseWhenAllDataIsValid()
        {
            //Arrange
            var sut = AcademyFactory.Instance;
            string validName = "Valid Name";
            string validUrl = "Valid Url";

            //Act
            var video = sut.CreateLectureResource("video", validName, validUrl);

            //Arrange
            Assert.IsInstanceOfType(video, typeof(VideoResource));
            Assert.AreEqual(validName, video.Name);
            Assert.AreEqual(validUrl, video.Url);
        }

        [TestMethod]
        public void ShouldCorrectlyAssignPresentationResourseWhenAllDataIsValid()
        {
            //Arrange
            var sut = AcademyFactory.Instance;
            string validName = "Valid Name";
            string validUrl = "Valid Url";

            //Act
            var presentation = sut.CreateLectureResource("presentation", validName, validUrl);

            //Arrange
            Assert.IsInstanceOfType(presentation, typeof(PresentationResource));
            Assert.AreEqual(validName, presentation.Name);
            Assert.AreEqual(validUrl, presentation.Url);
        }

        [TestMethod]
        public void ShouldCorrectlyAssignDemoResourseWhenAllDataIsValid()
        {
            //Arrange
            var sut = AcademyFactory.Instance;
            string validName = "Valid Name";
            string validUrl = "Valid Url";

            //Act
            var demo = sut.CreateLectureResource("demo", validName, validUrl);

            //Arrange
            Assert.IsInstanceOfType(demo, typeof(DemoResource));
            Assert.AreEqual(validName, demo.Name);
            Assert.AreEqual(validUrl, demo.Url);
        }

        [TestMethod]
        public void ShouldCorrectlyAssignHomeworkResourseWhenAllDataIsValid()
        {
            //Arrange
            var sut = AcademyFactory.Instance;
            string validName = "Valid Name";
            string validUrl = "Valid Url";

            //Act
            var homework = sut.CreateLectureResource("homework", validName, validUrl);

            //Arrange
            Assert.IsInstanceOfType(homework, typeof(HomeworkResource));

            Assert.AreEqual(validName, homework.Name);
            Assert.AreEqual(validUrl, homework.Url);
        }
    }
}
