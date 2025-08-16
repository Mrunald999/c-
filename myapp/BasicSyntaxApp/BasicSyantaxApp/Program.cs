namespace Math;

using drawing;
public class Program
{
    private string Bookname = String.Empty;
    private string description = String.Empty;
    private string Author = String.Empty;

    public static void Main(string[] args)
    {
        Program Theprogram = new Program();
        Theprogram.Bookname = "Simple Fly";
        Theprogram.description = "This is book";
        Theprogram.Author = "Capt GR";

        Console.WriteLine(Theprogram.Bookname);
        Console.WriteLine(Theprogram.description);
        Console.WriteLine(Theprogram.Author);

        /*Complex C1 = new Complex();
        C1.SetImaginary(55);
        C1.SetReal(2);

        Console.WriteLine(C1.GetImaginary());
        Console.WriteLine(C1.GetReal()); */

        Rectangle R1 = new Rectangle();
        R1.SetHeight(5);
        R1.SetWidth(10);

          Console.WriteLine(R1.GetHeight());
        Console.WriteLine(R1.GetWidth());






    }
    




}
