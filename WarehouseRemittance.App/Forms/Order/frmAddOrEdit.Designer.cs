namespace WarehouseRemittance.App.Forms.Order
{
    partial class frmAddOrEdit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.txtNameUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cbWareHouse = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(489, 358);
            this.dataGridView1.TabIndex = 4;
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNameUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIdOrder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.cbWareHouse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 79);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "بنگاه :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "تحویل گیرنده :";
            // 
            // txtNameUser
            // 
            this.txtNameUser.Location = new System.Drawing.Point(221, 8);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(156, 26);
            this.txtNameUser.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "شماره حواله :";
            // 
            // txtIdOrder
            // 
            this.txtIdOrder.Location = new System.Drawing.Point(3, 40);
            this.txtIdOrder.Name = "txtIdOrder";
            this.txtIdOrder.Size = new System.Drawing.Size(90, 26);
            this.txtIdOrder.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "تاریخ :";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(3, 8);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(90, 26);
            this.txtDate.TabIndex = 20;
            // 
            // cbWareHouse
            // 
            this.cbWareHouse.FormattingEnabled = true;
            this.cbWareHouse.Location = new System.Drawing.Point(221, 40);
            this.cbWareHouse.Name = "cbWareHouse";
            this.cbWareHouse.Size = new System.Drawing.Size(206, 26);
            this.cbWareHouse.TabIndex = 19;
            // 
            // frmAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 573);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddOrEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmAddOrEdit_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cbWareHouse;
    }
}