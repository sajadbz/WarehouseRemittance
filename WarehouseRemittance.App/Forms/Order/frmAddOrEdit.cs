using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseRemittance.App.Applications.Extensions;
using WarehouseRemittance.App.Applications.Utility;

namespace WarehouseRemittance.App.Forms.Order
{
    public partial class frmAddOrEdit : Form
    {
        private int _currentId = 0;
        public frmAddOrEdit()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShamsi();
            if (_currentId == 0)
            {
                btnSave.Text = "ذخیره";
                groupBox1.Text = "افزودن حواله";
            }
            else
            {
                btnSave.Text = "ویرایش";
                groupBox1.Text = "ویرایش حواله";
            }
        }

    
    }
}
