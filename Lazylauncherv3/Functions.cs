using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using svchost.Utilities;

namespace svchost
{
    class Functions
    {

        internal static readonly char[] chars =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();

        public static string GetUniqueKey(int size)
        {
            byte[] data = new byte[4 * size];
            using (var crypto = RandomNumberGenerator.Create())
            {
                crypto.GetBytes(data);
            }

            StringBuilder result = new StringBuilder(size);
            for (int i = 0; i < size; i++)
            {
                var rnd = BitConverter.ToUInt32(data, i * 4);
                var idx = rnd % chars.Length;

                result.Append(chars[idx]);
            }

            return result.ToString();
        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public static void runLogin()
        {
            Process login;
            login = new Process();
            login.StartInfo.FileName = Dictionary.login;
            login.Start();
            Properties.Settings.Default.keyStored = true;
            Properties.Settings.Default.Save();
            login.WaitForExit();
        }

        public static void injectionStatus()
        {
            e11240f4fe281c9eee3c015550f4bb97103270f9d12a7dcdf2c740b795e2cab8 m3 =
                new e11240f4fe281c9eee3c015550f4bb97103270f9d12a7dcdf2c740b795e2cab8();
            m3.Show();
        }

        public static void runConsole()
        {
            injectionStatus();

            Process loader; loader = new Process();
            loader.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            loader.StartInfo.FileName = Dictionary.console;
            loader.Start();
        }
        public static void runZoom()
        {
            injectionStatus();

            Process zoom; zoom = new Process();
            zoom.StartInfo.FileName = Dictionary.zoom;
            zoom.Start();
            runConsole();
        }

        public static bool IsLiveGameRunning()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://127.0.0.1:2999/liveclientdata/allgamedata");
            System.Net.ServicePointManager.ServerCertificateValidationCallback += delegate (object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                System.Security.Cryptography.X509Certificates.X509Chain chain,
                System.Net.Security.SslPolicyErrors sslPolicyErrors)
            {
                return true; // **** Always accept
            };

            request.Method = "GET";

            bool flag = false;

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK) flag = true;
                }
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }

            return flag;
        }
    }
}
