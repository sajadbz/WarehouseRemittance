using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace WarehouseRemittance.App.Forms.Settings
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }


        private void btnProductGroups_Click(object sender, EventArgs e)
        {
            var frm = Program.ServiceProvider.GetService<frmProductGroups>();
            frm.ShowDialog();
        }

        private void btnWarehouseGroups_Click(object sender, EventArgs e)
        {
            var frm = Program.ServiceProvider.GetService<frmWarehouseGroups>();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var frm = Program.ServiceProvider.GetService<frmUsers>();
            frm.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            var frm = Program.ServiceProvider.GetService<frmProduct>();
            frm.ShowDialog();
        }

    }
}
