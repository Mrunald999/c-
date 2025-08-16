namespace catelog;
public class ProductService: IProductsService
{
    private readonly IProductRepository _repo;
    public ProductService(IProductRepository repo)
    {
        _repo = repo;
    }
    public IEnumerable<Product> GetProducts()
    {
        return _repo.GetAll();
    }

    
}
