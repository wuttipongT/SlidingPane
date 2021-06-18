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

namespace SlidingPane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //active color 0,102,204
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (sidemenu.Width == 40)
            {
                //sidemenu.Visible = false;
                sidemenu.Width = 170;
                logo.Visible = true;

            }
            else {
                //sidemenu.Visible = false;
                sidemenu.Width = 40;
                logo.Visible = false;

            }
        }
    }


}
