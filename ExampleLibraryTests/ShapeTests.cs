using ExampleLibrary;

namespace ExampleLibraryTests
{
    public class ShapeTests
    {
        [Test]
        public void TestCircleArea()
        {
            var circle = new Circle(5);
            var expectedArea = Math.PI * 25;

            var actualArea = circle.CalculateArea();

            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.001));
        }

        [TestCase(13, 14, 15, 84)]
        [TestCase(5, 5, 6, 12)]
        [TestCase(3, 4, 5, 6)]
        public void TestTriangleArea(double sideAb, double sideBc, double sideCa, double expectedArea)
        {
            var triangle = new Triangle(sideAb, sideBc, sideCa);

            var actualArea = triangle.CalculateArea();


            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(.001));
        }

        [Test]
        public void TestRightAngledTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            var isRight = triangle.IsRightAngled();

            Assert.IsTrue(isRight);
        }

        [Test]
        public void TestNotRightAngledTriangle()
        {
            var triangle = new Triangle(2, 3, 4);

            var isRight = triangle.IsRightAngled();

            Assert.IsFalse(isRight);
        }

        [Test]
        public void TestTriangleExistence_InvalidSides_ThrowsArgumentException()
        {
            var sideA = 1;
            var sideB = 2;
            var sideC = 3;

            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(sideA, sideB, sideC);
            });
        }

        [Test]
        public void TestTriangleCreation_NegativeSides_ThrowsArgumentException()
        {
            var sideA = -1;
            var sideB = 2;
            var sideC = 3;

            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(sideA, sideB, sideC);
            });
        }

        [Test]
        public void TestCircleCreation_NegativeRadius_ThrowsArgumentException()
        {
            var radius = -1;

            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Circle(radius);
            });
        }
    }
}