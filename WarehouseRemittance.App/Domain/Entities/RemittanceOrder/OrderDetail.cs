using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseRemittance.App.Domain.Base;
using WarehouseRemittance.App.Domain.Entities.Products;

namespace WarehouseRemittance.App.Domain.Entities.RemittanceOrder
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
