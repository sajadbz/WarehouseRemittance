
namespace WarehouseRemittance.App.Forms.Settings
{
    partial class Settings
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
            this.btnProductGroups = new System.Windows.Forms.Button();
            this.btnWarehouseGroups = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductGroups
            // 
            this.btnProductGroups.Image = global::WarehouseRemittance.App.Properties.Resources._3712193;
            this.btnProductGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductGroups.Location = new System.Drawing.Point(12, 13);
            this.btnProductGroups.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProductGroups.Name = "btnProductGroups";
            this.btnProductGroups.Size = new System.Drawing.Size(303, 100);
            this.btnProductGroups.TabIndex = 0;
            this.btnProductGroups.Text = "گروه محصولات";
            this.btnProductGroups.UseVisualStyleBackColor = true;
            this.btnProductGroups.Click += new System.EventHandler(this.btnProductGroups_Click);
            // 
            // btnWarehouseGroups
            // 
            this.btnWarehouseGroups.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWarehouseGroups.Image = global::WarehouseRemittance.App.Properties.Resources.icons8_warehouse_964;
            this.btnWarehouseGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWarehouseGroups.Location = new System.Drawing.Point(12, 120);
            this.btnWarehouseGroups.Name = "btnWarehouseGroups";
            this.btnWarehouseGroups.Size = new System.Drawing.Size(303, 100);
            this.btnWarehouseGroups.TabIndex = 1;
            this.btnWarehouseGroups.Text = "گروه انبارها";
            this.btnWarehouseGroups.UseVisualStyleBackColor = true;
            this.btnWarehouseGroups.Click += new System.EventHandler(this.btnWarehouseGroups_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Image = global::WarehouseRemittance.App.Properties.Resources.Collapse;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(12, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(303, 100);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "برگشت";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUsers.Image = global::WarehouseRemittance.App.Properties.Resources.User_3;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(12, 226);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(303, 100);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "گروه اشخاص";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProduct.Image = global::WarehouseRemittance.App.Properties.Resources.icons8_product_96;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(12, 332);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(303, 100);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "کالا";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 553);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWarehouseGroups);
            this.Controls.Add(this.btnProductGroups);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تنظیمات";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductGroups;
        private System.Windows.Forms.Button btnWarehouseGroups;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnProduct;
    }
}