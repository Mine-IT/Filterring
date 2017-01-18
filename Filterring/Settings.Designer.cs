namespace Filterring
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Log_rbox = new System.Windows.Forms.RichTextBox();
            this.LogClear_btn = new System.Windows.Forms.Button();
            this.LogLoad_btn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UserPassword_tb = new System.Windows.Forms.TextBox();
            this.AdminPassword_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Disable_btn = new System.Windows.Forms.Button();
            this.Enable_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1355, 829);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1347, 803);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Log_rbox);
            this.panel1.Controls.Add(this.LogClear_btn);
            this.panel1.Controls.Add(this.LogLoad_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 797);
            this.panel1.TabIndex = 0;
            // 
            // Log_rbox
            // 
            this.Log_rbox.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Log_rbox.Location = new System.Drawing.Point(0, 117);
            this.Log_rbox.Name = "Log_rbox";
            this.Log_rbox.ReadOnly = true;
            this.Log_rbox.Size = new System.Drawing.Size(1338, 677);
            this.Log_rbox.TabIndex = 3;
            this.Log_rbox.Text = "";
            // 
            // LogClear_btn
            // 
            this.LogClear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogClear_btn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LogClear_btn.Location = new System.Drawing.Point(116, 44);
            this.LogClear_btn.Name = "LogClear_btn";
            this.LogClear_btn.Size = new System.Drawing.Size(96, 53);
            this.LogClear_btn.TabIndex = 2;
            this.LogClear_btn.Text = "Clear";
            this.LogClear_btn.UseVisualStyleBackColor = true;
            this.LogClear_btn.Click += new System.EventHandler(this.LogClear_btn_Click);
            // 
            // LogLoad_btn
            // 
            this.LogLoad_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogLoad_btn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LogLoad_btn.Location = new System.Drawing.Point(9, 44);
            this.LogLoad_btn.Name = "LogLoad_btn";
            this.LogLoad_btn.Size = new System.Drawing.Size(96, 53);
            this.LogLoad_btn.TabIndex = 1;
            this.LogLoad_btn.Text = "Load";
            this.LogLoad_btn.UseVisualStyleBackColor = true;
            this.LogLoad_btn.Click += new System.EventHandler(this.LogLoad_btn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1347, 803);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Authentication";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.799403F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.2006F));
            this.tableLayoutPanel1.Controls.Add(this.UserPassword_tb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AdminPassword_tb, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.99083F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.00917F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 516F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1341, 797);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UserPassword_tb
            // 
            this.UserPassword_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserPassword_tb.Location = new System.Drawing.Point(120, 197);
            this.UserPassword_tb.Name = "UserPassword_tb";
            this.UserPassword_tb.Size = new System.Drawing.Size(1218, 19);
            this.UserPassword_tb.TabIndex = 0;
            // 
            // AdminPassword_tb
            // 
            this.AdminPassword_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPassword_tb.Location = new System.Drawing.Point(120, 260);
            this.AdminPassword_tb.Name = "AdminPassword_tb";
            this.AdminPassword_tb.Size = new System.Drawing.Size(1218, 19);
            this.AdminPassword_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "User password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin password";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Disable_btn);
            this.panel2.Controls.Add(this.Enable_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(120, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 511);
            this.panel2.TabIndex = 4;
            // 
            // Disable_btn
            // 
            this.Disable_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Disable_btn.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Disable_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Disable_btn.Location = new System.Drawing.Point(226, 72);
            this.Disable_btn.Name = "Disable_btn";
            this.Disable_btn.Size = new System.Drawing.Size(105, 85);
            this.Disable_btn.TabIndex = 1;
            this.Disable_btn.Text = "Disable";
            this.Disable_btn.UseVisualStyleBackColor = true;
            this.Disable_btn.Click += new System.EventHandler(this.Disable_btn_Click);
            // 
            // Enable_btn
            // 
            this.Enable_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enable_btn.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Enable_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Enable_btn.Location = new System.Drawing.Point(79, 72);
            this.Enable_btn.Name = "Enable_btn";
            this.Enable_btn.Size = new System.Drawing.Size(105, 85);
            this.Enable_btn.TabIndex = 0;
            this.Enable_btn.Text = "Enable";
            this.Enable_btn.UseVisualStyleBackColor = true;
            this.Enable_btn.Click += new System.EventHandler(this.Enable_btn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 829);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox UserPassword_tb;
        private System.Windows.Forms.TextBox AdminPassword_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LogClear_btn;
        private System.Windows.Forms.Button LogLoad_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Disable_btn;
        private System.Windows.Forms.Button Enable_btn;
        private System.Windows.Forms.RichTextBox Log_rbox;
    }
}