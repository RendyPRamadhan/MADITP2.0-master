using MADITP2._0.ApplicationLogic.SO;
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

namespace MADITP2._0.UserInterface.SO.SOVerificationProcess
{
    public partial class clsPopUpCustomer : Form
    {
        clsGlobal Helper;
        SOVerificatorMasterAL SOVerificatorMasterAL;
        public string _CustomerID, _CustomerName, _ParamCust;
        private DataTable dt;
        private DataView dv;

        public clsPopUpCustomer()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = new clsGlobal();
                SOVerificatorMasterAL = new SOVerificatorMasterAL(Helper);
            }
        }

        public void setToolTip()
        {
            ToolTip toolTipSave = new ToolTip();
            toolTipSave.ShowAlways = true;
            toolTipSave.SetToolTip(btnSubmit, "SUBMIT [F10]");
        }

        private void SO_frmDialog_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            txtFind.Text = string.Empty;
            setToolTip();

            DataTable dt = SOVerificatorMasterAL.GetCustomer(_ParamCust);
            grd.AutoGenerateColumns = false;
            grd.DataSource = dt;
            dv = new DataView(dt);
        }

        private void pnlView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grd_DoubleClick(object sender, EventArgs e)
        {
            btnSubmit_Click(null, null);
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = SOVerificatorMasterAL.GetCustomer(txtFind.Text.Trim());
            grd.DataSource = null;
            grd.AutoGenerateColumns = false;
            grd.DataSource = dt;
            dv = new DataView(dt);
        }

        private void clsPopUpCustomer_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode != Keys.Tab)
                {
                    clsEventButton clsEventButton = new clsEventButton();
                    clsEventButton.EnumAction _ActionType = clsEventButton.getEventType(e.KeyCode.ToString());

                    switch (_ActionType)
                    {
                        case clsEventButton.EnumAction.SAVE:
                            {
                                btnSubmit_Click(null, null);
                                break;
                            }
                    }
                }
                else
                {
                    this.ProcessTabKey(true);
                }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(grd.Rows.Count > 0)
            {
                _CustomerID = grd["scm_customer_id", grd.CurrentCell.RowIndex].Value.ToString();
                _CustomerName = grd["scm_customer_name", grd.CurrentCell.RowIndex].Value.ToString();
                this.DialogResult = DialogResult.OK;
            }
        }


    }
}
