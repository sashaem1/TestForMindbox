namespace CulcLib.Tests
{
    public class Tests
    {
        [Test]
        public void TestBigCircle()
        {
            Circle circle = new Circle(12);
            double expected = 452.4;

            //act
            double result = circle.CalcSquare();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestSmallCircle()
        {
            Circle circle = new Circle(4.5);
            double expected = 63.6;

            //act
            double result = circle.CalcSquare();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestCirclWithNegativeRadius()
        {
            Circle circle;
            Assert.Catch(() => circle = new Circle(-2));
        }

        [Test]
        public void TestTriangleWithIncorrectSides()
        {
            Triangle triangle;
            Assert.Catch(() => triangle = new Triangle(20, 5, 3));
        }

        [Test]
        public void TestTriangleWithNegativeSide()
        {
            Triangle triangle;
            Assert.Catch(() => triangle = new Triangle(-4, 5, 3));
        }

        [Test]
        public void TestNormalTriangle()
        {
            Triangle triangle = new Triangle(4, 4, 5);
            double expected = 7.8;

            //act
            double result = triangle.CalcSquare();
            Assert.AreEqual(expected, result);
        }

    }
}