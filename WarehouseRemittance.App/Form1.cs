using System;
using System.Windows.Forms;
using WarehouseRemittance.App.Forms;
using WarehouseRemittance.App.Forms.Order;
using WarehouseRemittance.App.Forms.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace WarehouseRemittance.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemittance_Click(object sender, EventArgs e)
        {
            new Remittances().ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new Reports().ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            var frm = Program.ServiceProvider.GetService<Settings>();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
