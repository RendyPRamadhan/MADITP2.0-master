﻿using MADITP2._0.ApplicationLogic;
using MADITP2._0.ApplicationLogic.SO;
using MADITP2._0.businessLogic.SO;
using MADITP2._0.BusinessLogic.CB;
using MADITP2._0.DataAccess.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using MADITP2._0.Report.SO;
using MADITP2._0.UserControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MADITP2._0.userInterface.SO.CB_ARCollectionDepositEntryUI
{
    public partial class CB_ARCollectionDepositEntryUI : Form
    {
        clsGlobal Helper;
        GlobalAL GlobalAL;
        clsReport clsReport;
        clsAlert clsAlert;
        clsEventButton clsEventButton;
        CBARCollectionDepositEntryAL CBARCollectionDepositEntryAL;
        CBARCollectionDepositEntryBL CBARCollectionDepositEntryBL;
        CBARCollectionDepositEntryVoucherTxnBL CBARCollectionDepositEntryVoucherTxnBL;
        CBARCollectionDepositEntryVoucherDistTxnBL CBARCollectionDepositEntryVoucherDistTxnBL;
        //CBARCollectionDepositEntryIncentivePaymentBL clsIncentivePaymentBL;
        private string _UserEntityID, _UserEntity, _UserBranchID, _UserDivisionID, _UserGroupID;
        private string _ExistForm, _GLEntity;
        private bool _BranchFlag, _DivisionFlag, _DepartmentFlag, _FilerFlag, _IsViewAll;
        private string _VarSelected, _strVoucherType;
        private List<CBARCollectionDepositEntryIncentivePaymentBL> clsIncentivePaymentBL = new List<CBARCollectionDepositEntryIncentivePaymentBL>();
        private ArrayList _varArrListSave = new ArrayList();
        enum _SelectType { Collector_Plan, Outstanding_KW, All_Outstanding, DP_UangMuka_AR, COD_AR };

        public CB_ARCollectionDepositEntryUI()
        {

            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = new clsGlobal();
                GlobalAL = new GlobalAL(Helper);
                clsReport = new clsReport();
                clsEventButton = new clsEventButton();
                clsAlert = new clsAlert();
                CBARCollectionDepositEntryAL = new CBARCollectionDepositEntryAL(Helper);
                CBARCollectionDepositEntryBL = new CBARCollectionDepositEntryBL();
                CBARCollectionDepositEntryVoucherTxnBL = new CBARCollectionDepositEntryVoucherTxnBL();
                CBARCollectionDepositEntryVoucherDistTxnBL = new CBARCollectionDepositEntryVoucherDistTxnBL();
                ucBankEntry1.grd.CellClick += new DataGridViewCellEventHandler(grdCellClickUCBankEntry);
                uccbOtherDoc1.btnCancel.Click += new EventHandler(btnCancelReport_Click);
            }
        }

        private void btnCancelReport_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.CANCEL);
        }

        private void CB_ARCollectionDepositEntryUI_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            KeyPreview = true;

            getPropertyUser();

            DataTable dt = CBARCollectionDepositEntryAL.GetSystemDate();
            dtValidDate.Value = Convert.ToDateTime(dt.Rows[0]["SystemDate"]);

            loadCboEntity();
            loadCboBranch();
            loadCboDivision();
            loadCboPaymentType();
            loadCboCollector();
            loadCboBank();
            loadCboVoucherType();
            loadCboCurrCode();

            grpOutstanding.Enabled = false;

            _IsViewAll = true;
            navView_Click(navView, null);
        }

        private void CB_ARCollectionDepositEntryUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Tab)
            {
                clsEventButton clsEventButton = new clsEventButton();
                clsEventButton.EnumAction _ActionType = clsEventButton.getEventType(e.KeyCode.ToString());

                switch (_ActionType)
                {
                    case clsEventButton.EnumAction.VIEW:
                        {
                            navView_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.NEW:
                        {
                            navNew_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.EDIT:
                        {
                            navEdit_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.DELETE:
                        {
                            navDelete_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.PRINT:
                        {
                            navPrint_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.EXPORT:
                        {
                            navExport_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.EXIT:
                        {
                            navClose_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.SEARCH:
                        {
                            btnSearch_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.DISPLAY:
                        {
                            btnReview_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.PROSES:
                        {
                            btnProcess_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.CANCEL:
                        {
                            btnCancel_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.SAVE:
                        {
                            btnOK_Click(null, null);
                            break;
                        }
                }
            }
            else
            {
                this.ProcessTabKey(true);
            }
        }

        private void setToolTip()
        {
            ToolTip toolTipView = new ToolTip();
            toolTipView.ShowAlways = true;
            toolTipView.SetToolTip(navView, "VIEW [F12]");

            ToolTip toolTipNew = new ToolTip();
            toolTipNew.ShowAlways = true;
            toolTipNew.SetToolTip(navNew, "NEW [F1]");

            ToolTip toolTipEdit = new ToolTip();
            toolTipEdit.ShowAlways = true;
            toolTipEdit.SetToolTip(navEdit, "EDIT [F2]");

            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.ShowAlways = true;
            toolTipDelete.SetToolTip(navDelete, "DELETE [F3]");

            ToolTip toolTipPrint = new ToolTip();
            toolTipPrint.ShowAlways = true;
            toolTipPrint.SetToolTip(navPrint, "PRINT [F4]");

            ToolTip toolTipExport = new ToolTip();
            toolTipExport.ShowAlways = true;
            toolTipExport.SetToolTip(navExport, "EXPORT [F5]");

            ToolTip toolTipSearch = new ToolTip();
            toolTipSearch.ShowAlways = true;
            toolTipSearch.SetToolTip(btnSearch, "SEARCH [F6]");

            ToolTip toolTipProcess = new ToolTip();
            toolTipProcess.ShowAlways = true;
            toolTipProcess.SetToolTip(btnProcess, "PROCESS [F8]");

            ToolTip toolTipReview = new ToolTip();
            toolTipReview.ShowAlways = true;
            toolTipReview.SetToolTip(btnReview, "REVIEW [F11]");

            ToolTip toolTipCancel = new ToolTip();
            toolTipCancel.ShowAlways = true;
            toolTipCancel.SetToolTip(btnCancel, "CANCEL [F9]");

            ToolTip toolTipOK = new ToolTip();
            toolTipOK.ShowAlways = true;
            toolTipOK.SetToolTip(btnOK, "OK [F10]");
        }

        private void navView_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.VIEW);
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.NEW);
        }

        private void navEdit_Click(object sender, EventArgs e)
        {

        }

        private void navDelete_Click(object sender, EventArgs e)
        {

        }

        private void navPrint_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.PRINT);
        }

        private void navExport_Click(object sender, EventArgs e)
        {

        }

        private double ConvertToDouble(string _Value)
        {
            double _Result = 0;

            _Value = (_Value == null) ? "0" : ((_Value == "") ? "0" : _Value.Replace(",", ""));
            _Result = Convert.ToDouble(_Value);

            return _Result;
        }

        private bool UpdateToBank()
        {
            bool _Status = false;
            bool _blnSelect;
            int j;

            clsIncentivePaymentBL.Clear();
            //clsIncentivePaymentBL = new CBARCollectionDepositEntryIncentivePaymentBL();

            DataTable dt = CBARCollectionDepositEntryAL.GetGeneralFiscal("CB", Convert.ToString(ucReceiptFrom1.dtTransDate.Value.Year), _GLEntity);
            if(dt.Rows.Count > 0)
            {
                ucReceiptFrom1.dtTransDate.MinDate = Convert.ToDateTime(dt.Rows[0]["gfc_begining_date"]);
                ucReceiptFrom1.dtTransDate.Value = Convert.ToDateTime(dt.Rows[0]["SysDate"]);

                ucReceiptFrom1.txtReceiptFrom.Text = string.Empty;
                ucReceiptFrom1.txtTransAmount.Text = string.Empty;
                ucReceiptFrom1.txtRemarks.Text = string.Empty;
                ucCheque1.txtNo.Text = string.Empty;
                ucCheque1.txtRef.Text = string.Empty;

                if(CBCashType(EnumCashType.eCollection) == true)
                {
                    ucVoucherID1.txtVoucherRef.Text = txtVoucherRef.Text.Trim();

                    if(grd.Rows.Count > 0)
                    {
                        if (cboBankAccount.SelectedIndex > -1)
                        {
                            if (txtVoucherRef.Text.Trim().Length > 0)
                            {
                                if (cboVoucherType.SelectedIndex > -1)
                                {
                                    if (Convert.ToInt64(txtItemDeposit.Text.Trim()) > 0)
                                    {
                                        clsIncentivePaymentBL.Add(new CBARCollectionDepositEntryIncentivePaymentBL());

                                        foreach (DataGridViewRow dr in grd.Rows)
                                        {
                                            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dr.Cells["grdDeposit"];
                                            if (chk.Value != null)
                                            {
                                                if (Convert.ToBoolean(chk.Value) == Convert.ToBoolean(chk.TrueValue))
                                                {
                                                    _blnSelect = false;

                                                    for (j = 0; j <= clsIncentivePaymentBL.Count - 1; j++)
                                                    {
                                                        if (clsIncentivePaymentBL[j].varEntity == cboEntity.SelectedValue.ToString() && clsIncentivePaymentBL[j].varBranch == dr.Cells["ak_branch_id"].Value.ToString().Trim() && clsIncentivePaymentBL[j].varDivision == dr.Cells["ak_division_id"].Value.ToString().Trim())
                                                        {
                                                            double _CollectedValue = ConvertToDouble((dr.Cells["Collected"].Value == null) ? "" : dr.Cells["Collected"].Value.ToString());
                                                            double _WOValue = ConvertToDouble((dr.Cells["grdWo"].Value == null) ? "" : dr.Cells["grdWo"].Value.ToString());

                                                            clsIncentivePaymentBL[j].varValues = clsIncentivePaymentBL[j].varValues + _CollectedValue;
                                                            clsIncentivePaymentBL[j].varValuesCWH = clsIncentivePaymentBL[j].varValuesCWH + _WOValue;
                                                            _blnSelect = true;
                                                        }
                                                    }

                                                    if (_blnSelect == false)
                                                    {
                                                        j = clsIncentivePaymentBL.Count - 1;
                                                        if (j > 0 || clsIncentivePaymentBL[j].varEntity != null)
                                                        {
                                                            j = (clsIncentivePaymentBL.Count - 1) + 1;
                                                            clsIncentivePaymentBL.Add(new CBARCollectionDepositEntryIncentivePaymentBL());
                                                        }

                                                        clsIncentivePaymentBL[j].varEntity = cboEntity.SelectedValue.ToString();
                                                        clsIncentivePaymentBL[j].varBranch = dr.Cells["ak_branch_id"].Value.ToString().Trim();
                                                        clsIncentivePaymentBL[j].varDivision = dr.Cells["ak_division_id"].Value.ToString().Trim();
                                                        clsIncentivePaymentBL[j].varValues = ConvertToDouble((dr.Cells["Collected"].Value == null) ? "" : dr.Cells["Collected"].Value.ToString());
                                                        clsIncentivePaymentBL[j].varValuesCWH = ConvertToDouble((dr.Cells["grdWo"].Value == null) ? "" : dr.Cells["grdWo"].Value.ToString());

                                                        CBARCollectionDepositEntryBL = new CBARCollectionDepositEntryBL()
                                                        {
                                                            ak_entity_id = clsIncentivePaymentBL[j].varEntity.ToString(),
                                                            ak_branch_id = clsIncentivePaymentBL[j].varBranch.ToString(),
                                                            ak_division_id = clsIncentivePaymentBL[j].varDivision.ToString()
                                                        };

                                                        DataTable dtColl = CBARCollectionDepositEntryAL.GetARGeneralParamCollection(CBARCollectionDepositEntryBL);
                                                        if (dtColl.Rows.Count > 0)
                                                        {
                                                            clsIncentivePaymentBL[j].varGL.mEntity = (dtColl.Rows[0]["gp_ar_gl_entity"].ToString() == "") ? clsIncentivePaymentBL[j].varEntity : dtColl.Rows[0]["gp_ar_gl_entity"].ToString();
                                                            clsIncentivePaymentBL[j].varGL.mBranch = (dtColl.Rows[0]["gp_ar_gl_branch"].ToString() == "") ? dtColl.Rows[0]["bc_initial"].ToString() : dtColl.Rows[0]["gp_ar_gl_branch"].ToString();
                                                            clsIncentivePaymentBL[j].varGL.mDivision = (dtColl.Rows[0]["gp_ar_gl_division"].ToString() == "") ? dtColl.Rows[0]["dc_division_account"].ToString() : dtColl.Rows[0]["gp_ar_gl_division"].ToString();
                                                            clsIncentivePaymentBL[j].varGL.mDepartment = dtColl.Rows[0]["gp_ar_gl_department"].ToString();
                                                            clsIncentivePaymentBL[j].varGL.mMajor1 = dtColl.Rows[0]["gp_ar_gl_major1"].ToString();
                                                            clsIncentivePaymentBL[j].varGL.mMajor2 = dtColl.Rows[0]["gp_ar_gl_major2"].ToString();
                                                            clsIncentivePaymentBL[j].varGL.mMinor = dtColl.Rows[0]["gp_ar_gl_minor"].ToString();
                                                            clsIncentivePaymentBL[j].varGL.mAnalisys = dtColl.Rows[0]["gp_ar_gl_analisys"].ToString();
                                                            clsIncentivePaymentBL[j].varGL.mFiller = dtColl.Rows[0]["gp_ar_gl_filler"].ToString();

                                                            clsIncentivePaymentBL[j].varGLCWH.mEntity = (dtColl.Rows[0]["gp_ar_write_gl_entity"].ToString() == "") ? clsIncentivePaymentBL[j].varEntity : dtColl.Rows[0]["gp_ar_write_gl_entity"].ToString();
                                                            clsIncentivePaymentBL[j].varGLCWH.mBranch = (dtColl.Rows[0]["gp_ar_write_gl_branch"].ToString() == "") ? dtColl.Rows[0]["bc_initial"].ToString() : dtColl.Rows[0]["gp_ar_write_gl_branch"].ToString();
                                                            clsIncentivePaymentBL[j].varGLCWH.mDivision = (dtColl.Rows[0]["gp_ar_write_gl_division"].ToString() == "") ? dtColl.Rows[0]["dc_division_account"].ToString() : dtColl.Rows[0]["gp_ar_write_gl_division"].ToString();
                                                            clsIncentivePaymentBL[j].varGLCWH.mDepartment = dtColl.Rows[0]["gp_ar_write_gl_department"].ToString();
                                                            clsIncentivePaymentBL[j].varGLCWH.mMajor1 = dtColl.Rows[0]["gp_ar_write_gl_major1"].ToString();
                                                            clsIncentivePaymentBL[j].varGLCWH.mMajor2 = dtColl.Rows[0]["gp_ar_write_gl_major2"].ToString();
                                                            clsIncentivePaymentBL[j].varGLCWH.mMinor = dtColl.Rows[0]["gp_ar_write_gl_minor"].ToString();
                                                            clsIncentivePaymentBL[j].varGLCWH.mAnalisys = dtColl.Rows[0]["gp_ar_write_gl_analisys"].ToString();
                                                            clsIncentivePaymentBL[j].varGLCWH.mFiller = dtColl.Rows[0]["gp_ar_write_gl_filler"].ToString();

                                                            _strVoucherType = dtColl.Rows[0]["gp_vt_for_collection_receipt"].ToString();

                                                            DataTable dtAccountGL = CBARCollectionDepositEntryAL.GetCheckAccountGL(clsIncentivePaymentBL[j]);
                                                            if (dtAccountGL.Rows.Count > 0)
                                                            {
                                                                clsIncentivePaymentBL[j].varGL.mCashCode = dtAccountGL.Rows[0]["ad_cash_id"].ToString();

                                                                DataTable dtAccountCWH = CBARCollectionDepositEntryAL.GetCheckAccountGLCWH(clsIncentivePaymentBL[j]);
                                                                if (dtAccountCWH.Rows.Count > 0)
                                                                {
                                                                    clsIncentivePaymentBL[j].varGLCWH.mCashCode = dtAccountCWH.Rows[0]["ad_cash_id"].ToString();
                                                                    _Status = true;
                                                                }
                                                                else
                                                                {
                                                                    _Status = false;
                                                                    clsAlert.PushAlert("Invalid G/L Chart of Account line" + " Entity : " + clsIncentivePaymentBL[j].varGLCWH.mEntity.ToString() + " Branch : " + clsIncentivePaymentBL[j].varGLCWH.mBranch.ToString() + " Division : " + clsIncentivePaymentBL[j].varGLCWH.mDivision.ToString(), clsAlert.Type.Error);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                _Status = false;
                                                                clsAlert.PushAlert("Invalid G/L Chart of Account line" + " Entity : " + clsIncentivePaymentBL[j].varGL.mEntity.ToString() + " Branch : " + clsIncentivePaymentBL[j].varGL.mBranch.ToString() + " Division : " + clsIncentivePaymentBL[j].varGL.mDivision.ToString(), clsAlert.Type.Error);
                                                            }

                                                            _blnSelect = true;
                                                        }
                                                        else
                                                        {
                                                            _Status = false;
                                                            clsAlert.PushAlert("Invalid G/L Chart of Account line" + " Entity : " + clsIncentivePaymentBL[j].varEntity.ToString() + " Branch : " + clsIncentivePaymentBL[j].varBranch.ToString() + " Division : " + clsIncentivePaymentBL[j].varDivision.ToString(), clsAlert.Type.Error);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        _Status = false;
                                    }
                                }
                                else
                                {
                                    clsAlert.PushAlert("Voucher Type Required!", clsAlert.Type.Error);
                                    txtVoucherRef.Focus();
                                    _Status = false;
                                }
                            }
                            else
                            {
                                clsAlert.PushAlert("Voucher Ref. Required!", clsAlert.Type.Error);
                                txtVoucherRef.Focus();
                                _Status = false;
                            }
                        }
                        else
                        {
                            clsAlert.PushAlert("Bank Account Required!", clsAlert.Type.Error);
                            cboBankAccount.Focus();
                            _Status = false;
                        }
                    }
                }
                else
                {
                    _Status = false;
                    clsAlert.PushAlert("Please entry Cash Code for Entity " + cboEntity.Text.Trim() + " !", clsAlert.Type.Error);
                }
            }
            else
            {
                _Status = false;
                ucReceiptFrom1.dtTransDate.Value = ucReceiptFrom1.dtTransDate.MinDate;
                clsAlert.PushAlert("Please Check Fiscal Calender!", clsAlert.Type.Error);
            }


            if(_Status == true)
            {
                _strVoucherType = cboVoucherType.Text.Trim();

                if(_strVoucherType != "")
                {
                    DataTable dtVoucherID = CBARCollectionDepositEntryAL.GetVoucherTypeID(_strVoucherType);
                    if(dtVoucherID.Rows.Count > 0)
                    {
                        ucVoucherID1.txtVoucherType.Text = _strVoucherType;

                        string _VoucherSeqNo = "CB" + cboBankID.Text.Trim() + cboBankAccount.Text.Trim() + _strVoucherType;
                        DataTable dtVoucherSeq = CBARCollectionDepositEntryAL.GetVoucherSeq(_VoucherSeqNo);
                        if (dtVoucherSeq.Rows.Count > 0)
                        {
                            if(dtVoucherSeq.Rows[0]["stsnew"].ToString() != "0")
                            {
                                ucVoucherID1.txtVoucherNo.Text = dtVoucherSeq.Rows[0]["intNo"].ToString();
                                ucVoucherID1.txtBankID.Text = cboBankID.Text.Trim();
                                ucVoucherID1.txtBankAccount.Text = cboBankAccount.Text.Trim();

                                _Status = true;
                            }
                            else
                            {
                                _Status = false;
                                clsAlert.PushAlert("Please Input Sequence Number Definition " + _VoucherSeqNo + " !", clsAlert.Type.Error);
                            }
                        }
                    }
                    else
                    {
                        _Status = false;
                        clsAlert.PushAlert("Please Entry Voucher Type!", clsAlert.Type.Error);
                    }
                }
                else
                {
                    _Status = false;
                    clsAlert.PushAlert("Please Input Voucher Type in AR General Parameter and Voucher Type Master!", clsAlert.Type.Error);
                }
            }

            return _Status;
        }

        private bool CBCashType(EnumCashType _CBCashType)
        {
            bool _Status = false;

            DataTable dt = CBARCollectionDepositEntryAL.GetCashType(_GLEntity);
            if (dt.Rows.Count > 0)
            {
                if (_CBCashType == EnumCashType.eIncentive)
                {
                    ucReceiptFrom1.txtCashCode.Text = dt.Rows[0]["gp_cashcode_incentive_collector"].ToString();
                }
                else if (_CBCashType == EnumCashType.eCommission)
                {
                    ucReceiptFrom1.txtCashCode.Text = dt.Rows[0]["gp_cashcode_sales_commission"].ToString();
                }
                else if (_CBCashType == EnumCashType.eDP_COD)
                {
                    ucReceiptFrom1.txtCashCode.Text = dt.Rows[0]["gp_cashcode_dp_uangmuka"].ToString();
                }
                else if (_CBCashType == EnumCashType.eCollection)
                {
                    ucReceiptFrom1.txtCashCode.Text = dt.Rows[0]["gp_cashcode_collection"].ToString();
                }

                _Status = true;
            }
            else
            {
                ucReceiptFrom1.txtCashCode.Text = string.Empty;
                _Status = false;
            }

            return _Status;
        }

        private void MoveAccount()
        {
            int i;

            //With BankEntry1
            //    .GetDefiner True, True, True, True, 0
            //    .LineEnabled True, All, 0
            //    'BankEntry1.LineEnabled False, account, 0
            //    .RemoveJournal

            //    .propDr(0) = txtTrancationAmount
            //    .Enablestatus(0)
            //End With

            ucBankEntry1.clearRowsGrd();

            //---------------------------------------------------------------------------------------------------------------------------------------

            DataTable dtAccount = CBARCollectionDepositEntryAL.GetBankGLAccount(cboBankID.Text.Trim(), cboBankAccount.Text.Trim());
            if (dtAccount.Rows.Count > 0)
            {
                //foreach (DataRow dr in dtAccount.Rows)
                //{
                    string _DC = "";
                    double _Debit, _Credit;
                    if(Convert.ToDouble(txtCollectedByCashier.Text.Trim()) + Convert.ToDouble(txtWriteOff.Text.Trim()) < 0)
                    {
                        _DC = "C";
                        _Credit = Math.Abs(Convert.ToDouble(txtCollectedByCashier.Text.Trim()) + Convert.ToDouble(txtWriteOff.Text.Trim()));
                        _Debit = 0;
                    }
                    else
                    {
                        _DC = "D";
                        _Credit = 0;
                        _Debit = Math.Abs(Convert.ToDouble(txtCollectedByCashier.Text.Trim()) + Convert.ToDouble(txtWriteOff.Text.Trim()));
                    }

                    ucBankEntry1.addRowsGrd(dtAccount.Rows[0]["bam_bank_Branch"].ToString(),
                                            dtAccount.Rows[0]["bam_bank_Division"].ToString(),
                                            dtAccount.Rows[0]["bam_bank_Department"].ToString(),
                                            dtAccount.Rows[0]["bam_bank_Major1"].ToString(),
                                            dtAccount.Rows[0]["bam_bank_Major2"].ToString(),
                                            dtAccount.Rows[0]["bam_bank_Minor"].ToString(),
                                            dtAccount.Rows[0]["bam_bank_Analysis"].ToString(),
                                            dtAccount.Rows[0]["bam_bank_filler"].ToString(), 
                                            "",
                                            "AR Collection Receipt", 
                                            _DC,
                                            _Debit,
                                            _Credit, 
                                            false,
                                            _DC,
                                            _Debit,
                                            _Credit,
                                            "");

                _GLEntity = dtAccount.Rows[0]["bam_bank_Entity"].ToString();
            }

            ucReceiptFrom1.txtTransAmount.Text = string.Format("{0:#,##0}", (Convert.ToDouble(txtCollectedByCashier.Text.Trim()) + Convert.ToDouble(txtWriteOff.Text.Trim())));

            //---------------------------------------------------------------------------------------------------------------------------------------

            for(i = 0; i <= clsIncentivePaymentBL.Count - 1; i++)
            {
                if (Convert.ToDouble(clsIncentivePaymentBL[i].varValues) != 0)
                {
                    string _DCGL = "";
                    double _DebitGL, _CreditGL;

                    if (Convert.ToDouble(clsIncentivePaymentBL[i].varValues) > 0)
                    {
                        _DCGL = "C";
                        _CreditGL = Convert.ToDouble(clsIncentivePaymentBL[i].varValues);
                        _DebitGL = 0;
                    }
                    else
                    {
                        _DCGL = "D";
                        _CreditGL = 0;
                        _DebitGL = Convert.ToDouble(clsIncentivePaymentBL[i].varValues);
                    }

                    ucBankEntry1.addRowsGrd(clsIncentivePaymentBL[i].varGL.mBranch.ToString(),
                                            clsIncentivePaymentBL[i].varGL.mDivision.ToString(),
                                            clsIncentivePaymentBL[i].varGL.mDepartment.ToString(),
                                            clsIncentivePaymentBL[i].varGL.mMajor1.ToString(),
                                            clsIncentivePaymentBL[i].varGL.mMajor2.ToString(),
                                            clsIncentivePaymentBL[i].varGL.mMinor.ToString(),
                                            clsIncentivePaymentBL[i].varGL.mAnalisys.ToString(),
                                            clsIncentivePaymentBL[i].varGL.mFiller.ToString(),
                                            "",
                                            "Collection Receipt",
                                            _DCGL,
                                            _DebitGL,
                                            _CreditGL,
                                            false,
                                            _DCGL,
                                            _DebitGL,
                                            _CreditGL,
                                            clsIncentivePaymentBL[i].varGL.mCashCode.ToString());
                }

                //---------------------------------------------------------------------------------------------------------------------------------------

                if (Convert.ToDouble(clsIncentivePaymentBL[i].varValuesCWH) != 0)
                {
                    string _DCGLCWH = "";
                    double _DebitGLCWH, _CreditGLCWH;

                    if (Convert.ToDouble(clsIncentivePaymentBL[i].varValuesCWH) > 0)
                    {
                        _DCGLCWH = "C";
                        _CreditGLCWH = Convert.ToDouble(clsIncentivePaymentBL[i].varValuesCWH);
                        _DebitGLCWH = 0;
                    }
                    else
                    {
                        _DCGLCWH = "D";
                        _CreditGLCWH = 0;
                        _DebitGLCWH = Math.Abs(Convert.ToDouble(clsIncentivePaymentBL[i].varValuesCWH));
                    }

                    //BankEntry1.GetDefiner EntityTemp.Branch, EntityTemp.Division, EntityTemp.Department, EntityTemp.filler, j
                    ucBankEntry1.addRowsGrd(clsIncentivePaymentBL[i].varGLCWH.mBranch.ToString(),
                                            clsIncentivePaymentBL[i].varGLCWH.mDivision.ToString(),
                                            clsIncentivePaymentBL[i].varGLCWH.mDepartment.ToString(),
                                            clsIncentivePaymentBL[i].varGLCWH.mMajor1.ToString(),
                                            clsIncentivePaymentBL[i].varGLCWH.mMajor2.ToString(),
                                            clsIncentivePaymentBL[i].varGLCWH.mMinor.ToString(),
                                            clsIncentivePaymentBL[i].varGLCWH.mAnalisys.ToString(),
                                            clsIncentivePaymentBL[i].varGLCWH.mFiller.ToString(),
                                            "",
                                            "Write Off Receipt",
                                            _DCGLCWH,
                                            _DebitGLCWH,
                                            _CreditGLCWH,
                                            false,
                                            _DCGLCWH,
                                            _DebitGLCWH,
                                            _CreditGLCWH,
                                            clsIncentivePaymentBL[i].varGLCWH.mCashCode.ToString());
                }
            }

            ucBankEntry1.Enabled = true;
        }

        private void settingPanel(clsEventButton.EnumAction _ActionType)
        {
            switch (_ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    {
                        if (_ExistForm != "VIEW")
                        {
                            pnlView.Visible = true;
                            pnlNew.Visible = false;
                            pnlReport.Visible = false;

                            _ExistForm = "VIEW";
                            setToolTip();
                            Helper.SetActive(navView);
                        }

                        break;
                    }
                case clsEventButton.EnumAction.NEW:
                    {
                        if(_ExistForm != "NEW")
                        {
                            if (_ExistForm == "VIEW")
                            {
                                if (UpdateToBank() == true)
                                {
                                    pnlView.Visible = false;
                                    pnlNew.Visible = true;
                                    pnlReport.Visible = false;
                                    MoveAccount();

                                    _ExistForm = "NEW";
                                    setToolTip();
                                    Helper.SetActive(navNew);
                                }
                            }
                            else
                            {
                                clsAlert.PushAlert("Back to View Menu First!", clsAlert.Type.Error);
                            }
                        }

                        break;
                    }
                case clsEventButton.EnumAction.EDIT:
                    {
                        break;
                    }
                case clsEventButton.EnumAction.DELETE:
                    {
                        break;
                    }
                case clsEventButton.EnumAction.PRINT:
                    {
                        if (_ExistForm != "PRINT")
                        {
                            if (_ExistForm == "VIEW")
                            {
                                uccbOtherDoc1.loadForm();
                                uccbOtherDoc1._ShowDoc(UCCBOtherDoc.ePrintDoc.eReceipt);

                                pnlNew.Visible = false;
                                pnlView.Visible = false;
                                pnlReport.Visible = true;

                                _ExistForm = "PRINT";
                                setToolTip();
                                Helper.SetActive(navPrint);
                            }
                            else
                            {
                                clsAlert.PushAlert("Back to View Menu First!", clsAlert.Type.Error);
                            }
                        }

                        break;
                    }
                case clsEventButton.EnumAction.EXPORT:
                    {
                        break;
                    }
                case clsEventButton.EnumAction.EXIT:
                    {
                        Close();
                        break;
                    }
                case clsEventButton.EnumAction.CANCEL:
                    {
                        pnlNew.Visible = false;
                        pnlView.Visible = true;
                        pnlReport.Visible = false;

                        _ExistForm = "VIEW";
                        setToolTip();
                        Helper.SetActive(navView);

                        break;
                    }
                case clsEventButton.EnumAction.SAVE:
                    {
                        ProcessSave();
                        break;
                    }
                default:
                    {
                        pnlView.Visible = true;
                        pnlNew.Visible = false;
                        pnlReport.Visible = false;

                        _ExistForm = "VIEW";
                        setToolTip();
                        Helper.SetActive(navView);
                        break;
                    }
            }
        }

        private bool CheckAccountGL()
        {
            bool _Result = false;
            bool _stsGl, _StsValue;
            int _line;

            foreach (DataGridViewRow dr in ucBankEntry1.grd.Rows)
            {
                _line = 1;

                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dr.Cells["Delete"];
                if (Convert.ToBoolean(chk.Value) == Convert.ToBoolean(chk.FalseValue))
                {
                    _stsGl = false;
                    _StsValue = false;

                    string _Param = string.Empty;
                    _Param = dr.Cells["GLAccountBranch"].ToString().Trim();
                    _Param = _Param + dr.Cells["GLAccountDivision"].ToString().Trim();
                    _Param = _Param + dr.Cells["GLAccountDepartment"].ToString().Trim();
                    _Param = _Param + dr.Cells["GLAccountMajor1"].ToString().Trim();
                    _Param = _Param + dr.Cells["GLAccountMajor2"].ToString().Trim();
                    _Param = _Param + dr.Cells["GLAccountMinor"].ToString().Trim();
                    _Param = _Param + dr.Cells["GLAccountAnalysis"].ToString().Trim();
                    _Param = _Param + dr.Cells["GLAccountFiler"].ToString().Trim();

                    if (_Param != string.Empty)
                    {
                        clsIncentivePaymentBL.Clear();
                        clsIncentivePaymentBL.Add(new CBARCollectionDepositEntryIncentivePaymentBL());
                        int j = 0;

                        clsIncentivePaymentBL[j].varGL.mEntity = _GLEntity.ToString();
                        clsIncentivePaymentBL[j].varGL.mBranch = dr.Cells["GLAccountBranch"].Value.ToString().Trim();
                        clsIncentivePaymentBL[j].varGL.mDivision = dr.Cells["GLAccountDivision"].Value.ToString().Trim();
                        clsIncentivePaymentBL[j].varGL.mDepartment = dr.Cells["GLAccountDepartment"].Value.ToString().Trim();
                        clsIncentivePaymentBL[j].varGL.mMajor1 = dr.Cells["GLAccountMajor1"].Value.ToString().Trim();
                        clsIncentivePaymentBL[j].varGL.mMajor2 = dr.Cells["GLAccountMajor2"].Value.ToString().Trim();
                        clsIncentivePaymentBL[j].varGL.mMinor = dr.Cells["GLAccountMinor"].Value.ToString().Trim();
                        clsIncentivePaymentBL[j].varGL.mAnalisys = dr.Cells["GLAccountAnalysis"].Value.ToString().Trim();
                        clsIncentivePaymentBL[j].varGL.mFiller = dr.Cells["GLAccountFiler"].Value.ToString().Trim();

                        DataTable dt = CBARCollectionDepositEntryAL.GetCheckAccountOK(clsIncentivePaymentBL[j]);
                        if (dt.Rows.Count > 0)
                        {
                            _stsGl = false;

                            dr.Cells["CashCode"].Value = "";
                            if(dt.Rows[0]["ad_status"].ToString() == "D")
                            {
                                _stsGl = true;
                            }
                        }
                    }

                    if(Convert.ToDouble(dr.Cells["Debit"].Value) + Convert.ToDouble(dr.Cells["Credit"].Value) == 0)
                    {
                        _StsValue = false;
                    }
                    else
                    {
                        _StsValue = true;
                    }

                    //CHECK
                    if(_stsGl == _StsValue)
                    {
                        if (_stsGl == true && _StsValue == true)
                        {
                            //    ReDim Preserve varArrListSave(j)
                            //    varArrListSave(j) = i
                            //    j = j + 1


                        }
                    }
                    else
                    {
                        if (_stsGl == false)
                        {
                            clsAlert.PushAlert("Invalid G/L Chart of Account line " + _line.ToString() + " !", clsAlert.Type.Error);
                        }
                        else if(_StsValue == false)
                        {
                            clsAlert.PushAlert("You have to fill Credit or Debit Amount line  " + _line.ToString() + " !", clsAlert.Type.Error);

                            if(dr.Cells["DC"].ToString() == "C")
                            {
                                ucBankEntry1.grd.CurrentCell = dr.Cells["Credit"];
                            }
                            else if (dr.Cells["DC"].ToString() == "D")
                            {
                                ucBankEntry1.grd.CurrentCell = dr.Cells["Debit"];
                            }
                            else
                            {
                                ucBankEntry1.grd.CurrentCell = dr.Cells["DC"];
                            }

                            _Result = false;
                        }
                    }
                }
            }

            return _Result;
        }

        private bool AddSQLStr()
        {
            bool _Result = false;

            double _ReceiptAmount = 0;
            if (Convert.ToDouble(ucReceiptFrom1.txtTransAmount.Text.Trim()) > 0)
            {
                if (ucBankEntry1.grd.Rows[0].Cells["DC"].Value.ToString() == "C")
                {
                    _ReceiptAmount = Convert.ToDouble(ucReceiptFrom1.txtTransAmount.Text.Trim()) * -1;
                }
                else
                {
                    _ReceiptAmount = Convert.ToDouble(ucReceiptFrom1.txtTransAmount.Text.Trim());
                }
            }
            else
            {
                _ReceiptAmount = 0;
            }

            CBARCollectionDepositEntryVoucherTxnBL = new CBARCollectionDepositEntryVoucherTxnBL()
            {
                vt_bank_id = ucVoucherID1.txtBankID.Text.Trim().ToString(),
                vt_bank_sub_id = ucVoucherID1.txtBankAccount.Text.ToString().Trim(),
                vt_voucher_type = ucVoucherID1.txtVoucherType.Text.ToString().Trim(),
                vt_voucher_seq = Convert.ToDouble(ucVoucherID1.txtVoucherNo.Text.ToString().Trim()),
                vt_bank_txn_type = (ucBankEntry1.grd.Rows[0].Cells["DC"].Value.ToString() == "C") ? "P" : "R" ,
                vt_voucher_ref = ucVoucherID1.txtVoucherRef.Text.ToString().Trim(),
                vt_receipt_paid_to_name = ucReceiptFrom1.txtReceiptFrom.Text.Trim(),
                vt_txn_description = ucReceiptFrom1.txtRemarks.Text.Trim(),
                vt_bank_account_number = cboBankAccount.Text.Trim(),
                vt_gl_entity = _GLEntity.ToString(),
                vt_gl_branch = ucBankEntry1.grd.Rows[0].Cells["GLAccountBranch"].Value.ToString(),
                vt_gl_division= ucBankEntry1.grd.Rows[0].Cells["GLAccountDivision"].Value.ToString(),
                vt_gl_department = ucBankEntry1.grd.Rows[0].Cells["GLAccountDepartment"].Value.ToString(),
                vt_gl_major1 = ucBankEntry1.grd.Rows[0].Cells["GLAccountMajor1"].Value.ToString(),
                vt_gl_major2 = ucBankEntry1.grd.Rows[0].Cells["GLAccountMajor2"].Value.ToString(),
                vt_gl_minor = ucBankEntry1.grd.Rows[0].Cells["GLAccountMinor"].Value.ToString(),
                vt_gl_analysis = ucBankEntry1.grd.Rows[0].Cells["GLAccountAnalysis"].Value.ToString(),
                vt_gl_filler = ucBankEntry1.grd.Rows[0].Cells["GLAccountFiler"].Value.ToString(),
                vt_cheque_giro_number = ucCheque1.txtNo.Text.Trim(),
                vt_cheque_giro_reference = ucCheque1.txtRef.Text.Trim(),
                vt_cheque_giro_date = ucCheque1.dtDate.Value.Date,
                vt_original_cheque_currency = ucCheque1.cboCurrCode.Text.Trim(),
                vt_original_cheque_amount = (Convert.ToDouble(ucCheque1.txtAmount.Text.Trim()) > 0) ? Convert.ToDouble(ucCheque1.txtAmount.Text.Trim()) : 0,
                vt_current_rate = (Convert.ToDouble(ucCheque1.txtCurrRate.Text.Trim()) > 0) ? Convert.ToDouble(ucCheque1.txtCurrRate.Text.Trim()) : 0,
                vt_txn_base_amount = _ReceiptAmount,
                //'@vt_cash_code_26   [char](5),
                //Sqlstr = Sqlstr + FmtStr(Trim(BankEntry1.propCashCode(varArrListSave(UBound(varArrListSave))))) + " , "
                //'@vt_no_of_distribution_line_27     [numeric],
                //Sqlstr = Sqlstr + str(UBound(varArrListSave) + 1) + " , "

                //vt_cash_code = dtAssignDateSor.Value.Date,
                //vt_no_of_distribution_line = dtAssignDateSor.Value.Date,
                vt_entry_date = ucReceiptFrom1.dtTransDate.Value.Date,
                vt_user_id = clsLogin.USERID.ToString(),
            };

            bool _IsAddSQLStr = CBARCollectionDepositEntryAL.PostADDSQLSTR(CBARCollectionDepositEntryVoucherTxnBL);
            if (_IsAddSQLStr == true)
            {
                double _VarValue = 0;
                string _ReceiptDisbursement = "";
                if (ucBankEntry1.grd.Rows[0].Cells["DC"].Value.ToString() == "C")
                {
                    _VarValue = Convert.ToDouble(ucReceiptFrom1.txtTransAmount.Text.Trim()) * -1;
                    _ReceiptDisbursement = "P";
                }
                else
                {
                    _VarValue = Convert.ToDouble(ucReceiptFrom1.txtTransAmount.Text.Trim());
                    _ReceiptDisbursement = "R";
                }

                bool _IsEditCBBankACCMasterTxn = CBARCollectionDepositEntryAL.PostEditCBBankAccMasterTxn(ucReceiptFrom1.dtTransDate.Value.Year.ToString("yyyy"), cboBankID.Text.Trim(), cboBankAccount.Text.Trim(), ucReceiptFrom1.dtTransDate.Value.Month.ToString("MM"), _VarValue, _ReceiptDisbursement);
                if (_IsEditCBBankACCMasterTxn == true)
                {
                    _Result = true;
                }
                else
                {
                    _Result = false;
                }
            }
            else
            {
                _Result = false;
            }

            return _Result;
        }

        private bool SqlDistribution()
        {
            bool _Result = false;

            CBARCollectionDepositEntryVoucherDistTxnBL = new CBARCollectionDepositEntryVoucherDistTxnBL()
            {
                cbv_bank_id = ucVoucherID1.txtBankID.Text.Trim().ToString(),
                cbv_sub_bank_id = ucVoucherID1.txtBankAccount.Text.ToString().Trim(),
                cbv_voucher_type = ucVoucherID1.txtVoucherType.Text.ToString().Trim(),
                cbv_seq_no = Convert.ToDouble(ucVoucherID1.txtVoucherNo.Text.ToString().Trim()),
                cbv_bank_txn_type = (ucBankEntry1.grd.Rows[0].Cells["DC"].Value.ToString() == "C") ? "P" : "R",
                cbv_voucher_ref = ucVoucherID1.txtVoucherRef.Text.ToString().Trim(),
                cbv_receipt_paid_to_name = ucReceiptFrom1.txtReceiptFrom.Text.Trim(),
                cbv_txn_date = ucReceiptFrom1.dtTransDate.Value.Date,
                cbv_interfaced_user = clsLogin.USERID.ToString(),
                //vt_gl_entity = _GLEntity.ToString(),
                //vt_gl_branch = ucBankEntry1.grd.Rows[0].Cells["GLAccountBranch"].Value.ToString(),
                //vt_gl_division = ucBankEntry1.grd.Rows[0].Cells["GLAccountDivision"].Value.ToString(),
                //vt_gl_department = ucBankEntry1.grd.Rows[0].Cells["GLAccountDepartment"].Value.ToString(),
                //vt_gl_major1 = ucBankEntry1.grd.Rows[0].Cells["GLAccountMajor1"].Value.ToString(),
                //vt_gl_major2 = ucBankEntry1.grd.Rows[0].Cells["GLAccountMajor2"].Value.ToString(),
                //vt_gl_minor = ucBankEntry1.grd.Rows[0].Cells["GLAccountMinor"].Value.ToString(),
                //vt_gl_analysis = ucBankEntry1.grd.Rows[0].Cells["GLAccountAnalysis"].Value.ToString(),
                //vt_gl_filler = ucBankEntry1.grd.Rows[0].Cells["GLAccountFiler"].Value.ToString(),
                //vt_cheque_giro_number = ucCheque1.txtUCCNo.Text.Trim(),
                //vt_cheque_giro_reference = ucCheque1.txtUCCRef.Text.Trim(),
                //vt_cheque_giro_date = ucCheque1.dtUCCDate.Value.Date,
                //vt_original_cheque_currency = ucCheque1.cboUCCCurrCode.Text.Trim(),
                //vt_original_cheque_amount = (Convert.ToDouble(ucCheque1.txtUCCAmount.Text.Trim()) > 0) ? Convert.ToDouble(ucCheque1.txtUCCAmount.Text.Trim()) : 0,
                //vt_current_rate = (Convert.ToDouble(ucCheque1.txtUCCCurrRate.Text.Trim()) > 0) ? Convert.ToDouble(ucCheque1.txtUCCCurrRate.Text.Trim()) : 0,
                //vt_txn_base_amount = _ReceiptAmount,
                //vt_entry_date = ucReceiptFrom1.dtUCRFTransDate.Value.Date,
                //vt_user_id = clsLogin.USERID.ToString(),
            };

            return _Result;
        }

        private bool UpdateAR()
        {
            bool _Result = false;

            foreach(DataGridViewRow dr in grd.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dr.Cells["grdDeposit"];
                if (Convert.ToBoolean(chk.Value) == Convert.ToBoolean(chk.TrueValue))
                {
                    string _Data = dr.Cells["ak_item_seq_number"].ToString();
                    if ((_Data.Substring(_Data.Length - 3, 3)).Trim() == "DP" || (_Data.Substring(_Data.Length - 3, 3)).Trim() == "OD")
                    {
                        if((_Data.Substring(_Data.Length - 3, 3)).Trim() == "DP")
                        {
                            _VarSelected = _SelectType.DP_UangMuka_AR.ToString();
                        }
                        else
                        {
                            _VarSelected = _SelectType.COD_AR.ToString();
                        }

                        //==================================================
                        // update dp/cod
                        //===================================================

                        if(_VarSelected == _SelectType.DP_UangMuka_AR.ToString())
                        {
                            bool _IsDP = CBARCollectionDepositEntryAL.PostEditDownPaymentDP(dr.Cells["ak_so_number"].Value.ToString(),
                                                                                                                Convert.ToDouble(dr.Cells["Collected"].Value),
                                                                                                                ucVoucherID1.txtVoucherType.Text.Trim(),
                                                                                                                ucVoucherID1.txtVoucherNo.Text.Trim(),
                                                                                                                ucVoucherID1.txtVoucherRef.Text.Trim(), 
                                                                                                                ucReceiptFrom1.dtTransDate.Value.Date, 
                                                                                                                clsLogin.USERID.ToString());
                            if (_IsDP == true)
                            {
                                _Result = true;
                            }
                            else
                            {
                                _Result = false;
                            }
                        }
                        else if(_VarSelected == _SelectType.COD_AR.ToString())
                        {
                            bool _IsCOD = CBARCollectionDepositEntryAL.PostEditDownPaymentCOD(dr.Cells["ak_so_number"].Value.ToString(),
                                                                                                                Convert.ToDouble(dr.Cells["Collected"].Value),
                                                                                                                ucVoucherID1.txtVoucherType.Text.Trim(),
                                                                                                                ucVoucherID1.txtVoucherNo.Text.Trim(),
                                                                                                                ucVoucherID1.txtVoucherRef.Text.Trim(),
                                                                                                                ucReceiptFrom1.dtTransDate.Value.Date,
                                                                                                                clsLogin.USERID.ToString());
                            if (_IsCOD == true)
                            {
                                _Result = true;
                            }
                            else
                            {
                                _Result = false;
                            }
                        }


                    }
                }
            }

            return _Result;
        }

        private void ProcessSave()
        {
            if(ucReceiptFrom1.txtReceiptFrom.Text.Trim() != string.Empty)
            {
                if(CheckAccountGL() == true)
                {
                    if(AddSQLStr() == true)
                    {
                        if(SqlDistribution() == true)
                        {
                            if (UpdateAR() == true)
                            {
                                pnlNew.Visible = false;
                                pnlView.Visible = true;
                                ucVoucherID1.txtVoucherNo.Text = string.Empty;
                                ucVoucherID1.txtBankID.Text = string.Empty;
                                ucVoucherID1.txtBankAccount.Text = string.Empty;
                                DisplayData();
                                ucVoucherID1.txtVoucherNo.Text = string.Empty;
                                txtItemAmount.Text = "0";
                                txtCollectedByCashier.Text = "0";
                                txtWriteOff.Text = "0";
                                txtItemDeposit.Text = "0";
                            }
                            else
                            {
                                clsAlert.PushAlert("Failed Proccess UPDATE AR!", clsAlert.Type.Error);
                            }
                        }
                        else
                        {
                            clsAlert.PushAlert("Failed Proccess SQL DISTRIBUTION!", clsAlert.Type.Error);
                        }
                    }
                    else
                    {
                        clsAlert.PushAlert("Failed Proccess ADDSQLSTR!", clsAlert.Type.Error);
                    }
                }
                else
                {
                    clsAlert.PushAlert("Failed Proccess CHECK ACCOUNT GL!", clsAlert.Type.Error);
                }
            }
            else
            {
                clsAlert.PushAlert("Receipt From Required!", clsAlert.Type.Error);
                ucReceiptFrom1.txtReceiptFrom.Focus();
            }
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.EXIT);
        }

        private void getPropertyUser()
        {
            DataTable dt = CBARCollectionDepositEntryAL.GetPropertyUser();
            _UserEntityID = dt.Rows[0]["usr_entity_id"].ToString();
            _UserEntity = dt.Rows[0]["ec_entity"].ToString();
            _UserBranchID = dt.Rows[0]["usr_branch_id"].ToString();
            _UserDivisionID = dt.Rows[0]["usr_Division_id"].ToString();
            _UserGroupID = dt.Rows[0]["usr_group_id"].ToString();
        }

        private void loadCboEntity()
        {
            cboEntity.DataSource = CBARCollectionDepositEntryAL.GetEntity(true);
            cboEntity.ValueMember = "ValueMember";
            cboEntity.DisplayMember = "DisplayMember";

            if (_UserEntityID.Trim() != "0")
            {
                cboEntity.Enabled = false;
                cboEntity.SelectedValue = _UserEntityID;
            }
            else
            {
                cboEntity.Enabled = true;
                cboEntity.SelectedIndex = 2;
            }
        }

        private void loadCboBranch()
        {
            cboBranch.DataSource = CBARCollectionDepositEntryAL.GetBranch(true);
            cboBranch.ValueMember = "ValueMember";
            cboBranch.DisplayMember = "DisplayMember";

            if (_UserBranchID.Trim() != "0")
            {
                cboBranch.Enabled = false;
                cboBranch.SelectedValue = _UserBranchID.Trim();
            }
            else
            {
                cboBranch.Enabled = true;
                cboBranch.SelectedIndex = 0;
            }
        }

        private void loadCboDivision()
        {
            cboDivision.DataSource = CBARCollectionDepositEntryAL.GetDivision(true);
            cboDivision.ValueMember = "ValueMember";
            cboDivision.DisplayMember = "DisplayMember";

            if (_UserDivisionID.Trim() != "0")
            {
                cboDivision.Enabled = false;
                cboDivision.SelectedValue = _UserDivisionID;
            }
            else
            {
                cboDivision.Enabled = true;
                cboDivision.SelectedIndex = 0;
            }
        }

        private void loadCboPaymentType()
        {
            cboPaymentType.DataSource = CBARCollectionDepositEntryAL.GetHardCodedPaymentType(true);
            cboPaymentType.ValueMember = "ValueMember";
            cboPaymentType.DisplayMember = "DisplayMember";
            cboPaymentType.SelectedIndex = 0;
        }

        private void rbCollectorPlan_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCollectorPlan.Checked == true)
            {
                grpPlan.Enabled = true;
                grpOutstanding.Enabled = false;
            }
            else
            {
                grpPlan.Enabled = false;
                grpOutstanding.Enabled = true;
            }
        }

        private void rbOutstandingKW_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOutstandingKW.Checked == true || rbAllOutstandingItem.Checked == true)
            {
                grpPlan.Enabled = false;
                grpOutstanding.Enabled = true;
            }
            else
            {
                grpPlan.Enabled = true;
                grpOutstanding.Enabled = false;
            }
        }

        private void rbAllOutstandingItem_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOutstandingKW.Checked == true || rbAllOutstandingItem.Checked == true)
            {
                grpPlan.Enabled = false;
                grpOutstanding.Enabled = true;
            }
            else
            {
                grpPlan.Enabled = true;
                grpOutstanding.Enabled = false;
            }
        }

        private void cboBankID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboBankAccount.DataSource = CBARCollectionDepositEntryAL.GetBankAccountToComboBox(false, cboBankID.Text.Trim().ToUpper(), "R");
            cboBankAccount.ValueMember = "ValueMember";
            cboBankAccount.DisplayMember = "DisplayMember";
            cboBankAccount.SelectedIndex = -1;
        }

        private void DisplayData()
        {
            txtItemAmount.Text = "0";
            txtCollectedByCashier.Text = "0";
            txtItemDeposit.Text = "0";

            _GLEntity = cboEntity.SelectedValue.ToString();
            DataTable dtDate = CBARCollectionDepositEntryAL.GetSelectGeneralFiscalCalenderOpen("CB", _GLEntity);
            if (dtDate.Rows.Count > 0)
            {
                ucReceiptFrom1.dtTransDate.MinDate = Convert.ToDateTime(dtDate.Rows[0]["gfc_begining_date"]);
                ucReceiptFrom1.dtTransDate.Value = Convert.ToDateTime(dtDate.Rows[0]["curr_date"]);
                txtFiscalCalender.Text = ucReceiptFrom1.dtTransDate.Value.ToString("MMM yyyy");
            }
            else
            {
                ucReceiptFrom1.dtTransDate.Value = ucReceiptFrom1.dtTransDate.MinDate;
            }

            if (rbCollectorPlan.Checked == true)
            {
                _VarSelected = _SelectType.Collector_Plan.ToString();

                CBARCollectionDepositEntryBL = new CBARCollectionDepositEntryBL()
                {
                    ak_entity_id = cboEntity.SelectedValue.ToString(),
                    ak_branch_id = cboBranch.SelectedValue.ToString(),
                    ak_division_id = cboDivision.SelectedValue.ToString(),
                    ak_collector_id = cboCollectorIDPlan.SelectedValue.ToString(),
                    ak_kw_visit_date = dtValidDate.Value.Date,
                    ak_kw_payment_type = (cboPaymentType.Text == "VISA ORDER") ? "VISA OTOMATIS" : cboPaymentType.Text.ToString().ToUpper()
                };

                bool _IsValidDate = (chbNullValidateDate.Checked == true) ? true : false;

                DataTable dt = CBARCollectionDepositEntryAL.ReadCollectorPlan(EnumFilter.GET_ALL, CBARCollectionDepositEntryBL, 1, 50, _IsValidDate, clsLogin.USERID.ToString());
                grd.AutoGenerateColumns = false;
                grd.DataSource = dt;
            }
            else if (rbOutstandingKW.Checked == true)
            {
                _VarSelected = _SelectType.Outstanding_KW.ToString();

                CBARCollectionDepositEntryBL = new CBARCollectionDepositEntryBL()
                {
                    ak_entity_id = cboEntity.SelectedValue.ToString(),
                    ak_branch_id = cboBranch.SelectedValue.ToString(),
                    ak_division_id = cboDivision.SelectedValue.ToString(),
                    ak_collector_id = cboCollectorIDPlan.SelectedValue.ToString(),
                    ak_customer_id = txtCustomerID.Text.Trim(),
                    ak_item_number = txtInvoiceNo.Text.Trim()
                };

                DataTable dt = CBARCollectionDepositEntryAL.ReadOutstandingKW(EnumFilter.GET_ALL, CBARCollectionDepositEntryBL, 1, 50, clsLogin.USERID.ToString());
                grd.AutoGenerateColumns = false;
                grd.DataSource = dt;
            }
            else if (rbAllOutstandingItem.Checked == true)
            {
                _VarSelected = _SelectType.All_Outstanding.ToString();

                CBARCollectionDepositEntryBL = new CBARCollectionDepositEntryBL()
                {
                    ak_entity_id = cboEntity.SelectedValue.ToString(),
                    ak_branch_id = cboBranch.SelectedValue.ToString(),
                    ak_division_id = cboDivision.SelectedValue.ToString(),
                    ak_collector_id = cboCollectorIDPlan.SelectedValue.ToString(),
                    ak_customer_id = txtCustomerID.Text.Trim(),
                    ak_item_number = txtInvoiceNo.Text.Trim()
                };

                DataTable dt = CBARCollectionDepositEntryAL.ReadAllOutstandingItem(EnumFilter.GET_ALL, CBARCollectionDepositEntryBL, 1, 50, clsLogin.USERID.ToString());
                grd.AutoGenerateColumns = false;
                grd.DataSource = dt;
            }

        }

        private void SetStructureDef()
        {
            DataTable dt = CBARCollectionDepositEntryAL.GetStructureDef(cboEntity.SelectedValue.ToString());

            if(dt.Rows.Count > 0)
            {
                _BranchFlag = (dt.Rows[0]["ec_branch_flag"].ToString() == "Y") ? true : false;
                _DivisionFlag = (dt.Rows[0]["ec_division_flag"].ToString() == "Y") ? true : false;
                _DepartmentFlag = (dt.Rows[0]["ec_department_flag"].ToString() == "Y") ? true : false;
                _FilerFlag = (dt.Rows[0]["ec_filler_flag"].ToString() == "Y") ? true : false;
            }        
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            DisplayData();
            SetStructureDef();
            btnSearch.Enabled = true;
        }

        private void ReviewGrd()
        {
            //SHOW JUST CHECKED
            if (_IsViewAll == true)
            {
                foreach (DataGridViewRow dr in grd.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dr.Cells["grdDeposit"];

                    if (chk.Value == null)
                    {
                        dr.Visible = false;
                    }
                    else if (Convert.ToBoolean(chk.Value) == Convert.ToBoolean(chk.FalseValue))
                    {
                        dr.Visible = false;
                    }
                }

                _IsViewAll = false;
            }
            else
            {
                //SHOW ALL DATA
                foreach (DataGridViewRow dr in grd.Rows)
                {
                    dr.Visible = true;
                }

                _IsViewAll = true;
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            if(grd.Rows.Count > 0)
            {
                ReviewGrd();
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if(((txtCollectedByCashier.Text.Trim() == "") ? 0 : Convert.ToDouble(txtCollectedByCashier.Text.Trim())) != 0 || ((txtWriteOff.Text.Trim() == "") ? 0 : Convert.ToDouble(txtWriteOff.Text.Trim())) != 0)
            {
                if(UpdateToBank() == true && navNew.Enabled == true)
                {
                    pnlView.Visible = false;
                    pnlNew.Visible = true;
                    ucBankEntry1.Enabled = true;
                    MoveAccount();
                }
            }
        }

        private void cboEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboEntity.SelectedIndex == 0)
            {
                cboEntity.SelectedIndex = 2;
            }
        }

        private void ColumnValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (grd.CurrentCell.ColumnIndex == 3 || grd.CurrentCell.ColumnIndex == 4 || grd.CurrentCell.ColumnIndex == 5 || grd.CurrentCell.ColumnIndex == 9 || grd.CurrentCell.ColumnIndex == 10 || grd.CurrentCell.ColumnIndex == 11)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.CANCEL);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.SAVE);
        }

        private void grd_KeyPress(object sender, KeyPressEventArgs e)
        {
            string typedChars = string.Empty;

            //if (e.KeyChar == '\l' || e.KeyChar == Keys.Right || e.KeyChar == Keys.Up || e.KeyChar == Keys.Down)
            //{
            //    typedChars = string.Empty;
            //    return;
            //}

            if (Char.IsLetter(e.KeyChar))
            {
                typedChars += e.KeyChar.ToString();

                for (int i = 0; i < (grd.Rows.Count); i++)
                {
                    if (grd.Rows[i].Cells["scm_customer_name"].Value.ToString().StartsWith(typedChars, true, CultureInfo.InvariantCulture))
                    {
                        grd.Rows[i].Cells[0].Selected = true;
                        return; // stop looping
                    }
                }
            }
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grd.CurrentCell.ColumnIndex == 12)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)grd.Rows[e.RowIndex].Cells["grdDeposit"];
                if (chk.Value == null)
                {
                    chk.Value = Convert.ToBoolean(chk.TrueValue);
                }
                else if (Convert.ToBoolean(chk.Value) == Convert.ToBoolean(chk.TrueValue))
                {
                    grd.Rows[e.RowIndex].Cells["Collected"].Value = grd.Rows[e.RowIndex].Cells["Column13"].Value;
                    grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = "";
                    grd.Rows[e.RowIndex].Cells["grdWo"].Value = "";

                    chk.Value = Convert.ToBoolean(chk.FalseValue);
                }
                else if (Convert.ToBoolean(chk.Value) == Convert.ToBoolean(chk.FalseValue))
                {
                    chk.Value = Convert.ToBoolean(chk.TrueValue);
                }

                //OVER FOCUS TO REMOVE ERROR WHEN SORTING
                grd.CurrentCell = grd.Rows[e.RowIndex].Cells["scm_customer_name"];

                grd.RefreshEdit();
                grd.NotifyCurrentCellDirty(true);

                TotalAll();
            }
        }

        private void grd_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(ColumnValue_KeyPress);
            if (grd.CurrentCell.ColumnIndex == 3 || grd.CurrentCell.ColumnIndex == 4 || grd.CurrentCell.ColumnIndex == 5 || grd.CurrentCell.ColumnIndex == 9 || grd.CurrentCell.ColumnIndex == 10 || grd.CurrentCell.ColumnIndex == 11)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(ColumnValue_KeyPress);
                }
            }
        }

        private void grd_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (grd.CurrentCell.ColumnIndex == 9)
            {
                CBARCollectionDepositEntryBL = new CBARCollectionDepositEntryBL()
                {
                    ak_entity_id = cboEntity.SelectedValue.ToString(),
                    ak_branch_id = grd.Rows[e.RowIndex].Cells["ak_branch_id"].Value.ToString().Trim(),
                    ak_division_id = grd.Rows[e.RowIndex].Cells["ak_division_id"].Value.ToString().Trim()
                };

                DataTable dt = CBARCollectionDepositEntryAL.GetARGeneralParamWOStatus(CBARCollectionDepositEntryBL);
                if(dt.Rows.Count > 0)
                {
                    grd.Rows[e.RowIndex].Cells["Column16"].Value = dt.Rows[0]["gp_max_write_off_amount"].ToString();
                }
            }
        }

        private void grd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
            {
            //UNTUK YANG NILAI PLUS
            if(Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value) > 0)
            {
                //AMOUNT BY CHASIER COLLECTED.
                if (grd.CurrentCell.ColumnIndex == 9)
                {
                    grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = "";
                    grd.Rows[e.RowIndex].Cells["grdWo"].Value = "";

                    if (grd.Rows[e.RowIndex].Cells["Collected"].Value != null)
                    {
                        if (grd.Rows[e.RowIndex].Cells["Collected"].Value.ToString() != "")
                        {
                            if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value) != 0)
                            {
                                if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value) > Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value))
                                {
                                    grd.Rows[e.RowIndex].Cells["grdWo"].Value = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value) - Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value);
                                }
                                else
                                {
                                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)grd.Rows[e.RowIndex].Cells["grdDeposit"];
                                    chk.Value = Convert.ToBoolean(chk.TrueValue);

                                    if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value) <= Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value))
                                    {
                                        grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value) - Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value);

                                        if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString().Replace(",", "")) <= Convert.ToInt64((grd.Rows[e.RowIndex].Cells["Column16"].Value.ToString() == "") ? 0 : grd.Rows[e.RowIndex].Cells["Column16"].Value))
                                        {
                                            grd.Rows[e.RowIndex].Cells["grdWo"].Value = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString().Replace(",", ""));
                                            grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = "";
                                        }
                                    }
                                    else
                                    {
                                        grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = "";
                                        grd.Rows[e.RowIndex].Cells["grdWo"].Value = "";
                                    }
                                }
                            }
                        }
                    }
                }
                //AMOUNT BY CHASIER OUTS.
                else if (grd.CurrentCell.ColumnIndex == 10)
                {
                    if (grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value != null)
                    {
                        if (grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString() != "")
                        {
                            if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString().Replace(",", "")) != 0)
                            {
                                if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value) < Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value) + Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString().Replace(",", "")))
                                {
                                    grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value) - Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value);
                                }
                            }
                        }
                    }
                }
                //KOLOM WO
                else if (grd.CurrentCell.ColumnIndex == 11)
                {
                    if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value) == Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value))
                    {
                        grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = string.Empty;
                        grd.Rows[e.RowIndex].Cells["grdWo"].Value = string.Empty;
                    }
                    else if (grd.Rows[e.RowIndex].Cells["grdWo"].Value != null)
                    {
                        if (grd.Rows[e.RowIndex].Cells["grdWo"].Value.ToString() != "")
                        {
                            grd.Rows[e.RowIndex].Cells["grdWo"].Value = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdWo"].Value.ToString().Replace(",", ""));

                            if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdWo"].Value.ToString().Replace(",", "")) != 0)
                            {
                                grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value) - Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value) - Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdWo"].Value.ToString().Replace(",", ""));
                            }
                        }
                    }
                }

                //JIKA SELAIN COLLECTOR PLAN
                if (_VarSelected != _SelectType.Collector_Plan.ToString())
                {
                    double _AmountByChashierOut = 0;
                    if (grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value == null)
                    {
                        _AmountByChashierOut = 0;
                    }
                    else if (grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString() == "")
                    {
                        _AmountByChashierOut = 0;
                    }
                    else
                    {
                        _AmountByChashierOut = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString().Replace(",", ""));
                    }

                    if (_AmountByChashierOut <= Convert.ToInt64((grd.Rows[e.RowIndex].Cells["Column16"].Value.ToString() == "") ? 0 : grd.Rows[e.RowIndex].Cells["Column16"].Value) && _AmountByChashierOut > 0)
                    {
                        grd.Rows[e.RowIndex].Cells["grdWo"].Value = grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value;
                        grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = string.Empty;
                    }
                }
            }
            //UNTUK YANG NILAI MINUS
            else
            {
                if(grd.CurrentCell.ColumnIndex == 9)
                {  
                    if (grd.Rows[e.RowIndex].Cells["Collected"].Value != null)
                    {
                        if (grd.Rows[e.RowIndex].Cells["Collected"].Value.ToString() != "")
                        {
                            if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value) > 0)
                            {
                                grd.Rows[e.RowIndex].Cells["Collected"].Value = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value) * -1;
                            }
                        }
                    }
                }
                else if (grd.CurrentCell.ColumnIndex == 10)
                {
                    if (grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value != null)
                    {
                        if (grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString() != "")
                        {
                            if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString().Replace(",", "")) > 0)
                            {
                                grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString().Replace(",", "")) * -1;
                            }
                        }
                    }
                }
                else if (grd.CurrentCell.ColumnIndex == 11)
                {
                    if (grd.Rows[e.RowIndex].Cells["grdWo"].Value != null)
                    {
                        if (grd.Rows[e.RowIndex].Cells["grdWo"].Value.ToString() != "")
                        {
                            if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdWo"].Value.ToString().Replace(",", "")) > 0)
                            {
                                grd.Rows[e.RowIndex].Cells["grdWo"].Value = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdWo"].Value.ToString().Replace(",", "")) * -1;
                            }
                        }
                    }
                }

                //AMOUNT BY CHASIER COLLECTED.
                if (grd.CurrentCell.ColumnIndex == 9)
                {
                    grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = "";
                    grd.Rows[e.RowIndex].Cells["grdWo"].Value = "";

                    if (grd.Rows[e.RowIndex].Cells["Collected"].Value != null)
                    {
                        if (grd.Rows[e.RowIndex].Cells["Collected"].Value.ToString() != "")
                        {
                            if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value) != 0)
                            {
                                if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value) < Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value))
                                {
                                    grd.Rows[e.RowIndex].Cells["grdWo"].Value = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value) - Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value);
                                }
                                else
                                {
                                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)grd.Rows[e.RowIndex].Cells["grdDeposit"];
                                    chk.Value = Convert.ToBoolean(chk.TrueValue);

                                    if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value) >= Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value))
                                    {
                                        grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value) - Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value);

                                        if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString().Replace(",", "")) >= Convert.ToInt64((grd.Rows[e.RowIndex].Cells["Column16"].Value.ToString() == "") ? 0 : grd.Rows[e.RowIndex].Cells["Column16"].Value))
                                        {
                                            grd.Rows[e.RowIndex].Cells["grdWo"].Value = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString().Replace(",", ""));
                                            grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = "";
                                        }
                                    }
                                    else
                                    {
                                        grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = "";
                                        grd.Rows[e.RowIndex].Cells["grdWo"].Value = "";
                                    }
                                }
                            }
                        }
                    }
                }
                //AMOUNT BY CHASIER OUTS.
                else if (grd.CurrentCell.ColumnIndex == 10)
                {
                    if (grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value != null)
                    {
                        if (grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString() != "")
                        {
                            if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString().Replace(",", "")) != 0)
                            {
                                if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value) < (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value) + Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString().Replace(",", ""))))
                                {
                                    grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value) - Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value);
                                }
                                else
                                {
                                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)grd.Rows[e.RowIndex].Cells["grdDeposit"];
                                    chk.Value = Convert.ToBoolean(chk.TrueValue);

                                    grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString().Replace(",", ""));
                                }
                            }
                        }
                    }
                }
                //KOLOM WO
                else if (grd.CurrentCell.ColumnIndex == 11)
                {
                    if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value) == Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value))
                    {
                        grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = string.Empty;
                        grd.Rows[e.RowIndex].Cells["grdWo"].Value = string.Empty;
                    }
                    else if (grd.Rows[e.RowIndex].Cells["grdWo"].Value != null)
                    {
                        if (grd.Rows[e.RowIndex].Cells["grdWo"].Value.ToString() != "")
                        {
                            grd.Rows[e.RowIndex].Cells["grdWo"].Value = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdWo"].Value.ToString().Replace(",", ""));

                            if (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdWo"].Value.ToString().Replace(",", "")) != 0)
                            {
                                grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Outstanding"].Value) - (Convert.ToInt64(grd.Rows[e.RowIndex].Cells["Collected"].Value) - Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdWo"].Value.ToString().Replace(",", "")));
                            }
                        }
                    }
                }

                //JIKA SELAIN COLLECTOR PLAN
                if (_VarSelected != _SelectType.Collector_Plan.ToString())
                {
                    double _AmountByChashierOut = 0;
                    if (grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value == null)
                    {
                        _AmountByChashierOut = 0;
                    }
                    else if (grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString() == "")
                    {
                        _AmountByChashierOut = 0;
                    }
                    else
                    {
                        _AmountByChashierOut = Convert.ToInt64(grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value.ToString().Replace(",", ""));
                    }

                    if (_AmountByChashierOut <= Convert.ToInt64((grd.Rows[e.RowIndex].Cells["Column16"].Value.ToString() == "") ? 0 : grd.Rows[e.RowIndex].Cells["Column16"].Value) && _AmountByChashierOut > 0)
                    {
                        grd.Rows[e.RowIndex].Cells["grdWo"].Value = grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value;
                        grd.Rows[e.RowIndex].Cells["grdAmountByChashierOut"].Value = string.Empty;
                    }
                }
            }

            TotalAll();

        }

        private void TotalAll()
        {
            double _ItemAmont = 0;
            double _CollectedByCashier = 0;
            double _WriteOff = 0;
            double _ItemDeposit = 0;

            txtItemAmount.Text = "0";
            txtCollectedByCashier.Text = "0";
            txtWriteOff.Text = "0";
            txtItemDeposit.Text = "0";

            foreach(DataGridViewRow dr in grd.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dr.Cells["grdDeposit"];
                if (chk.Value != null)
                {
                    if (Convert.ToBoolean(chk.Value) == Convert.ToBoolean(chk.TrueValue))
                    {
                        _ItemAmont = _ItemAmont + Convert.ToInt64(dr.Cells["Outstanding"].Value);
                        _CollectedByCashier = _CollectedByCashier + Convert.ToInt64(dr.Cells["Collected"].Value);
                        _WriteOff = _WriteOff + Convert.ToInt64((dr.Cells["grdWo"].Value == null || dr.Cells["grdWo"].Value.ToString() == "") ? 0 : dr.Cells["grdWo"].Value);
                        _ItemDeposit = _ItemDeposit + 1;
                    }
                }
            }

            txtItemAmount.Text = string.Format("{0:#,##0}", _ItemAmont);
            txtCollectedByCashier.Text = string.Format("{0:#,##0}", _CollectedByCashier);
            txtWriteOff.Text = string.Format("{0:#,##0}", _WriteOff);
            txtItemDeposit.Text = string.Format("{0:#,##0}", _ItemDeposit);
        }

        private void loadCboCollector()
        {
            cboCollectorIDPlan.DataSource = CBARCollectionDepositEntryAL.GetCollectorToComboBox(true);
            cboCollectorIDPlan.ValueMember = "ValueMember";
            cboCollectorIDPlan.DisplayMember = "DisplayMember";
            cboCollectorIDPlan.SelectedIndex = 0;

            cboCollectorIDOut.DataSource = CBARCollectionDepositEntryAL.GetCollectorToComboBox(true);
            cboCollectorIDOut.ValueMember = "ValueMember";
            cboCollectorIDOut.DisplayMember = "DisplayMember";
            cboCollectorIDOut.SelectedIndex = 0;
        }

        private void loadCboBank()
        {
            cboBankID.DataSource = CBARCollectionDepositEntryAL.GetBankToComboBox(false);
            cboBankID.ValueMember = "ValueMember";
            cboBankID.DisplayMember = "DisplayMember";
            cboBankID.SelectedIndex = 0;
        }

        private void loadCboVoucherType()
        {
            cboVoucherType.DataSource = CBARCollectionDepositEntryAL.GetVoucherTypeToComboBox(false);
            cboVoucherType.ValueMember = "ValueMember";
            cboVoucherType.DisplayMember = "DisplayMember";
            cboVoucherType.SelectedIndex = 0;
        }

        private void loadCboCurrCode()
        {
            ucCheque1.cboCurrCode.DataSource = CBARCollectionDepositEntryAL.GetCurrCodeToComboBox(false);
            ucCheque1.cboCurrCode.ValueMember = "ValueMember";
            ucCheque1.cboCurrCode.DisplayMember = "ValueMember";
            //ucCheque1.cboUCCCurrCodee.SelectedIndex = 0;

            DataTable dt = CBARCollectionDepositEntryAL.GetCurrCode();
            ucCheque1.cboCurrCode.SelectedValue = dt.Rows[0]["cc_currency_code"].ToString();
        }

        private void chbNullValidateDate_CheckedChanged(object sender, EventArgs e)
        {
            if(chbNullValidateDate.Checked == true)
            {
                dtValidDate.Enabled = false;
            }
            else
            {
                dtValidDate.Enabled = true;
            }
        }

        private void grdCellClickUCBankEntry(object sender, DataGridViewCellEventArgs e)
        {
            switch (ucBankEntry1.grd.CurrentCell.ColumnIndex)
            {
                case 0:
                    {
                        //lblUCBEInformation.Text = "Branch";
                        break;
                    }
                case 1:
                    {
                        //lblUCBEInformation.Text = "Branch";
                        break;
                    }
                case 2:
                    {
                        //lblUCBEInformation.Text = "Division";
                        break;
                    }
                case 3:
                    {
                        //lblUCBEInformation.Text = "Department";
                        break;
                    }
                case 4:
                    {
                        //lblUCBEInformation.Text = "Major 1";
                        break;
                    }
                case 5:
                    {
                        //lblUCBEInformation.Text = "Major 2";
                        break;
                    }
                case 6:
                    {
                        //lblUCBEInformation.Text = "Minor";
                        break;
                    }
                case 7:
                    {
                        //lblUCBEInformation.Text = "Analysis";
                        break;
                    }
                case 8:
                    {
                        //lblUCBEInformation.Text = "Filer";
                        break;
                    }
                case 9:
                    {


                        break;
                    }
                case 10:
                    {
                        //lblUCBEInformation.Text = "Description";
                        break;
                    }
                case 11:
                    {
                        //lblUCBEInformation.Text = "D/C/A";
                        break;
                    }
                case 12:
                    {
                        //lblUCBEInformation.Text = "Debit";
                        break;
                    }
                case 13:
                    {
                        //lblUCBEInformation.Text = "Credit";
                        break;
                    }
                case 14:
                    {
                        //lblUCBEInformation.Text = "Delete";
                        break;
                    }
            }
        }
    }
}
