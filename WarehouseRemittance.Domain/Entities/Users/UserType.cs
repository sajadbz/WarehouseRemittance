using System.ComponentModel;

namespace WarehouseRemittance.Domain.Entities.Users
{
    public enum UserType
    {
        [Description( "عمومی")]
        Customer = 1,
        [Description("راننده")]
        Driver
    }
    //public class UserType : BaseEntity<int>
    //{
    //    public string Name { get; set; }

    //    #region Navigation Propertis
    //    public ICollection<User> Users { get; set; } 
    //    #endregion
    //}
}
