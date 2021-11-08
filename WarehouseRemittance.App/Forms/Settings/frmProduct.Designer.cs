namespace WarehouseRemittance.App.Forms.Settings
{
    partial class frmProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProductGroups = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnSaveOrEdit = new System.Windows.Forms.Button();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProductNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGroupProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.cmRightClick.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbProductGroups);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن کالا";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "گروه کالا :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(310, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 27);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام کالا :";
            // 
            // cbProductGroups
            // 
            this.cbProductGroups.DisplayMember = "Name";
            this.cbProductGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductGroups.FormattingEnabled = true;
            this.cbProductGroups.Location = new System.Drawing.Point(11, 59);
            this.cbProductGroups.Name = "cbProductGroups";
            this.cbProductGroups.Size = new System.Drawing.Size(291, 28);
            this.cbProductGroups.TabIndex = 0;
            this.cbProductGroups.ValueMember = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnCansel);
            this.groupBox2.Controls.Add(this.btnSaveOrEdit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 444);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 67);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::WarehouseRemittance.App.Properties.Resources.Collapse1;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(6, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 45);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.Image = global::WarehouseRemittance.App.Properties.Resources.Save_2_Stop;
            this.btnCansel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCansel.Location = new System.Drawing.Point(171, 15);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(160, 45);
            this.btnCansel.TabIndex = 12;
            this.btnCansel.Text = "انصراف";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Visible = false;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // btnSaveOrEdit
            // 
            this.btnSaveOrEdit.Image = global::WarehouseRemittance.App.Properties.Resources.Save_2;
            this.btnSaveOrEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveOrEdit.Location = new System.Drawing.Point(338, 15);
            this.btnSaveOrEdit.Name = "btnSaveOrEdit";
            this.btnSaveOrEdit.Size = new System.Drawing.Size(160, 45);
            this.btnSaveOrEdit.TabIndex = 11;
            this.btnSaveOrEdit.Text = "ثبت";
            this.btnSaveOrEdit.UseVisualStyleBackColor = true;
            this.btnSaveOrEdit.Click += new System.EventHandler(this.btnSaveOrEdit_Click);
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduct,
            this.NameProduct,
            this.IdProductNumber,
            this.IdGroupProduct});
            this.dgList.ContextMenuStrip = this.cmRightClick;
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.Location = new System.Drawing.Point(0, 71);
            this.dgList.MultiSelect = false;
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowHeadersVisible = false;
            this.dgList.RowHeadersWidth = 51;
            this.dgList.RowTemplate.Height = 29;
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size(505, 261);
            this.dgList.TabIndex = 0;
            // 
            // IdProduct
            // 
            this.IdProduct.DataPropertyName = "Id";
            this.IdProduct.FillWeight = 40F;
            this.IdProduct.HeaderText = "کد";
            this.IdProduct.MinimumWidth = 6;
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.ReadOnly = true;
            // 
            // NameProduct
            // 
            this.NameProduct.DataPropertyName = "Name";
            this.NameProduct.FillWeight = 60F;
            this.NameProduct.HeaderText = "نام کالا";
            this.NameProduct.MinimumWidth = 6;
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // IdProductNumber
            // 
            this.IdProductNumber.DataPropertyName = "NumberItem";
            this.IdProductNumber.FillWeight = 50F;
            this.IdProductNumber.HeaderText = "کد کالا";
            this.IdProductNumber.MinimumWidth = 6;
            this.IdProductNumber.Name = "IdProductNumber";
            this.IdProductNumber.ReadOnly = true;
            // 
            // IdGroupProduct
            // 
            this.IdGroupProduct.DataPropertyName = "GroupName";
            this.IdGroupProduct.FillWeight = 80.04716F;
            this.IdGroupProduct.HeaderText = "نام گروه کالا";
            this.IdGroupProduct.MinimumWidth = 6;
            this.IdGroupProduct.Name = "IdGroupProduct";
            this.IdGroupProduct.ReadOnly = true;
            // 
            // cmRightClick
            // 
            this.cmRightClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmEdit,
            this.cmDelete});
            this.cmRightClick.Name = "cmRightClick";
            this.cmRightClick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmRightClick.Size = new System.Drawing.Size(125, 52);
            // 
            // cmEdit
            // 
            this.cmEdit.Name = "cmEdit";
            this.cmEdit.Size = new System.Drawing.Size(124, 24);
            this.cmEdit.Text = "ویرایش";
            this.cmEdit.Click += new System.EventHandler(this.cmEdit_Click);
            // 
            // cmDelete
            // 
            this.cmDelete.Name = "cmDelete";
            this.cmDelete.Size = new System.Drawing.Size(124, 24);
            this.cmDelete.Text = "حذف";
            this.cmDelete.Click += new System.EventHandler(this.cmDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(505, 71);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(11, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(421, 27);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "جستجو :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 511);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت کالا";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.cmRightClick.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnSaveOrEdit;
        private System.Windows.Forms.ContextMenuStrip cmRightClick;
        private System.Windows.Forms.ToolStripMenuItem cmEdit;
        private System.Windows.Forms.ToolStripMenuItem cmDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProductGroups;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProductNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGroupProduct;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}