using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MADITP2._0.UserControls
{
    public partial class UCCheque : UserControl
    {
        public UCCheque()
        {
            InitializeComponent();
        }

        private void txtUCCCurrRate_TextChanged(object sender, EventArgs e)
        {
            if (txtCurrRate.Text.Trim().Length > 0)
            {
                txtCurrRate.Text = string.Format("{0:#,##0}", (Convert.ToDouble(txtCurrRate.Text.Trim())));
            }
        }

        private void txtUCCAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text.Trim().Length > 0)
            {
                txtAmount.Text = string.Format("{0:#,##0}", (Convert.ToDouble(txtAmount.Text.Trim())));
            }
        }

        private void txtUCCCurrRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtUCCAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }
    }
}
