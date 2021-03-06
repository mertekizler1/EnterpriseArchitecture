using EnterpriseArchitecture.Core.DataAccess;
using EnterpriseArchitecture.Entities.Concrete;

namespace EnterpriseArchitecture.DataAccess.Abstract
{
    public interface IShipperDal : IEntityRepository<Shipper>
    {
    }
}