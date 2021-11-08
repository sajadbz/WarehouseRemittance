using WarehouseRemittance.Domain.Entities.Users;

namespace WarehouseRemittance.Core.Dtos.Users
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UserType UserType { get; set; }
        public string UserTypeString { get; set; }
        public string Phone { get; set; }
    }
}
