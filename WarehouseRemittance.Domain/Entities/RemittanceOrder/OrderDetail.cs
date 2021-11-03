using WarehouseRemittance.Domain.Base;
using WarehouseRemittance.Domain.Entities.Products;

namespace WarehouseRemittance.Domain.Entities.RemittanceOrder
{
    public class OrderDetail : BaseEntity<long>
    {
        public int Count { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }

        public long OrderId { get; set; }
        public Order Order { get; set; }
    }
}
