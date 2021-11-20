using EnterpriseArchitecture.Core.DataAccess.EntityFramework;
using EnterpriseArchitecture.DataAccess.Abstract;
using EnterpriseArchitecture.DataAccess.Concrete.EntityFramework.Context;
using EnterpriseArchitecture.Entities.Concrete;

namespace EnterpriseArchitecture.DataAccess.Concrete.EntityFramework
{
    public class CustomerDal : EfEntityRepositoryBase<Customer, NorthwindContext>, ICustomerDal
    {
    }
}