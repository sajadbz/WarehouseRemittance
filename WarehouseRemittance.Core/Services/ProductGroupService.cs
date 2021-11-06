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
    public class ProductGroupService
    {
         WarehouseRemittanceContext _context = new WarehouseRemittanceContext();

        public List<ProductGroupDto> GetAll()
        {
            return _context.ProductGroups
                .Select(c => new ProductGroupDto
                {
                    Name = c.Name
                })
                .ToList();
        }
        public List<ProductGroupDto> GetAll(string serach)
        {
            return _context.ProductGroups
                .Where(c =>
                c.Name.Contains(serach))
                .Select(c => new ProductGroupDto
                {
                    Name = c.Name
                })
                .ToList();
        }
        /// <summary>
        /// Add New Product Group
        /// </summary>
        /// <param name="name">Group Name</param>
        /// <returns></returns>
        public long Add(String name)
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
        /// <param name="pId">ProductGroup ID</param>
        /// <param name="name">Name ProductGroup</param>
        public void Update(int pId,string name)
        {
            var group = _context.ProductGroups.Find(pId);
            group.Name = name; ;
            _context.ProductGroups.Update(group);
            _context.SaveChanges();
        }
        /// <summary>
        /// Find product
        /// </summary>
        /// <param name="pId">New ProductGroupId</param>
        /// <returns></returns>
        public Product FindProductId(long pId)
        {
            var product = _context.Products.Find(pId);
            return product;
        }
        /// <summary>
        /// Delete GroupName
        /// </summary>
        public void Delete(long pId)
        {
            _context.ProductGroups.Remove(_context.ProductGroups.Find(pId));
            _context.SaveChanges();
        }
    }
}
