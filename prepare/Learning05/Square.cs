class Square : Shape
{
    public double Side { get; }

    public Square(string color, double side) : base(color)
    {
        Side = side;
    }

    public override double GetArea() => Side * Side;
}