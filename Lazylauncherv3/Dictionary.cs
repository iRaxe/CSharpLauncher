using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using svchost.KeyAuth;

namespace svchost
{
    public class Dictionary
    {
        public static string name = "Holyness"; 
        public static string ownerid = "8XinNh6izS"; 
        public static string secret = "23725576186a56940089a55335fd1831d5de372a929e13acf59e3fa811cf76a4"; 
        public static string version = "1.0"; 

        public static string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        public static string login = appPath + @"\utilities\conhost.exe";
        public static string console = appPath + @"\utilities\RuntimeBroker.exe";
        public static string zoom = appPath + @"\utilities\zoom.exe";


    }
}
