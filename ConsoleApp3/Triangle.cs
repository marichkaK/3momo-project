using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Triangle
    {
        public List<ColorSide> triangle { get; private set; }

        public Triangle(ColorSide[] sides)
        {
            try
            {
                Validate(sides);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            triangle = new List<ColorSide>(3);
            for (int i = 0; i < sides.Length; i++)
            {
                triangle.Add(sides[i]);
            }
        }
        private void Validate(ColorSide[] sides)
        {

            if (sides[0].getLength() + sides[1].getLength() <= sides[2].getLength() ||
                sides[1].getLength() + sides[2].getLength() <= sides[0].getLength() ||
                sides[2].getLength() + sides[0].getLength() <= sides[1].getLength())
            {
                throw new ArgumentException("One side of triangle are bigger than two others");
            }
            
        }
        public void print()
        {
            for (int i = 0; i < this.triangle.Count; i++)
            {
                Console.Write(this.triangle[i].getColor().getColor() + " ");
                Console.WriteLine(this.triangle[i].getLength());
            }
        }
        public string GetJsonBlock()
        {
            string jsonBlock = "{";
            for (int i = 1; i < 4; i++)
            {
                jsonBlock += "\"" + i + "sideLength\" : \"" + this.triangle[i - 1].getLength() + "\"," +
                             "\"" + i + "sideColor\" : \"" + this.triangle[i - 1].getColor() + "\",";
            }
            jsonBlock += "},";
            return jsonBlock;
        }
        public double GetPeritemer()
        {
            double perimeter = 0;
            foreach (var el in triangle)
            {
                perimeter += el.getLength();
            }
            return perimeter;
        }
    }
}
