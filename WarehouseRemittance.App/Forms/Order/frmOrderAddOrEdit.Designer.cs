namespace WarehouseRemittance.App.Forms.Order
{
    partial class frmOrderAddOrEdit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgListProducts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductCount = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkReceived = new System.Windows.Forms.CheckBox();
            this.chkSent = new System.Windows.Forms.CheckBox();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.dtCreateDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboWareHouse = new System.Windows.Forms.ComboBox();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListProducts)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgListProducts);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 573);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgListProducts
            // 
            this.dgListProducts.AllowUserToAddRows = false;
            this.dgListProducts.AllowUserToDeleteRows = false;
            this.dgListProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduct,
            this.NameProduct,
            this.Count});
            this.dgListProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListProducts.Location = new System.Drawing.Point(3, 126);
            this.dgListProducts.Name = "dgListProducts";
            this.dgListProducts.ReadOnly = true;
            this.dgListProducts.RowHeadersVisible = false;
            this.dgListProducts.RowHeadersWidth = 51;
            this.dgListProducts.RowTemplate.Height = 29;
            this.dgListProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListProducts.Size = new System.Drawing.Size(494, 333);
            this.dgListProducts.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtProductCount);
            this.panel2.Controls.Add(this.btnAddProduct);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cboProducts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 61);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "تعداد کالا :";
            // 
            // txtProductCount
            // 
            this.txtProductCount.Location = new System.Drawing.Point(113, 19);
            this.txtProductCount.Name = "txtProductCount";
            this.txtProductCount.Size = new System.Drawing.Size(93, 22);
            this.txtProductCount.TabIndex = 8;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Image = global::WarehouseRemittance.App.Properties.Resources.Save_2;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(7, 10);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(102, 39);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "افزودن";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "نام کالا :";
            // 
            // cboProducts
            // 
            this.cboProducts.DisplayMember = "Name";
            this.cboProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(279, 19);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(151, 22);
            this.cboProducts.TabIndex = 5;
            this.cboProducts.ValueMember = "Id";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnCansel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 520);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 50);
            this.panel3.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::WarehouseRemittance.App.Properties.Resources.Collapse1;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(6, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 40);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.Image = global::WarehouseRemittance.App.Properties.Resources.Save_2_Stop;
            this.btnCansel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCansel.Location = new System.Drawing.Point(167, 4);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(160, 40);
            this.btnCansel.TabIndex = 14;
            this.btnCansel.Text = "انصراف";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::WarehouseRemittance.App.Properties.Resources.Save_2;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(328, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 40);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkReceived);
            this.panel1.Controls.Add(this.chkSent);
            this.panel1.Controls.Add(this.cboUser);
            this.panel1.Controls.Add(this.dtCreateDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtOrderCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboWareHouse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 108);
            this.panel1.TabIndex = 0;
            // 
            // chkReceived
            // 
            this.chkReceived.AutoSize = true;
            this.chkReceived.Location = new System.Drawing.Point(47, 74);
            this.chkReceived.Name = "chkReceived";
            this.chkReceived.Size = new System.Drawing.Size(153, 18);
            this.chkReceived.TabIndex = 30;
            this.chkReceived.Text = "محصول تحویل شده است";
            this.chkReceived.UseVisualStyleBackColor = true;
            // 
            // chkSent
            // 
            this.chkSent.AutoSize = true;
            this.chkSent.Location = new System.Drawing.Point(273, 74);
            this.chkSent.Name = "chkSent";
            this.chkSent.Size = new System.Drawing.Size(156, 18);
            this.chkSent.TabIndex = 29;
            this.chkSent.Text = "محصول ارسال شده است";
            this.chkSent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSent.UseVisualStyleBackColor = true;
            // 
            // cboUser
            // 
            this.cboUser.DisplayMember = "Name";
            this.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(226, 5);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(160, 22);
            this.cboUser.TabIndex = 28;
            this.cboUser.ValueMember = "Id";
            // 
            // dtCreateDate
            // 
            this.dtCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCreateDate.Location = new System.Drawing.Point(7, 5);
            this.dtCreateDate.MinDate = new System.DateTime(2021, 11, 8, 0, 0, 0, 0);
            this.dtCreateDate.Name = "dtCreateDate";
            this.dtCreateDate.RightToLeftLayout = true;
            this.dtCreateDate.Size = new System.Drawing.Size(107, 22);
            this.dtCreateDate.TabIndex = 27;
            this.dtCreateDate.Value = new System.DateTime(2021, 11, 8, 21, 2, 45, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 26;
            this.label4.Text = "بنگاه :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 25;
            this.label3.Text = "تحویل گیرنده :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "شماره حواله :";
            // 
            // txtOrderCode
            // 
            this.txtOrderCode.Enabled = false;
            this.txtOrderCode.Location = new System.Drawing.Point(9, 35);
            this.txtOrderCode.Name = "txtOrderCode";
            this.txtOrderCode.Size = new System.Drawing.Size(107, 22);
            this.txtOrderCode.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "تاریخ :";
            // 
            // cboWareHouse
            // 
            this.cboWareHouse.DisplayMember = "Name";
            this.cboWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWareHouse.FormattingEnabled = true;
            this.cboWareHouse.Location = new System.Drawing.Point(226, 35);
            this.cboWareHouse.Name = "cboWareHouse";
            this.cboWareHouse.Size = new System.Drawing.Size(160, 22);
            this.cboWareHouse.TabIndex = 19;
            this.cboWareHouse.ValueMember = "Id";
            // 
            // IdProduct
            // 
            this.IdProduct.DataPropertyName = "ProductId";
            this.IdProduct.HeaderText = "کد محصول";
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.ReadOnly = true;
            // 
            // NameProduct
            // 
            this.NameProduct.DataPropertyName = "ProductName";
            this.NameProduct.HeaderText = "نام کالا";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "تعداد کارتن";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // frmOrderAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 573);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrderAddOrEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmAddOrEdit_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListProducts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgListProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboWareHouse;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.DateTimePicker dtCreateDate;
        private System.Windows.Forms.CheckBox chkReceived;
        private System.Windows.Forms.CheckBox chkSent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductCount;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}