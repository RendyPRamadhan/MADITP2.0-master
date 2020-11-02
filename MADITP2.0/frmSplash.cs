using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MADITP2._0.login;

namespace MADITP2._0
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.9)
                this.Opacity += 0.1;

            panelBar.Width += 10;
            if (panelBar.Width >= 500)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;

            if (time.Hour < 12 && time.Hour >= 5)
                greeting.Text = "Good Morning,";
            else if (time.Hour >= 12 && time.Hour < 15)
                greeting.Text = "Good Afternoon,";
            else if (time.Hour >= 15 && time.Hour < 18)
                greeting.Text = "Good Evening,";
            else
                greeting.Text = "Good Night,";

            username.Text = clsLogin.USERID;
            this.Opacity = 0.0;
            timer1.Start();
        }
    }
}
