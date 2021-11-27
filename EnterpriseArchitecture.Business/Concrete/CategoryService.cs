using EnterpriseArchitecture.Business.Abstract;
using EnterpriseArchitecture.Business.Constants;
using EnterpriseArchitecture.Core.Utilities.Results;
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
            if (category.CategoryId <= 0)
            {
                _categoryDal.Create(category);

                return new SuccessResult(Messages.CategoryAdded);
            }
            else
            {
                return new ErrorResult(Messages.CategoryIdInvalid);
            }

        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);

            return new SuccessResult(Messages.CategoryDeleted);
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.CategoriesListed);
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }
    }
}