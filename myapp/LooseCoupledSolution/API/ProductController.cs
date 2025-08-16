using System.Security.Cryptography.X509Certificates;
using catelog;
namespace API;

public class ProductController : IProductsController
{
    private readonly IProductsService _svc;
    public ProductController(IProductsService svc)
    {
        _svc = svc;
    }
    public void Delete(int id)
    {

    }

    public Product Details(int id)
    {
        IEnumerable<Product> products = _svc.GetProducts();

        List<Product> allProducts = (List<Product>)products;
        return allProducts.Find(x => x.Id == id);
    }

    public IEnumerable<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> Index()
    {
        return _svc.GetProducts();
    }

    public void Post(Product product)
    {
        
    }

    public void Put(int id, Product product)
    {
        
    }
}
