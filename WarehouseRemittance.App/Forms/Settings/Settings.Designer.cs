
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::WarehouseRemittance.App.Properties.Resources.Collapse;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 100);
            this.button1.TabIndex = 2;
            this.button1.Text = "برگشت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = global::WarehouseRemittance.App.Properties.Resources.User_3;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 100);
            this.button2.TabIndex = 3;
            this.button2.Text = "گروه اشخاص";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = global::WarehouseRemittance.App.Properties.Resources.icons8_product_96;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(303, 100);
            this.button3.TabIndex = 4;
            this.button3.Text = "کالا";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 553);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}