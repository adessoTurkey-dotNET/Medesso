using Medesso.Sample.Domain.Entities.Product;
using Medesso.Sample.Repository.Context;
using Medesso.Sample.Repository.Contracts;

namespace Medesso.Sample.Repository.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }
}