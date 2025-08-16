using Catalog;
 //Integration of Product and ProductManager classes
 
Product p1 = new Product();
p1.Id = 1;
p1.Name = "Lotus";
p1.Description = "A worship flower.";
p1.Price = 50.00m;
p1.ImageURL = "https://qa.com";
 
 
Product p2 = new Product();
p2.Id = 2;
p2.Name = "Rose";
p2.Description = "A symbol of love.";
p2.Price = 50.00m;
p2.ImageURL = "https://qa.com";
 
List<Product> products = new List<Product>();
products.Add(p1);
products.Add(p2);
 
ProductManager productManager = new ProductManager();
foreach (Product product in products)
{
    productManager.Display(product);
    Console.WriteLine();
}