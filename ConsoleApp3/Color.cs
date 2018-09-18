using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    /// <summary>
    /// Represents the class for color.
    /// </summary>
    class Color
    {
        public String color { get; set; }

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="color">Name of color</param>
        public Color(String color)
        {
            this.color = color;
        }

        /// <summary>
        /// Returns the name of color.
        /// </summary>
        /// <returns>Color</returns>
        public String getColor()
        {
            return color;
        }
    }
}
