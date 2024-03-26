
using System.Linq.Expressions;

namespace Play.Common
{
    public interface IRepository<T> where T : IEntity {
    Task CreateAsync(T item);
    Task<IReadOnlyCollection<T>> GetAllAsync();
    Task<T> GetAsync(Guid id);
    Task RemoveAsync(Guid id);
    Task UpdateAsync(T item);
    Task<IReadOnlyCollection<T>> GetAllAsync(Expression<Func<T, bool>> filter);
    Task<T> GetAsync(Expression<Func<T, bool>> filter);


  }
}