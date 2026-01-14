using ConsoleApp;

public class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Shape[] shapes = new Shape[5]
        {
            new Circle(3),
            new Rectangle(4, 6),
            new Triangle(9, 12, 13),
            new Circle(17.3),
            new Rectangle(7.7, 3)
        };
        Shape largestAreaShape = shapes[0];
        foreach (Shape shape in shapes)
        {
            shape.GetInfo();
            if (shape.CalculateArea() > largestAreaShape.CalculateArea())
                largestAreaShape = shape;
        }
        Console.WriteLine("Фігура з найбільшою площею:");
        largestAreaShape.GetInfo();
    }
}