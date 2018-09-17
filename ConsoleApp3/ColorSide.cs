using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class ColorSide :IColor
    {
        private Color color;
        private int length;

        public ColorSide(Color color, int length)
        {
            this.color = color;
            this.length = length;

        }

        public Color getColor()
        {
            return color;
        }

        public int getLength()
        {
            return length;
        }
    }
}
