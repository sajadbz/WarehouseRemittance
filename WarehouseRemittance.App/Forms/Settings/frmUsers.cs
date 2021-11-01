using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WarehouseRemittance.App.Data.Context;
using WarehouseRemittance.App.Domain.Entities.Users;
using WarehouseRemittance.App.Applications.Extensions;
using Microsoft.EntityFrameworkCore;

namespace WarehouseRemittance.App.Forms.Settings
{
    public partial class frmUsers : Form
    {
        WarehouseRemittanceContext _context = new WarehouseRemittanceContext();
        private static int _courrentUserId = 0;
        public frmUsers()
        {
            InitializeComponent();
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnSaveOrEdit_Click(object sender, EventArgs e)
        {
            if (_courrentUserId == 0)
            {
                User user = new User()
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    UserType = GetSelectedType()
                };
                _context.Users.Add(user);
            }
            else
            {
                var user = _context.Users.Find(_courrentUserId);
                user.Name = txtName.Text;
                user.Phone = txtPhone.Text;
                user.UserType = GetSelectedType();
                _context.Users.Update(user);
            }
            _context.SaveChanges();
            Clear();
            LoadGrid();
        }

        private void cmEdit_Click(object sender, EventArgs e)
        {
            if (dgList.RowCount > 0)
            {
                var userId = (int)dgList.SelectedRows[0].Cells[0].Value;
                var user = _context.Users.Find(userId);
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
                    _context.Users.Remove(_context.Users.Find(userId));
                    _context.SaveChanges();
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

        private void LoadGrid()
        {
            dgList.AutoGenerateColumns = false;
            dgList.DataSource = _context.Users
                .Include(c=>c.Orders)
                .Select(c => new
                {
                    c.Id,
                    c.Name,
                    c.Phone,
                    UserType = c.UserType.GetDescription(),
                    OrderCount = c.Orders.Count
                })
                .ToList();
        }
        #endregion
    }
}
