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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            this.MaximizeBox = false;

        }

        private void Settings_Load(object sender, EventArgs e)
        {

            Log log = new Log();

            log.Write("Setting","Run","Show settings window",true);
            
    

            if(Configuration.Security.Default.Lock == true)
            {

                Enable_btn.Enabled = false;
                Disable_btn.Enabled = true;
            }
            else
            {
                Enable_btn.Enabled = true;
                Disable_btn.Enabled = false;
            }

        }




        private void Loading()
        {



        }



        //---------


        private void LogLoad_btn_Click(object sender, EventArgs e)
        {

            Log log = new Log();

            Log_rbox.AppendText(log.Read());

        }

        private void LogClear_btn_Click(object sender, EventArgs e)
        {
            Log log = new Log();

            log.Write(String.Empty,String.Empty,String.Empty,false);
        }




        //----------


        private void Enable_btn_Click(object sender, EventArgs e)
        {

            Log log = new Log();

            log.Write("Setting", "edit", "enable , change login sys.", true);




            Enable_btn.Enabled = false;
            Disable_btn.Enabled = true;


            Configuration.Security.Default.Lock = true;
            Configuration.Security.Default.Save();

        }

        private void Disable_btn_Click(object sender, EventArgs e)
        {

            Log log = new Log();

            log.Write("Setting", "edit", "disable , change login sys.", true);



            Enable_btn.Enabled = true;
            Disable_btn.Enabled = false;

            Configuration.Security.Default.Lock = false;
            Configuration.Security.Default.Save();
        }
    }
}
