using Drawing;
using UI;
public class Shapes
{
    public static void Main(string[] args)
    {
        UIManager mgr = new UIManager();
        mgr.ShowMenu();
        int choice = mgr.getchoice();
        switch (choice)
        {
            case 1:
            Line l1 = mgr.GetLine();
            l1.Draw();
            
             break;
            case 2:
                Circle c1 = mgr.GetCircle();
                c1.Draw();
                
                      break;
                case 3:

                break;

        }
    }
}
