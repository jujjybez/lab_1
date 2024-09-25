using System.Diagnostics;
using System.Drawing;
using lab_1_2;

namespace test_2
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void TestArea()
        {
            double sideA = 3.2;
            double sideB = 4.2;
            lab_1_2.Rectangle rec = new lab_1_2.Rectangle(sideA, sideB);

            double area = rec.Area;
            Assert.AreEqual(13.44, area, 0.01, "Area calculation is incorrect.");
        }
        [TestMethod]
        public void TestPerimeter()
        {
            double sideA = 3.2;
            double sideB = 4.2;
            lab_1_2.Rectangle rec = new lab_1_2.Rectangle(sideA, sideB);

            double perimeter = rec.Perimeter;

            Assert.AreEqual(14.8, perimeter, 0.01, "Perimeter calculation is incorrect.");
        }
    }
}
