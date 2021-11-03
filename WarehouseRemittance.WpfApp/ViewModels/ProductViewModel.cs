using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseRemittance.Core.Dtos.Products;

namespace WarehouseRemittance.WpfApp.ViewModels
{
    public class ProductViewModel
    {
        [Display(Name = "نام محصول")]
        public string ProductName { get; set; }
        [Display(Name = "نام گروه محصول")]
        public string GroupName { get; set; }
    }
    public static class ProductConvertor
    {
        public static ProductViewModel ToViewModel(this ProductDto dto)
        {
            return new ProductViewModel
            {
                GroupName = dto.GroupName,
                ProductName = dto.Name
            };
        }
        public static List<ProductViewModel> ToViewModel(this List<ProductDto> dtos)
        {
            return dtos.Select(c => c.ToViewModel()).ToList();
        }
    }
}
