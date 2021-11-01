using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseRemittance.App.Applications;
using WarehouseRemittance.App.Domain.Base;
using WarehouseRemittance.App.Domain.Entities.RemittanceOrder;

namespace WarehouseRemittance.App.Domain.Entities.Users
{
     public class User : BaseEntity<int>
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }        
        public UserType UserType { get; set; }
        [Required]
        [MaxLength(100)]
        public string Phone { get; set; }

        #region Navigation Properties
        //public int UserTypeId { get; set; }
        //public UserType UserType { get; set; }

        public ICollection<Order> Orders { get; set; }
        #endregion

    }
}
