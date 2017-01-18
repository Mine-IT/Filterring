using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filterring
{
    public partial class InputDialog : Form
    {
        public InputDialog()
        {
            InitializeComponent();

            this.TopMost = true;
        }

        private void InputDialog_Load(object sender, EventArgs e)
        {
            Title_lb.Text = str_Title;

            if(bl_PasswordMode == true)
            {
                Read_tb.PasswordChar = '*';
            }

        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Read_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                TmpString.str_TMP = Read_tb.Text;

                Encryption.Sha256 hash = new Encryption.Sha256();

                this.Close();
            }
            else if(e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                
            }
        }






        public static string str_Title;
        public static bool bl_PasswordMode;

        private void InputDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            str_Title = String.Empty;

            bl_PasswordMode = false;
        }

        
    }
    
    
}
