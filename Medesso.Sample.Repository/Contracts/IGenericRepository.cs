using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace Medesso.Sample.Repository.Contracts;

public interface IGenericRepository<T> where T : class
{
    Task AddAsync(T entity, CancellationToken cancellationToken);
        
    Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken);
        
    Task UpdateAsync(T entity, CancellationToken cancellationToken);
        
    Task UpdateRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken);
        
    Task<IList<T>> FindManyAsync(
        Expression<Func<T, bool>> predicate = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
        CancellationToken cancellationToken = default);

    Task<T> FindAsync(
        Expression<Func<T, bool>> predicate = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
        CancellationToken cancellationToken = default);

    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

    Task<IList<TResult>> QueryListAsync<TResult>(
        Expression<Func<T, TResult>> selector,
        Expression<Func<T, bool>> predicate = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
        CancellationToken cancellationToken = default);
}