using System;
using System.Windows.Forms;
using WarehouseRemittance.App.Services;
using WarehouseRemittance.Core.Services;
using WarehouseRemittance.Domain.Entities.Users;

namespace WarehouseRemittance.App.Forms.Settings
{
    public partial class frmUsers : Form
    {
        private readonly IUserService _userService;
        private static int _courrentUserId = 0;
        public frmUsers(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnSaveOrEdit_Click(object sender, EventArgs e)
        {
            if (_courrentUserId == 0)
            {
                _userService.Add(txtName.Text, txtPhone.Text, (int)GetSelectedType());
            }
            else
            {
                _userService.Update(_courrentUserId, txtName.Text, txtPhone.Text, (int)GetSelectedType());
            }
            Clear();
            LoadGrid();
        }

        private void cmEdit_Click(object sender, EventArgs e)
        {
            if (dgList.RowCount > 0)
            {
                var userId = (int)dgList.SelectedRows[0].Cells[0].Value;
                var user = _userService.Find(userId);
                _courrentUserId = userId;
                txtName.Text = user.Name;
                txtPhone.Text = user.Phone;
                btnSaveOrEdit.Text = "ویرایش";
                groupBox1.Text = "ویرایش شخص";
                btnCansel.Visible = true;
                switch (user.UserType)
                {
                    case UserType.Customer:
                        rbCustomer.Checked = true;
                        break;
                    case UserType.Driver:
                        rbDriver.Checked = true;
                        break;
                }
            }

        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmDelete_Click(object sender, EventArgs e)
        {
            if (dgList.RowCount > 0)
            {
                var name = dgList.SelectedRows[0].Cells[1].Value;
                if (MessageBox.Show($"آیا از حذف شخص {name} مطمئن هستید ؟", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var userId = (int)dgList.SelectedRows[0].Cells[0].Value;
                    _userService.Delete(userId);
                    Clear();
                    LoadGrid();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Custom Methods
        private UserType GetSelectedType()
        {
            if (rbCustomer.Checked)
                return UserType.Customer;
            else if (rbDriver.Checked)
                return UserType.Driver;

            //throw new Exception("Not exist.");
            return UserType.Customer;
        }
        private void Clear()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            btnSaveOrEdit.Text = "افزودن";
            groupBox1.Text = "افزودن شخص جدید";
            _courrentUserId = 0;
            btnCansel.Visible = false;
            rbCustomer.Checked = true;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(txtSearch.Text);
        }

        private void LoadGrid(string search = null)
        {
            dgList.AutoGenerateColumns = false;
            if (string.IsNullOrWhiteSpace(search))
                dgList.DataSource = _userService.GetAll();
            else
                dgList.DataSource = _userService.GetAll(search);

            dgList.MouseDown += GeneralService.DataGridView_MouseDown;
        }
        #endregion


    }
}
