namespace AzureConfigManager
{
    partial class FrmConfigXml
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.txtAppSettings = new System.Windows.Forms.TextBox();
            this.txtConnectionStrings = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 13);
            label1.TabIndex = 2;
            label1.Text = "<appSettings>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 139);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 13);
            label2.TabIndex = 3;
            label2.Text = "<connectionStrings>";
            // 
            // txtAppSettings
            // 
            this.txtAppSettings.Location = new System.Drawing.Point(12, 26);
            this.txtAppSettings.Multiline = true;
            this.txtAppSettings.Name = "txtAppSettings";
            this.txtAppSettings.Size = new System.Drawing.Size(260, 107);
            this.txtAppSettings.TabIndex = 0;
            this.txtAppSettings.Click += new System.EventHandler(this.txtAppSettings_Click);
            // 
            // txtConnectionStrings
            // 
            this.txtConnectionStrings.Location = new System.Drawing.Point(12, 155);
            this.txtConnectionStrings.Multiline = true;
            this.txtConnectionStrings.Name = "txtConnectionStrings";
            this.txtConnectionStrings.Size = new System.Drawing.Size(260, 94);
            this.txtConnectionStrings.TabIndex = 1;
            this.txtConnectionStrings.Click += new System.EventHandler(this.txtConnectionStrings_Click);
            // 
            // FrmConfigXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtConnectionStrings);
            this.Controls.Add(this.txtAppSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfigXml";
            this.Text = "Web.config Xml";
            this.Load += new System.EventHandler(this.FrmConfigXml_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAppSettings;
        private System.Windows.Forms.TextBox txtConnectionStrings;
    }
}