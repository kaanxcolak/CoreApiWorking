using System.Linq.Expressions;

namespace DataLayer.InterfacesOfRepo
{
    public interface IRepository<T, Id> where T : class, new()
    {
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
        T GetById(Id id);
        IQueryable<T> GetAll(Expression<Func<T, bool>>? filter = null, string[]? includeRelationalTables = null);
        T GetByConditions(Expression<Func<T, bool>>? filter = null, string[]? includeRelationalTables = null);
    }
}
