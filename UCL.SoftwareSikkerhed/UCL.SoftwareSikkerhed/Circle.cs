using System;
using System.Collections.Generic;
using System.Text;

namespace UCL.SoftwareSikkerhed
{
    class Circle:IShape
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        private double GetArea()
        {
            return _radius * _radius * Math.PI;
        }
        public void DisplayArea()
        {
            Console.WriteLine($"Radius: {_radius}");
            Console.WriteLine($"Circle Area is: {GetArea()}");
        }
    }
}
