using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using svchost.Login_Register;
using svchost.Utilities;

namespace svchost
{
    public partial class bugFix : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public bugFix()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Functions.CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            keyFix k3 = new keyFix();
            k3.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://holyness.crisp.help/en/");
        }

        private void bugFix_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void bugFix_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void bugFix_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void bugFix_Load(object sender, EventArgs e)
        {
            Text = Functions.GetUniqueKey(8);
        }
    }
}
