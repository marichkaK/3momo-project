using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    /// <summary>
    /// Represents class of colorside.
    /// </summary>
    public class ColorSide :IColor
    {
        private Color color;
        private int length;

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="color">Name of color</param>
        /// <param name="length">Lenght</param>
        public ColorSide(Color color, int length)
        {
            this.color = color;
            this.length = length;

        }

        /// <summary>
        /// Returns the name of color.
        /// </summary>
        /// <returns>Color</returns>
        public Color getColor()
        {
            return color;
        }

        /// <summary>
        /// Returns lenght.
        /// </summary>
        /// <returns>Lenght</returns>
        public int getLength()
        {
            return length;
        }
    }
}
