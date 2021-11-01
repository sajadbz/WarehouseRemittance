using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseRemittance.App.Domain.Base;
using WarehouseRemittance.App.Domain.Entities.RemittanceOrder;
using WarehouseRemittance.App.Domain.Entities.Warehouses;

namespace WarehouseRemittance.App.Domain.Entities.Products
{
   public class Product : BaseEntity<long>
    {
        
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        public int NumberItem { get; set; }

        #region Navigation Properties
        public int GroupId { get; set; }        
        public ProductGroup  Group { get; set; }

        //public int WarehouseId { get; set; }
        //public Warehouse Warehouse { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
        #endregion
    }
}
