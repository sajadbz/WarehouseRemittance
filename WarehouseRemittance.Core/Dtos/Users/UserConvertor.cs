using System;
using WarehouseRemittance.Core.Extensions;
using WarehouseRemittance.Domain.Entities.Users;

namespace WarehouseRemittance.Core.Dtos.Users
{
    public static class UserConvertor
    {
        public static UserDto ToDto(this User u)
        {
            string userType = Convert.ToString(u.UserType.GetDescription());
            return new UserDto
            {
                Id = u.Id,
                Name = u.Name,
                Phone = u.Phone,
                UserTypeString = userType,
            };
        }
    }
}
