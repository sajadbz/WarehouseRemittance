using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WarehouseRemittance.Core.Dtos.Products;
using WarehouseRemittance.Core.Dtos.RemittanceOrder;
using WarehouseRemittance.Core.Utility;
using WarehouseRemittance.Data.Context;
using WarehouseRemittance.Domain.Entities.Products;
using WarehouseRemittance.Domain.Entities.RemittanceOrder;

namespace WarehouseRemittance.Core.Services
{
    public interface IOrderService
    {
        OrderDto Find(long orderId);
        List<OrderDto> GetAll();
        List<OrderDto> GetAll(long code);
        long Add(OrderDto dto);
        public void Update(OrderDto dto);
        public void Delete(long orderId);
    }
    public class OrderService : IOrderService
    {
        WarehouseRemittanceContext _context = new WarehouseRemittanceContext();
        public List<OrderDto> GetAll()
        {
            return _context.Orders
                //.Where(c => c.IsDelete == false)
                .Include(c => c.OrderDetails).ThenInclude(c => c.Product)
                .Include(c => c.User)
                .Select(c => c.ToDto())
                //.IgnoreQueryFilters()
                .ToList();
        }
        public List<OrderDto> GetAll(long code)
        {
            return _context.Orders
                //.Where(c => c.IsDelete == false)
                .Where(c => c.OrderCode == code)
                .Include(c => c.OrderDetails).ThenInclude(c => c.Product)
                .Include(c => c.User)
                .Select(c => c.ToDto())
                .ToList();
        }
        public long Add(OrderDto dto)
        {
            long defaultCode = 1000;
            if (_context.Orders.Any())
                defaultCode = _context.Orders.Max(c => c.OrderCode) + 1;

            Order order = new Order
            {
                OrderCode = defaultCode,
                CreateDate = dto.CreateDate,
                UserId = dto.UserId,
                WarehouseId = dto.WarehouseId,
                IsDelete = false,
                IsReceived = false,
                IsSent = false,
            };
            _context.Orders.Add(order);
            _context.SaveChanges();
            if (dto.OrderDetails?.Count > 0)
            {
                foreach (var item in dto.OrderDetails)
                {
                    OrderDetail detail = new OrderDetail
                    {
                        OrderId = order.Id,
                        ProductId = item.ProductId,
                        Count = item.Count
                    };
                    _context.OrderDetails.Add(detail);
                }
                _context.SaveChanges();
            }
                
            return order.Id;
        }
        public void Update(OrderDto dto)
        {
            //TODO: Update Order ...
            var order = _context.Orders.Find(dto.Id);
            order.IsReceived = dto.IsReceived;
            order.IsSent = dto.IsSent;
            //_context.Orders.Update(order);
            //_context.SaveChanges();
        }
        public void Delete(long orderId)
        {
            var order = _context.Orders.Find(orderId);
            order.IsDelete = true;
            _context.SaveChanges();
        }
        public OrderDto Find(long orderId)
        {
            var order = _context.Orders
                .Include(c => c.OrderDetails).ThenInclude(c => c.Product)
                .Include(c => c.User)
                .Single(c => c.Id == orderId);
            return order.ToDto();
        }

    }
}
