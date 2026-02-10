using System.Collections.Generic;

public class ProductService
{
    private readonly IRepository<string> _repository;

    // Dependency Injection via constructor
    public ProductService(IRepository<string> repository)
    {
        _repository = repository;
    }

    public void AddProduct(string product)
    {
        _repository.Add(product);
    }

    public IEnumerable<string> GetProducts()
    {
        return _repository.GetAll();
    }
}
