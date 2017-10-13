using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace adsClicke
{
    class logOperate
    {
        public void writeLog( string fileName,string msg,string folderName="Log")
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(AppDomain.CurrentDomain.BaseDirectory).Append(folderName).Append("\\").Append(DateTime.Now.ToString("yyyy-MM-dd")).Append("\\");
            string file = sb.ToString();
            if (!Directory.Exists(file))
                Directory.CreateDirectory(file);
            sb.Append(fileName);
            if (!File.Exists(sb.ToString()))
                File.Create(sb.ToString()).Close();
            
            StreamWriter sw = File.AppendText(sb.ToString());
            sw.Write(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            sw.Write("  ");
            sw.WriteLine(msg);
            
            sw.Close();
            return;
        }
    }
}
