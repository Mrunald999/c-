namespace Drawing;

public class Shape
{
    protected int Thickness { get; set; }
    protected Color ShapeColor { get; set; }
    public Shape()
    {
        Thickness = 0;
        ShapeColor = new Color(0, 0, 0);
    }
    public Shape(int Thickness, Color c)
    {
        this.Thickness = Thickness;
        this.ShapeColor = c;
    }
    public void display()
    {
        Console.WriteLine("thickness= " + Thickness);
        Console.WriteLine(ShapeColor.Red + " " + ShapeColor.Green + " " + ShapeColor.Blue);
    }
    public virtual void Draw()
    {
        Console.WriteLine("ShapeDrawFunction");
        Console.WriteLine("(" + ShapeColor.Red + " ," + ShapeColor.Green + " ," + ShapeColor.Blue + ")");
        Console.WriteLine("Thickness" + Thickness);
    }
}