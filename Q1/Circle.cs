using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass4.Q1
{
    internal class Circle : ICircle
    {
        public double Radius { get;set; }
        double IShape.Area { get ; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Area() {
          return  Math.PI* Radius *Radius;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape: {Circle}");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {Area}");
        }
    }
}
