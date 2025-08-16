namespace Drawing;
public struct Color
{
    public Color(int r, int g, int b)
    {
        this.Red = r;
        this.Blue = b;
        this.Green = g;
    }
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }
}