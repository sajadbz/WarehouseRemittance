using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseRemittance.App.Domain.Base;
using WarehouseRemittance.App.Domain.Entities.Products;
using WarehouseRemittance.App.Domain.Entities.RemittanceOrder;

namespace WarehouseRemittance.App.Domain.Entities.Warehouses
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
