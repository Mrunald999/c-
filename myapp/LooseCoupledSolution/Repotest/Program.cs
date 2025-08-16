using catelog;
using API;
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
