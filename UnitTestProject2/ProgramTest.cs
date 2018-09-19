using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ConsoleApp3;
using System.IO;

namespace UnitTestProject2
{
    [TestClass]
    public  class ProgramTest
    {
        [TestMethod]
        public void readDate_FromFile()
        {
            Triangle tr = new Triangle(new ColorSide[] { new ColorSide(new Color("yellow"), 1 ),
                new ColorSide(new Color("red"), 2),
                new ColorSide(new Color("yellow"), 1) });
            List<Triangle> l = new List<Triangle>();
            l.Add(tr);
            string pathToTrianglesFile = "C:\\Users\\mkunyk\\source\\repos\\ConsoleApp3\\ConsoleApp3\\Triangles.txt";
            List<Triangle> list = Program.ReadData(pathToTrianglesFile);
            Assert.AreNotEqual(l.LastIndexOf(tr), list.LastIndexOf(list[3]));
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void readDate_FromFileThatDoesntExist()
        { 
            string pathToTrianglesFile = "C:\\Users\\mkunyk\\source\\repos\\ConsoleApp3\\ConsoleApp3\\Triangl2es.txt";
            List<Triangle> list = Program.ReadData(pathToTrianglesFile);
        }

        [TestMethod]
        public void sortByPerimeter_WithGoodInputs()
        {
            Triangle tr = new Triangle(new ColorSide[] { new ColorSide(new Color("yellow"), 1 ),
                new ColorSide(new Color("red"), 2),
                new ColorSide(new Color("yellow"), 1) });
        
            Triangle tr1 = new Triangle(new ColorSide[] { new ColorSide(new Color("yellow"), 3 ),
                new ColorSide(new Color("red"), 2),
                new ColorSide(new Color("yellow"), 3) });
            
            Triangle tr2 = new Triangle(new ColorSide[] { new ColorSide(new Color("yellow"), 2 ),
                new ColorSide(new Color("red"), 2),
                new ColorSide(new Color("yellow"), 1) });
            List<Triangle> l = new List<Triangle>();
            l.Add(tr);
            l.Add(tr1);
            l.Add(tr2);
           List<Triangle> sortedTr = Program.SortByPerimeter(l);
            Assert.AreEqual(l[0].GetPeritemer(), sortedTr[0].GetPeritemer());
        }

    }
}
