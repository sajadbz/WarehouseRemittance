using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseRemittance.Core.Dtos.Products;
using WarehouseRemittance.Core.Dtos.RemittanceOrder;
using WarehouseRemittance.Data.Context;
using WarehouseRemittance.Domain.Entities.RemittanceOrder;

namespace WarehouseRemittance.Core.Services
{
    public interface IOrderService
    {
        OrderDto Find(long orderId);
        List<OrderDto> GetAll();
        List<OrderDto> GetAll(long code);
        Task<List<OrderDto>> GetAllAsync();
        long AddDetail(OrderDetailDto dto);
        long Add(OrderDto dto);
        public void Update(OrderDto dto);
        public void Delete(long orderId);
        public void DeleteProduct(long orderDetailId);
        List<OrderDetailDto> GetOrderDetails(long orderId);
        
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
        public async Task<List<OrderDto>> GetAllAsync()
        {
            return await _context.Orders
                //.Where(c => c.IsDelete == false)
                .Include(c => c.OrderDetails).ThenInclude(c => c.Product)
                .Include(c => c.User)
                .Select(c => c.ToDto())
                //.IgnoreQueryFilters()
                .ToListAsync();
        }
        //public OrderDto getOrderId(long code)
        //{
        //    return (OrderDto)_context.Orders
        //        .Select(c => c.ToDtoId());
        //}
        public long AddDetail(OrderDetailDto dto)
        {
            OrderDetail orderDetail = new OrderDetail
            {
                ProductId = dto.ProductId,
                Count = dto.Count,
                //OrderId = dto.OrderId,

            };

            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();

            return orderDetail.Id;

        }
        public long Add(OrderDto dto)
        {
            long defaultCode = 1000;
            if (_context.Orders.Any())
                defaultCode = _context.Orders.Max(c => c.OrderCode) + 1;

            Order order = new Order
            {
                OrderCode = defaultCode,                
                CreateDate = DateTime.Now,
                UserId = dto.UserId,
                WarehouseId = dto.WarehouseId,
                IsDelete = false,
                IsReceived = dto.IsReceived,
                IsSent = dto.IsSent,                
            };
            _context.Add(order);
            _context.SaveChanges();

            if (dto.OrderDetails?.Count > 0)
            {
                foreach (var item in dto.OrderDetails)
                {
                    _context.OrderDetails.Add(new OrderDetail
                    {
                        OrderId = order.Id,
                        ProductId = item.ProductId,
                        Count = item.Count
                    });
                }
                _context.SaveChanges();
            }


            return order.Id;
        }
        public void Update(OrderDto dto)
        {            
            var order = _context.Orders.Find(dto.Id);
            order.UserId = dto.UserId;
            order.WarehouseId = dto.WarehouseId;
            //order.CreateDate = dto.CreateDate;
            order.IsReceived = dto.IsReceived;
            order.IsSent = dto.IsSent;
            _context.Orders.Update(order);
            _context.SaveChanges();

            if (_context.OrderDetails.Any(c => c.OrderId == dto.Id))
            {
                _context.OrderDetails.RemoveRange(_context.OrderDetails.Where(c => c.OrderId == dto.Id));
                _context.SaveChanges();
            }

            if (dto.OrderDetails?.Count > 0)
            {
                foreach (var item in dto.OrderDetails)
                {
                    // It must be add to database not update 
                    _context.OrderDetails.Add(new OrderDetail
                    {
                        OrderId = order.Id,
                        ProductId = item.ProductId,
                        Count = item.Count                        
                    });
                }
                _context.SaveChanges();
            }
            
        }
        public void Delete(long orderId)
        {
            //Why remove order? it must be soft delete
            var order = _context.Orders.Find(orderId);
            _context.Remove(order);
            //order.IsDelete = true;
            _context.SaveChanges();
        }

        // DeleteProduct is not a good name, it must be DeleteOrderDetail
        public void DeleteProduct(long orderDetailId)
        {
            var order = _context.OrderDetails.Find(orderDetailId);
            _context.RemoveRange(order);
            //_context.SaveChanges();
        } 
        public OrderDto Find(long orderId)
        {
            var order = _context.Orders
                .Include(c => c.OrderDetails).ThenInclude(c => c.Product)
                .Include(c => c.User)
                .Single(c => c.Id == orderId);
            return order.ToDto();
        }

        public List<OrderDetailDto> GetOrderDetails(long orderId)
        {
            return _context.OrderDetails
                .Include(c => c.Product)
                .Where(c => c.OrderId == orderId)
                .Select(c => c.ToDto())
                .ToList();
        }

        
    }
}
