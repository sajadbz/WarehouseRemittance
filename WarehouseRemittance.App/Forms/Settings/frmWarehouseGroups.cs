using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseRemittance.Data.Context;
using WarehouseRemittance.Domain.Entities.Warehouses;

namespace WarehouseRemittance.App.Forms
{
    public partial class frmWarehouseGroups : Form
    {
        WarehouseRemittanceContext _context = new WarehouseRemittanceContext();
        private static int _currentGroupId = 0;

        public frmWarehouseGroups()
        {
            InitializeComponent();
        }
        private void LoadGrip()
        {
            dgList.AutoGenerateColumns = false;
            dgList.DataSource = _context.Warehouses.ToList();
        }
        private void Clear()
        {
            txtAddress.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            groupBox1.Text = "افزودن انبار جدید";
            btnSave.Text = "افزودن";
        }

        private void frmWarehouseGroups_Load(object sender, EventArgs e)
        {
            LoadGrip();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_currentGroupId == 0)
            {
                
                Warehouse house = new Warehouse()
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                };
                _context.Warehouses.Add(house); 
            }
            else
            {
                var house = _context.Warehouses.Find(_currentGroupId);
                house.Name = txtName.Text;
                house.Phone = txtPhone.Text;
                house.Address = txtAddress.Text;
                _context.Warehouses.Update(house);
            }
            _context.SaveChanges();
            LoadGrip();
            Clear();
        }

        private void cmEdit_Click(object sender, EventArgs e)
        {
            if (dgList.RowCount > 0)
            {
                var groupId = (int)dgList.SelectedRows[0].Cells[0].Value;
                var house = _context.Warehouses.Find(groupId);
                _currentGroupId=house.Id;
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
                if (MessageBox.Show($"آیا مایل به حذف انبار  {nameHouse} می باشید","حذف",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var groupId = (int)dgList.SelectedRows[0].Cells[0].Value;
                    _context.Warehouses.Remove(_context.Warehouses.Find(groupId));
                    _context.SaveChanges();
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


    }
}
