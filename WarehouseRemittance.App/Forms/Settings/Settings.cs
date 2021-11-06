using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseRemittance.Core.Services;

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
            new frmProductGroups().ShowDialog();
        }

        private void btnWarehouseGroups_Click(object sender, EventArgs e)
        {
            new frmWarehouseGroups().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmUsers().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // new frmProduct(new ProductService(),new ProductGroupService()).ShowDialog();
            var frm = Program.ServiceProvider.GetService<frmProduct>();
            frm.ShowDialog();
        }
    }
}
