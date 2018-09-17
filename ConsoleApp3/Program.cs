using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp3
{
    class Program
    {
        static List<Triangle> RePaintTriagles(List<Triangle> _triangles)
        {
            List<Triangle> triangles = _triangles.Where(x => x.triangle[0].getColor().getColor() == x.triangle[1].getColor().getColor() && x.triangle[0].getColor().getColor() != x.triangle[2].getColor().getColor() ||
                                                             x.triangle[0].getColor().getColor() == x.triangle[2].getColor().getColor() && x.triangle[0].getColor().getColor() != x.triangle[1].getColor().getColor() ||
                                                             x.triangle[1].getColor().getColor() == x.triangle[2].getColor().getColor() && x.triangle[1].getColor().getColor() != x.triangle[0].getColor().getColor()).ToList();
            foreach (var x in triangles)
            {
                if (x.triangle[0].getColor().getColor() == x.triangle[1].getColor().getColor())
                {
                    x.triangle[2].getColor().color = x.triangle[0].getColor().getColor();
                }
                else if (x.triangle[0].getColor().getColor() == x.triangle[2].getColor().getColor())
                {
                    x.triangle[1].getColor().color = x.triangle[0].getColor().getColor();
                }
                else
                {
                    x.triangle[0].getColor().color = x.triangle[1].getColor().getColor();
                }
            }
            return triangles;
        }
        static void Main(string[] args)
        {
         
            
           
          
            Console.Read();

        }
    }
}
