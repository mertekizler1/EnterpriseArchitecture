using EnterpriseArchitecture.Business.Abstract;
using EnterpriseArchitecture.Core.Utilities.Results.Common;
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

        public IResult Add(Category category)
        {
            if (category != null)
            {
                _categoryDal.Create(category);

                return new Result(true, "Added");
            }
            else
            {
                return new Result(false, "Failed");
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