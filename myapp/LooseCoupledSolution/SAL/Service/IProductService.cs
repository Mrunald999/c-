namespace catelog;

using System.Collections.Generic;

public interface IProductsService
{
    IEnumerable<Product> GetProducts();
}