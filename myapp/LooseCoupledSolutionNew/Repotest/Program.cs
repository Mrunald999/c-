using catelog;

using HR.Repository;
using HR.Services;
using HR.Controllers;
using HR.UI;
ProductRepository repository = new ProductRepository();
IProductsService productService = new ProductService(repository);
IProductsController controller = new ProductController(productService);

IEnumerable<Product> products = controller.Index();
foreach (Product product in products)
{

    Console.WriteLine(product.Id);
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Quantity);
}
