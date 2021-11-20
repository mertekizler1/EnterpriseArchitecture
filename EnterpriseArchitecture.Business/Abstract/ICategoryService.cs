using EnterpriseArchitecture.Entities.Concrete;

namespace EnterpriseArchitecture.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        Category GetById(int categoryId);

        void Add(Category category);

        //void Delete(int categoryId);
    }
}