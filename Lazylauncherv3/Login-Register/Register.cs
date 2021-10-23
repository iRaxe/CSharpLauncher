using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using svchost.KeyAuth;

namespace svchost.Login_Register
{
    public partial class registerForm : Form
    {
        private static string name = Dictionary.name;
        private static string ownerid = Dictionary.ownerid;
        private static string secret = Dictionary.secret;
        private static string version = Dictionary.version;
        public static api KeyAuthApp = new api(name, ownerid, secret, version);

        private readonly Bitmap _img2 = Properties.Resources.bx_hide_svg;
        private readonly Bitmap _img2X = Properties.Resources.bx_show;

        private bool mouseDown;
        private Point lastLocation;

        int result = -1;
        int error = 0;

        public registerForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Functions.CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
        }

        Login main = new Login();

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            main.Show();
            Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (KeyAuthApp.register(usernameTextBox.Text, passwordTextBox.Text, keyTextBox.Text))
            {
                MessageBox.Show("Congratulations! You have binded your username to the key license!", "HolySuccesSs");
                main.Show();
                this.Hide();
            }
        }

        private void backToLoginURL_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Hide();
        }

        private void visiblePassword_Click(object sender, EventArgs e)
        {
            if (visiblePassword.Image == _img2)
            {
                visiblePassword.Image = _img2X;
                passwordTextBox.UseSystemPasswordChar = true;
            }

            else if (visiblePassword.Image == _img2X)
            {
                visiblePassword.Image = _img2;
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void visibleKey_Click(object sender, EventArgs e)
        {
            if (visibleKey.Image == _img2)
            {
                visibleKey.Image = _img2X;
                keyTextBox.UseSystemPasswordChar = true;
            }

            else if (visibleKey.Image == _img2X)
            {
                visibleKey.Image = _img2;
                keyTextBox.UseSystemPasswordChar = false;
            }
        }

        private void registerForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void registerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void registerForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
