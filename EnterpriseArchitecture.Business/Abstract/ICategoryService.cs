using EnterpriseArchitecture.Core.Utilities.Results.Common;
using EnterpriseArchitecture.Entities.Concrete;

namespace EnterpriseArchitecture.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        Category GetById(int categoryId);

        IResult Add(Category category);

        //void Delete(int categoryId);
    }
}