using GeometryLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void GetCircleArea_PositiveRadius_ReturnsCorrectArea()
        {
            double radius = 5;
            double expectedArea = 78.53981633974483;

            double actualArea = Geometry.GetCircleArea(radius);

            Assert.AreEqual(expectedArea, actualArea);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCircleArea_NegativeRadius_ThrowsArgumentException()
        {

            double radius = -5;

            double actualArea = Geometry.GetCircleArea(radius);
        }


        [TestMethod]
        public void GetTriangleArea_PositiveSides_ReturnsCorrectArea()
        {

            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expectedArea = 6;

            double actualArea = Geometry.GetTriangleArea(side1, side2, side3);


            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetTriangleArea_NegativeSides_ThrowsArgumentException()
        {
            double side1 = -3;
            double side2 = 4;
            double side3 = 5;

            double actualArea = Geometry.GetTriangleArea(side1, side2, side3);
        }

        [TestMethod]
        public void GetArea_Circle_ReturnsCorrectArea()
        {
            double[] sides = new double[] { 5 };
            double expectedArea = 78.53981633974483;

            double actualArea = Geometry.GetArea(sides);


            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void GetArea_Triangle_ReturnsCorrectArea()
        {
            double[] sides = new double[] { 3, 4, 5 };
            double expectedArea = 6;

            double actualArea = Geometry.GetArea(sides);


            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void GetArea_RightAngledTriangle_ReturnsCorrectArea()
        {
            double[] sides = new double[] { 3, 4, 5 };
            double expectedArea = 6;

            double actualArea = Geometry.GetArea(sides);


            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetArea_InvalidNumberOfSides_ThrowsArgumentException()
        {
            double[] sides = new double[] { 3, 4 };

            double actualArea = Geometry.GetArea(sides);
        }
    }
}