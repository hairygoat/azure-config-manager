namespace AzureConfigManager
{
    partial class FrmMain
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnLoadCredentials = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstApps = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.appSettingsGrid = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringsGrid = new System.Windows.Forms.DataGridView();
            this.ConnectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSql = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCommit = new System.Windows.Forms.Button();
            this.comboSubscription = new System.Windows.Forms.ComboBox();
            this.btnSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appSettingsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionStringsGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadCredentials
            // 
            this.btnLoadCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCredentials.Location = new System.Drawing.Point(12, 39);
            this.btnLoadCredentials.Name = "btnLoadCredentials";
            this.btnLoadCredentials.Size = new System.Drawing.Size(610, 29);
            this.btnLoadCredentials.TabIndex = 0;
            this.btnLoadCredentials.Text = "Connect";
            this.btnLoadCredentials.UseVisualStyleBackColor = true;
            this.btnLoadCredentials.Click += new System.EventHandler(this.BtnLoadCredentials_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 74);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstApps);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(610, 422);
            this.splitContainer1.SplitterDistance = 125;
            this.splitContainer1.TabIndex = 1;
            // 
            // lstApps
            // 
            this.lstApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstApps.FormattingEnabled = true;
            this.lstApps.Location = new System.Drawing.Point(0, 0);
            this.lstApps.Name = "lstApps";
            this.lstApps.Size = new System.Drawing.Size(125, 422);
            this.lstApps.TabIndex = 0;
            this.lstApps.SelectedIndexChanged += new System.EventHandler(this.LstApps_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.appSettingsGrid);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.connectionStringsGrid);
            this.splitContainer2.Size = new System.Drawing.Size(481, 422);
            this.splitContainer2.SplitterDistance = 285;
            this.splitContainer2.TabIndex = 0;
            // 
            // appSettingsGrid
            // 
            this.appSettingsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.appSettingsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appSettingsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.appSettingsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appSettingsGrid.Location = new System.Drawing.Point(0, 0);
            this.appSettingsGrid.Name = "appSettingsGrid";
            this.appSettingsGrid.Size = new System.Drawing.Size(481, 285);
            this.appSettingsGrid.TabIndex = 0;
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            this.Key.Width = 50;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 59;
            // 
            // connectionStringsGrid
            // 
            this.connectionStringsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.connectionStringsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionStringsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConnectionName,
            this.ConnectionString,
            this.IsSql});
            this.connectionStringsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionStringsGrid.Location = new System.Drawing.Point(0, 0);
            this.connectionStringsGrid.Name = "connectionStringsGrid";
            this.connectionStringsGrid.Size = new System.Drawing.Size(481, 133);
            this.connectionStringsGrid.TabIndex = 0;
            // 
            // ConnectionName
            // 
            this.ConnectionName.HeaderText = "Name";
            this.ConnectionName.Name = "ConnectionName";
            this.ConnectionName.Width = 60;
            // 
            // ConnectionString
            // 
            this.ConnectionString.HeaderText = "ConnectionString";
            this.ConnectionString.Name = "ConnectionString";
            this.ConnectionString.Width = 113;
            // 
            // IsSql
            // 
            this.IsSql.HeaderText = "Is SQL?";
            this.IsSql.Name = "IsSql";
            this.IsSql.Width = 51;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(634, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // btnCommit
            // 
            this.btnCommit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommit.Location = new System.Drawing.Point(12, 502);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(610, 23);
            this.btnCommit.TabIndex = 3;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.BtnCommit_Click);
            // 
            // comboSubscription
            // 
            this.comboSubscription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSubscription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSubscription.FormattingEnabled = true;
            this.comboSubscription.Location = new System.Drawing.Point(12, 12);
            this.comboSubscription.Name = "comboSubscription";
            this.comboSubscription.Size = new System.Drawing.Size(572, 21);
            this.comboSubscription.TabIndex = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(590, 10);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(32, 23);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "...";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 553);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.comboSubscription);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnLoadCredentials);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Azure Config Viewer";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appSettingsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionStringsGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadCredentials;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstApps;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView appSettingsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridView connectionStringsGrid;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.ComboBox comboSubscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionString;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSql;
        private System.Windows.Forms.Button btnSettings;
    }
}

