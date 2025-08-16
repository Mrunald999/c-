namespace Catalog
{
    public class ProductManager
    {
        public void Display(Product p)
        {
            Console.WriteLine("ID:" + p.Id);
            Console.WriteLine("Name:" + p.Name);
            Console.WriteLine("Description:" + p.Description);
            Console.WriteLine("Price:" + p.Price.ToString("C"));
            Console.WriteLine("ImageURL:" + p.ImageURL);
        }
 
    }
   
}