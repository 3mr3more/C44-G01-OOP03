using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass4.Q1
{
    internal class Rectangle : IRectangle
    {
        public double Width { get ; set; }
        public double Height { get ; set ; }
        public double Area { get ; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double IArea()
        {
            Area = Width * Height;
            return Area;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Width: {Width}, Height: {Height}");
            Console.WriteLine($"Area: {IArea}");
        }

    }
}
