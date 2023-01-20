namespace Medesso.Sample.Repository.Contracts;

public interface IUnitOfWork
{
    IProductRepository ProductRepository { get; }
    Task<int> SaveChangesAsync();
}