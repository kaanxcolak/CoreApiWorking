using EntityLayer.ResultModels;
using System.Linq.Expressions;

namespace BusinessLayer.InterfacesOfManagers
{
    public interface IManager<T, Id>
    {
        IDataResult<T> Add(T model); //Ekleme için IResult değil DataResult kullandık. Çünkü eklenen verinin idsine ihtiyaç duyarsak geriye dönen datadan id alabiliriz.
        IResult Update(T model);
        IResult Delete(T model);
        IDataResult<ICollection<T>> GetAll(Expression<Func<T, bool>>? filter = null);
        IDataResult<T> GetByConditions(Expression<Func<T, bool>>? filter = null);
        IDataResult<T> GetById(Id id);
    }
}
