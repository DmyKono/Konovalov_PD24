using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz3
{
    internal class Figure
    {
        private Point[] points;

        public Figure(Point[] points)
        {
            this.points = points;
        }

        private double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2));
        }

        public double PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                int nextIndex = (i + 1) % points.Length;
                perimeter += LengthSide(points[i], points[nextIndex]);
            }
            return perimeter;
        }
    }
}
