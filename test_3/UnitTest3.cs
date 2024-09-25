using System.Diagnostics;
using System.Drawing;
using lab_1_3;

namespace test_3
{
    [TestClass]
    public class TestFigure
    {
        [TestMethod]
        public void TestLenghtSide()
        {
            var pA = new lab_1_3.Point(1, 1);
            var pB = new lab_1_3.Point(4, 5);
            var figure = new Figure(pA, pB);

            double lenght = figure.LengthSide(pA, pB);

            Assert.AreEqual(5.0, lenght, "Lenght is incorrect.");
        }

        [TestMethod]
        public void TestTrianglePerimeter()
        {
            var p1 = new lab_1_3.Point(0, 0);
            var p2 = new lab_1_3.Point(4, 0);
            var p3 = new lab_1_3.Point(4, 3);
            var figure = new Figure(p1, p2, p3);

            double perimeter = figure.PerimeterCalculator();

            Assert.AreEqual(12.0, perimeter, "Perimeter is incorrect.");
        }

        [TestMethod]
        public void TestRectanglePerimeter()
        {
            var p1 = new lab_1_3.Point(0, 0);
            var p2 = new lab_1_3.Point(4, 0);
            var p3 = new lab_1_3.Point(4, 3);
            var p4 = new lab_1_3.Point(0, 3);
            var figure = new Figure(p1, p2, p3, p4);

            double perimeter = figure.PerimeterCalculator();

            Assert.AreEqual(14.0, perimeter, "Perimeter is incorrect.");
        }

        [TestMethod]
        public void TestPentagonPerimeter()
        {
            var p1 = new lab_1_3.Point(0, 0);
            var p2 = new lab_1_3.Point(4, 0);
            var p3 = new lab_1_3.Point(4, 3);
            var p4 = new lab_1_3.Point(2, 5);
            var p5 = new lab_1_3.Point(0, 3);
            var figure = new Figure(p1, p2, p3, p4, p5);

            double perimeter = figure.PerimeterCalculator();

            Assert.AreEqual(15.66, perimeter, 0.01, "Perimeter is incorrect.");
        }
    }
}
