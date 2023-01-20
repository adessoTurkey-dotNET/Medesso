using Medesso.Sample.Repository.Context;
using Medesso.Sample.Repository.Contracts;
using Medesso.Sample.Repository.Repositories;

namespace Medesso.Sample.Repository.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        ProductRepository = new ProductRepository(context);
    }

    public IProductRepository ProductRepository { get; }

    public Task<int> SaveChangesAsync()
    {
        return _context.SaveChangesAsync();
    }
}