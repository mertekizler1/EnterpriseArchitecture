using EnterpriseArchitecture.Core.Utilities.Results.Common;
using EnterpriseArchitecture.Entities.Concrete;

namespace EnterpriseArchitecture.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();

        IDataResult<Category> GetById(int categoryId);

        IResult Add(Category category);

        IResult Delete(Category category);
    }
}