namespace AzureConfigManager
{
    partial class FrmMultiSetting
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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.radioAppSetting = new System.Windows.Forms.RadioButton();
            this.radioConnectionString = new System.Windows.Forms.RadioButton();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.radioConnectionString);
            groupBox1.Controls.Add(this.radioAppSetting);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(207, 52);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // radioAppSetting
            // 
            this.radioAppSetting.AutoSize = true;
            this.radioAppSetting.Location = new System.Drawing.Point(6, 19);
            this.radioAppSetting.Name = "radioAppSetting";
            this.radioAppSetting.Size = new System.Drawing.Size(80, 17);
            this.radioAppSetting.TabIndex = 0;
            this.radioAppSetting.TabStop = true;
            this.radioAppSetting.Text = "App Setting";
            this.radioAppSetting.UseVisualStyleBackColor = true;
            // 
            // radioConnectionString
            // 
            this.radioConnectionString.AutoSize = true;
            this.radioConnectionString.Location = new System.Drawing.Point(92, 19);
            this.radioConnectionString.Name = "radioConnectionString";
            this.radioConnectionString.Size = new System.Drawing.Size(109, 17);
            this.radioConnectionString.TabIndex = 1;
            this.radioConnectionString.TabStop = true;
            this.radioConnectionString.Text = "Connection String";
            this.radioConnectionString.UseVisualStyleBackColor = true;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(52, 96);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(167, 20);
            this.txtValue.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(52, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 20);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 73);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 13);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 99);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 13);
            label2.TabIndex = 4;
            label2.Text = "Value:";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(144, 122);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Save";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // FrmMultiSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 162);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMultiSetting";
            this.Text = "Add Setting to Multiple Apps";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioConnectionString;
        private System.Windows.Forms.RadioButton radioAppSetting;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnGo;
    }
}