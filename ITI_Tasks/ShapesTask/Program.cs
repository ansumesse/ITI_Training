namespace ShapesTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Console.WriteLine($"Area of Circle {circle.CalcArea()}");

            Triangle triangle = new Triangle(5, 6);
            Console.WriteLine($"Area of triangle {triangle.CalcArea()}");

            Rectangle rectangle = new Rectangle(5, 6);
            Console.WriteLine($"Area of rectangle {rectangle.CalcArea()}");

            GeoShapes[] shapes = new GeoShapes[]
            {
                new Circle(3),
                new Rectangle(3,6),
                new Triangle(3,5)
            };

        }
    }
}
