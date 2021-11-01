﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseRemittance.App.Domain.Base;

namespace WarehouseRemittance.App.Domain.Entities.Products
{
    public class ProductGroup : BaseEntity<int>
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        #region Navigation Properties
        public ICollection<Product> Products { get; set; }

        #endregion
    }
}
