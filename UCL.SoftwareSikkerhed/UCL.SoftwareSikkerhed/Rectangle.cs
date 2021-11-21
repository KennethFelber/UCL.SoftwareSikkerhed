using System;

namespace UCL.SoftwareSikkerhed
{
    class Rectangle:IShape
    {
        private double _length;
        private double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }

        private double GetArea()
        {
            return _length * _width;
        }

        public void DisplayArea()
        {
            Console.WriteLine($"Length: {_length}");
            Console.WriteLine($"Width: {_width}");
            Console.WriteLine($"Rectangle Area is: {GetArea()}");
        }
    }

}
