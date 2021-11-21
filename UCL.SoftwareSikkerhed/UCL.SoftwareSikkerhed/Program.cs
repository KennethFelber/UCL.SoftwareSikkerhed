using System;
using System.Collections.Generic;
using System.Text;

namespace UCL.SoftwareSikkerhed
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = GetValueFromConsole("Length");
            var height = GetValueFromConsole("Height");
            var radius = GetValueFromConsole("Radius");

            Rectangle r = new Rectangle(length, height);
            r.DisplayArea();

            Circle c = new Circle(radius);
            c.DisplayArea();

            Console.ReadLine();
        }

        private static double GetValueFromConsole(string name)
        {
            double value = 0;
            while (value == 0)
            {
                Console.Write($"Insert {name}: ");
                if (!double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Please insert valid number.");
                    Console.WriteLine(value);
                }
            }
            return value;
        }
    }
}
