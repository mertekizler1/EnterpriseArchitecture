using EnterpriseArchitecture.Core.Entities;

namespace EnterpriseArchitecture.Entities.Concrete
{
    public class Region : IEntity
    {
        public int RegionId { get; set; }

        public string RegionDescription { get; set; }
    }
}
