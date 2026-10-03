namespace ShapeAreas;

class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Circle(2.5),
            new Rectangle(3, 8)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Shape type: " + shape.GetType().Name);
            Console.WriteLine("Area: " + shape.CalculateArea().ToString("F2"));
            Console.WriteLine();
        }
    }
}
