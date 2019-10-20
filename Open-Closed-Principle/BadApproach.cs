using System;
using System.Collections.Generic;
using System.Text;

namespace S.O.L.I.D.Open_Closed_Principle
{
    class BadApproach
    {
        public class Rectangle
        {
            public double Width { get; set; }
            public double Height { get; set; }
        }
        public class Circle
        {
            public double Radius { get; set; }
        }
        public class CombinedAreaCalculator
        {
            public double Area(object[] shapes)
            {
                double area = 0;
                foreach (var shape in shapes)
                {
                    if (shape is Rectangle)
                    {
                        Rectangle rectangle = (Rectangle)shape;
                        area += rectangle.Width * rectangle.Height;
                    }
                    if (shape is Circle)
                    {
                        Circle circle = (Circle)shape;
                        area += (circle.Radius * circle.Radius) * Math.PI;
                    }
                }
                return area;
            }
        }
    }
}
