using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Rectangle : Shape
    {
        public double Length;
        public double Width;
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double CalculateArea()
        {
            return Length * Width;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Rectangle: Довжина = {Length}, Ширина = {Width}, Площа = {CalculateArea()}, Периметр = {CalculatePerimeter()}");
        }
    }
}
