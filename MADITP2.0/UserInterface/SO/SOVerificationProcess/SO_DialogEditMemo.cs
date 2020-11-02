using MADITP2._0.ApplicationLogic;
using MADITP2._0.ApplicationLogic.SO;
using MADITP2._0.businessLogic.SO;
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
    public partial class SO_DialogEditMemo : Form
    {
        clsGlobal Helper;
        GlobalAL GlobalAL;
        clsAlert clsAlert;
        SOVerificationProcessAL SOVerificationProcessAL;
        SOVerificationProcessBL SOVerificationProcessBL;
        public string _VerID, _VerName, _KPNo, _MenuName, _Memo;

        public SO_DialogEditMemo()
        {
            InitializeComponent();
            Helper = new clsGlobal();
            GlobalAL = new GlobalAL(Helper);
            clsAlert = new clsAlert();
            SOVerificationProcessAL = new SOVerificationProcessAL(Helper);
            SOVerificationProcessBL = new SOVerificationProcessBL();
        }

        private void btnSaveEditMemoVs_Click(object sender, EventArgs e)
        {
            SOVerificationProcessBL = new SOVerificationProcessBL()
            {
                verificator_id = _VerID,
                so_kp_no = _KPNo,
                remark_activity = txtMemoEditMemoVs.Text
            };

            bool _isSucess = SOVerificationProcessAL.UpdateRemarks(SOVerificationProcessBL);
            if(_isSucess == true)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnTransferEditMemoVs_Click(object sender, EventArgs e)
        {
            if(txtMemoEditMemoVs.Text.Length > 0)
            {
                title.Text = "TRANSFER MEMO";

                pnlEditMemo.Visible = false;
                pnlTransferMemo.Visible = true;

                txtMemoTransferMemoVs.Text = txtMemoEditMemoVs.Text;
            }
            else
            {
                clsAlert.PushAlert("Memo required!", clsAlert.Type.Error);
            }
        }

        private void btnCancelDisplayMemoSor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveTransferMemoVs_Click(object sender, EventArgs e)
        {
            if(txtKPNoTransferMemoVs.Text.Trim().Length > 0)
            {
                SOVerificationProcessBL = new SOVerificationProcessBL()
                {
                    so_kp_no = txtKPNoTransferMemoVs.Text.Trim(),
                    remark_activity = txtMemoEditMemoVs.Text
                };

                DataTable dt = SOVerificationProcessAL.GetKPHeaderByKPNo(txtKPNoTransferMemoVs.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    bool _isSucess = SOVerificationProcessAL.TransferRemarks(SOVerificationProcessBL);
                    if (_isSucess == true)
                    {
                        btnCancelTransferMemoVs_Click(null, null);
                    }
                }
                else
                {
                    clsAlert.PushAlert("KP Number not found!", clsAlert.Type.Error);
                    txtKPNoTransferMemoVs.Focus();
                }
            }
            else
            {
                clsAlert.PushAlert("KP Number required!", clsAlert.Type.Error);
                txtKPNoTransferMemoVs.Focus();
            }        
        }

        private void SO_DialogEditMemo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Tab)
            {
                clsEventButton clsEventButton = new clsEventButton();
                clsEventButton.EnumAction _ActionType = clsEventButton.getEventType(e.KeyCode.ToString());

                switch (_ActionType)
                {
                    case clsEventButton.EnumAction.DISPLAY:
                        {
                            if (_MenuName == "tabVS")
                            {
                                btnTransferEditMemoVs_Click(null, null);
                            }

                            break;
                        }
                    case clsEventButton.EnumAction.SAVE:
                        {
                            if (_MenuName == "tabVS" && pnlEditMemo.Visible == true)
                            {
                                btnSaveEditMemoVs_Click(null, null);
                            }
                            else if (_MenuName == "tabVS" && pnlTransferMemo.Visible == true)
                            {
                                btnSaveTransferMemoVs_Click(null, null);
                            }
                            break;
                        }

                    case clsEventButton.EnumAction.CANCEL:
                        {
                            if (_MenuName == "tabVS" && pnlEditMemo.Visible == true)
                            {
                                btnCancelEditMemoVs_Click(null, null);
                            }
                            else if (_MenuName == "tabVS" && pnlTransferMemo.Visible == true)
                            {
                                btnCancelTransferMemoVs_Click(null, null);
                            }
                            else if (_MenuName == "tabSOR" && pnlDisplayMemoSor.Visible == true)
                            {
                                btnCancelDisplayMemoSor_Click(null, null);
                            }
                            break;
                        }
                }
            }
            else
            {
                this.ProcessTabKey(true);
            }
        }

        private void btnCancelTransferMemoVs_Click(object sender, EventArgs e)
        {
            title.Text = "EDIT MEMO";
            pnlEditMemo.Visible = true;
            pnlTransferMemo.Visible = false;
        }

        private void SetTooltip()
        {
            ToolTip toolTipSaveEditMemoVs = new ToolTip();
            toolTipSaveEditMemoVs.ShowAlways = true;
            toolTipSaveEditMemoVs.SetToolTip(btnSaveEditMemoVs, "SAVE [F10]");

            ToolTip toolTipCancelEditMemoVs = new ToolTip();
            toolTipCancelEditMemoVs.ShowAlways = true;
            toolTipCancelEditMemoVs.SetToolTip(btnCancelEditMemoVs, "CANCEL [F9]");

            ToolTip toolTipTransferMemoVS = new ToolTip();
            toolTipTransferMemoVS.ShowAlways = true;
            toolTipTransferMemoVS.SetToolTip(btnTransferEditMemoVs, "TRANSFER MEMO [F11]");

            ToolTip toolTipSaveTransferMemoVs = new ToolTip();
            toolTipSaveTransferMemoVs.ShowAlways = true;
            toolTipSaveTransferMemoVs.SetToolTip(btnSaveTransferMemoVs, "SAVE [F10]");

            ToolTip toolTipCancelTransferMemoVs = new ToolTip();
            toolTipCancelTransferMemoVs.ShowAlways = true;
            toolTipCancelTransferMemoVs.SetToolTip(btnCancelTransferMemoVs, "CANCEL [F9]");

            ToolTip toolTipCancelDisplayMemoSor = new ToolTip();
            toolTipCancelDisplayMemoSor.ShowAlways = true;
            toolTipCancelDisplayMemoSor.SetToolTip(btnCancelDisplayMemoSor, "CANCEL [F9]");
        }

        private void SO_DialogEditMemo_Load(object sender, EventArgs e)
        {
            SetTooltip();
            KeyPreview = true;

            if (_MenuName == "tabVS")
            {
                Height = 415;
                Width = 517;

                title.Text = "EDIT MEMO";
                pnlEditMemo.Visible = true;
                pnlTransferMemo.Visible = false;
                pnlDisplayMemoSor.Visible = false;

                txtKPNoEditMemoVs.Text = _KPNo;
                txtVerIDEditMemoVs.Text = _VerID;
                txtVerNameEditMemoVs.Text = _VerName;

                DataTable dt = SOVerificationProcessAL.GetMemoVisitingActivity(_VerID, _KPNo);
                txtMemoEditMemoVs.Text = dt.Rows[0]["svs_remark_activity"].ToString();
            }
            else if(_MenuName == "tabSOR")
            {
                Height = 266;
                Width = 519;

                title.Text = "DISPLAY MEMO";
                pnlEditMemo.Visible = false;
                pnlTransferMemo.Visible = false;
                pnlDisplayMemoSor.Visible = true;

                txtDisplayMemoSor.Text = _Memo;
            }
            
        }

        private void btnCancelEditMemoVs_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
