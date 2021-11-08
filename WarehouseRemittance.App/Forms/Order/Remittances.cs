using System;
using System.Windows.Forms;
using WarehouseRemittance.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace WarehouseRemittance.App.Forms.Order
{
    public partial class Remittances : Form
    {
        private readonly IOrderService _orderService;
        public Remittances(IOrderService orderService)
        {
            InitializeComponent();
            _orderService = orderService;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {            
            this.Close();            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
            var frm = Program.ServiceProvider.GetService<frmOrderAddOrEdit>();
            if(frm.ShowDialog() == DialogResult.OK)
                LoadGrid(); 

        }

        private void Remittances_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            dgOrder.AutoGenerateColumns = false;
            dgOrder.DataSource = _orderService.GetAll();
        }
    }
}
