using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseRemittance.App.Domain.Base;
using WarehouseRemittance.App.Domain.Entities.Users;
using WarehouseRemittance.App.Domain.Entities.Warehouses;

namespace WarehouseRemittance.App.Domain.Entities.RemittanceOrder
{
    public class Order : BaseEntity<long>
    {
        
        public DateTime CreateDate { get; set; }
        public bool IsSent { get; set; }
        public bool IsReceived { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
        
    }
}
