
namespace WarehouseRemittance.App.Forms.Order
{
    partial class Remittances
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgOrder = new System.Windows.Forms.DataGridView();
            this.IdOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmRghitClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::WarehouseRemittance.App.Properties.Resources.Collapse3;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(202, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 77);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "خروج";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::WarehouseRemittance.App.Properties.Resources.Clipboard_Search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(293, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 77);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::WarehouseRemittance.App.Properties.Resources.Clipboard_Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(384, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 77);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::WarehouseRemittance.App.Properties.Resources.Clipboard_Edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(475, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 77);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::WarehouseRemittance.App.Properties.Resources.Clipboard_Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(566, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 77);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ثبت حواله ";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgOrder
            // 
            this.dgOrder.AllowUserToAddRows = false;
            this.dgOrder.AllowUserToDeleteRows = false;
            this.dgOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOrder,
            this.User,
            this.DataOrder,
            this.CountItems});
            this.dgOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrder.Location = new System.Drawing.Point(0, 94);
            this.dgOrder.MultiSelect = false;
            this.dgOrder.Name = "dgOrder";
            this.dgOrder.ReadOnly = true;
            this.dgOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgOrder.RowHeadersVisible = false;
            this.dgOrder.RowHeadersWidth = 51;
            this.dgOrder.RowTemplate.Height = 29;
            this.dgOrder.Size = new System.Drawing.Size(663, 314);
            this.dgOrder.TabIndex = 3;
            // 
            // IdOrder
            // 
            this.IdOrder.DataPropertyName = "OrderCode";
            this.IdOrder.HeaderText = "کد حواله";
            this.IdOrder.MinimumWidth = 6;
            this.IdOrder.Name = "IdOrder";
            this.IdOrder.ReadOnly = true;
            // 
            // User
            // 
            this.User.DataPropertyName = "UserFullName";
            this.User.HeaderText = "گیرنده حواله";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // DataOrder
            // 
            this.DataOrder.DataPropertyName = "CreateDate";
            this.DataOrder.HeaderText = "تاریخ حواله";
            this.DataOrder.MinimumWidth = 6;
            this.DataOrder.Name = "DataOrder";
            this.DataOrder.ReadOnly = true;
            // 
            // CountItems
            // 
            this.CountItems.DataPropertyName = "ProductCount";
            this.CountItems.HeaderText = "تعداد کالا";
            this.CountItems.MinimumWidth = 6;
            this.CountItems.Name = "CountItems";
            this.CountItems.ReadOnly = true;
            // 
            // cmRghitClick
            // 
            this.cmRghitClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmRghitClick.Name = "cmRghitClick";
            this.cmRghitClick.Size = new System.Drawing.Size(61, 4);
            // 
            // Remittances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 408);
            this.Controls.Add(this.dgOrder);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Remittances";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت حواله جات";
            this.Load += new System.EventHandler(this.Remittances_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgOrder;
        private System.Windows.Forms.ContextMenuStrip cmRghitClick;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountItems;
    }
}