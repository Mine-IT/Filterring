namespace Filterring
{
    partial class InputDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_btn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Read_tb = new System.Windows.Forms.TextBox();
            this.Title_lb = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.635649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.36435F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1336, 763);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Title_lb);
            this.panel1.Controls.Add(this.Close_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 37);
            this.panel1.TabIndex = 0;
            // 
            // Close_btn
            // 
            this.Close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_btn.AutoSize = true;
            this.Close_btn.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Close_btn.ForeColor = System.Drawing.Color.Red;
            this.Close_btn.Location = new System.Drawing.Point(1282, 6);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(39, 27);
            this.Close_btn.TabIndex = 0;
            this.Close_btn.Text = "×";
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Read_tb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1330, 714);
            this.panel2.TabIndex = 1;
            // 
            // Read_tb
            // 
            this.Read_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Read_tb.BackColor = System.Drawing.Color.DarkGray;
            this.Read_tb.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Read_tb.Location = new System.Drawing.Point(3, 247);
            this.Read_tb.Multiline = true;
            this.Read_tb.Name = "Read_tb";
            this.Read_tb.Size = new System.Drawing.Size(1324, 40);
            this.Read_tb.TabIndex = 0;
            this.Read_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Read_tb_KeyPress);
            // 
            // Title_lb
            // 
            this.Title_lb.AutoSize = true;
            this.Title_lb.Font = new System.Drawing.Font("Meiryo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title_lb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title_lb.Location = new System.Drawing.Point(8, 8);
            this.Title_lb.Name = "Title_lb";
            this.Title_lb.Size = new System.Drawing.Size(0, 31);
            this.Title_lb.TabIndex = 1;
            // 
            // InputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1336, 763);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputDialog";
            this.Opacity = 0.8D;
            this.Text = "InputDialog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputDialog_FormClosing);
            this.Load += new System.EventHandler(this.InputDialog_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Close_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Read_tb;
        private System.Windows.Forms.Label Title_lb;
    }
}