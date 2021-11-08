using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseRemittance.Core.Dtos.Warehouses;
using WarehouseRemittance.Data.Context;
using WarehouseRemittance.Domain.Entities.Warehouses;

namespace WarehouseRemittance.Core.Services
{
    public interface IWarehouseService
    {
        List<WarehouseDto> GetAll();
        List<WarehouseDto> GetAll(string search);
        int Add(string wName, string wPhone, string wAddress);
        void Delete(int wId);
        WarehouseDto Find(int wId);
        void Update(int wId, string wName, string wPhone, string wAddress);
    }
    public class WarehouseService : IWarehouseService
    {
        WarehouseRemittanceContext _context = new WarehouseRemittanceContext();

        public List<WarehouseDto> GetAll()
        {
            return _context.Warehouses
                .Select(c => c.ToDto())
                .ToList();
        }
        public List<WarehouseDto> GetAll(string search)
        {
            return _context.Warehouses
                .Where(c=>
                c.Name.Contains(search) ||
                c.Phone.Contains(search) ||
                c.Address.Contains(search))
                .Select(c => c.ToDto())
                .ToList();
        }

        /// <summary>
        /// Add New Warehouse
        /// </summary>
        /// <param name="wName">New Warehouse Name</param>
        /// <param name="wPhone">New Warehouse phone</param>
        /// <param name="wAddress">New Warehouse Address</param>
        /// <returns></returns>
        public int Add(string wName,string wPhone,string wAddress)
        {
            Warehouse warehouse = new Warehouse()
            {
                Name = wName,
                Phone = wPhone,
                Address = wAddress,
            };
            _context.Warehouses.Add(warehouse);
            _context.SaveChanges();
            return warehouse.Id;

        }

        /// <summary>
        /// Delete Warehouse
        /// </summary>
        /// <param name="wId">Warehouse ID</param>
        /// <returns></returns>
        public void Delete(int wId)
        {
            _context.Warehouses.Remove(_context.Warehouses.Find(wId));
            _context.SaveChanges();
        }

        /// <summary>
        /// Find Id Warehoues
        /// </summary>
        /// <param name="wId">Warehouse Id</param>
        /// <returns></returns>
        public WarehouseDto Find(int wId)
        {
            var warehouse = _context.Warehouses.Find(wId);
            return warehouse.ToDto();
        }

        /// <summary>
        /// Update Warehouse
        /// </summary>
        /// <param name="wId">Warehouse Id</param>
        /// <param name="wName">Update Warehouse Name</param>
        /// <param name="wPhone">Update Warehouse Phone</param>
        /// <param name="wAddress">Update Warehouse Address</param>
        public void Update(int wId,string wName, string wPhone, string wAddress)
        {
            var warehouse = _context.Warehouses.Find(wId);
            warehouse.Name = wName;
            warehouse.Phone = wPhone;
            warehouse.Address = wAddress;
            _context.Warehouses.Update(warehouse);
            _context.SaveChanges();
        }
    }
}
