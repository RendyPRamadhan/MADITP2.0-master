using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MADITP2._0
{
    public partial class frmLayout2 : Form
    {
        clsGlobal Helper = new clsGlobal();
        public frmLayout2()
        {
            InitializeComponent();
        }

        private void frmLayout2_Load(object sender, EventArgs e)
        {
            navView.PerformClick();
        }

        private void navView_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
        }
    }
}
