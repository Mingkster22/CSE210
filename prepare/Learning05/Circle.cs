class Circle : Shape
{
    public double Radius { get; }

    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
    }

    public override double GetArea() => Math.PI * Radius * Radius;
}