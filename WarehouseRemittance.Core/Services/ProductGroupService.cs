using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseRemittance.Core.Dtos.Products;
using WarehouseRemittance.Data.Context;
using WarehouseRemittance.Domain.Entities.Products;

namespace WarehouseRemittance.Core.Services
{
    public interface IProductGroupService
    {
        List<ProductGroupDto> GetAll();
        List<ProductGroupDto> GetAll(string search);
        long Add(string name);
        void Update(int groupId, string name);
        ProductGroupDto Find(int groupId);
        void Delete(int groupId);
    }
    public class ProductGroupService: IProductGroupService
    {
        WarehouseRemittanceContext _context = new WarehouseRemittanceContext();

        public List<ProductGroupDto> GetAll()
        {
            return _context.ProductGroups
                .Select(c => new ProductGroupDto
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToList();
        }
        public List<ProductGroupDto> GetAll(string search)
        {
            return _context.ProductGroups
                .Where(c =>
                c.Name.Contains(search))
                .Select(c => c.ToDto())
                .ToList();
        }
        /// <summary>
        /// Add New Product Group
        /// </summary>
        /// <param name="name">Group Name</param>
        /// <returns></returns>
        public long Add(string name)
        {
            ProductGroup group = new ProductGroup
            {
                Name = name
            };
            _context.ProductGroups.Add(group);
            _context.SaveChanges();
            return group.Id;
        }
        /// <summary>
        /// Update Name ProductGroup
        /// </summary>
        /// <param name="groupId">ProductGroup ID</param>
        /// <param name="name">Name ProductGroup</param>
        public void Update(int groupId, string name)
        {
            var group = _context.ProductGroups.Find(groupId);
            group.Name = name;
            _context.ProductGroups.Update(group);
            _context.SaveChanges();
        }
        /// <summary>
        /// Find product group
        /// </summary>
        /// <param name="groupId">New ProductGroupId</param>
        /// <returns></returns>
        public ProductGroupDto Find(int groupId)
        {
            var product = _context.ProductGroups.Find(groupId);
            return product.ToDto();
        }
        /// <summary>
        /// Delete GroupName
        /// </summary>
        public void Delete(int groupId)
        {
            _context.ProductGroups.Remove(_context.ProductGroups.Find(groupId));
            _context.SaveChanges();
        }
    }
}
