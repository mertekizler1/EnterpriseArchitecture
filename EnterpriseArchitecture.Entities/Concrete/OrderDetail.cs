using EnterpriseArchitecture.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseArchitecture.Entities.Concrete
{
    public class OrderDetail : IEntity
    {
        [Key]
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }
    }
}