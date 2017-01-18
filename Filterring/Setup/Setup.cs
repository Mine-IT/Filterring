using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Filterring.Configuration;

using Encryption;


namespace Filterring.Setup
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();

            this.TopMost = true;
        }

        private void Setup_Load(object sender, EventArgs e) {  }


        private bool bl_Setup = false;
        private void Finish_btn_Click(object sender, EventArgs e)
        {


            if (UserPassword_tb.Text != String.Empty || UserPassword_tb.Text != "" || UserPassword_tb.Text != null || 
                AdminPassword_tb.Text != String.Empty || AdminPassword_tb.Text != "" || AdminPassword_tb.Text != null)
            {
                
                if(UserPassword_tb.Text.Length > 5 || AdminPassword_tb.Text.Length > 5)
                {
                    
                    if(UserPassword_tb.Text != AdminPassword_tb.Text)
                    {

                        Sha256 hash = new Sha256();



                        Properties.Settings.Default.UserPassword = hash.Enc(UserPassword_tb.Text);


                        Properties.Settings.Default.AdminPassword = hash.Enc(AdminPassword_tb.Text);

                        Properties.Settings.Default.State = false;


                        Properties.Settings.Default.Save();



                        Configuration.Apps.Default.App1Path = String.Empty;

                        Configuration.Apps.Default.App2Path = String.Empty;

                        Configuration.Apps.Default.App3Path = String.Empty;

                        Configuration.Apps.Default.App4Path = String.Empty;

                        Configuration.Apps.Default.App5Path = String.Empty;

                        Configuration.Apps.Default.App6Path = String.Empty;

                        Configuration.Apps.Default.App7Path = String.Empty;

                        Configuration.Apps.Default.App1Path = String.Empty;

                        Configuration.Apps.Default.App9Path = String.Empty;




                        Configuration.Apps.Default.Save();


                        




                        Form1.bl_Setup = true;

                        bl_Setup = true;




                        Log log = new Log();



                        log.CreateFile();




                        log.Write("Setup", "Success", "", true);



                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("The same password can not be used.");

                    }

                }
                else
                {
                    MessageBox.Show("Please make it more than 5 digits.");
                }

            }
            else
            {
                MessageBox.Show("Please input all correctly.");
            }




        }

        
        private void Setup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(bl_Setup == false)
            {
                MessageBox.Show("! Setup aborted !");

                Form1.bl_Setup = false;     


            }

        }

        
    }
}
