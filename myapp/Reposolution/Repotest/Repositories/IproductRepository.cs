namespace catelog;

public interface Iproductrepository
{
    Product GetByID(int id);
    IEnumerable<Product> GetAll();
    void Add(Product product);
    void Update(Product product);
    void Delete(int id);
}