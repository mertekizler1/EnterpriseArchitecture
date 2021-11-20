using EnterpriseArchitecture.Core.Entities;

namespace EnterpriseArchitecture.Entities.Concrete
{
    public class Shipper : IEntity
    {
        public int ShipperId { get; set; }

        public string CompanyName { get; set; }

        public string Phone { get; set; }
    }
}