using System;
using System.Collections.Generic;
using WarehouseRemittance.Core.Dtos.Users;
using WarehouseRemittance.Core.Dtos.Warehouses;

namespace WarehouseRemittance.Core.Dtos.RemittanceOrder
{
    public class OrderDto
    {
        public long Id { get; set; }
        public long OrderCode { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsSent { get; set; }
        public bool IsReceived { get; set; }

        public int UserId { get; set; }
        public UserDto User { get; set; }
        public string UserFullName { get; set; }

        public int WarehouseId { get; set; }
        public WarehouseDto Warehouse { get; set; }

        public List<OrderDetailDto> OrderDetails { get; set; }
        public decimal ProductCount { get; set; }

    }
}
