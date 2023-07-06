class Rectangle : Shape
{
    public double Length { get; }
    public double Width { get; }

    public Rectangle(string color, double length, double width) : base(color)
    {
        Length = length;
        Width = width;
    }

    public override double GetArea() => Length * Width;
}