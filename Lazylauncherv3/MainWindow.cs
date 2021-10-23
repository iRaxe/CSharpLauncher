using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using svchost.Login_Register;
using static svchost.Functions;

namespace svchost
{
    public partial class MainWindow : Form
    {
        
        private bool mouseDown;
        private Point lastLocation;
        private readonly Bitmap _img1 = Properties.Resources.Group_11;
        private readonly Bitmap _img1X = Properties.Resources.Group_56;

        public MainWindow()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            zoomBox.Image = _img1;
        }

       

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey is a beta, wait is not even implemented!", "Wait update please");
        }
        
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey is a beta, wait is not even implemented!", "Wait update please");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey is a beta, wait is not even implemented!", "Wait update please");
        }

        private void zoomBox_Click(object sender, EventArgs e)
        {
            if (zoomBox.Image == _img1)
            {
                zoomBox.Image = _img1X;
            }

            else if (zoomBox.Image == _img1X)
            {
                zoomBox.Image = _img1;
            }

        }
        
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Text = GetUniqueKey(8);
            welcomeLabel.Text = "Welcome back " + Login.KeyAuthApp.user_data.username + ", Are you ready for 1v9?";
            licenseLabel.Text = " " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry));

        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        private void inject2Icon_Click(object sender, EventArgs e)
        {
            Text = GetUniqueKey(8);
            if (zoomBox.Image == _img1)
            {
                runConsole();
            }
            else
            {
                runZoom();
            }
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void recoveryURL_Click(object sender, EventArgs e)
        {
                bugFix b3 = new bugFix();
                b3.Show();
        }
    }
}
