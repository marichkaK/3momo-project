using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
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
            Assert.Equal(expected, res);
        }
    }
}
