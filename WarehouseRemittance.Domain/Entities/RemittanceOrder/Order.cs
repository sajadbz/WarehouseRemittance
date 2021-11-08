using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseRemittance.Domain.Base;
using WarehouseRemittance.Domain.Entities.Users;
using WarehouseRemittance.Domain.Entities.Warehouses;

namespace WarehouseRemittance.Domain.Entities.RemittanceOrder
{
    public class Order : BaseEntity<long>
    {

        public long OrderCode { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsSent { get; set; }
        public bool IsReceived { get; set; }
        public bool IsDelete { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
        
    }
}
