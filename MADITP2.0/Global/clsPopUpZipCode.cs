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
    public partial class clsPopUpZipCode : Form
    {
        clsGlobal Helper;
        SOVerificatorMasterAL SOVerificatorMasterAL;
        public string _ZipCode, _Kelurahan, _Kecamatan, _City, _Province, _ParamZipCode, _AreaCode;
        private DataTable dt;
        private DataView dv;

        public clsPopUpZipCode()
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

        private void clsPopUpZipCode_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            txtFind.Text = string.Empty;
            setToolTip();

            DataTable dt = SOVerificatorMasterAL.GetZipCodes(_ParamZipCode);
            grd.AutoGenerateColumns = false;
            grd.DataSource = dt;
            dv = new DataView(dt);
        }

        private void grd_DoubleClick(object sender, EventArgs e)
        {
            btnSubmit_Click(null, null);
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = SOVerificatorMasterAL.GetZipCodes(txtFind.Text.Trim());
            grd.DataSource = null;
            grd.AutoGenerateColumns = false;
            grd.DataSource = dt;
            dv = new DataView(dt);
        }

        private void clsPopUpZipCode_KeyDown(object sender, KeyEventArgs e)
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
                _ZipCode = grd["zip_code", grd.CurrentCell.RowIndex].Value.ToString();
                _Kelurahan = grd["kelurahan", grd.CurrentCell.RowIndex].Value.ToString();
                _Kecamatan = grd["kecamatan", grd.CurrentCell.RowIndex].Value.ToString();
                _City = grd["cc_city", grd.CurrentCell.RowIndex].Value.ToString();
                _Province = grd["cc_province", grd.CurrentCell.RowIndex].Value.ToString();
                _AreaCode = grd["area_code", grd.CurrentCell.RowIndex].Value.ToString();

                this.DialogResult = DialogResult.OK;
            }
        }


    }
}
