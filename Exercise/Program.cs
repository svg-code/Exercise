using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class PlaneShape
    {
        double CalcPerimeter(List<IPlaneShape> AllShapes)
        {
            double perimeter = 0;
            foreach (var item in AllShapes)
            {
                perimeter += item.Perimeter();
            }
            return perimeter;
        }
    }

    public class Rectangle: IPlaneShape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public double Perimeter()
        {
            return Height * Width;
        }
    }

    public class Square : IPlaneShape
    {
        public double Width { get; set; }

        public double Perimeter()
        {
            return Math.Pow(Width, 2);
        }
    }

    interface IPlaneShape
    {
        public double Perimeter();
    }


}
