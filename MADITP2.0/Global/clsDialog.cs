using System;
using System.Drawing;
using System.Windows.Forms;

namespace MADITP2._0.Global
{
    public partial class clsDialog : Form
    {
        Form background = new Form();
        private static clsDialog dialog;
        private static DialogResult result;

        public clsDialog()
        {
            InitializeComponent();
            this.Text = string.Empty;
        }

        private void clsDialog_Load(object sender, EventArgs e)
        {
            background.Opacity = .60d;
            background.BackColor = Color.Black;
            background.WindowState = FormWindowState.Maximized;
            background.FormBorderStyle = FormBorderStyle.None;
            background.ShowInTaskbar = false;
            background.TopMost = true;
            background.Show();
            this.Owner = background;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            this.Close();
            background.Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            this.Close();
            background.Close();
        }

        public static DialogResult ShowDialog(string message)
        {
            dialog = new clsDialog();
            dialog.message.Text = message;
            dialog.ShowDialog();
            return result;
        }
    }
}
