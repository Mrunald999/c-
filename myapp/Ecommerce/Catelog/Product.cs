namespace Ecomerce.Catelog;

public class ProductManager
{
    public int Id { get; set}
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal price { get; set; }

   public string ImageURL { get; set; } = string.Empty;

}
