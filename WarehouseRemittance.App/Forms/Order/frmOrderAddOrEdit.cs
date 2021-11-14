using System;
using System.Windows.Forms;
using WarehouseRemittance.Core.Dtos.RemittanceOrder;
using Microsoft.Extensions.DependencyInjection;
using WarehouseRemittance.Core.Services;
using System.Collections.Generic;
using WarehouseRemittance.App.Services;

namespace WarehouseRemittance.App.Forms.Order
{
    public partial class frmOrderAddOrEdit : Form
    {
        public long OrderId = 0;
        private List<OrderDetailDto> _orderDetailDtos;
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        private readonly IWarehouseService _warehouseService;
        private readonly IProductService _productService;

        public frmOrderAddOrEdit(IOrderService orderService, IUserService userService, IWarehouseService warehouseService, IProductService productService)
        {
            InitializeComponent();
            _orderService = orderService;
            _userService = userService;
            _warehouseService = warehouseService;
            _productService = productService;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            LoadComboBox();

            if (OrderId == 0)
            {
                dtCreateDate.Text = DateTime.Now.ToString();
                btnSave.Text = "ذخیره";
                groupBox1.Text = "افزودن حواله";

                LoadGrid();
            }
            else
            {
                btnSave.Text = "ویرایش";
                groupBox1.Text = "ویرایش حواله";
                LoadGrid(OrderId);
            }

        }
        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            long Id = Convert.ToInt64(dgListProducts.SelectedRows[0].Cells[1].Value);
            if (OrderId == 0)
            {
                DeleteListProduct((int)DataGridViewElementStates.Selected);
                LoadGrid();
            }
            else
            {
                if (Id > 0)
                {
                    _orderService.DeleteProduct(Id);
                   // LoadGrid();
                }
                else
                {  
                        Int32 selectedRowCount = dgListProducts.Rows.GetRowCount(DataGridViewElementStates.Selected);
                        if (selectedRowCount > 0)
                        {
                            for (int i = 0; i < selectedRowCount; i++)
                            {
                                DeleteListProduct((int)DataGridViewElementStates.Selected);
                            }
                        }
                        
                    LoadGrid();
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _orderDetailDtos.Add(new OrderDetailDto
            {
                ProductId = (long)cboProducts.SelectedValue,
                Count = Convert.ToInt32(txtProductCount.Text),
                ProductName = cboProducts.Text
            });
            BindingSource source = new BindingSource();
            source.DataSource = _orderDetailDtos;
            dgListProducts.AutoGenerateColumns = false;
            dgListProducts.DataSource = source;
            // Clear form
            txtProductCount.Text = "";
            cboProducts.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var dto = new OrderDto
            {
                CreateDate = DateTime.Parse(dtCreateDate.Text),
                IsReceived = chkReceived.Checked,
                IsSent = chkSent.Checked,
                UserId = (int)cboUser.SelectedValue,
                WarehouseId = (int)cboWareHouse.SelectedValue,
                OrderDetails = _orderDetailDtos,
            };
            if (OrderId == 0)
            {
                _orderService.Add(dto);
            }
            else
            {
                dto.Id = OrderId;
                _orderService.Update(dto);
            }

            DialogResult = DialogResult.OK;
        }

        #region Costum Methods
        private void LoadComboBox()
        {
            cboUser.DataSource = _userService.GetAll();
            cboWareHouse.DataSource = _warehouseService.GetAll();
            cboProducts.DataSource = _productService.GetAll();
        }

        private void LoadGrid(long? orderId = null)
        {
            BindingSource source = new BindingSource();
            dgListProducts.AutoGenerateColumns = false;
            _orderDetailDtos = new List<OrderDetailDto>();


            if (orderId.HasValue)
            {
                var orderDetails = _orderService.GetOrderDetails(orderId.Value);
                source.DataSource = orderDetails;
                dgListProducts.DataSource = source;
                _orderDetailDtos.AddRange(orderDetails);
                //  txtOrderCode.Text =Convert.ToString(_orderService.getOrderId(OrderId));
            }
            else
            {
                source.DataSource = _orderDetailDtos;
                dgListProducts.DataSource = source;
                // txtOrderCode.Text = Convert.ToString(_orderService.getOrderId(OrderId));
            }
            dgListProducts.MouseDown += GeneralService.DataGridView_MouseDown;
        }
        private void DeleteListProduct(int orderId)
        {
            Int32 selectedRowCount = dgListProducts.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    dgListProducts.Rows.RemoveAt(dgListProducts.SelectedRows[0].Index);
                }
            }
        }

        #endregion

    }
}
