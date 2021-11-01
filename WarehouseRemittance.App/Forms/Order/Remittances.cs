using System;
using System.Windows.Forms;

namespace WarehouseRemittance.App.Forms.Order
{
    public partial class Remittances : Form
    {
        public Remittances()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {            
            this.Close();            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmAddOrEdit().ShowDialog();
            
        }
    }
}
