using System;
using System.Threading.Tasks;
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
        private void Remittances_Load(object sender, EventArgs e)
        {
            Task.Run(LoadGrid);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = Program.ServiceProvider.GetService<frmOrderAddOrEdit>();
            frm.OrderId = 0;
            if (frm.ShowDialog() == DialogResult.OK)
                Task.Run(LoadGrid);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgOrder.RowCount > 0 && dgOrder.SelectedRows.Count == 1)
            {
                long orderId = (long) dgOrder.SelectedRows[0].Cells[0].Value;
                var frm = Program.ServiceProvider.GetService<frmOrderAddOrEdit>();
                frm.OrderId = orderId;
                if (frm.ShowDialog() == DialogResult.OK)
                    Task.Run(LoadGrid);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var taskDelete = Task.Run(() =>
            {
                _orderService.Delete(Convert.ToInt64(dgOrder.SelectedRows[0].Cells[0].Value));
            });
            taskDelete.ContinueWith((t, s) =>
            {
                Task.Run(LoadGrid);
            },null);

        }
        #region Custom Methods

        private async Task LoadGrid()
        {
            dgOrder.AutoGenerateColumns = false;
            dgOrder.DataSource = await _orderService.GetAllAsync();
        }
        #endregion
    }
}
