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
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelItem = new System.Windows.Forms.Button();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboWareHouse = new System.Windows.Forms.ComboBox();
            this.dtCreateDate = new System.Windows.Forms.DateTimePicker();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.chkSent = new System.Windows.Forms.CheckBox();
            this.chkReceived = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdProducts);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 573);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // grdProducts
            // 
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProducts.Location = new System.Drawing.Point(3, 126);
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.RowHeadersWidth = 51;
            this.grdProducts.RowTemplate.Height = 29;
            this.grdProducts.Size = new System.Drawing.Size(489, 333);
            this.grdProducts.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelItem);
            this.panel2.Controls.Add(this.btnNewItem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 61);
            this.panel2.TabIndex = 3;
            // 
            // btnDelItem
            // 
            this.btnDelItem.Image = global::WarehouseRemittance.App.Properties.Resources.cancel_480px;
            this.btnDelItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelItem.Location = new System.Drawing.Point(286, 3);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.Size = new System.Drawing.Size(100, 52);
            this.btnDelItem.TabIndex = 15;
            this.btnDelItem.Text = "حذف کالا";
            this.btnDelItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelItem.UseVisualStyleBackColor = true;
            // 
            // btnNewItem
            // 
            this.btnNewItem.Image = global::WarehouseRemittance.App.Properties.Resources.plus___480px;
            this.btnNewItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewItem.Location = new System.Drawing.Point(386, 3);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(100, 52);
            this.btnNewItem.TabIndex = 14;
            this.btnNewItem.Text = "کالا جدید";
            this.btnNewItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewItem.UseVisualStyleBackColor = true;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
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
            this.panel3.Size = new System.Drawing.Size(489, 50);
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
            this.panel1.Size = new System.Drawing.Size(489, 108);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 26;
            this.label4.Text = "بنگاه :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 25;
            this.label3.Text = "تحویل گیرنده :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "شماره حواله :";
            // 
            // txtOrderCode
            // 
            this.txtOrderCode.Enabled = false;
            this.txtOrderCode.Location = new System.Drawing.Point(7, 40);
            this.txtOrderCode.Name = "txtOrderCode";
            this.txtOrderCode.Size = new System.Drawing.Size(139, 22);
            this.txtOrderCode.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 11);
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
            this.cboWareHouse.Location = new System.Drawing.Point(236, 40);
            this.cboWareHouse.Name = "cboWareHouse";
            this.cboWareHouse.Size = new System.Drawing.Size(191, 22);
            this.cboWareHouse.TabIndex = 19;
            this.cboWareHouse.ValueMember = "Id";
            // 
            // dtCreateDate
            // 
            this.dtCreateDate.Location = new System.Drawing.Point(7, 8);
            this.dtCreateDate.Name = "dtCreateDate";
            this.dtCreateDate.Size = new System.Drawing.Size(180, 22);
            this.dtCreateDate.TabIndex = 27;
            // 
            // cboUser
            // 
            this.cboUser.DisplayMember = "Name";
            this.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(236, 11);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(160, 22);
            this.cboUser.TabIndex = 28;
            this.cboUser.ValueMember = "Id";
            // 
            // chkSent
            // 
            this.chkSent.AutoSize = true;
            this.chkSent.Location = new System.Drawing.Point(324, 74);
            this.chkSent.Name = "chkSent";
            this.chkSent.Size = new System.Drawing.Size(156, 18);
            this.chkSent.TabIndex = 29;
            this.chkSent.Text = "محصول ارسال شده است";
            this.chkSent.UseVisualStyleBackColor = true;
            // 
            // chkReceived
            // 
            this.chkReceived.AutoSize = true;
            this.chkReceived.Location = new System.Drawing.Point(162, 74);
            this.chkReceived.Name = "chkReceived";
            this.chkReceived.Size = new System.Drawing.Size(153, 18);
            this.chkReceived.TabIndex = 30;
            this.chkReceived.Text = "محصول تحویل شده است";
            this.chkReceived.UseVisualStyleBackColor = true;
            // 
            // frmOrderAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 573);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnDelItem;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.DataGridView grdProducts;
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
    }
}