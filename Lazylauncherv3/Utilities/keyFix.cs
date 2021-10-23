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

namespace svchost.Utilities
{
    public partial class keyFix : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public keyFix()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Functions.CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

        }

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            bugFix b3 = new bugFix();
            b3.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Functions.runLogin();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://holyness.shop/product-list/four-columns");
        }

        private void keyFix_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void keyFix_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void keyFix_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void keyFix_Load(object sender, EventArgs e)
        {
            Text = Functions.GetUniqueKey(8);
        }
    }
}
