namespace cookie_exporter
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.radioChrome = new System.Windows.Forms.RadioButton();
            this.radioFirefox = new System.Windows.Forms.RadioButton();
            this.groupBrowser = new System.Windows.Forms.GroupBox();
            this.groupExport = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtCookies = new System.Windows.Forms.TextBox();
            this.btnDeleteCookies = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtImport = new System.Windows.Forms.TextBox();
            this.groupBrowser.SuspendLayout();
            this.groupExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(7, 66);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(359, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // radioChrome
            // 
            this.radioChrome.AutoSize = true;
            this.radioChrome.Checked = true;
            this.radioChrome.Location = new System.Drawing.Point(85, 24);
            this.radioChrome.Name = "radioChrome";
            this.radioChrome.Size = new System.Drawing.Size(76, 23);
            this.radioChrome.TabIndex = 1;
            this.radioChrome.TabStop = true;
            this.radioChrome.Text = "Chrome";
            this.radioChrome.UseVisualStyleBackColor = true;
            // 
            // radioFirefox
            // 
            this.radioFirefox.AutoSize = true;
            this.radioFirefox.Location = new System.Drawing.Point(220, 24);
            this.radioFirefox.Name = "radioFirefox";
            this.radioFirefox.Size = new System.Drawing.Size(67, 23);
            this.radioFirefox.TabIndex = 2;
            this.radioFirefox.Text = "Firefox";
            this.radioFirefox.UseVisualStyleBackColor = true;
            // 
            // groupBrowser
            // 
            this.groupBrowser.Controls.Add(this.btnDeleteCookies);
            this.groupBrowser.Controls.Add(this.radioFirefox);
            this.groupBrowser.Controls.Add(this.btnStart);
            this.groupBrowser.Controls.Add(this.radioChrome);
            this.groupBrowser.Location = new System.Drawing.Point(12, 12);
            this.groupBrowser.Name = "groupBrowser";
            this.groupBrowser.Size = new System.Drawing.Size(373, 146);
            this.groupBrowser.TabIndex = 3;
            this.groupBrowser.TabStop = false;
            this.groupBrowser.Text = "Browser";
            // 
            // groupExport
            // 
            this.groupExport.Controls.Add(this.btnImport);
            this.groupExport.Controls.Add(this.txtImport);
            this.groupExport.Controls.Add(this.btnExport);
            this.groupExport.Controls.Add(this.txtCookies);
            this.groupExport.Enabled = false;
            this.groupExport.Location = new System.Drawing.Point(12, 164);
            this.groupExport.Name = "groupExport";
            this.groupExport.Size = new System.Drawing.Size(373, 99);
            this.groupExport.TabIndex = 4;
            this.groupExport.TabStop = false;
            this.groupExport.Text = "Import / Export";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(262, 57);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(104, 29);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtCookies
            // 
            this.txtCookies.Location = new System.Drawing.Point(16, 57);
            this.txtCookies.Name = "txtCookies";
            this.txtCookies.Size = new System.Drawing.Size(239, 26);
            this.txtCookies.TabIndex = 0;
            this.txtCookies.Text = "cookies.txt";
            // 
            // btnDeleteCookies
            // 
            this.btnDeleteCookies.Enabled = false;
            this.btnDeleteCookies.Location = new System.Drawing.Point(7, 104);
            this.btnDeleteCookies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteCookies.Name = "btnDeleteCookies";
            this.btnDeleteCookies.Size = new System.Drawing.Size(359, 34);
            this.btnDeleteCookies.TabIndex = 3;
            this.btnDeleteCookies.Text = "Delete all cookies";
            this.btnDeleteCookies.UseVisualStyleBackColor = true;
            this.btnDeleteCookies.Click += new System.EventHandler(this.btnDeleteCookies_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(262, 25);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(104, 29);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtImport
            // 
            this.txtImport.Location = new System.Drawing.Point(16, 25);
            this.txtImport.Name = "txtImport";
            this.txtImport.Size = new System.Drawing.Size(239, 26);
            this.txtImport.TabIndex = 4;
            this.txtImport.Text = "cookies.txt";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 273);
            this.Controls.Add(this.groupExport);
            this.Controls.Add(this.groupBrowser);
            this.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selenium cookie manager v0.1";
            this.groupBrowser.ResumeLayout(false);
            this.groupBrowser.PerformLayout();
            this.groupExport.ResumeLayout(false);
            this.groupExport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton radioChrome;
        private System.Windows.Forms.RadioButton radioFirefox;
        private System.Windows.Forms.GroupBox groupBrowser;
        private System.Windows.Forms.GroupBox groupExport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtCookies;
        private System.Windows.Forms.Button btnDeleteCookies;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtImport;
    }
}

