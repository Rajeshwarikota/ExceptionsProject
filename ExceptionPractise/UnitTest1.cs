using ExceptionProject;

namespace ExceptionPractise
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        // testing children category 
        public void TestchildrenCategory()
        {
            // Arrange
            int age = 14;
            string expectedCategory = "Children";

            // Act
            string actualCategory = PersonCategory.CategorizeAge(age);

            // Assert
            Assert.AreEqual(expectedCategory, actualCategory);
        }
        [TestMethod]
        // testing Adults category 
        public void TestAdultCategory()
        {
            // Arrange
            int age = 40;
            string expectedCategory = "Adults";

            // Act
            string actualCategory = PersonCategory.CategorizeAge(age);

            // Assert
            Assert.AreEqual(expectedCategory, actualCategory);
        }
        [TestMethod]
        // testing youth category 
        public void TestyouthCategory()
        {
            // Arrange
            int age = 20;
            string expectedCategory = "Youth";

            // Act
            string actualCategory = PersonCategory.CategorizeAge(age);

            // Assert
            Assert.AreEqual(expectedCategory, actualCategory);
        }
        [TestMethod]
        // testing seniors category 
        public void TestseniorCategory()
        {
            // Arrange
            int age = 70;
            string expectedCategory = "Seniors";

            // Act
            string actualCategory = PersonCategory.CategorizeAge(age);

            // Assert
            Assert.AreEqual(expectedCategory, actualCategory);
        }
    }
}