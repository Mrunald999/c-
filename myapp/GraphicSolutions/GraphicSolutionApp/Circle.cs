namespace Drawing;

public class Circle : Shape
{
    public int Radius { get; set; }
    public Point Center { get; set; }  //has a relation
    public Circle()
    {
        this.Radius = 0;
        this.Center = new Point(1, 34);
    }

    public Circle(int radius, Point center, int Thickness, Color color) : base(Thickness, color)
    {
        this.Radius = radius;
        this.Center = center;
    }
     public void Display()
    {
        Console.WriteLine("\n Circle details:");
        Console.WriteLine("Radius=" + this.Radius);
        Console.WriteLine("Center= ");
        this.Center.Display();
    }
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
        this.Center.Display();
        Console.WriteLine("Radius=" + this.Radius);
        base.Draw();
    }
    public Color GetColor()
    {
        return ShapeColor;
    }

    public void SetColor(Color color)
    {
        ShapeColor = color;
    }
    public int GetThickness()
    {
        return Thickness;
    }
     public void SetThickness(int thickness)
    {
        Thickness = thickness;
    }
}