using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using svchost.Login_Register;
using static svchost.Functions;

namespace svchost
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Functions.CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox4.Width += 5;
            if (pictureBox4.Width >= 500)
            {
                bool isElevated;
                using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
                {
                    WindowsPrincipal principal = new WindowsPrincipal(identity);
                    isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
                }

                if (isElevated)
                {
                    timer2.Stop();
                    Login f3 = new Login();
                    f3.Show();
                    Hide();
                }
                else
                {
                    timer2.Stop();
                    MessageBox.Show("Run as admin!", "HolyNoOoOOOooO");
                }
            }
        }

        private void Splashscreen_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        private void Splashscreen_Load(object sender, EventArgs e)
        {
            Text = GetUniqueKey(8);
        }
    }
}
