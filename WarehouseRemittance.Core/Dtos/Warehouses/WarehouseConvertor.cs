using WarehouseRemittance.Domain.Entities.Warehouses;

namespace WarehouseRemittance.Core.Dtos.Warehouses
{
    public static class WarehouseConvertor
    {
        public static WarehouseDto ToDto(this Warehouse w)
        {
            return new WarehouseDto
            {
                Id = w.Id,
                Name = w.Name,
                Address = w.Address,
                Phone = w.Phone,
            };
        }
    }
}
