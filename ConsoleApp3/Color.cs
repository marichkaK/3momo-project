using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Color
    {
        public String color { get; set; }

        public Color(String color)
        {
            this.color = color;
        }

        public String getColor()
        {
            return color;
        }
    }
}
