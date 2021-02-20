using System;
using System.Collections.Generic;
using System.Text;
using course.Entities.Enumerates;

namespace course.Entities
{
    class Retangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retangle(double width, double heigth, Color color) : base (color)
        {
            Width = width;
            Height = heigth;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
