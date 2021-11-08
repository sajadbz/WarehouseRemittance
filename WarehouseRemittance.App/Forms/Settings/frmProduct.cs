using System;
using System.Linq;
using System.Windows.Forms;
using WarehouseRemittance.App.Services;
using WarehouseRemittance.Core.Services;

namespace WarehouseRemittance.App.Forms.Settings
{
    public partial class frmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly IProductGroupService _productGroupService;
        private static long _currentProductId = 0;

        public frmProduct(IProductService productService,IProductGroupService productGroupService)
        {
            InitializeComponent();
            _productService = productService;
            _productGroupService = productGroupService;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadGroups();
        }


        private void btnSaveOrEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("نام کالا را وارد کنید");
                return;
            }

            int groupId = Convert.ToInt32(cbProductGroups.SelectedValue);
            if (_currentProductId == 0)
                _productService.Add(groupId, txtName.Text);
            else
                _productService.Update(_currentProductId, groupId, txtName.Text);

            Clear();
            LoadGrid();
        }

        private void cmEdit_Click(object sender, EventArgs e)
        {
            if (dgList.RowCount > 0)
            {
                var itemId = (long)dgList.SelectedRows[0].Cells[0].Value;
                var item = _productService.Find(itemId);

                _currentProductId = itemId;
                txtName.Text = item.Name;
                cbProductGroups.SelectedValue = item.GroupId;
                btnSaveOrEdit.Text = "ویرایش";
                groupBox1.Text = $"ویرایش کالا ({item.NumberItem})";
                btnCansel.Visible = true;
            }
        }

        private void cmDelete_Click(object sender, EventArgs e)
        {
            if (dgList.RowCount > 0)
            {
                string name = dgList.SelectedRows[0].Cells[1].Value.ToString();
                if (MessageBox.Show($"آیا مایل به حذف کالا{name} می باشید ؟", "حذف کالا", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var itemId = (long) dgList.SelectedRows[0].Cells[0].Value;
                    _productService.Delete(itemId);
                    LoadGrid();
                    Clear();
                }

            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(txtSearch.Text);
        }

        #region Custom Methods
        private void Clear()
        {
            _currentProductId = 0;
            txtName.Text = "";
            btnCansel.Visible = false;
            btnSaveOrEdit.Text = "افزودن";
            groupBox1.Text = "افزودن کالا";
            cbProductGroups.SelectedIndex = 0;
        }
        private void LoadGrid(string search = null)
        {
            dgList.AutoGenerateColumns = false;
            if (string.IsNullOrWhiteSpace(search))
                dgList.DataSource = _productService.GetAll();
            else
                dgList.DataSource = _productService.GetAll(search);

            dgList.MouseDown += GeneralService.DataGridView_MouseDown;
        }
        private void LoadGroups()
        {
            cbProductGroups.DataSource = _productGroupService.GetAll();
        }
        #endregion
    }
}
