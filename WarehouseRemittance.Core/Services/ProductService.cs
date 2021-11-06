using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WarehouseRemittance.Core.Dtos.Products;
using WarehouseRemittance.Core.Utility;
using WarehouseRemittance.Data.Context;
using WarehouseRemittance.Domain.Entities.Products;

namespace WarehouseRemittance.Core.Services
{
    public class ProductService
    {
        WarehouseRemittanceContext _context = new WarehouseRemittanceContext();
        public List<ProductDto> GetAll()
        {
            return _context.Products
                .Include(c => c.Group)
                .Select(c => new ProductDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    NumberItem = c.NumberItem,
                    GroupId = c.GroupId,
                    GroupName = c.Group.Name,
                })
                .ToList();
        }
        public List<ProductDto> GetAll(string search)
        {
            return _context.Products
                     .Where(c =>
                     c.Name.Contains(search) ||
                     c.Group.Name.Contains(search) ||
                     c.NumberItem.ToString().Contains(search))
                     .Include(c => c.Group)
                     .Select(c => new ProductDto
                     {
                         Id = c.Id,
                         Name = c.Name,
                         NumberItem = c.NumberItem,
                         GroupId = c.GroupId,
                         GroupName = c.Group.Name,
                     })
                     .ToList();
        }

        /// <summary>
        /// Add product to database
        /// </summary>
        /// <param name="gId">GroupId</param>
        /// <param name="name">Product name</param>
        public long Add(int pId, string name)
        {
            int rndNumber = 0;
            do
            {
                rndNumber = Generator.RandomNumber(max: 999999);
            } while (_context.Products.Any(c => c.NumberItem == rndNumber));
            Product product = new Product()
            {
                Name = name,
                GroupId = pId,
                NumberItem = rndNumber,
            };
            _context.Products.Add(product);
            _context.SaveChanges();

            return product.Id;
        }
        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="pId">ProductId</param>
        /// <param name="gId">New Product GroupId</param>
        /// <param name="name">New Product Name</param>
        public void Update(long pId, int gId, string name)
        {
            var product = _context.Products.Find(pId);
            product.Name = name;
            product.GroupId = gId;
            _context.Products.Update(product);
            _context.SaveChanges();
        }
        /// <summary>
        /// Delete product
        /// </summary>
        /// <param name="pId">New Product GroupId</param>
        public void Delete(long pId)
        {
            _context.Products.Remove(_context.Products.Find(pId));
            _context.SaveChanges();
        }
        /// <summary>
        /// Find product
        /// </summary>
        /// <param name="pId">New ProductId</param>
        /// <returns></returns>
        public Product FindProductId(long pId)
        {

            var product = _context.Products.Find(pId);
            return product;
        }
        /// <summary>
        /// Find GroupId
        /// </summary>
        /// <returns></returns>
        public List<ProductDto> FindGroupId()
        {

            return _context.Products
                .Include(c => c.Group)
                .Select(c => new ProductDto
                {
                    GroupId = c.GroupId
                })
                .ToList();


        }
    }
}
