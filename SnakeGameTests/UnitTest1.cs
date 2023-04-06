using SnakeGame;

namespace SnakeGameTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Point_ComparePoints_5and5andX_TrueReturned()
        {
            //arrange
            int thisPointLeft = 5;
            int thisPointTop = 5;
            char thisPointSymbol = 'x';

            int pointLeft = 5;
            int pointTop = 5;
            char pointSymbol = '*';

            bool expected = true;
            //act
            Point thisPoint = new Point(thisPointLeft, thisPointTop, thisPointSymbol);
            Point point = new Point(pointLeft, pointTop, pointSymbol);
            bool actual = thisPoint.ComparePoints(point);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}