using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;
using System;

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
        [ExpectedException(typeof(ArgumentException))]
        public void validate_BadInputs()
        {
            ColorSide[] tr ={ new ColorSide(new Color("yellow"), 1),
                new ColorSide(new Color("red"), 2),
                new ColorSide(new Color("green"), 0) };
            Triangle triangle = new Triangle(tr);
            triangle.Validate(tr);
        }
    }
}
