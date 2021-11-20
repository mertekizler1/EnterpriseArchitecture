using EnterpriseArchitecture.Core.DataAccess.EntityFramework;
using EnterpriseArchitecture.DataAccess.Abstract;
using EnterpriseArchitecture.DataAccess.Concrete.EntityFramework.Context;
using EnterpriseArchitecture.Entities.Concrete;

namespace EnterpriseArchitecture.DataAccess.Concrete.EntityFramework
{
    internal class RegionDal : EfEntityRepositoryBase<Region, NorthwindContext>, IRegionDal
    {
    }
}