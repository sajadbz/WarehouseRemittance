using System;
using System.Windows.Forms;
using WarehouseRemittance.App.Services;
using WarehouseRemittance.Core.Services;

namespace WarehouseRemittance.App.Forms
{
    public partial class frmProductGroups : Form
    {
        private readonly IProductGroupService _productGroup;
        private static int _currentGroupId = 0;

        public frmProductGroups(IProductGroupService productGroupService)
        {
            InitializeComponent();
            _productGroup = productGroupService;
        }

        private void frmProductGroups_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_currentGroupId == 0)
            {
                _productGroup.Add(txtName.Text);
            }
            else
            {
                _productGroup.Update(_currentGroupId, txtName.Text);
            }


            Clear();
            LoadGrid();
        }

        private void cmnEdit_Click(object sender, EventArgs e)
        {
            if (grdList.RowCount > 0)
            {
                var groupId =(int) grdList.SelectedRows[0].Cells[0].Value;
                var groupName = _productGroup.Find(groupId);

                txtName.Text = groupName.Name;
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
                    _productGroup.Delete(groupId);
                    Clear();
                    LoadGrid();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Custom Method
        private void LoadGrid()
        {
            grdList.AutoGenerateColumns = false;
            grdList.DataSource = _productGroup.GetAll();

            grdList.MouseDown += GeneralService.DataGridView_MouseDown;
        }
        private void Clear()
        {
            txtName.Text = "";
            btnSave.Text = "افزودن";
            groupBox1.Text = "افزودن گروه جدید";
            btnCancel.Visible = false;
            _currentGroupId = 0;
        }
        #endregion

    }
}
