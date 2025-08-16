namespace Drawing;

public class Line : Shape
{
    public Point StartPoint { get; set; }
    public Point EndPoint { get; set; }
    public Line() //Default constructor
    {
        this.StartPoint = new Point(0, 0);
        this.EndPoint = new Point(0, 0);
    }
    public Line(Point Startpoint, Point Endpoint, int thickness, Color ShapeColor) : base(thickness, ShapeColor)
    {
        this.StartPoint = StartPoint;
        this.EndPoint = Endpoint;
    }
    public void Display()
    {
        Console.WriteLine("Line Details");
        this.StartPoint.Display();
        this.EndPoint.Display();
    }
    public override void Draw()
    {
        Console.WriteLine("LineDrawFucntion");
        StartPoint.Display();
        EndPoint.Display();
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
    public void SetThickness(int thkness)
    {
        Thickness = thkness;
    }
 }
