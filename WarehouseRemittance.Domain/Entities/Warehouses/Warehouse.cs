using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseRemittance.Domain.Base;
using WarehouseRemittance.Domain.Entities.Products;
using WarehouseRemittance.Domain.Entities.RemittanceOrder;

namespace WarehouseRemittance.Domain.Entities.Warehouses
{
    public class Warehouse : BaseEntity<int>
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }        
        [MaxLength(50)]
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
