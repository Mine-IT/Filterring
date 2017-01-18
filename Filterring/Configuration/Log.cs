using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filterring.Configuration
{
    class Log
    {


        public void CreateFile()
        {

            try
            {
                Directory.CreateDirectory(@"C:\Users\" + Environment.UserName + @"\Documents\Log");
            }catch { }

            try
            {
                using(var filecre = File.Create(@"C:\Users\" + Environment.UserDomainName + @"\Documents\Log\log.txt"))
                {
                    filecre.Close();
                    filecre.Dispose();
                }
            }catch { }
            
        }

        public void Write(string origin1,string origin2,string origin3,bool Overwrite) // false -> over , true -> append
        {

            try
            {
                StreamWriter ws_writer = new StreamWriter(@"C:\Users\" + Environment.UserName + @"\Documents\Log\log.txt", Overwrite, Encoding.UTF8);

                ws_writer.Write(origin1 + " : " + origin2 + " :::: "   + DateTime.Now + Environment.NewLine + "comment :: " + origin3 + Environment.NewLine + Environment.NewLine);


                ws_writer.Close();

                ws_writer.Dispose();
            } catch {  }


        }


        public string Read()
        {

            string str_reader = String.Empty;

            try
            {
                StreamReader sr_reader = new StreamReader(@"C:\Users\" + Environment.UserName + @"\Documents\Log\log.txt",Encoding.UTF8);

                str_reader = sr_reader.ReadToEnd();


                sr_reader.Close();

                sr_reader.Dispose();
            }catch { }

            return str_reader;
        }



    }
}
