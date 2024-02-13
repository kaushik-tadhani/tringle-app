using NUnit.Framework;
using NUnit.Framework.Legacy;
using TringleApp;

namespace TringleAppTest
{
    [TestFixture]
    public class TriangleTest
    {
        // Kaushik Tadhani
        [Test]
        public void ValidTriangle_Input60and60and60_OutputValidTrinagle()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            string expected = "The triangle is valid.";

            // Act
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }
    }
}
