using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WarehouseRemittance.Core.Services;
using WarehouseRemittance.Domain.Entities.Warehouses;

namespace WarehouseRemittance.App.Forms
{
    public partial class frmWarehouseGroups : Form
    {
        WarehouseService _warehouse = new WarehouseService();
        private static int _currentGroupId = 0;

        public frmWarehouseGroups()
        {
            InitializeComponent();
        }


        private void frmWarehouseGroups_Load(object sender, EventArgs e)
        {
            LoadGrip();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_currentGroupId == 0)
            {
                _warehouse.Add(txtName.Text, txtPhone.Text, txtAddress.Text);
            }
            else
            {
                _warehouse.Update(_currentGroupId, txtName.Text, txtPhone.Text, txtAddress.Text);
            }
            LoadGrip();
            Clear();
        }

        private void cmEdit_Click(object sender, EventArgs e)
        {
            if (dgList.RowCount > 0)
            {
                var warehouseId = (int)dgList.SelectedRows[0].Cells[0].Value;
                var house = _warehouse.Find(warehouseId);
                _currentGroupId = house.Id;
                txtName.Text = house.Name;
                txtAddress.Text = house.Address;
                txtPhone.Text = house.Phone;
                groupBox1.Text = "ویرایش انبار";
                btnSave.Text = "ویرایش";
                btnCancel.Visible = true;
            }
        }

        private void cmDelete_Click(object sender, EventArgs e)
        {
            if (dgList.RowCount > 0)
            {
                string nameHouse = dgList.SelectedRows[0].Cells[1].Value.ToString();
                if (MessageBox.Show($"آیا مایل به حذف انبار  {nameHouse} می باشید", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var warehouseId = (int)dgList.SelectedRows[0].Cells[0].Value;
                    _warehouse.Delete(warehouseId);
                    Clear();
                    LoadGrip();

                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            btnCancel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGrip(txtSearch.Text);
        }

        #region Custom Methods
        private void LoadGrip(string search = null)
        {
            dgList.AutoGenerateColumns = false;
            if (string.IsNullOrWhiteSpace(search))
                dgList.DataSource = _warehouse.GetAll();
            else
                dgList.DataSource = _warehouse.GetAll(search);
        }
        private void Clear()
        {
            txtAddress.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            groupBox1.Text = "افزودن انبار جدید";
            btnSave.Text = "افزودن";
        }
        #endregion
    }
}
