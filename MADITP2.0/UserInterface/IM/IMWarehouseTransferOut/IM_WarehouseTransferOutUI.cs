using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using MADITP2._0.ApplicationLogic;
using System.Collections;
using MADITP2._0.ApplicationLogic.IM;
using MADITP2._0.DataAccess.IM;
using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.Report.IM;

namespace MADITP2._0.userInterface.SO.IM_WarehouseTransferOutUI
{
    public partial class IM_WarehouseTransferOutUI : Form
    {
        clsGlobal Helper;
        GlobalAL GlobalAL;
        clsReport clsReport;
        IMWarehouseTransferOutAL IMWarehouseTransferOutAL;
        IMWarehouseTransferOutBL IMWarehouseTransferOutBL;
        clsAlert clsAlert;

        private List<IMWarehouseTransferOutBL> ArrayIMWarehouseTransferOutBL = new List<IMWarehouseTransferOutBL>();
        private int _CurrentPageH, _CurrentPageD, _FetchLimit, _TotalPageH, _TotalPageD;
        private string _ExistForm;
        private bool _isLoad, _isLoadEditor, _isLoadCboTo, _IsLockEntry;

        public IM_WarehouseTransferOutUI()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = new clsGlobal();
                GlobalAL = new GlobalAL(Helper);
                clsReport = new clsReport();
                IMWarehouseTransferOutAL = new IMWarehouseTransferOutAL(Helper);
                IMWarehouseTransferOutBL = new IMWarehouseTransferOutBL();
                clsAlert = new clsAlert();
            }
        }

        private void clearEditor()
        {
            LockEntry(false);

            txtSequenceNo.Text = string.Empty;
            cboTransType.SelectedIndex = -1;
            lblTransTypeInfo.Text = string.Empty;
            txtTransDescription.Text = string.Empty;
            cboFrom.SelectedIndex = -1;
            lblFromInfo.Text = string.Empty;
            cboTo.DataSource = null;
            lblToInfo.Text = string.Empty;
            grdEditor.Rows.Clear();
        }

        private void LockEntry(bool _IsTrue)
        {
            if (_IsTrue == true)
            {
                cboTransType.Enabled = false;
                txtTransDescription.ReadOnly = true;
                cboFrom.Enabled = false;
                cboTo.Enabled = false;
                btnLineEntry.Enabled = false;

                _IsLockEntry = true;
            }
            else
            {
                cboTransType.Enabled = true;
                txtTransDescription.ReadOnly = false;
                cboFrom.Enabled = true;
                cboTo.Enabled = true;
                btnLineEntry.Enabled = true;

                _IsLockEntry = false;
            }

        }

        private void loadEditor()
        {
            cboTransType.DataSource = null;
            cboTransType.DataSource = IMWarehouseTransferOutAL.GetTransferTxnTypeToComboBox(clsLogin.USERID.ToString(), false);
            cboTransType.ValueMember = "ValueMember";
            cboTransType.DisplayMember = "DisplayMember";
            cboTransType.SelectedIndex = -1;

            cboFrom.DataSource = null;
            cboFrom.DataSource = IMWarehouseTransferOutAL.GetWarehouseEditorToComboBox(clsLogin.USERID.ToString(), false);
            cboFrom.ValueMember = "DisplayMember";
            cboFrom.DisplayMember = "ValueMember";
            cboFrom.SelectedIndex = -1;

            DataTable dt = IMWarehouseTransferOutAL.GetSystemDate();
            dtTxn.Value = Convert.ToDateTime(dt.Rows[0]["gfc_ending_date"]);
        }

        private void settingPanel(clsEventButton.EnumAction _ActionType)
        {
            switch (_ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    {
                        if (_ExistForm != "VIEW")
                        {
                            txtRefenceNo.Focus();
                            pnlView.Visible = true;
                            pnlNew.Visible = false;
                            pnlPrint.Visible = false;

                            _ExistForm = "VIEW";
                            setToolTip();
                            Helper.SetActive(navView);
                        }

                        break;
                    }
                case clsEventButton.EnumAction.NEW:
                    {
                        if (_ExistForm != "NEW")
                        {
                            _isLoadEditor = true;
                            loadEditor();
                            LockEntry(false);
                            clearEditor();

                            pnlView.Visible = false;
                            pnlNew.Visible = true;
                            pnlPrint.Visible = false;

                            _ExistForm = "NEW";
                            setToolTip();
                            Helper.SetActive(navNew);
                            _isLoadEditor = false;
                        }

                        break;
                    }
                
                case clsEventButton.EnumAction.PRINT:
                    {
                        if (_ExistForm == "VIEW")
                        {
                            if(grdHeader.Rows.Count > 0)
                            {
                                
                            }

                            bool _result = PrintReport();
                            if (_result == true)
                            {
                                pnlView.Visible = false;
                                pnlNew.Visible = false;
                                pnlPrint.Visible = true;

                                _ExistForm = "PRINT";
                                setToolTip();
                                Helper.SetActive(navPrint);
                            }
                        }
                        break;
                    }
                case clsEventButton.EnumAction.EXPORT:
                    {
                        if (_ExistForm == "VIEW")
                        {
                            if (grdHeader.Rows[grdHeader.CurrentCell.RowIndex].Cells["st_txn_reference"].ToString().Trim() != "")
                            {
                                IMWarehouseTransferOutBL = new IMWarehouseTransferOutBL()
                                {
                                    st_txn_reference = getReference().ToString().Trim(),
                                    st_warehouse_id = getWarehouseFrom().ToString().Trim()
                                };

                                DataTable dt = GlobalAL.GetReport(clsReport.REPORT_IM_WAREHOUSE_TRANSFER_OUT(IMWarehouseTransferOutBL));
                                if (dt.Rows.Count > 0)
                                {
                                    clsExcel clExcel = new clsExcel();
                                    using (var fbd = new FolderBrowserDialog())
                                    {
                                        DialogResult result = fbd.ShowDialog();
                                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                                        {
                                            var path = fbd.SelectedPath;
                                            clExcel.ExportToExcel(path, dt, EnumExcel.REPORT_WAREHOUSE_TRANSFER_OUT);
                                            MessageBox.Show("The data successfully generated..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            Helper.SetActive(navView);
                                        }
                                    }
                                }

                                Helper.SetActive(navView);
                            }
                        }

                        break;
                    }
                case clsEventButton.EnumAction.EXIT:
                    {
                        Close();
                        break;
                    }
                case clsEventButton.EnumAction.SAVE:
                    {
                        ProcessSave();
                        break;
                    }
                case clsEventButton.EnumAction.CANCEL:
                    {
                        pnlView.Visible = true;
                        pnlNew.Visible = false;
                        pnlPrint.Visible = false;

                        _ExistForm = "VIEW";
                        setToolTip();
                        Helper.SetActive(navView);

                        break;
                    }
                case clsEventButton.EnumAction.DISPLAY:
                    {
                        AddLineEntry();
                        break;
                    }
                default:
                {
                    txtRefenceNo.Focus();
                    pnlView.Visible = true;
                    pnlNew.Visible = false;
                    pnlPrint.Visible = false;
                    _ExistForm = "VIEW";
                    setToolTip();
                    break;
                }
            }
        }

        private void AddLineEntry()
        {
            bool _IsPassed = false;
            DataTable dtWHFrom = new DataTable();
            DataTable dtTxnType = new DataTable();

            if (cboTransType.Text.Trim() != "")
            {
                if (cboFrom.Text.Trim() != "")
                {
                    if (cboTo.Text.Trim() != "")
                    {
                        dtWHFrom = IMWarehouseTransferOutAL.GetWarehouseEditorByID(cboFrom.Text.Trim());
                        if (dtWHFrom.Rows.Count > 0)
                        {
                            if (cboTransType.Text.Trim() == "TRT")
                            {
                                if (dtWHFrom.Rows[0]["wh_transit_warehouse_id"].ToString().Substring(0, 3) == "INT")
                                {
                                    _IsPassed = true;
                                }
                                else
                                {
                                    clsAlert.PushAlert("Transit Warehouse Not Found, Please Contact Warehouse Admin!", clsAlert.Type.Error);
                                    cboFrom.Focus();
                                    _IsPassed = false;
                                }
                            }
                            else
                            {
                                _IsPassed = true;
                            }
                        }
                    }
                    else
                    {
                        clsAlert.PushAlert("Warehouse To Required!", clsAlert.Type.Error);
                        cboTo.Focus();
                        _IsPassed = false;
                    }
                }
                else
                {
                    clsAlert.PushAlert("Warehouse From Required!", clsAlert.Type.Error);
                    cboFrom.Focus();
                    _IsPassed = false;
                }
            }
            else
            {
                clsAlert.PushAlert("Txn Type Required!", clsAlert.Type.Error);
                cboTransType.Focus();
                _IsPassed = false;
            }

            //Function Cheek Sequence Code Untuk Masing-Masing Transaction Yang dibuat.
            if (_IsPassed == true)
            {
                dtTxnType = IMWarehouseTransferOutAL.GetTransferTxnTypeByID(cboTransType.Text.Trim());

                //Same Database 'O' = Online
                if (dtTxnType.Rows[0]["ttt_system_type"].ToString() == "O")
                {
                    //With Transit
                    if (dtTxnType.Rows[0]["ttt_with_transit_warehouse"].ToString() == "Y")
                    {
                        //Confirm
                        if (dtTxnType.Rows[0]["ttt_confirmation_transfer_required"].ToString() == "Y")
                        {
                            //2B
                            if (CheekSequnceCode(cboFrom.Text.Trim(), dtTxnType.Rows[0]["ttt_txn_type_out_from_org_wh"].ToString().Trim()) == true)
                            {
                                if (CheekSequnceCode(dtWHFrom.Rows[0]["wh_transit_warehouse_id"].ToString().Trim(), dtTxnType.Rows[0]["ttt_txn_type_in_to_transit_wh"].ToString().Trim()) == true)
                                {
                                    _IsPassed = true;
                                }
                                else
                                {
                                    clsAlert.PushAlert("Sequence Code For this Transaction not Found!", clsAlert.Type.Error);
                                    _IsPassed = false;
                                }
                            }
                            else
                            {
                                clsAlert.PushAlert("Sequence Code For this Transaction not Found!", clsAlert.Type.Error);
                                _IsPassed = false;
                            }
                        }
                        //Otomatis
                        else
                        {
                            //2A
                            if (CheekSequnceCode(cboFrom.Text.Trim(), dtTxnType.Rows[0]["ttt_txn_type_out_from_org_wh"].ToString().Trim()) == true)
                            {
                                if (CheekSequnceCode(dtWHFrom.Rows[0]["wh_transit_warehouse_id"].ToString().Trim(), dtTxnType.Rows[0]["ttt_txn_type_in_to_transit_wh"].ToString().Trim()) == true)
                                {
                                    if (CheekSequnceCode(dtWHFrom.Rows[0]["wh_transit_warehouse_id"].ToString().Trim(), dtTxnType.Rows[0]["ttt_txn_type_out_from_transit_wh"].ToString().Trim()) == true)
                                    {
                                        if (CheekSequnceCode(cboTo.Text.Trim(), dtTxnType.Rows[0]["ttt_txn_type_in_to_destination_wh"].ToString().Trim()) == true)
                                        {
                                            _IsPassed = true;
                                        }
                                        else
                                        {
                                            clsAlert.PushAlert("Sequence Code For this Transaction not Found!", clsAlert.Type.Error);
                                            _IsPassed = false;
                                        }
                                    }
                                    else
                                    {
                                        clsAlert.PushAlert("Sequence Code For this Transaction not Found!", clsAlert.Type.Error);
                                        _IsPassed = false;
                                    }
                                }
                                else
                                {
                                    clsAlert.PushAlert("Sequence Code For this Transaction not Found!", clsAlert.Type.Error);
                                    _IsPassed = false;
                                }
                            }
                            else
                            {
                                clsAlert.PushAlert("Sequence Code For this Transaction not Found!", clsAlert.Type.Error);
                                _IsPassed = false;
                            }
                        }
                    }
                    //Without Transit
                    else
                    {
                        //Confirm
                        if (dtTxnType.Rows[0]["ttt_confirmation_transfer_required"].ToString() == "Y")
                        {
                            //1B
                            if (CheekSequnceCode(cboFrom.Text.Trim(), dtTxnType.Rows[0]["ttt_txn_type_out_from_org_wh"].ToString().Trim()) == true)
                            {
                                _IsPassed = true;
                            }
                            else
                            {
                                clsAlert.PushAlert("Sequence Code For this Transaction not Found!", clsAlert.Type.Error);
                                _IsPassed = false;
                            }
                        }
                        //Otomatis
                        else
                        {
                            //1A
                            if (CheekSequnceCode(cboFrom.Text.Trim(), dtTxnType.Rows[0]["ttt_txn_type_out_from_org_wh"].ToString().Trim()) == true)
                            {
                                if (CheekSequnceCode(cboTo.Text.Trim(), dtTxnType.Rows[0]["ttt_txn_type_in_to_destination_wh"].ToString().Trim()) == true)
                                {
                                    _IsPassed = true;
                                }
                                else
                                {
                                    clsAlert.PushAlert("Sequence Code For this Transaction not Found!", clsAlert.Type.Error);
                                    _IsPassed = false;
                                }
                            }
                            else
                            {
                                clsAlert.PushAlert("Sequence Code For this Transaction not Found!", clsAlert.Type.Error);
                                _IsPassed = false;
                            }
                        }
                    }
                }
                //Diffrenece Database 'B' = Batch
                else
                {
                    //With Transit
                    if (dtTxnType.Rows[0]["ttt_with_transit_warehouse"].ToString() == "Y")
                    {
                        //Confirm
                        if (dtTxnType.Rows[0]["ttt_confirmation_transfer_required"].ToString() == "Y")
                        {
                            //2B
                            if (CheekSequnceCode(cboFrom.Text.Trim(), dtTxnType.Rows[0]["ttt_txn_type_out_from_org_wh"].ToString().Trim()) == true)
                            {
                                if (CheekSequnceCode(dtWHFrom.Rows[0]["wh_transit_warehouse_id"].ToString().Trim(), dtTxnType.Rows[0]["ttt_txn_type_in_to_transit_wh"].ToString().Trim()) == true)
                                {
                                    _IsPassed = true;
                                }
                                else
                                {
                                    clsAlert.PushAlert("Sequence Code For this Transaction not Found!", clsAlert.Type.Error);
                                    _IsPassed = false;
                                }
                            }
                            else
                            {
                                clsAlert.PushAlert("Sequence Code For this Transaction not Found!", clsAlert.Type.Error);
                                _IsPassed = false;
                            }
                        }
                        //Otomatis
                        else
                        {
                            //2A
                            if (CheekSequnceCode(cboFrom.Text.Trim(), dtTxnType.Rows[0]["ttt_txn_type_out_from_org_wh"].ToString().Trim()) == true)
                            {
                                if (CheekSequnceCode(dtWHFrom.Rows[0]["wh_transit_warehouse_id"].ToString().Trim(), dtTxnType.Rows[0]["ttt_txn_type_in_to_transit_wh"].ToString().Trim()) == true)
                                {
                                    if (CheekSequnceCode(dtWHFrom.Rows[0]["wh_transit_warehouse_id"].ToString().Trim(), dtTxnType.Rows[0]["ttt_txn_type_out_from_transit_wh"].ToString().Trim()) == true)
                                    {
                                        _IsPassed = true;
                                    }
                                    else
                                    {
                                        clsAlert.PushAlert("Sequence Code For this Transaction not Found!", clsAlert.Type.Error);
                                        _IsPassed = false;
                                    }
                                }
                                else
                                {
                                    clsAlert.PushAlert("Sequence Code For this Transaction not Found!", clsAlert.Type.Error);
                                    _IsPassed = false;
                                }
                            }
                            else
                            {
                                clsAlert.PushAlert("Sequence Code For this Transaction not Found!", clsAlert.Type.Error);
                                _IsPassed = false;
                            }
                        }
                    }
                    //Without Transit
                    else
                    {
                        //Confirm / Otomatis
                        if (CheekSequnceCode(cboFrom.Text.Trim(), dtTxnType.Rows[0]["ttt_txn_type_out_from_org_wh"].ToString().Trim()) == true)
                        {
                            _IsPassed = true;
                        }
                        else
                        {
                            clsAlert.PushAlert("Sequence Code For this Transaction not Found!", clsAlert.Type.Error);
                            _IsPassed = false;
                        }
                    }
                }
            }

            if (_IsPassed == true)
            {
                if (dtTxnType.Rows[0]["ttt_with_transit_warehouse"].ToString() == "Y")
                {
                    if (dtWHFrom.Rows[0]["wh_transit_warehouse_id"].ToString().Trim() != "")
                    {
                        _IsPassed = true;
                    }
                    else
                    {
                        clsAlert.PushAlert("The Transit Warehouse from " + cboFrom.Text.Trim() + " haven't defined!", clsAlert.Type.Error);
                        _IsPassed = false;
                    }
                }
            }


            if (_IsPassed == true)
            {
                LockEntry(true);
                if (grdEditor.Rows.Count == 0)
                {
                    AddRowsGrd("", "", "", "", "", "", "", "");
                    grdEditor.CurrentCell = grdEditor.Rows[grdEditor.Rows.Count - 1].Cells["grdProductID"];
                    grdEditor.BeginEdit(true);
                }
            }
        }

        private bool PrintReport()
        {
            bool _Result = false;
            string _CP = "";
            string _EntityDesc = "";
            string _BranchDesc = "";
            string _Kota = "";

            try
            {
                if(grdHeader.Rows[grdHeader.CurrentCell.RowIndex].Cells["st_txn_reference"].ToString().Trim() != "")
                {
                    IMWarehouseTransferOutBL = new IMWarehouseTransferOutBL()
                    {
                        st_txn_reference = getReference().ToString().Trim(),
                        st_warehouse_id = getWarehouseFrom().ToString().Trim()
                    };

                    DataTable dt = GlobalAL.GetReport(clsReport.REPORT_IM_WAREHOUSE_TRANSFER_OUT(IMWarehouseTransferOutBL));
                    if (dt.Rows.Count > 0)
                    {
                        DataTable dtContact = IMWarehouseTransferOutAL.GetContactPerson(getWarehouseFrom().ToString().Trim());
                        if(dtContact.Rows.Count > 0)
                        {
                            _CP = dtContact.Rows[0]["wh_contact_person"].ToString();
                        }

                        DataTable dtDesc = IMWarehouseTransferOutAL.GetEntityBranchDesc(getReference().ToString().Trim());
                        if (dtDesc.Rows.Count > 0)
                        {
                            _EntityDesc = dtDesc.Rows[0]["ec_entity"].ToString();
                            _BranchDesc = dtDesc.Rows[0]["bc_branch"].ToString();
                            _Kota = dtDesc.Rows[0]["bc_remark"].ToString();
                        }

                        if(dtDesc.Rows.Count == 0 || dtDesc.Rows[0]["ec_entity"].ToString() == "")
                        {
                            DataTable dtDescOpt = IMWarehouseTransferOutAL.GetEntityBranchDescOpt(clsLogin.USERID.Trim());
                            if (dtDescOpt.Rows.Count > 0)
                            {
                                _EntityDesc = dtDescOpt.Rows[0]["ec_entity"].ToString();
                                _BranchDesc = dtDescOpt.Rows[0]["bc_branch"].ToString();
                                _Kota = dtDescOpt.Rows[0]["bc_remark"].ToString();
                            }
                        }

                        if (_EntityDesc == "(All)")
                        {
                            _EntityDesc = "PT. TIGARAKSA SATRIA";
                        }

                        if (_BranchDesc == "(All)")
                        {
                            _BranchDesc = "JAKARTA";
                            _Kota = "JAKARTA";
                        }

                        rptIMWarehouseTransferOut rptIMWarehouseTransferOut = new rptIMWarehouseTransferOut();
                        rptIMWarehouseTransferOut.SetDataSource(dt);
                        rptIMWarehouseTransferOut.SetParameterValue("parEntityDesc", _EntityDesc.Trim()); ;
                        rptIMWarehouseTransferOut.SetParameterValue("parBranchDesc", _BranchDesc.Trim());
                        rptIMWarehouseTransferOut.SetParameterValue("parKota", _Kota.Trim());
                        rptIMWarehouseTransferOut.SetParameterValue("parContactPerson", _CP.Trim());
                        rptViewerVsa.ReportSource = rptIMWarehouseTransferOut;

                        _Result = true;
                    }
                }
            }
            catch (Exception)
            {
                clsAlert.PushAlert("Error Loading Data!", clsAlert.Type.Error);
                _Result = false;
            }

            return _Result;
        }

        private bool CheckSequence()
        {
            bool _Result = false;
            bool _IsSucessed = false;
            bool _IsUpdated = false;

            string _sType = "IMTRANSFERTXN";
            if (cboTransType.Text.Trim() != "")
            {
                DataTable dt = IMWarehouseTransferOutAL.GetSNIDDetail(_sType);
                if(dt.Rows.Count > 0)
                {
                    if((Convert.ToInt64(dt.Rows[0]["sn_last_number"]) + 1) < Convert.ToInt64(dt.Rows[0]["sn_maximum"]))
                    {
                        txtSequenceNo.Text = (Convert.ToInt64(dt.Rows[0]["sn_last_number"]) + 1).ToString();
                        _IsSucessed = true;
                    }
                    else
                    {
                        clsAlert.PushAlert("Sequence # Already Maximun!", clsAlert.Type.Error);
                        _IsSucessed = false;
                    }
                }
                else
                {
                    clsAlert.PushAlert("Sequence # Not SUCCEED!", clsAlert.Type.Error);
                    _IsSucessed = false;
                }
            }
            else
            {
                clsAlert.PushAlert("Txn Type Required!", clsAlert.Type.Error);
                _IsSucessed = false;
            }

            if(_IsSucessed == true)
            {
                _IsUpdated = IMWarehouseTransferOutAL.updateSeqNo(_sType, txtSequenceNo.Text.Trim());
                if(_IsUpdated == true)
                {
                    _Result = true;
                }
                else
                {
                    clsAlert.PushAlert("Failed to Updating Sequence No!", clsAlert.Type.Error);
                    _Result = false;
                }
            }
            else
            {
                _Result = false;
            }

            return _Result;
        }

        private void ProcessSave()
        {
            bool _IsPassed = false;
            bool _FlagOK = false;
            int _Idx = 1;
            int _row = 0;
            ArrayIMWarehouseTransferOutBL.Clear();

            if (_IsLockEntry == true)
            {
                if (grdEditor.Rows[0].Cells["grdProductID"].Value.ToString() != "" || grdEditor.Rows[0].Cells["grdQuantity"].Value.ToString() != "")
                {
                    if(CheckSequence() == true)
                    {
                        if(cboTxnType.Text.Trim() == "TRT")
                        {
                            DataTable dtWH = IMWarehouseTransferOutAL.GetWarehouseEditorByID(cboFrom.Text.Trim());
                            if (dtWH.Rows[0]["wh_transit_warehouse_id"].ToString().Substring(0, 3) == "INT") //CEK
                            {
                                _IsPassed = true;
                            }
                            else
                            {
                                clsAlert.PushAlert("Transit Warehouse Not Found, Please Contact Warehouse Admin!", clsAlert.Type.Error);
                                _IsPassed = false;
                            }
                        }
                        else
                        {
                            _IsPassed = true;
                        }
                    }
                    else
                    {
                        _IsPassed = false;
                    }
                } 
                else
                {
                    clsAlert.PushAlert("Please, Check the Product Detail First!", clsAlert.Type.Error);
                    _IsPassed = false;
                }
            }
            else
            {
                clsAlert.PushAlert("Please Save The Header or Click The LineEntry First!", clsAlert.Type.Error);
                _IsPassed = false;
            }

            _Idx = 1;
            

            if(_IsPassed == true)
            {
                _row = 0;

                DataTable dtTxnType = IMWarehouseTransferOutAL.GetTransferTxnTypeByID(cboTransType.Text.Trim()); //FOR TXN TYPE DETAIL
                DataTable dtWareFrom = IMWarehouseTransferOutAL.GetWarehouseEditorByID(cboFrom.Text.Trim()); //FOR WAREHOUSE FROM DETAIL

                foreach (DataGridViewRow dr in grdEditor.Rows)
                {
                    //INTRANSIT = 'N'
                    if (dtTxnType.Rows[0]["ttt_with_transit_warehouse"].ToString().Trim() == "N")
                    {
                        for (int K = 1; K <= 2; K++)
                        {
                            _FlagOK = false;

                            if(dr.Cells["grdProductID"].Value.ToString() != "" && (dr.Cells["grdQuantity"].Value.ToString() != "" || dr.Cells["grdQuantity"].Value.ToString() != "0"))
                            {
                                //TRO
                                if(K == 1)
                                {
                                    ArrayIMWarehouseTransferOutBL.Add(new IMWarehouseTransferOutBL());

                                    ArrayIMWarehouseTransferOutBL[_row].st_warehouse_id = cboFrom.Text.Trim().ToString();
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_type_code = dtTxnType.Rows[0]["ttt_txn_type_out_from_org_wh"].ToString().Trim();
                                    ArrayIMWarehouseTransferOutBL[_row].st_transfer_status = (dtTxnType.Rows[0]["ttt_confirmation_transfer_required"].ToString().Trim() == "N") ? "Y" : "N";
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_quantity = Convert.ToInt32(dr.Cells["grdQuantity"].Value) * -1;
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_cost_value = Convert.ToInt64(dr.Cells["grdTotalCost"].Value) * -1;

                                    _FlagOK = true;
                                }

                                if(dtTxnType.Rows[0]["ttt_confirmation_transfer_required"].ToString().Trim() == "N")
                                {
                                    //JIKA SYSTEM TYPE-NYA 'O' / ONLINE BISA LANGSUNG DIINSERT
                                    if(dtTxnType.Rows[0]["ttt_system_type"].ToString().Trim() == "O")
                                    {
                                        //TRI
                                        if(K == 2)
                                        {
                                            ArrayIMWarehouseTransferOutBL.Add(new IMWarehouseTransferOutBL());

                                            ArrayIMWarehouseTransferOutBL[_row].st_warehouse_id = cboTo.Text.Trim().ToString();
                                            ArrayIMWarehouseTransferOutBL[_row].st_txn_type_code = dtTxnType.Rows[0]["ttt_txn_type_in_to_destination_wh"].ToString().Trim();
                                            ArrayIMWarehouseTransferOutBL[_row].st_transfer_status = "Y";
                                            ArrayIMWarehouseTransferOutBL[_row].st_txn_quantity = Convert.ToInt32(dr.Cells["grdQuantity"].Value);
                                            ArrayIMWarehouseTransferOutBL[_row].st_txn_cost_value = Convert.ToInt64(dr.Cells["grdTotalCost"].Value);

                                            _FlagOK = true;
                                        }
                                    }
                                }

                                if(_FlagOK == true)
                                {
                                    ArrayIMWarehouseTransferOutBL[_row].st_product_id = dr.Cells["grdProductID"].Value.ToString().Trim();
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_type_index = _Idx;
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_date = dtTxn.Value.Date;
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_reference = cboTransType.Text.Trim() + "-" + txtSequenceNo.Text.Trim();
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_description = txtTransDescription.Text.Trim();
                                    ArrayIMWarehouseTransferOutBL[_row].st_from_warehouse_id = cboFrom.Text.Trim();
                                    ArrayIMWarehouseTransferOutBL[_row].st_to_warehouse_id = cboTo.Text.Trim();
                                    ArrayIMWarehouseTransferOutBL[_row].st_user_id = clsLogin.USERID.Trim();

                                    _row++;
                                }
                            }
                        }      
                    }
                    //INTRANSIT = 'Y'
                    else
                    {
                        for (int K = 1; K <= 4; K++)
                        {
                            _FlagOK = false;

                            if (dr.Cells["grdProductID"].Value.ToString() != "" && Convert.ToInt64(dr.Cells["grdQuantity"].Value) != 0)
                            {
                                //TRO/BTO
                                if(K == 1)
                                {
                                    ArrayIMWarehouseTransferOutBL.Add(new IMWarehouseTransferOutBL());

                                    ArrayIMWarehouseTransferOutBL[_row].st_warehouse_id = cboFrom.Text.Trim().ToString();
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_type_code = dtTxnType.Rows[0]["ttt_txn_type_out_from_org_wh"].ToString().Trim();
                                    ArrayIMWarehouseTransferOutBL[_row].st_transfer_status = (dtTxnType.Rows[0]["ttt_confirmation_transfer_required"].ToString().Trim() == "N") ? "Y" : "N";
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_quantity = Convert.ToInt32(dr.Cells["grdQuantity"].Value) * -1;
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_cost_value = Convert.ToInt64(dr.Cells["grdTotalCost"].Value) * -1; //CEK

                                    _FlagOK = true;
                                }

                                //BII UNTUK KE TRANSIT
                                if (K == 2)
                                {
                                    ArrayIMWarehouseTransferOutBL.Add(new IMWarehouseTransferOutBL());

                                    ArrayIMWarehouseTransferOutBL[_row].st_warehouse_id = dtWareFrom.Rows[0]["wh_transit_warehouse_id"].ToString().Trim();
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_type_code = dtTxnType.Rows[0]["ttt_txn_type_in_to_transit_wh"].ToString().Trim();
                                    ArrayIMWarehouseTransferOutBL[_row].st_transfer_status = "Y";
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_quantity = Convert.ToInt32(dr.Cells["grdQuantity"].Value);
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_cost_value = Convert.ToInt64(dr.Cells["grdTotalCost"].Value); //CEK

                                    _FlagOK = true;
                                }

                                if (dtTxnType.Rows[0]["ttt_confirmation_transfer_required"].ToString().Trim() == "N")
                                {
                                    //BIO
                                    if (K == 3)
                                    {
                                        ArrayIMWarehouseTransferOutBL.Add(new IMWarehouseTransferOutBL());

                                        ArrayIMWarehouseTransferOutBL[_row].st_warehouse_id = dtWareFrom.Rows[0]["wh_transit_warehouse_id"].ToString().Trim();
                                        ArrayIMWarehouseTransferOutBL[_row].st_txn_type_code = dtTxnType.Rows[0]["ttt_txn_type_out_from_transit_wh"].ToString().Trim();
                                        ArrayIMWarehouseTransferOutBL[_row].st_transfer_status = "Y";
                                        ArrayIMWarehouseTransferOutBL[_row].st_txn_quantity = Convert.ToInt32(dr.Cells["grdQuantity"].Value) * -1;
                                        ArrayIMWarehouseTransferOutBL[_row].st_txn_cost_value = Convert.ToInt64(dr.Cells["grdTotalCost"].Value) * -1;

                                        _FlagOK = true;
                                    }

                                    //Jika System Typenya Batch maka  harus  mealkukan entry manual  pada BTI nya
                                    //Dan jika  System Typenya  O (online)  bisa otomatis terinsert

                                    if (dtTxnType.Rows[0]["ttt_system_type"].ToString().Trim() == "O")
                                    {
                                        //BTI
                                        if (K == 4)
                                        {
                                            ArrayIMWarehouseTransferOutBL.Add(new IMWarehouseTransferOutBL());

                                            ArrayIMWarehouseTransferOutBL[_row].st_warehouse_id = cboTo.Text.Trim().ToString();
                                            ArrayIMWarehouseTransferOutBL[_row].st_txn_type_code = dtTxnType.Rows[0]["ttt_txn_type_in_to_destination_wh"].ToString().Trim();
                                            ArrayIMWarehouseTransferOutBL[_row].st_transfer_status = "Y";
                                            ArrayIMWarehouseTransferOutBL[_row].st_txn_quantity = Convert.ToInt32(dr.Cells["grdQuantity"].Value);
                                            ArrayIMWarehouseTransferOutBL[_row].st_txn_cost_value = Convert.ToInt64(dr.Cells["grdTotalCost"].Value);

                                            _FlagOK = true;
                                        }
                                    }
                                }

                                if(_FlagOK == true)
                                {
                                    ArrayIMWarehouseTransferOutBL[_row].st_product_id = dr.Cells["grdProductID"].Value.ToString().Trim();
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_type_index = _Idx;
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_date = dtTxn.Value.Date;
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_reference = cboTransType.Text.Trim() + "-" + txtSequenceNo.Text.Trim();
                                    ArrayIMWarehouseTransferOutBL[_row].st_txn_description = txtTransDescription.Text.Trim();
                                    ArrayIMWarehouseTransferOutBL[_row].st_from_warehouse_id = cboFrom.Text.Trim();
                                    ArrayIMWarehouseTransferOutBL[_row].st_to_warehouse_id = cboTo.Text.Trim();
                                    ArrayIMWarehouseTransferOutBL[_row].st_user_id = clsLogin.USERID.Trim();

                                    _row++;
                                }
                            }
                        }
                    }

                    _Idx++;
                }

                if(ArrayIMWarehouseTransferOutBL.Count > 0)
                {
                    bool _IsSendEmail = false;
                    DataTable dtEmail = new DataTable();
                    if (cboTransType.Text.Trim() == "TRT")
                    {
                        //GET EMAIL ADDRESS
                        dtEmail = IMWarehouseTransferOutAL.GetEmailAddress(cboFrom.Text.Trim(), cboTo.Text.Trim());
                        if (dtEmail.Rows.Count > 0)
                        {
                            _IsSendEmail = true;
                        }
                        else
                        {
                            _IsSendEmail = false;
                            //clsAlert.PushAlert("Email Address Not Found For WH From " + cboFrom.Text.Trim() + " and WH To " + cboTo.Text.Trim() + ", Please Contact Administrator!", clsAlert.Type.Error);
                        }
                    }

                    //PROSES SIMPAN
                    bool _isSucess = IMWarehouseTransferOutAL.Post(ArrayIMWarehouseTransferOutBL, _IsSendEmail, (_IsSendEmail == true) ? dtEmail.Rows[0]["EmailTo"].ToString().Trim() : "", cboTransType.Text.Trim() + "-" + txtSequenceNo.Text.Trim());
                    if (_isSucess == true)
                    {
                        clsAlert.PushAlert("Process Successed. No Sequence " + cboTransType.Text.Trim() + "-" + txtSequenceNo.Text.Trim() + " !", clsAlert.Type.Success);
                        clearEditor();
                    }
                    else
                    {
                        clsAlert.PushAlert("Process Failed!", clsAlert.Type.Error);
                    }
                }
            }
        }

        private string getReference()
        {
            string _Reference = string.Empty;

            if (grdHeader.Rows.Count > 0)
            {
                int i;
                i = grdHeader.CurrentCell.RowIndex;
                _Reference = grdHeader["st_txn_reference", i].Value.ToString();
            }

            return _Reference;
        }

        private string getWarehouseFrom()
        {
            string _WarehouseID = string.Empty;

            if (grdHeader.Rows.Count > 0)
            {
                int i;
                i = grdHeader.CurrentCell.RowIndex;
                _WarehouseID = grdHeader["st_from_warehouse_id", i].Value.ToString();
            }

            return _WarehouseID;
        }

        private void PaginationD(Boolean onloading = false)
        {
            if (_TotalPageD == 0)
            {
                btnNextD.Enabled = false;
                btnPrevD.Enabled = false;
                return;
            }

            if (_TotalPageD == _CurrentPageD)
            {
                btnNextD.Enabled = false;
                btnPrevD.Enabled = false;
                if (_CurrentPageD > 1)
                {
                    btnPrevD.Enabled = true;
                }

                return;
            }

            if (onloading)
            {
                btnPrevD.Enabled = false;
                btnNextD.Enabled = false;

                return;
            }

            if (_CurrentPageD < 2)
            {
                btnPrevD.Enabled = false;
                btnNextD.Enabled = true;
            }
            else
            {
                btnPrevD.Enabled = true;
                btnNextD.Enabled = true;
            }

            return;
        }

        private void PaginationH(Boolean onloading = false)
        {
            if (_TotalPageH == 0)
            {
                btnNextH.Enabled = false;
                btnPrevH.Enabled = false;
                return;
            }

            if (_TotalPageH == _CurrentPageH)
            {
                btnNextH.Enabled = false;
                btnPrevH.Enabled = false;
                if (_CurrentPageH > 1)
                {
                    btnPrevH.Enabled = true;
                }

                return;
            }

            if (onloading)
            {
                btnPrevH.Enabled = false;
                btnNextH.Enabled = false;

                return;
            }

            if (_CurrentPageH < 2)
            {
                btnPrevH.Enabled = false;
                btnNextH.Enabled = true;
            }
            else
            {
                btnPrevH.Enabled = true;
                btnNextH.Enabled = true;
            }

            return;
        }

        private void DrawDatatableD()
        {
            DataTable dt = new DataTable();
            DataTable dtCount = new DataTable();

            IMWarehouseTransferOutBL = new IMWarehouseTransferOutBL()
            {
                st_txn_reference = getReference()
            };

            if(grdHeader.Rows.Count > 0)
            {
                //GET DATA FOR GRID
                dt = IMWarehouseTransferOutAL.ReadDetail(EnumFilter.GET_WITH_PAGING, IMWarehouseTransferOutBL, _CurrentPageD, _FetchLimit);
                grdDetail.AutoGenerateColumns = false;
                grdDetail.DataSource = dt;
            }
            else
            {
                grdDetail.DataSource = null;
            }

            if (grdHeader.Rows.Count > 0)
            {
                //GET COUNT FOR PAGING
                dtCount = IMWarehouseTransferOutAL.ReadDetail(EnumFilter.GET_COUNT_ROWS, IMWarehouseTransferOutBL, _CurrentPageD, _FetchLimit);
                _TotalPageD = (int)Math.Ceiling((Double)Convert.ToInt64(dtCount.Rows[0]["TotalRows"]) / _FetchLimit);
            }
            else
            {
                _TotalPageD = 0;
            }

            lblPagingInfoD.Text = (Convert.ToInt32(_TotalPageD) > 0) ? "Pages : " + _CurrentPageD.ToString() + " / " + _TotalPageD : "Pages : - ";
            lblRowsD.Text = "Records : " + grdDetail.Rows.Count.ToString() + " Rows";
            PaginationD();
        }

        private void DrawDatatableH()
        {
            //GET DATA FOR GRID
            IMWarehouseTransferOutBL = new IMWarehouseTransferOutBL()
            {
                st_gl_txn_type = cboTxnType.Text.Trim().ToString(),
                st_txn_reference = txtRefenceNo.Text.Trim().ToString(),
                st_from_warehouse_id = (cboWHFrom.Text.Trim() == "") ? "0" : cboWHFrom.SelectedValue.ToString().Trim(),
                st_to_warehouse_id = cboWHTo.SelectedValue.ToString().Trim()
            };

            DataTable dt = IMWarehouseTransferOutAL.Read(EnumFilter.GET_WITH_PAGING, IMWarehouseTransferOutBL, _CurrentPageH, _FetchLimit);
            grdHeader.AutoGenerateColumns = false;
            grdHeader.DataSource = dt;

            //GET COUNT FOR PAGING
            DataTable dtCount = IMWarehouseTransferOutAL.Read(EnumFilter.GET_COUNT_ROWS, IMWarehouseTransferOutBL, _CurrentPageH, _FetchLimit);
            _TotalPageH = (int)Math.Ceiling((Double)Convert.ToInt64(dtCount.Rows[0]["TotalRows"]) / _FetchLimit);
            lblPagingInfoH.Text = (Convert.ToInt32(_TotalPageH) > 0) ? "Pages : " + _CurrentPageH.ToString() + " / " + _TotalPageH : "Pages : - ";
            lblRowsH.Text = "Records : " + grdHeader.Rows.Count.ToString() + " Rows";
            PaginationH();
        }

        private void DrawDatatable()
        {
            DrawDatatableH();
            DrawDatatableD();
        }

        private void SettingVariable(bool _IsAll)
        {
            _FetchLimit = (int)EnumFetchData.DefaultLimit;

            if(_IsAll == true)
            {
                //FOR DATA VSA HEADER
                _CurrentPageH = 1;
                _TotalPageH = 0;
            }

            //FOR DATA VSA DETAIL
            _CurrentPageD = 1;
            _TotalPageD = 0;
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
            
            ToolTip toolTipExit = new ToolTip();
            toolTipExit.ShowAlways = true;
            toolTipExit.SetToolTip(navClose, "EXIT [ESC]");

            ToolTip toolTipSearch = new ToolTip();
            toolTipSearch.ShowAlways = true;
            toolTipSearch.SetToolTip(btnSearch, "SEARCH [F6]");

            ToolTip toolTipCancel = new ToolTip();
            toolTipCancel.ShowAlways = true;
            toolTipCancel.SetToolTip(btnCancel, "CANCEL [F9]");

            ToolTip toolTipSave = new ToolTip();
            toolTipSave.ShowAlways = true;
            toolTipSave.SetToolTip(btnSave, "SAVE [F10]");

            ToolTip toolTipLineEntry = new ToolTip();
            toolTipLineEntry.ShowAlways = true;
            toolTipLineEntry.SetToolTip(btnLineEntry, "LINE ENTRY [F11]");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.VIEW);
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.EXIT);
        }

        private void loadComboBox()
        {
            cboTxnType.DataSource = IMWarehouseTransferOutAL.GetTransferTxnTypeToComboBox(clsLogin.USERID.ToString(), false);
            cboTxnType.ValueMember = "ValueMember";
            cboTxnType.DisplayMember = "DisplayMember";
            cboTxnType.SelectedIndex = -1;

            DataTable dt = IMWarehouseTransferOutAL.GetUserWH(clsLogin.USERID.ToString());
            if(dt.Rows.Count > 0)
            {
                if(dt.Rows[0]["User_PIM"].ToString() == "Y")
                {
                    cboWHFrom.DataSource = IMWarehouseTransferOutAL.GetWarehouseWHToComboBox(false);
                    cboWHFrom.ValueMember = "ValueMember";
                    cboWHFrom.DisplayMember = "DisplayMember";
                    cboWHFrom.SelectedIndex = -1;
                }
                else if (dt.Rows[0]["User_PIM"].ToString() == "N")
                {
                    cboWHFrom.DataSource = IMWarehouseTransferOutAL.GetWarehouseToComboBox(clsLogin.USERID.ToString(), false);
                    cboWHFrom.ValueMember = "ValueMember";
                    cboWHFrom.DisplayMember = "DisplayMember";
                    cboWHFrom.SelectedIndex = -1;
                }
            }

            cboWHTo.DataSource = IMWarehouseTransferOutAL.GetWarehouseWHToComboBox(true);
            cboWHTo.ValueMember = "ValueMember";
            cboWHTo.DisplayMember = "DisplayMember";
            cboWHTo.SelectedIndex = 0;
        }

        private void IM_WarehouseTransferOutUI_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            KeyPreview = true;

            _isLoad = true;
            loadComboBox();
            _isLoad = false;

            lblTxnTypeInfo.Text = string.Empty;

            navView_Click(navView, null);
        }

        private void btnNextD_Click(object sender, EventArgs e)
        {
            _CurrentPageH++;
            PaginationH(true);
            DrawDatatableD();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SettingVariable(true);
            PaginationH(true);
            DrawDatatable();
        }

        private void cboTxnType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_isLoad == false)
            {
                lblTxnTypeInfo.Text = cboTxnType.SelectedValue.ToString().ToUpper();
            }
        }

        private void IM_WarehouseTransferOutUI_KeyDown(object sender, KeyEventArgs e)
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
                    case clsEventButton.EnumAction.SAVE:
                        {
                            btnSave_Click(null, null);
                            break;
                        }

                    case clsEventButton.EnumAction.CANCEL:
                        {
                            btnCancel_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.DISPLAY:
                        {
                            btnLineEntry_Click(null, null);
                            break;
                        }
                }
            }
            else
            {
                this.ProcessTabKey(true);
            }
        }

        private void loadCboToEditor()
        {
            _isLoadCboTo = true;
            cboTo.DataSource = IMWarehouseTransferOutAL.GetWarehouseByIDEditor(cboFrom.Text.Trim(), cboTransType.Text.Trim(), false);
            cboTo.ValueMember = "DisplayMember";
            cboTo.DisplayMember = "ValueMember";
            cboTo.SelectedIndex = -1;

            lblToInfo.Text = "";
            _isLoadCboTo = false;
        }

        private void cboTransType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadEditor == false)
            {
                if (cboTransType.SelectedIndex > -1)
                {
                    lblTransTypeInfo.Text = cboTransType.SelectedValue.ToString().ToUpper(); ;
                    cboTo.DataSource = null;
                    lblToInfo.Text = "";

                    if (cboFrom.SelectedIndex > -1)
                    {
                        DataTable dt = IMWarehouseTransferOutAL.GetTransferTxnTypeByID(cboTransType.Text.Trim());
                        DataTable dtWH = IMWarehouseTransferOutAL.GetWarehouseEditorByID(cboFrom.Text.Trim());
                        if (dt.Rows[0]["ttt_with_transit_warehouse"].ToString() == "N")
                        {
                            loadCboToEditor();
                        }
                        else if (dt.Rows[0]["ttt_with_transit_warehouse"].ToString() == "Y" && dtWH.Rows[0]["wh_transit_warehouse_id"].ToString().Trim() != "")
                        {
                            loadCboToEditor();
                        }
                        else
                        {
                            clsAlert.PushAlert("Transit WH ID For this Type Cannot null!", clsAlert.Type.Error);
                            cboFrom.SelectedIndex = -1;
                            lblFromInfo.Text = "";
                            cboFrom.Focus();
                        }
                    }
                }
                else
                {
                    lblTransTypeInfo.Text = string.Empty;
                }
            }
        }

        private void btnLineEntry_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.DISPLAY);
        }

        private void AddRowsGrd(string _ProductID, string _ProducrDesc, string _Qty, string _UnitCost, string _TotalCost, string _ProductType, string _QtyOnHand, string _QtyAvailable)
        {
            int _NoUrut = grdEditor.Rows.Count + 1;
            grdEditor.Rows.Add(_NoUrut, _ProductID, _ProducrDesc, _Qty, _UnitCost, _TotalCost, _ProductType, _QtyOnHand, _QtyAvailable);
        }

        private bool CheekSequnceCode(string _WHID, string _TxnType)
        {
            bool _result = false;

            string _Param = "IM" + _WHID + _TxnType;
            DataTable dt = IMWarehouseTransferOutAL.GetSNIDDetail(_Param);

            if(dt.Rows.Count > 0)
            {
                if(Convert.ToDouble(dt.Rows[0]["sn_last_number"]) + 1 < Convert.ToDouble(dt.Rows[0]["sn_maximum"]))
                {
                    _result = true;
                }
                else
                {
                    _result = false;
                }
            }

            return _result;
        }

        private void grdEditor_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool _IsPassed = true;

            if (grdEditor.CurrentCell.ColumnIndex == 1)
            {
                if(((grdEditor.CurrentRow.Cells["grdProductID"].Value == null) ? "" : grdEditor.CurrentRow.Cells["grdProductID"].Value.ToString()) != "")
                {
                    //clear column value
                    for (int i = 2; i < grdEditor.Columns.Count; i++)
                    {
                        grdEditor.Rows[e.RowIndex].Cells[i].Value = "";
                    }

                    foreach (DataGridViewRow dr in grdEditor.Rows)
                    {
                        if (grdEditor.CurrentRow.Index != dr.Index)
                        {
                            if (grdEditor.CurrentRow.Cells["grdProductID"].Value.ToString().Trim() != dr.Cells["grdProductID"].Value.ToString().Trim())
                            {
                                _IsPassed = true;
                            }
                            else
                            {
                                clsAlert.PushAlert("Duplicate Product ID " + grdEditor.CurrentRow.Cells["grdProductID"].Value.ToString().Trim() + "!", clsAlert.Type.Error);
                                grdEditor.CurrentRow.Cells["grdProductID"].Value = "";
                                _IsPassed = false;

                                //grdEditor.CurrentCell = grdEditor.Rows[grdEditor.Rows.Count - 1].Cells["grdProductID"];
                                //grdEditor.BeginEdit(true);
                                break;
                            }
                        }
                    }

                    if (_IsPassed == true)
                    {
                        DataTable dtProduct = IMWarehouseTransferOutAL.GetProductByID(grdEditor.CurrentRow.Cells["grdProductID"].Value.ToString().Trim());
                        if (dtProduct.Rows.Count > 0)
                        {
                            grdEditor.CurrentRow.Cells["grdProductDesc"].Value = dtProduct.Rows[0]["pm_product_description"].ToString();

                            if (dtProduct.Rows[0]["pm_product_type"].ToString() == "M")
                            {
                                grdEditor.CurrentRow.Cells["grdProductType"].Value = "Multiple";
                            }
                            else if (dtProduct.Rows[0]["pm_product_type"].ToString() == "S")
                            {
                                grdEditor.CurrentRow.Cells["grdProductType"].Value = "Single";
                            }
                            else if (dtProduct.Rows[0]["pm_product_type"].ToString() == "P")
                            {
                                grdEditor.CurrentRow.Cells["grdProductType"].Value = "Package";
                            }

                            DataTable dtCostSTD = IMWarehouseTransferOutAL.GetCostSTDByPID(grdEditor.CurrentRow.Cells["grdProductID"].Value.ToString().Trim());
                            if (dtCostSTD.Rows.Count > 0)
                            {
                                grdEditor.CurrentRow.Cells["grdUnitCost"].Value = Convert.ToDouble(dtCostSTD.Rows[0]["cs_standard_unit_cost"]);
                            }

                            if (grdEditor.CurrentRow.Cells["grdUnitCost"].Value.ToString() != "")
                            {
                                if (grdEditor.CurrentRow.Cells["grdUnitCost"].Value.ToString() != "0")
                                {
                                    DataTable dtQty = IMWarehouseTransferOutAL.GetQtyProduct(grdEditor.CurrentRow.Cells["grdProductID"].Value.ToString().Trim(), cboFrom.Text.Trim());

                                    if (dtQty.Rows.Count > 0)
                                    {
                                        grdEditor.CurrentRow.Cells["grdQtyOnHand"].Value = dtQty.Rows[0]["sb_qty_onhand"];
                                        grdEditor.CurrentRow.Cells["grdQtyAvailable"].Value = dtQty.Rows[0]["qty_available"];
                                        grdEditor.CurrentRow.Cells["grdQuantity"].Value = "";

                                        grdEditor.CurrentCell = grdEditor.Rows[grdEditor.Rows.Count - 1].Cells["grdQuantity"];
                                        grdEditor.BeginEdit(true);
                                    }
                                    else
                                    {
                                        clsAlert.PushAlert("Product : " + grdEditor.CurrentRow.Cells["grdProductID"].Value.ToString().Trim() + " In Warehouse " + cboFrom.Text.Trim() + " Not Found!", clsAlert.Type.Error);
                                        for (int i = 1; i < grdEditor.Columns.Count; i++)
                                        {
                                            grdEditor.Rows[e.RowIndex].Cells[i].Value = "";
                                        }

                                        //grdEditor.CurrentCell = grdEditor.Rows[grdEditor.Rows.Count - 1].Cells["grdProductID"];
                                        //grdEditor.BeginEdit(true);
                                    }
                                }
                                else
                                {
                                    clsAlert.PushAlert("Product Cost Still Zero!", clsAlert.Type.Error);
                                    for (int i = 1; i < grdEditor.Columns.Count; i++)
                                    {
                                        grdEditor.Rows[e.RowIndex].Cells[i].Value = "";
                                    }

                                    //grdEditor.CurrentCell = grdEditor.Rows[grdEditor.Rows.Count - 1].Cells["grdProductID"];
                                    //grdEditor.BeginEdit(true);
                                }
                            }
                            else
                            {
                                clsAlert.PushAlert("Product Cost Still Zero!", clsAlert.Type.Error);
                                for (int i = 1; i < grdEditor.Columns.Count; i++)
                                {
                                    grdEditor.Rows[e.RowIndex].Cells[i].Value = "";
                                }

                                //grdEditor.CurrentCell = grdEditor.Rows[grdEditor.Rows.Count - 1].Cells["grdProductID"];
                                //grdEditor.BeginEdit(true);
                            }
                        }
                        else
                        {
                            clsAlert.PushAlert("Product ID " + grdEditor.CurrentRow.Cells["grdProductID"].Value.ToString().Trim() + " Not Found!", clsAlert.Type.Error);
                            grdEditor.CurrentRow.Cells["grdProductID"].Value = "";

                            //grdEditor.CurrentCell = grdEditor.Rows[grdEditor.Rows.Count - 1].Cells["grdProductID"];
                            //grdEditor.BeginEdit(true);
                        }
                    }
                }
            }
            else if (grdEditor.CurrentCell.ColumnIndex == 3)
            {
                if(((grdEditor.CurrentRow.Cells["grdQuantity"].Value == null) ? "" : grdEditor.CurrentRow.Cells["grdQuantity"].Value.ToString()) != "")
                {
                    if (grdEditor.CurrentRow.Cells["grdProductDesc"].Value.ToString() != "")
                    {
                        if (((grdEditor.CurrentRow.Cells["grdQuantity"].Value.ToString() == "") ? 0 : Convert.ToInt64(grdEditor.CurrentRow.Cells["grdQuantity"].Value)) != 0)
                        {

                            if (((grdEditor.CurrentRow.Cells["grdUnitCost"].Value.ToString() == "") ? 0 : Convert.ToInt64(grdEditor.CurrentRow.Cells["grdUnitCost"].Value)) != 0)
                            {
                                if (Convert.ToInt64(grdEditor.CurrentRow.Cells["grdQuantity"].Value) <= Convert.ToInt64(grdEditor.CurrentRow.Cells["grdQtyAvailable"].Value))
                                {
                                    grdEditor.CurrentRow.Cells["grdTotalCost"].Value = Convert.ToDouble(grdEditor.CurrentRow.Cells["grdUnitCost"].Value) * Convert.ToDouble(grdEditor.CurrentRow.Cells["grdQuantity"].Value);

                                    string _ProdID = (grdEditor.Rows[grdEditor.Rows.Count - 1].Cells["grdProductID"].Value == null) ? "" : grdEditor.Rows[grdEditor.Rows.Count - 1].Cells["grdProductID"].Value.ToString();
                                    string _Qty = (grdEditor.Rows[grdEditor.Rows.Count - 1].Cells["grdQuantity"].Value == null) ? "" : grdEditor.Rows[grdEditor.Rows.Count - 1].Cells["grdQuantity"].Value.ToString();

                                    if (_ProdID != "" && (_Qty != "" && _Qty != "0"))
                                    {
                                        AddRowsGrd("", "", "", "", "", "", "", "");
                                        grdEditor.CurrentCell = grdEditor.Rows[grdEditor.Rows.Count - 1].Cells["grdProductID"];
                                        grdEditor.BeginEdit(true);
                                    }
                                }
                                else
                                {
                                    clsAlert.PushAlert("Product Stock Not Enought, Available Stock :" + grdEditor.CurrentRow.Cells["grdQtyAvailable"].Value.ToString() + " !", clsAlert.Type.Error);
                                    grdEditor.CurrentRow.Cells["grdQuantity"].Value = 0;

                                    grdEditor.CurrentCell = grdEditor.Rows[grdEditor.Rows.Count - 1].Cells["grdQuantity"];
                                    grdEditor.BeginEdit(true);
                                }
                            }
                            else
                            {
                                clsAlert.PushAlert("Unit Cost Can Not Blank or Zero!", clsAlert.Type.Error);
                                grdEditor.CurrentRow.Cells["grdQuantity"].Value = 0;

                                //grdEditor.CurrentCell = grdEditor.Rows[grdEditor.Rows.Count - 1].Cells["grdQuantity"];
                                //grdEditor.BeginEdit(true);
                            }

                        }
                        else
                        {
                            clsAlert.PushAlert("Quantity Can Not Blank or Zero!", clsAlert.Type.Error);
                            grdEditor.CurrentRow.Cells["grdQuantity"].Value = 0;

                            //grdEditor.CurrentCell = grdEditor.Rows[grdEditor.Rows.Count - 1].Cells["grdQuantity"];
                            //grdEditor.BeginEdit(true);
                        }
                    }
                    else
                    {
                        clsAlert.PushAlert("Product Desc Can Not Blank!", clsAlert.Type.Error);
                        grdEditor.CurrentRow.Cells["grdQuantity"].Value = 0;

                        //grdEditor.CurrentCell = grdEditor.Rows[grdEditor.Rows.Count - 1].Cells["grdQuantity"];
                        //grdEditor.BeginEdit(true);
                    }
                }
                else
                {
                    if (((grdEditor.Rows[grdEditor.CurrentCell.RowIndex].Cells["grdProductID"].Value == null) ? "" : grdEditor.Rows[grdEditor.CurrentCell.RowIndex].Cells["grdProductID"].Value.ToString()) != "")
                    {
                        clsAlert.PushAlert("Quantity Can Not Blank or Zero!", clsAlert.Type.Error);
                        grdEditor.CurrentRow.Cells["grdQuantity"].Value = 0;
                    }
                    else
                    {
                        clsAlert.PushAlert("Product Desc Can Not Blank!", clsAlert.Type.Error);
                        grdEditor.CurrentRow.Cells["grdQuantity"].Value = 0;
                    }
                }
            }
        }

        private void cboTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadCboTo == false)
            {
                if (cboTo.SelectedIndex > -1)
                {
                    if (cboTo.Text.Trim() == cboFrom.Text.Trim())
                    {
                        clsAlert.PushAlert("Warehose From and Warehouse To Cannot Same!", clsAlert.Type.Error);
                        cboTo.SelectedIndex = -1;
                        lblToInfo.Text = "";
                        cboTo.Focus();
                    }
                    else
                    {
                        lblToInfo.Text = cboTo.SelectedValue.ToString().ToUpper();
                    }
                }
            }
        }

        private void cboFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadEditor == false)
            {
                if (cboFrom.SelectedIndex > -1)
                {
                    cboTo.DataSource = null;
                    lblToInfo.Text = "";

                    if (cboTransType.SelectedIndex > -1)
                    {
                        DataTable dt = IMWarehouseTransferOutAL.GetTransferTxnTypeByID(cboTransType.Text.Trim());
                        DataTable dtWH = IMWarehouseTransferOutAL.GetWarehouseEditorByID(cboFrom.Text.Trim());

                        if(dt.Rows[0]["ttt_with_transit_warehouse"].ToString() == "N")
                        {
                            lblFromInfo.Text = cboFrom.SelectedValue.ToString().ToUpper(); ;
                            loadCboToEditor();
                        }
                        else if (dt.Rows[0]["ttt_with_transit_warehouse"].ToString() == "Y" && dtWH.Rows[0]["wh_transit_warehouse_id"].ToString().Trim() != "")
                        {
                            lblFromInfo.Text = cboFrom.SelectedValue.ToString().ToUpper(); ;
                            loadCboToEditor();
                        }
                        else
                        {
                            clsAlert.PushAlert("Transit WH ID For this Type Cannot Null!", clsAlert.Type.Error);
                            cboFrom.SelectedIndex = -1;
                            lblFromInfo.Text = "";
                            cboFrom.Focus();
                        }
                    }
                    else
                    {
                        clsAlert.PushAlert("Txn Type Required!", clsAlert.Type.Error);
                        cboFrom.SelectedIndex = -1;
                        lblFromInfo.Text = "";
                        cboTransType.Focus();
                    }
                }
            }
        }

        private void grdHeader_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SettingVariable(false);
                DrawDatatableD();
            }
        }

        private void btnPrevD_Click(object sender, EventArgs e)
        {
            _CurrentPageD--;
            PaginationD(true);
            DrawDatatableD();
        }

        private void btnNextH_Click(object sender, EventArgs e)
        {
            _CurrentPageH++;
            PaginationH(true);
            DrawDatatableH();
            DrawDatatableD();
        }

        private void btnPrevH_Click(object sender, EventArgs e)
        {
            _CurrentPageH--;
            PaginationH(true);
            DrawDatatableH();
            _CurrentPageD = 1;
            DrawDatatableD();
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.EXPORT);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.SAVE);
        }

    }
}
