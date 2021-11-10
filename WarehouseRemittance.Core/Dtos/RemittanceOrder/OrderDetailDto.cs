using WarehouseRemittance.Core.Dtos.Products;

namespace WarehouseRemittance.Core.Dtos.RemittanceOrder
{
    public class OrderDetailDto 
    {
        public long Id { get; set; }
        public int Count { get; set; }

        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public ProductDto Product { get; set; }

        public long OrderId { get; set; }
        //public OrderDto Order { get; set; }
    }
}
