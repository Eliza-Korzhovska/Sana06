using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Triangle : Shape
    {
        public double SideA;
        public double SideB;
        public double SideC;
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public override double CalculateArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Triangle: Сторона А = {SideA}, Сторона B = {SideB}, Сторона C = {SideC}, Площа = {CalculateArea()}, Периметр = {CalculatePerimeter()}");
        }
    }
}
