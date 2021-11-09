using System;
using System.Windows.Forms;
using WarehouseRemittance.Core.Dtos.RemittanceOrder;
using WarehouseRemittance.Core.Services;

namespace WarehouseRemittance.App.Forms.Order
{

    partial class frmAddItemOrder : Form
    {
        private readonly IOrderService _orderDetail;
        private readonly IProductService _productService;

        public frmAddItemOrder(IOrderService orderDetail, IProductService productService)
        {
            InitializeComponent();
            _orderDetail = orderDetail;
            _productService = productService;
        }
        private void frmAddItemOrder_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
                var dto = new OrderDetailDto
                {
                    ProductId = (long)cboItemName.SelectedValue,
                   Count = Convert.ToInt32(txtItemCount.Text),
                    

                };
                _orderDetail.AddDetail(dto);

                this.Close();
            
        }
        #region Costum Methods
        private void LoadComboBox()
        {
            cboItemName.DataSource = _productService.GetAll();
        }

        #endregion
    }

}
