using System;
using System.Drawing;
using System.Windows.Forms;
using MADITP2._0.Properties;

namespace MADITP2._0.Global
{
    public partial class clsAlert : Form
    {
        public clsAlert()
        {
            InitializeComponent();
            this.Text = string.Empty;
        }

        public enum Action
        {
            wait, start, close
        }

        public enum Type
        {
            Success, Warning, Error, Info
        }

        private clsAlert.Action action;
        private int x, y;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = Action.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case Action.wait:
                    timer1.Interval = 5000;
                    action = Action.close;
                    break;
                case Action.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                        this.Left--;
                    else
                        if (this.Opacity == 1.0)
                        action = Action.wait;
                    break;
                case Action.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                        base.Close();
                    break;
            }
        }

        public void ShowAlert(string message, Type type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string name;

            for (int i = 1; i < 10; i++)
            {
                name = "alert" + i.ToString();
                clsAlert form = (clsAlert)Application.OpenForms[name];

                if (form == null)
                {
                    this.Name = name;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case Type.Success:
                    this.pictureBox1.Image = Resources.success;
                    this.BackColor = Color.FromArgb(0, 126, 51);
                    break;
                case Type.Warning:
                    this.pictureBox1.Image = Resources.failed;
                    this.BackColor = Color.FromArgb(255, 136, 0);
                    break;
                case Type.Error:
                    this.pictureBox1.Image = Resources.failed;
                    this.BackColor = Color.FromArgb(204, 0, 0);
                    break;
                case Type.Info:
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.FromArgb(0, 153, 204);
                    break;
            }

            this.label1.Text = message;
            this.Show();
            this.TopMost = true;
            this.action = Action.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }

        public void PushAlert(string message, Type type)
        {
            new clsAlert().ShowAlert(message, type);
        }
    }
}
