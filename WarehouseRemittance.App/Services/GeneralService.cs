using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseRemittance.App.Services
{
    public class GeneralService
    {
        public static void DataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is DataGridView list && e.Button == MouseButtons.Right)
            {
                var hti = list.HitTest(e.X, e.Y);
                list.ClearSelection();
                list.Rows[hti.RowIndex].Selected = true;
            }
        }
    }
}
