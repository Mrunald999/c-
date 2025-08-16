namespace UI;
using Drawing;
public class UIManager
{
    public void ShowMenu()
    {
        Console.WriteLine("Welcome");
        Console.WriteLine("Choose Options");
        Console.WriteLine("1.Create Line");
        Console.WriteLine("2.Create Circle");
        Console.WriteLine("3.Exit");
    }
    public int getchoice()
    {
        Console.WriteLine("Enter your choice ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
    public Point getPoints()
    {
        // Taking input for Start Point
        Point thePoint = new Point();
        Console.WriteLine("Accept Point Coordinates");
        Console.WriteLine("Enter X value:");
        thePoint.X = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y value:");
        thePoint.Y = int.Parse(Console.ReadLine());
        return thePoint;
    }
    public int GetThickness()
    {
        Console.WriteLine("Enter Thickness");
        int thickness = int.Parse(Console.ReadLine());
        return thickness;
    }
    public Color GetColor()
    {
        Color thecolor = new Color();
        Console.WriteLine("Enter color");
        Console.WriteLine("Enter Red Value (0, 255)");
        thecolor.Red = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Green Value (0, 255)");
        thecolor.Green = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Blue Value (0, 255)");
        thecolor.Blue = int.Parse(Console.ReadLine());
        return thecolor;
    }
    public Line GetLine()
    {
        Line theLine = new Line();
        theLine.StartPoint = getPoints();
        theLine.EndPoint = getPoints();
        Color thecolor = GetColor();
        theLine.SetColor(thecolor);
        int thickness = GetThickness();
        theLine.SetThickness(thickness);
        return theLine;
    }
    public int GetRadius()
    {
        Console.WriteLine("Enter Radius");
        int radius = int.Parse(Console.ReadLine());
        return radius;
    }
    public Circle GetCircle()
    {
        Circle theCircle = new Circle();
        theCircle.Center = getPoints();
        theCircle.Radius = GetRadius();
        Color color = GetColor();
        theCircle.SetColor(color);
        int thickness = GetThickness();
        theCircle.SetThickness(thickness);
        return theCircle;
    }
    /*public Rectangle GetRectanglele()
    {
        Rectangle therectangle = new Rectangle();
        therectangle.Center = getPoints();
        
        Color color = GetColor();
        theCircle.SetColor(color);
        int thickness = GetThickness();
        theCircle.SetThickness(thickness);
        return theCircle;
        
return therectangle;
    }*/
}


    

    


        
    



