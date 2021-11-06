using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseRemittance.Core.Dtos.Users;
using WarehouseRemittance.Data.Context;
using WarehouseRemittance.Domain.Entities.Users;

namespace WarehouseRemittance.Core.Services
{
    public class UserService
    {
        WarehouseRemittanceContext _context = new WarehouseRemittanceContext();
        public List<UserDto> GetAll()
        {
            return _context.Users
                //.Include(c => UserType)
                .Select(c => c.ToDto())
                .ToList();
        }
        public List<UserDto> GetAll(string Search)
        {
            return _context.Users
                .Where(c =>
                c.Name.Contains(Search) ||
                c.Phone.Contains(Search))
                //.Include(c => UserType)
                .Select(c => c.ToDto())
                .ToList();
        }

        /// <summary>
        ///  Delete User
        /// </summary>
        /// <param name="uId">User Id</param>
        public void Delete(int uId)
        {
            _context.Users.Remove(_context.Users.Find(uId));
            _context.SaveChanges();

        }

        /// <summary>
        /// Find User
        /// </summary>
        /// <param name="uId">user Id</param>
        /// <returns></returns>
        public UserDto Find(int uId)
        {
            var user = _context.Users.Find(uId);
            return user.ToDto();
        }

        /// <summary>
        /// Add New User
        /// </summary>
        /// <param name="uName">New User Name</param>
        /// <param name="uPhone">New User Phone</param>
        /// <param name="uType">Select New UserType</param>
        /// <returns></returns>
        public int Add(string uName, string uPhone, int uType)
        {
            User user = new User()
            {
                Name = uName,
                Phone = uPhone,
                UserType = (UserType)uType,
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }

        /// <summary>
        /// Update User
        /// </summary>
        /// <param name="uId">Find UserId</param>
        /// <param name="uName">Update User Name</param>
        /// <param name="uPhone">Update User Phone</param>
        /// <param name="uType">Update Select UserType</param>
        public void Update(int uId, string uName, string uPhone, int uType)
        {
            var user = _context.Users.Find(uId);
            user.Name = uName;
            user.Phone = uPhone;
            user.UserType = (UserType)uType;
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
