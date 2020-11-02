using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MADITP2._0.Global;

namespace MADITP2._0.UserInterface.SO
{
    public partial class SOKPEntryUI : Form
    {
        private int AppState;
        clsAlert Alert;
        clsGlobal Helper;
        public SOKPEntryUI()
        {
            Alert = new clsAlert();
            Helper = new clsGlobal();

            InitializeComponent();
        }

        private void SOKPEntryUI_Load(object sender, EventArgs e)
        {
            navView.PerformClick();
        }

        private void navView_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            panelView.BringToFront();
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            panelEditor.BringToFront();
        }

        private void navEdit_Click(object sender, EventArgs e)
        {

        }

        private void navDelete_Click(object sender, EventArgs e)
        {

        }

        private void navPrint_Click(object sender, EventArgs e)
        {

        }

        private void navExport_Click(object sender, EventArgs e)
        {

        }

        private void navClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
