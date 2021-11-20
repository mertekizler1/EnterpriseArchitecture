using EnterpriseArchitecture.Core.Entities;
using System.Linq.Expressions;

namespace EnterpriseArchitecture.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class , IEntity , new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        List<T> GetAllByCagetory(int categoryId);
    }
}