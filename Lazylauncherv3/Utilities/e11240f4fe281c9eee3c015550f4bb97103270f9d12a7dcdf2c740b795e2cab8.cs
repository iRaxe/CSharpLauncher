using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using svchost.Login_Register;

namespace svchost.Utilities
{
    public partial class e11240f4fe281c9eee3c015550f4bb97103270f9d12a7dcdf2c740b795e2cab8 : Form
    {
        public e11240f4fe281c9eee3c015550f4bb97103270f9d12a7dcdf2c740b795e2cab8()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Functions.CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void e11240f4fe281c9eee3c015550f4bb97103270f9d12a7dcdf2c740b795e2cab8_Load(object sender, EventArgs e)
        {
            status.Text = "Injecting";
            status.ForeColor = Color.FromArgb(255, 78, 78);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox4.Width += 5;
            if (pictureBox4.Width < 500) return;
            timer1.Stop();
            Close();
        }
    }
}
