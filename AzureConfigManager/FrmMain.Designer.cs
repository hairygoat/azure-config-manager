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
            System.Windows.Forms.TabControl tabControl1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLoadWebApps = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnWebConfig = new System.Windows.Forms.Button();
            this.btnCustomErrorAudit = new System.Windows.Forms.Button();
            this.btnCustomErrors = new System.Windows.Forms.Button();
            this.btnUptime = new System.Windows.Forms.Button();
            this.btnFilezilla = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.appSettingsGrid = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringsGrid = new System.Windows.Forms.DataGridView();
            this.ConnectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSql = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCommit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLoadVMs = new System.Windows.Forms.Button();
            this.lstVMs = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboSubscription = new System.Windows.Forms.ComboBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lstApps = new System.Windows.Forms.ListBox();
            this.btnAddMultipleSetting = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tabControl1.Controls.Add(this.tabPage1);
            tabControl1.Controls.Add(this.tabPage2);
            tabControl1.Location = new System.Drawing.Point(12, 39);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(698, 494);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLoadWebApps);
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.btnCommit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(690, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Web Apps";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLoadWebApps
            // 
            this.btnLoadWebApps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadWebApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadWebApps.Location = new System.Drawing.Point(6, 6);
            this.btnLoadWebApps.Name = "btnLoadWebApps";
            this.btnLoadWebApps.Size = new System.Drawing.Size(675, 29);
            this.btnLoadWebApps.TabIndex = 0;
            this.btnLoadWebApps.Text = "Refresh";
            this.btnLoadWebApps.UseVisualStyleBackColor = true;
            this.btnLoadWebApps.Click += new System.EventHandler(this.BtnLoadCredentials_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 41);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAddMultipleSetting);
            this.splitContainer1.Panel1.Controls.Add(this.btnWebConfig);
            this.splitContainer1.Panel1.Controls.Add(this.btnCustomErrorAudit);
            this.splitContainer1.Panel1.Controls.Add(this.btnCustomErrors);
            this.splitContainer1.Panel1.Controls.Add(this.btnUptime);
            this.splitContainer1.Panel1.Controls.Add(this.btnFilezilla);
            this.splitContainer1.Panel1.Controls.Add(this.lstApps);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(675, 392);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnWebConfig
            // 
            this.btnWebConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWebConfig.Location = new System.Drawing.Point(0, 270);
            this.btnWebConfig.Name = "btnWebConfig";
            this.btnWebConfig.Size = new System.Drawing.Size(137, 23);
            this.btnWebConfig.TabIndex = 4;
            this.btnWebConfig.Text = "Web.config XML";
            this.btnWebConfig.UseVisualStyleBackColor = true;
            this.btnWebConfig.Click += new System.EventHandler(this.btnWebConfig_Click);
            // 
            // btnCustomErrorAudit
            // 
            this.btnCustomErrorAudit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomErrorAudit.Location = new System.Drawing.Point(0, 295);
            this.btnCustomErrorAudit.Name = "btnCustomErrorAudit";
            this.btnCustomErrorAudit.Size = new System.Drawing.Size(137, 23);
            this.btnCustomErrorAudit.TabIndex = 3;
            this.btnCustomErrorAudit.Text = "Audit customErrors";
            this.btnCustomErrorAudit.UseVisualStyleBackColor = true;
            this.btnCustomErrorAudit.Click += new System.EventHandler(this.btnCustomErrorAudit_Click);
            // 
            // btnCustomErrors
            // 
            this.btnCustomErrors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomErrors.Location = new System.Drawing.Point(0, 319);
            this.btnCustomErrors.Name = "btnCustomErrors";
            this.btnCustomErrors.Size = new System.Drawing.Size(137, 23);
            this.btnCustomErrors.TabIndex = 2;
            this.btnCustomErrors.Text = "customErrors";
            this.btnCustomErrors.UseVisualStyleBackColor = true;
            this.btnCustomErrors.Click += new System.EventHandler(this.btnCustomErrors_Click);
            // 
            // btnUptime
            // 
            this.btnUptime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUptime.Location = new System.Drawing.Point(0, 343);
            this.btnUptime.Name = "btnUptime";
            this.btnUptime.Size = new System.Drawing.Size(137, 23);
            this.btnUptime.TabIndex = 1;
            this.btnUptime.Text = "Uptime";
            this.btnUptime.UseVisualStyleBackColor = true;
            this.btnUptime.Click += new System.EventHandler(this.btnUptime_Click);
            // 
            // btnFilezilla
            // 
            this.btnFilezilla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilezilla.Location = new System.Drawing.Point(0, 367);
            this.btnFilezilla.Name = "btnFilezilla";
            this.btnFilezilla.Size = new System.Drawing.Size(137, 22);
            this.btnFilezilla.TabIndex = 1;
            this.btnFilezilla.Text = "Open in Filezilla";
            this.btnFilezilla.UseVisualStyleBackColor = true;
            this.btnFilezilla.Click += new System.EventHandler(this.btnFilezilla_Click);
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
            this.splitContainer2.Size = new System.Drawing.Size(534, 392);
            this.splitContainer2.SplitterDistance = 263;
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
            this.appSettingsGrid.Size = new System.Drawing.Size(534, 263);
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
            this.connectionStringsGrid.Size = new System.Drawing.Size(534, 125);
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
            // btnCommit
            // 
            this.btnCommit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommit.Location = new System.Drawing.Point(6, 439);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(675, 23);
            this.btnCommit.TabIndex = 3;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.BtnCommit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLoadVMs);
            this.tabPage2.Controls.Add(this.lstVMs);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(690, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Virtual Machines";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLoadVMs
            // 
            this.btnLoadVMs.Location = new System.Drawing.Point(6, 6);
            this.btnLoadVMs.Name = "btnLoadVMs";
            this.btnLoadVMs.Size = new System.Drawing.Size(480, 31);
            this.btnLoadVMs.TabIndex = 1;
            this.btnLoadVMs.Text = "Refresh";
            this.btnLoadVMs.UseVisualStyleBackColor = true;
            this.btnLoadVMs.Click += new System.EventHandler(this.btnLoadVMs_Click);
            // 
            // lstVMs
            // 
            this.lstVMs.FormattingEnabled = true;
            this.lstVMs.Location = new System.Drawing.Point(6, 43);
            this.lstVMs.Name = "lstVMs";
            this.lstVMs.Size = new System.Drawing.Size(217, 394);
            this.lstVMs.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(722, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // comboSubscription
            // 
            this.comboSubscription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSubscription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSubscription.FormattingEnabled = true;
            this.comboSubscription.Location = new System.Drawing.Point(12, 12);
            this.comboSubscription.Name = "comboSubscription";
            this.comboSubscription.Size = new System.Drawing.Size(660, 21);
            this.comboSubscription.TabIndex = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Location = new System.Drawing.Point(678, 10);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(32, 23);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "...";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lstApps
            // 
            this.lstApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstApps.FormattingEnabled = true;
            this.lstApps.Location = new System.Drawing.Point(0, 0);
            this.lstApps.Name = "lstApps";
            this.lstApps.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstApps.Size = new System.Drawing.Size(137, 238);
            this.lstApps.TabIndex = 0;
            this.lstApps.SelectedIndexChanged += new System.EventHandler(this.LstApps_SelectedIndexChanged);
            // 
            // btnAddMultipleSetting
            // 
            this.btnAddMultipleSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMultipleSetting.Location = new System.Drawing.Point(0, 244);
            this.btnAddMultipleSetting.Name = "btnAddMultipleSetting";
            this.btnAddMultipleSetting.Size = new System.Drawing.Size(137, 23);
            this.btnAddMultipleSetting.TabIndex = 5;
            this.btnAddMultipleSetting.Text = "Add setting to multiple";
            this.btnAddMultipleSetting.UseVisualStyleBackColor = true;
            this.btnAddMultipleSetting.Click += new System.EventHandler(this.btnAddMultipleSetting_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 558);
            this.Controls.Add(tabControl1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.comboSubscription);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Azure Config Viewer";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
            this.tabPage2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadWebApps;
        private System.Windows.Forms.SplitContainer splitContainer1;
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
        private System.Windows.Forms.Button btnFilezilla;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstVMs;
        private System.Windows.Forms.Button btnLoadVMs;
        private System.Windows.Forms.Button btnUptime;
        private System.Windows.Forms.Button btnCustomErrors;
        private System.Windows.Forms.Button btnCustomErrorAudit;
        private System.Windows.Forms.Button btnWebConfig;
        private System.Windows.Forms.ListBox lstApps;
        private System.Windows.Forms.Button btnAddMultipleSetting;
    }
}

