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
using svchost.KeyAuth;
using static svchost.Functions;

namespace svchost.Login_Register
{
    public partial class Login : Form
    {
        private readonly Bitmap _img1 = Properties.Resources.Rectangle_2__2_;
        private readonly Bitmap _img1X = Properties.Resources.Rectangle_2__3_;
        private readonly Bitmap _img2 = Properties.Resources.bx_hide_svg;
        private readonly Bitmap _img2X = Properties.Resources.bx_show;
        public static api KeyAuthApp = new api(Dictionary.name, Dictionary.ownerid, Dictionary.secret, Dictionary.version);
        private bool mouseDown;
        private Point lastLocation;

        public Login()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            saveCredentialsButton.Image = _img1;
            button2.Image = _img2X;
            if (Properties.Settings.Default.savePassword != true) return;
            usernameTextBox.Text = Properties.Settings.Default.userName;
            passwordTextBox.Text = Properties.Settings.Default.passUser;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
            Text = GetUniqueKey(8);
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void saveCredentialsButton_Click(object sender, EventArgs e)
        {
            saveCredentialsButton.Image = saveCredentialsButton.Image == _img1 ? _img1X : _img1;
            if (saveCredentialsButton.Image != _img1X) return;
            Properties.Settings.Default.userName = usernameTextBox.Text;
            Properties.Settings.Default.passUser = passwordTextBox.Text;
            Properties.Settings.Default.savePassword = true;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Image == _img2)
            {
                button2.Image = _img2X;
                passwordTextBox.UseSystemPasswordChar = true;
            }

            else if (button2.Image == _img2X)
            {
                button2.Image = _img2;
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void newAccountURL_Click(object sender, EventArgs e)
        {
            registerForm f3 = new registerForm();
            f3.Show();
            Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (KeyAuthApp.login(usernameTextBox.Text, passwordTextBox.Text))
            {
                MainWindow m3 = new MainWindow();
                if (Properties.Settings.Default.keyStored)
                {
                    m3.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Login successful, Please login also into our injector!", "HolySuccess");
                    runLogin();
                    m3.Show();
                    Hide();
                }
            }
        }

        private void recoveryURL_Click(object sender, EventArgs e)
        {
            bugFix b3 = new bugFix();
            b3.Show();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
