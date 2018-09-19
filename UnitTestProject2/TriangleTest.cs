using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;

namespace UnitTestProject2
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void getPerimeter_WithGoodInput()
        {
            ColorSide[] tr ={ new ColorSide(new Color("yellow"), 2),
                new ColorSide(new Color("red"), 2),
                new ColorSide(new Color("green"), 2) };
            Triangle triangle = new Triangle(tr);
            double expected = 6;
            double res = triangle.GetPeritemer();
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void getPerimeter_WithBadInput()
        {
            ColorSide[] tr ={ new ColorSide(new Color("yellow"), 1),
                new ColorSide(new Color("red"), 2),
                new ColorSide(new Color("green"), 0) };
            Triangle triangle = new Triangle(tr);
            double expected = 3;
            double res = triangle.GetPeritemer();
            Assert.AreEqual(expected, res);
        }
    }
}
