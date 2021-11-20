using EnterpriseArchitecture.Business.Abstract;
using EnterpriseArchitecture.DataAccess.Abstract;
using EnterpriseArchitecture.Entities.Concrete;

namespace EnterpriseArchitecture.Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            try
            {
                _categoryDal.Create(category);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            
        }

        //public void Delete(int categoryId)
        //{
        //    _categoryDal.Delete(categoryId);
        //}

        public List<Category> GetAll()
        {
           var result = _categoryDal.GetAll();

           return result;
        }

        public Category GetById(int categoryId)
        {
            var result = _categoryDal.Get(c => c.CategoryId == categoryId);

            return result;
        }
    }
}