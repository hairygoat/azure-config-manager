namespace AzureConfigManager
{
    partial class FrmSettings
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.gridSubscriptions = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtTenantId = new System.Windows.Forms.TextBox();
            this.txtApiEndpoint = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtRedirectUri = new System.Windows.Forms.TextBox();
            this.SubscriptionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscriptionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubscriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(44, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 13);
            label1.TabIndex = 4;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(24, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 13);
            label2.TabIndex = 6;
            label2.Text = "Tenant Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 67);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 13);
            label3.TabIndex = 8;
            label3.Text = "Api Endpoint:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(32, 93);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(48, 13);
            label4.TabIndex = 10;
            label4.Text = "Client Id:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(14, 119);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(66, 13);
            label5.TabIndex = 12;
            label5.Text = "Redirect Uri:";
            // 
            // gridSubscriptions
            // 
            this.gridSubscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSubscriptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubscriptionId,
            this.SubscriptionName});
            this.gridSubscriptions.Location = new System.Drawing.Point(409, 12);
            this.gridSubscriptions.Name = "gridSubscriptions";
            this.gridSubscriptions.Size = new System.Drawing.Size(353, 124);
            this.gridSubscriptions.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(667, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(567, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 31);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(86, 12);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(317, 20);
            this.txtLogin.TabIndex = 3;
            // 
            // txtTenantId
            // 
            this.txtTenantId.Location = new System.Drawing.Point(86, 38);
            this.txtTenantId.Name = "txtTenantId";
            this.txtTenantId.Size = new System.Drawing.Size(317, 20);
            this.txtTenantId.TabIndex = 5;
            // 
            // txtApiEndpoint
            // 
            this.txtApiEndpoint.Location = new System.Drawing.Point(86, 64);
            this.txtApiEndpoint.Name = "txtApiEndpoint";
            this.txtApiEndpoint.Size = new System.Drawing.Size(317, 20);
            this.txtApiEndpoint.TabIndex = 7;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(86, 90);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(317, 20);
            this.txtClientId.TabIndex = 9;
            // 
            // txtRedirectUri
            // 
            this.txtRedirectUri.Location = new System.Drawing.Point(86, 116);
            this.txtRedirectUri.Name = "txtRedirectUri";
            this.txtRedirectUri.Size = new System.Drawing.Size(317, 20);
            this.txtRedirectUri.TabIndex = 11;
            // 
            // SubscriptionId
            // 
            this.SubscriptionId.HeaderText = "Subscription Id";
            this.SubscriptionId.Name = "SubscriptionId";
            // 
            // SubscriptionName
            // 
            this.SubscriptionName.HeaderText = "Name";
            this.SubscriptionName.Name = "SubscriptionName";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 189);
            this.Controls.Add(label5);
            this.Controls.Add(this.txtRedirectUri);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtApiEndpoint);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtTenantId);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gridSubscriptions);
            this.Name = "FrmSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSubscriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSubscriptions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtTenantId;
        private System.Windows.Forms.TextBox txtApiEndpoint;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtRedirectUri;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscriptionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscriptionName;
    }
}