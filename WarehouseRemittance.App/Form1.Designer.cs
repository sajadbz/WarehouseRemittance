
namespace WarehouseRemittance.App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRemittance = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemittance
            // 
            this.btnRemittance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemittance.Image = global::WarehouseRemittance.App.Properties.Resources.Clipboard;
            this.btnRemittance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemittance.Location = new System.Drawing.Point(13, 12);
            this.btnRemittance.Name = "btnRemittance";
            this.btnRemittance.Size = new System.Drawing.Size(254, 85);
            this.btnRemittance.TabIndex = 0;
            this.btnRemittance.Text = "حواله ها";
            this.btnRemittance.UseVisualStyleBackColor = false;
            this.btnRemittance.Click += new System.EventHandler(this.btnRemittance_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReport.Image = global::WarehouseRemittance.App.Properties.Resources.Report;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(13, 103);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(254, 85);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "گزارشات";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSetting.Image = global::WarehouseRemittance.App.Properties.Resources.Symbol_Configuration_2;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(13, 194);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(254, 85);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "تنظیمات";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::WarehouseRemittance.App.Properties.Resources.Window;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 85);
            this.button1.TabIndex = 3;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRemittance);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remittance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemittance;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button button1;
    }
}

