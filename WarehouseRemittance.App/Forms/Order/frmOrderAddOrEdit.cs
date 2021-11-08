using System;
using System.Windows.Forms;
using WarehouseRemittance.Core.Dtos.RemittanceOrder;
using Microsoft.Extensions.DependencyInjection;
using WarehouseRemittance.Core.Services;

namespace WarehouseRemittance.App.Forms.Order
{
    public partial class frmOrderAddOrEdit : Form
    {
        private int _currentId = 0;
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        private readonly IWarehouseService _warehouseService;


        public frmOrderAddOrEdit(IOrderService orderService, IUserService userService, IWarehouseService warehouseService)
        {
            InitializeComponent();
            _orderService = orderService;
            _userService = userService;
            _warehouseService = warehouseService;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            if (_currentId == 0)
            {
                dtCreateDate.Text = DateTime.Now.ToString();
                btnSave.Text = "ذخیره";
                groupBox1.Text = "افزودن حواله";
            }
            else
            {
                btnSave.Text = "ویرایش";
                groupBox1.Text = "ویرایش حواله";
            }
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            var frm = Program.ServiceProvider.GetService<frmAddItemOrder>();
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_currentId == 0)
            {
                var dto = new OrderDto
                {
                    CreateDate = DateTime.Parse(dtCreateDate.Text),
                    IsReceived = chkReceived.Checked,
                    IsSent = chkSent.Checked,
                    UserId = (int)cboUser.SelectedValue,
                    WarehouseId = (int) cboWareHouse.SelectedValue,
                };
                _orderService.Add(dto);
            }

            DialogResult = DialogResult.OK;
        }
        #region Costum Methods
        private void LoadComboBox()
        {
            cboUser.DataSource = _userService.GetAll();
            cboWareHouse.DataSource = _warehouseService.GetAll();
        }
        private void LoadGrid()
        {
            dgListProducts.AutoGenerateColumns = false;
            dgListProducts.DataSource = _orderService.GetAll();
        }

        #endregion
    }
}
