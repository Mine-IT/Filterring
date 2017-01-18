using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Filterring.Configuration;

namespace Filterring
{
    public partial class AppsEdit : Form
    {
        public AppsEdit()
        {
            InitializeComponent();

            this.TopMost = true;

            this.MaximizeBox = false;

        }

        private void AppsEdit_Load(object sender, EventArgs e)
        {
            Loading();

            Log log = new Log();

            log.Write("AppEdit" ,"Run","Show AppEdit window",true);

        }

        private void AppsEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();

            Log log = new Log();

            log.Write("AppEdit", "Save", "Save apps path", true);


        }





        private void Loading()
        {
            App1Path_tb.Text = Configuration.Apps.Default.App1Path;

            App2Path_tb.Text = Configuration.Apps.Default.App2Path;

            App3Path_tb.Text = Configuration.Apps.Default.App3Path;

            App4Path_tb.Text = Configuration.Apps.Default.App4Path;

            App5Path_tb.Text = Configuration.Apps.Default.App5Path;
        
            App6Path_tb.Text = Configuration.Apps.Default.App6Path;

            App7Path_tb.Text = Configuration.Apps.Default.App7Path;

            App8Path_tb.Text = Configuration.Apps.Default.App8Path;

            App9Path_tb.Text = Configuration.Apps.Default.App9Path;

        }


        private void Save()
        {
            if (App1Path_tb.Text != String.Empty)
            {
                Configuration.Apps.Default.App1Path = App1Path_tb.Text;
            }
            else
            {
                Configuration.Apps.Default.App1Path = String.Empty;
            }


            if (App2Path_tb.Text != String.Empty)
            {
                Configuration.Apps.Default.App2Path = App2Path_tb.Text;
            }
            else
            {
                Configuration.Apps.Default.App2Path = String.Empty;
            }


            if (App3Path_tb.Text != String.Empty)
            {
                Configuration.Apps.Default.App3Path = App3Path_tb.Text;
            }
            else
            {
                Configuration.Apps.Default.App3Path = String.Empty;
            }


            if (App4Path_tb.Text != String.Empty)
            {
                Configuration.Apps.Default.App4Path = App4Path_tb.Text;
            }
            else
            {
                Configuration.Apps.Default.App4Path = String.Empty;

            }



            if (App5Path_tb.Text != String.Empty)
            {
                Configuration.Apps.Default.App5Path = App5Path_tb.Text;

            }
            else
            {
                Configuration.Apps.Default.App5Path = String.Empty;
            }


            if (App6Path_tb.Text != String.Empty)
            {
                Configuration.Apps.Default.App6Path = App6Path_tb.Text;
            }
            else
            {
                Configuration.Apps.Default.App6Path = String.Empty;
            }



            if (App7Path_tb.Text != String.Empty)
            {
                Configuration.Apps.Default.App7Path = App7Path_tb.Text;
            }
            else
            {
                Configuration.Apps.Default.App7Path = String.Empty;
            }


            if (App8Path_tb.Text != String.Empty)
            {
                Configuration.Apps.Default.App8Path = App8Path_tb.Text;

            }
            else
            {
                Configuration.Apps.Default.App8Path = String.Empty;
            }


            if (App9Path_tb.Text != String.Empty)
            {
                Configuration.Apps.Default.App9Path = App9Path_tb.Text;

            }
            else
            {
                Configuration.Apps.Default.App9Path = String.Empty;
            }

            Configuration.Apps.Default.Save();

            

        }

    

    }
}
