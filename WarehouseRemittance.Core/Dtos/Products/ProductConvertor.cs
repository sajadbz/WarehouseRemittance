using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseRemittance.Domain.Entities.Products;

namespace WarehouseRemittance.Core.Dtos.Products
{
    public static class ProductConvertor
    {
        public static ProductDto ToDto(this Product p)
        {
            return new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                GroupId = p.GroupId,
                GroupName = p.Group?.Name,
                NumberItem = p.NumberItem
            };
        }
        public static ProductGroupDto ToDto(this ProductGroup group)
        {
            return new ProductGroupDto
            {
                Id = group.Id,
                Name = group.Name
            };
        }
    }
}
