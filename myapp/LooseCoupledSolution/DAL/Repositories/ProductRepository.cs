namespace catelog;

public class ProductRepository : IProductRepository
{
    List<Product> allProducts = null;
    public ProductRepository()
    {
        allProducts = new List<Product>();
    }
    public void Add(Product product)
    {

        allProducts.Add(product);
    }


    public IEnumerable<Product> GetAll()
    {
        Product p1 = new Product { Id = 33, Name = "Rose", Quantity = 8 };
        allProducts.Add(p1);
        Product p2 = new Product { Id = 34, Name = "Jasmine", Quantity = 1 };
        allProducts.Add(p2);
        Product p3 = new Product { Id = 35, Name = "Jarbera", Quantity = 9 };
        allProducts.Add(p2);
        return allProducts;
    }
    public void Delete(int id)
    {
        Product foundProduct = GetByID(id);
        if (foundProduct != null)
        {
            allProducts.Remove(foundProduct);
        }
    }
    public Product GetByID(int id)
    {
        Product theProduct = allProducts.Find(x => (x.Id == id));
        return theProduct;
    }
    public void Update(Product product)
    {
        //logic for updation of product;
        Product foundProduct = GetByID(product.Id);
        foundProduct = product;

    }
}

