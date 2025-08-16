namespace Drawing;
public class Point
{
    //Autoproperty
    public int X { get; set; }
    public int Y { get; set; }
   public Point() //Default constructor
    {
        this.X = 0;
        this.Y = 0;
    }
    public Point(int x, int y) //parameterized constructor
    {
        this.X = x;
        this.Y = y;
    }
    public void Display()
    {
        Console.WriteLine("(" + this.X + " , " + this.Y+ ")"); 
    } 

    
 }
