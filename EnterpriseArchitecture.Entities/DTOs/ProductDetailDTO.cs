using EnterpriseArchitecture.Core.Entities;

namespace EnterpriseArchitecture.Entities.DTOs
{
    public class ProductDetailDTO : IDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string CategoryName { get; set; }

        public short UnitsInStock { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }
    }
}