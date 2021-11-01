using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseRemittance.App.Data.Context;
using WarehouseRemittance.App.Domain.Entities.Products;

namespace WarehouseRemittance.App.Forms
{
    public partial class frmProductGroups : Form
    {
        WarehouseRemittanceContext _context = new WarehouseRemittanceContext();
        private static int _currentGroupId = 0;
        public frmProductGroups()
        {
            InitializeComponent();
        }

        private void frmProductGroups_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            grdList.AutoGenerateColumns = false;
            grdList.DataSource = _context.ProductGroups.ToList();
        }
        private void Clear()
        {
            txtName.Text = "";
            btnSave.Text = "افزودن";
            groupBox1.Text = "افزودن گروه جدید";
            btnCancel.Visible = false;
            _currentGroupId = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_currentGroupId == 0)
            {
                ProductGroup group = new ProductGroup
                {
                    Name = txtName.Text
                };
                _context.ProductGroups.Add(group);
            }
            else
            {
                var group = _context.ProductGroups.Find(_currentGroupId);
                group.Name = txtName.Text;
                _context.ProductGroups.Update(group);
            }

            _context.SaveChanges();
            Clear();
            LoadGrid();
        }

        private void cmnEdit_Click(object sender, EventArgs e)
        {
            if (grdList.RowCount > 0)
            {
                var groupId = (int)grdList.SelectedRows[0].Cells[0].Value;
                var group = _context.ProductGroups.Find(groupId);
                txtName.Text = group.Name;
                _currentGroupId = group.Id;
                groupBox1.Text = btnSave.Text = "ویرایش";
                btnCancel.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmnDelete_Click(object sender, EventArgs e)
        {
            if (grdList.RowCount > 0)               
            {
                string Name = grdList.SelectedRows[0].Cells[1].Value.ToString();
                if (MessageBox.Show($"آیا گروه {Name} حذف کنم ؟", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    var groupId = (int)grdList.SelectedRows[0].Cells[0].Value;
                    _context.ProductGroups.Remove(_context.ProductGroups.Find(groupId));
                    _context.SaveChanges();
                    Clear();
                    LoadGrid();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
