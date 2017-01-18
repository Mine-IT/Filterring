using System;
using System.IO;
using System.Diagnostics;
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

namespace Filterring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool bl_Setup = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            


            if (!Directory.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Local\Filterring"))
            {
                //show setup window

                Setup.Setup setup = new Setup.Setup();

                setup.ShowDialog();

                if(bl_Setup == false)
                {
                    this.Close();

                }

            }
            else
            {

                if(Configuration.Security.Default.Lock == true)
                {
                    

                    bool bl_Exit = false;

                    for (;;)
                    {
                    
                        //show login window
                        InputDialog.bl_PasswordMode = true;
                        InputDialog.str_Title = "Login (user)";

                        InputDialog id = new InputDialog();

                        id.ShowDialog();


                        Sha256 hash = new Sha256();

                        try
                        {

                            if (hash.Enc(TmpString.str_TMP) == Properties.Settings.Default.UserPassword)
                            {
                                TmpString.str_TMP = String.Empty;


                                break;
                            }

                        } catch { bl_Exit = true; break; }

                    }


                    if(bl_Exit == true)
                    {
                        Application.Exit();
                    }

                }
            }

            Properties.Settings.Default.State = false;

            Properties.Settings.Default.Save();

            AppsView();            
            SysView();
            

        }



        private void AppsView()
        {
            

            if(Configuration.Apps.Default.App1Path != String.Empty)
            {
                try
                {
                    Icon icon = Icon.ExtractAssociatedIcon(Configuration.Apps.Default.App1Path);

                    App1_btn.BackgroundImageLayout = ImageLayout.Center;

                    App1_btn.BackgroundImage = icon.ToBitmap();

                    App1_btn.Enabled = true;



                }
                catch
                {
                    App1_btn.Text = "?";

                    App1_btn.Enabled = true;
                }
            }
            else
            {
                App1_btn.Text = String.Empty;

                App1_btn.BackgroundImage = null;

                App1_btn.Enabled = false;
            }



            if (Configuration.Apps.Default.App2Path != String.Empty)
            {
                try
                {
                    Icon icon = Icon.ExtractAssociatedIcon(Configuration.Apps.Default.App2Path);

                    App2_btn.BackgroundImageLayout = ImageLayout.Center;

                    App2_btn.BackgroundImage = icon.ToBitmap();

                    App2_btn.Enabled = true;



                }
                catch
                {
                    App2_btn.Text = "?";

                    App2_btn.Enabled = true;
                }
            }
            else
            {
                App2_btn.Text = String.Empty;

                App2_btn.BackgroundImage = null;


                App2_btn.Enabled = false;
            }


            if (Configuration.Apps.Default.App3Path != String.Empty)
            {
                try
                {
                    Icon icon = Icon.ExtractAssociatedIcon(Configuration.Apps.Default.App3Path);

                    App3_btn.BackgroundImageLayout = ImageLayout.Center;

                    App3_btn.BackgroundImage = icon.ToBitmap();

                    App3_btn.Enabled = true;


                }
                catch
                {
                    App3_btn.Text = "?";

                    App3_btn.Enabled = true;
                }
            }
            else
            {
                App3_btn.Text = String.Empty;

                App3_btn.BackgroundImage = null;

                App3_btn.Enabled = false;

            }


            if (Configuration.Apps.Default.App4Path != String.Empty)
            {
                try
                {
                    Icon icon = Icon.ExtractAssociatedIcon(Configuration.Apps.Default.App4Path);

                    App4_btn.BackgroundImageLayout = ImageLayout.Center;

                    App4_btn.BackgroundImage = icon.ToBitmap();

                    App4_btn.Enabled = true;




                }
                catch
                {
                    App4_btn.Text = "?";

                    App4_btn.Enabled = true;
                }
            }
            else
            {
                App4_btn.Text = String.Empty;

                App4_btn.BackgroundImage = null;

                App4_btn.Enabled = false;
            }


            if (Configuration.Apps.Default.App5Path != String.Empty)
            {
                try
                {
                    Icon icon = Icon.ExtractAssociatedIcon(Configuration.Apps.Default.App5Path);

                    App5_btn.BackgroundImageLayout = ImageLayout.Center;

                    App5_btn.BackgroundImage = icon.ToBitmap();

                    App5_btn.Enabled = true;




                }
                catch
                {
                    App5_btn.Text = "?";

                    App5_btn.Enabled = true;
                }
            }
            else
            {
                App5_btn.Text = String.Empty;

                App5_btn.BackgroundImage = null;

                App5_btn.Enabled = false;
            }


            if (Configuration.Apps.Default.App6Path != String.Empty)
            {

                try
                {
                    Icon icon = Icon.ExtractAssociatedIcon(Configuration.Apps.Default.App6Path);

                    App6_btn.BackgroundImageLayout = ImageLayout.Center;

                    App6_btn.BackgroundImage = icon.ToBitmap();

                    App6_btn.Enabled = true;


                }
                catch
                {
                    App6_btn.Text = "?";

                    App6_btn.Enabled = true;
                }
            }
            else
            {
                App6_btn.Text = String.Empty;

                App6_btn.BackgroundImage = null;

                App6_btn.Enabled = false;
            }



            if (Configuration.Apps.Default.App7Path != String.Empty)
            {

                try
                {
                    Icon icon = Icon.ExtractAssociatedIcon(Configuration.Apps.Default.App7Path);

                    App7_btn.BackgroundImageLayout = ImageLayout.Center;

                    App7_btn.BackgroundImage = icon.ToBitmap();

                    App7_btn.Enabled = true;


                }
                catch
                {
                    App7_btn.Text = "?";

                    App7_btn.Enabled = true;
                }
            }
            else
            {
                App7_btn.Text = String.Empty;

                App7_btn.BackgroundImage = null;

                App7_btn.Enabled = false;
            }



            if (Configuration.Apps.Default.App8Path != String.Empty)
            {

                try
                {
                    Icon icon = Icon.ExtractAssociatedIcon(Configuration.Apps.Default.App8Path);

                    App8_btn.BackgroundImageLayout = ImageLayout.Center;

                    App8_btn.BackgroundImage = icon.ToBitmap();

                    App8_btn.Enabled = true;


                    
                }
                catch
                {
                    App8_btn.Text = "?";

                    App8_btn.Enabled = true;
                }
            }
            else
            {
                App8_btn.Text = String.Empty;

                App8_btn.BackgroundImage = null;


                App8_btn.Enabled = false;
            }



            if (Configuration.Apps.Default.App9Path != String.Empty)
            {

                try
                {
                    Icon icon = Icon.ExtractAssociatedIcon(Configuration.Apps.Default.App9Path);

                    App9_btn.BackgroundImageLayout = ImageLayout.Center;

                    App9_btn.BackgroundImage = icon.ToBitmap();

                    App9_btn.Enabled = true;


                }
                catch
                {
                    App9_btn.Text = "?";

                    App9_btn.Enabled = true;
                }
            }
            else
            {
                App9_btn.Text = String.Empty;

                App9_btn.BackgroundImage = null;

                App9_btn.Enabled = false;
            }

            
            
        }
        
        private void SysView()
        {

            /*State button*/
            if(Properties.Settings.Default.State == true)
            {
                State_btn.Text = "Admin";
            }
            else
            {
                State_btn.Text = "User";
            }
            
        }



        private void State_btn_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.State == true)
            {
                DialogResult dr = MessageBox.Show("Change to user?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

                if(dr == DialogResult.Yes)
                {
                    Properties.Settings.Default.State = false;

                    Properties.Settings.Default.Save();

                    State_btn.Text = "User";
                    

                }

            }
            else if(Properties.Settings.Default.State == false)
            {


                InputDialog.bl_PasswordMode = true;

                InputDialog.str_Title = "Change to admin";

                InputDialog id = new InputDialog();

                id.ShowDialog();

                Sha256 hash = new Sha256();

                if(hash.Enc(TmpString.str_TMP) == Properties.Settings.Default.AdminPassword)
                {
                    Properties.Settings.Default.State = true;

                    Properties.Settings.Default.Save();

                    State_btn.Text = "Admin";
                }

            }


        }


        private void AppsEdit_btn_Click(object sender, EventArgs e)
        {
            AppsEdit ae = new AppsEdit();

            ae.ShowDialog();

            AppsView();
        }


        private void Settings_btn_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();

            set.ShowDialog();
            
        }

        private void TaskManager_btn_Click(object sender, EventArgs e)
        {
            Run(@"C:\Windows\system32\Taskmgr.exe");
        }


        private void ThisShutdown_btn_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }






        private void App1_btn_Click(object sender, EventArgs e)
        {
            if(Configuration.Apps.Default.App1Path != String.Empty)
            {

                if(Run(Configuration.Apps.Default.App1Path) == true)
                {
                    App1_btn.Text = String.Empty;
                   
                }
                else
                {
                    MessageBox.Show("It was not processed properly");
                }
            }
        }

        private void App2_btn_Click(object sender, EventArgs e)
        {
            if (Configuration.Apps.Default.App2Path != String.Empty)
            {

                if (Run(Configuration.Apps.Default.App2Path) == true)
                {

                    App2_btn.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("It was not processed properly");
                }

            }
        }

        private void App3_btn_Click(object sender, EventArgs e)
        {
            if (Configuration.Apps.Default.App3Path != String.Empty)
            {

                if (Run(Configuration.Apps.Default.App3Path) == true)
                {

                    App3_btn.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("It was not processed properly");
                }

            }
        }

        private void App4_btn_Click(object sender, EventArgs e)
        {
            if (Configuration.Apps.Default.App4Path != String.Empty)
            {

                if (Run(Configuration.Apps.Default.App4Path) == true)
                {

                    App4_btn.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("It was not processed properly");
                }

            }
        }

        private void App5_btn_Click(object sender, EventArgs e)
        {
            if (Configuration.Apps.Default.App5Path != String.Empty)
            {

                if (Run(Configuration.Apps.Default.App5Path) == true)
                {

                    App5_btn.Text = String.Empty;

                }
                else
                {
                    MessageBox.Show("It was not processed properly");
                }

            }
        }

        private void App6_btn_Click(object sender, EventArgs e)
        {
            if (Configuration.Apps.Default.App6Path != String.Empty)
            {

                if (Run(Configuration.Apps.Default.App6Path) == true)
                {
                    App6_btn.Text = String.Empty;

                }
                else
                {
                    MessageBox.Show("It was not processed properly");
                }

            }
        }

        private void App7_btn_Click(object sender, EventArgs e)
        {
            if (Configuration.Apps.Default.App7Path != String.Empty)
            {

                if (Run(Configuration.Apps.Default.App7Path) == true)
                {
                    App7_btn.Text = String.Empty;

                }
                else
                {
                    MessageBox.Show("It was not processed properly");
                }

            }

        }

        private void App8_btn_Click(object sender, EventArgs e)
        {
            if (Configuration.Apps.Default.App8Path != String.Empty)
            {

                if (Run(Configuration.Apps.Default.App8Path) == true)
                {
                    App8_btn.Text = String.Empty;

                }
                else
                {
                    MessageBox.Show("It was not processed properly");
                }

            }
        }

        private void App9_btn_Click(object sender, EventArgs e)
        {
            if (Configuration.Apps.Default.App9Path != String.Empty)
            {

                if (Run(Configuration.Apps.Default.App9Path) == true)
                {
                    App9_btn.Text = String.Empty;

                }
                else
                {
                    MessageBox.Show("It was not processed properly");
                }

            }
        }











        //View license
        private void License_btn_Click(object sender, EventArgs e)
        {
            License license = new License();

            license.ShowDialog();
        }


        //select
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TmpString.str_TMP = String.Empty;

            if(tabControl1.SelectedIndex == 1)
            {
                

                if(Properties.Settings.Default.State == false)
                {
                    InputDialog.bl_PasswordMode = true;

                    InputDialog.str_Title = "Login (admin)";

                    InputDialog id = new InputDialog();

                    id.ShowDialog();

                    Sha256 hash = new Sha256();


                    if(hash.Enc(TmpString.str_TMP) != Properties.Settings.Default.AdminPassword)
                    {
                        tabControl1.SelectedIndex = 0;
                    }

                }
                
            }
            
        }


        //Run
        private bool Run(string str_apppath)
        {
            this.TopMost = false;

            try
            {
                Process proc = Process.Start(str_apppath);


                return true;
            }
            catch
            {


                return false;
            }
            
        }
        

    }



}


//State
//true -> admin
//false -> user