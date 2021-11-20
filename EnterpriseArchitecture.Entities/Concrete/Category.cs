using EnterpriseArchitecture.Core.Entities;

namespace EnterpriseArchitecture.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}
