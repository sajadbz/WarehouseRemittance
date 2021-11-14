using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseRemittance.Domain.Entities.RemittanceOrder;
using WarehouseRemittance.Core.Dtos.Users;
using WarehouseRemittance.Core.Dtos.Warehouses;
using WarehouseRemittance.Core.Dtos.Products;

namespace WarehouseRemittance.Core.Dtos.RemittanceOrder
{
    public static class OrderConvertor
    {
        public static OrderDto ToDto(this Order o)
        {
            return new OrderDto
            {
                Id = o.Id,
                //CreateDate = o.CreateDate,
                IsReceived = o.IsReceived,
                IsSent = o.IsSent,
                OrderCode = o.OrderCode,
                UserId = o.UserId,
                WarehouseId = o.WarehouseId,
                OrderDetails = o.OrderDetails?.Select(c => c?.ToDto()).ToList(),
                ProductCount = o.OrderDetails.Where(c=> c.OrderId == o.Id)?.Sum(c => c.Count) ?? 0,
                User = o.User?.ToDto(),
                UserFullName = o.User?.Name,
                Warehouse = o.Warehouse?.ToDto()
            };
        }
        public static OrderDetailDto ToDto(this OrderDetail o)
        {
            return new OrderDetailDto
            {
                Id = o.Id,
                OrderId = o.OrderId,
                Count = o.Count,
                ProductId = o.ProductId,
                ProductName = o.Product.Name,
                Product = o.Product?.ToDto()
            };
        }
        //public static OrderDto ToDtoId (this Order o)
        //{
        //    return new OrderDto
        //    {
        //        OrderCode = o.OrderCode,
        //    };
        //}
    }
}
