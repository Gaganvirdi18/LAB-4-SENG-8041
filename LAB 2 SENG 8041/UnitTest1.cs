

using NUnit.Framework;
    namespace NUnitDemonstration.Tests
    {
        [TestFixture]
        public class TriangleTests
        {
            [Test]
            public void ValidTriangle_ValidInput_ReturnsValidMessage()
            {
                // Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;
                // Act
                string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
                // Assert
                Assert.AreEqual("The triangle is valid.", result);
            }
        [Test]
        public void ValidTriangle_ValidIsoscelesTriangle_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 45;
            int secondAngle = 45;
            int thirdAngle = 90;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        [Test]
        public void ValidTriangle_ValidScaleneTriangle_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 30;
            int secondAngle = 60;
            int thirdAngle = 90;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        [Test]
        public void ValidTriangle__ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 0;
            int secondAngle = 90;
            int thirdAngle = 90;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        [Test]
        public void ValidTriangle_InvalidNegativeAngles_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = -4;
            int secondAngle = 90;
            int thirdAngle = 135;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        [Test]
        public void ValidTriangle_InvalidSumOfAngles_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 90;
            int secondAngle = 90;
            int thirdAngle = 90;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        [Test]
        public void ValidTriangle_InvalidLargeAngles_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 120;
            int secondAngle = 60;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        [Test]
        public void ValidTriangle_InvalidNonTriangle_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 90;
            int secondAngle = 90;
            int thirdAngle = 0;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 90;
            int secondAngle = 90;
            int thirdAngle = 1; // Invalid, the sum is not 180
                                // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result); // This assertion will fail

        }

        [Test]
        public void ValidTriangle_addonenumber_failedcase()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 61; // Invalid, the sum is not 180
                                 // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result); // This assertion will fail
        }

    }
}
