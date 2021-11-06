using System;
using System.Linq;
using System.Windows.Forms;
using WarehouseRemittance.Core.Services;

namespace WarehouseRemittance.App.Forms.Settings
{
    public partial class frmProduct : Form
    {
        private readonly ProductService _productService = new ProductService();
        private static long _currentProductId = 0;
        public frmProduct()
        {
            InitializeComponent();
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

            int ProductId = Convert.ToInt32(cbProductItem.SelectedValue);
            if (_currentProductId == 0)
                _productService.Add(ProductId, txtName.Text);
            else
                _productService.Update(_currentProductId, ProductId, txtName.Text);
            
            Clear();
            LoadGrid();
        }

        private void cmEdit_Click(object sender, EventArgs e)
        {
            if (dgList.RowCount > 0)
            {
                var itemId = (long)dgList.SelectedRows[0].Cells[0].Value;
                var item = _productService.FindProductId(itemId);

                _currentProductId = itemId;
                txtName.Text = item.Name;
                cbProductItem.SelectedValue = item.Group;
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
                    var itemId = (Int64)dgList.SelectedRows[0].Cells[0].Value;
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
            cbProductItem.SelectedIndex = 0;
        }
        private void LoadGrid(string search = null)
        {
            dgList.AutoGenerateColumns = false;
            if (string.IsNullOrWhiteSpace(search))
                dgList.DataSource = _productService.GetAll();
            else
                dgList.DataSource = _productService.GetAll(search);
        }
        private void LoadGroups()
        {
            cbProductItem.DataSource = _productService.FindGroupId();
        }
        #endregion


    }
}
