using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseRemittance.Core.Dtos.Products
{
    public class ProductDto
    {
        public long Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int NumberItem { get; set; }
        public string GroupName { get; set; }
    }
}
