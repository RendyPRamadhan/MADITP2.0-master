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

namespace MADITP2._0.userInterface.IM.IM_RejectConfirmationUI
{
    public partial class IM_RejectConfirmationUI : Form
    {
        clsGlobal Helper;
        GlobalAL GlobalAL;
        clsReport clsReport;
        IMRejectConfirmationAL IMRejectConfirmationAL;
        IMTransferConfirmationBL IMTransferConfirmationBL;
        clsAlert clsAlert;

        private List<IMTransferConfirmationBL> ArrayIMTransferConfirmationBL = new List<IMTransferConfirmationBL>();
        private List<IMTransferConfirmationBL> ArrayGrdHeaderSelected = new List<IMTransferConfirmationBL>();
        private int _CurrentPageH, _CurrentPageD, _FetchLimit, _TotalPageH, _TotalPageD;
        private string _ExistForm, _WarehouseTransit;
        private bool _isLoad;

        public IM_RejectConfirmationUI()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = new clsGlobal();
                GlobalAL = new GlobalAL(Helper);
                clsReport = new clsReport();
                IMRejectConfirmationAL = new IMRejectConfirmationAL(Helper);
                IMTransferConfirmationBL = new IMTransferConfirmationBL();
                clsAlert = new clsAlert();
            }
        }

        private void settingPanel(clsEventButton.EnumAction _ActionType)
        {
            switch (_ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    {
                        cboTxnType_SelectedIndexChanged(null, null);

                        _ExistForm = "VIEW";
                        setToolTip();
                        Helper.SetActive(navView);

                        break;
                    }
                case clsEventButton.EnumAction.NEW:
                    {
                        break;
                    }
                case clsEventButton.EnumAction.DELETE:
                    {
                        break;
                    }
                case clsEventButton.EnumAction.PRINT:
                    {
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
                case clsEventButton.EnumAction.SAVE:
                    {
                        ProsesReject();
                        break;
                    }
                default:
                {
                    break;
                }
            }
        }

        private void ProsesReject()
        {
            try
            {
                int _Idx = 1;
                int _row = 0;
                ArrayIMTransferConfirmationBL.Clear();  

                //CHECK MIN 1 ROW IS CHECKED
                if (ArrayGrdHeaderSelected.Count > 0)
                {
                    if (clsDialog.ShowDialog("Are You Sure to Reject ?") == DialogResult.Yes)
                    {
                        _row = 0;

                        for (int j = 0; j <= ArrayGrdHeaderSelected.Count - 1; j++)
                        {
                            DataTable dtTxnType = IMRejectConfirmationAL.GetTransferTxnTypeByID(ArrayGrdHeaderSelected[j].st_txn_reference.ToString().Trim().Substring(0, 3));
                            DataTable dtWHTransit = IMRejectConfirmationAL.GetTransitWHID(ArrayGrdHeaderSelected[j].st_from_warehouse_id.ToString().Trim());

                            //GET DATA FOR GRID DETAIL TEMP
                            IMTransferConfirmationBL = new IMTransferConfirmationBL()
                            {
                                st_txn_reference = ArrayGrdHeaderSelected[j].st_txn_reference.ToString().Trim()
                            };

                            grdDetailTemp.DataSource = null;
                            DataTable dtTemp = IMRejectConfirmationAL.ReadDetail(EnumFilter.GET_ALL, IMTransferConfirmationBL, _CurrentPageD, _FetchLimit);
                            grdDetailTemp.AutoGenerateColumns = false;
                            grdDetailTemp.DataSource = dtTemp;
                            grdDetailTemp.Refresh();

                            _Idx = 1;
                            foreach (DataGridViewRow drT in grdDetailTemp.Rows)
                            {
                                //INTRANSIT = 'N'
                                if (dtTxnType.Rows[0]["ttt_with_transit_warehouse"].ToString().Trim() == "N")
                                {
                                    if (drT.Cells["grdReferenceTemp"].Value.ToString().Trim() == ArrayGrdHeaderSelected[j].st_txn_reference.ToString().Trim())
                                    {
                                        if (((drT.Cells["grdQtyReceivedTemp"].Value.ToString().Trim() == "") ? 0 : Convert.ToInt32(drT.Cells["grdQtyReceivedTemp"].Value)) != 0)
                                        {
                                            ArrayIMTransferConfirmationBL.Add(new IMTransferConfirmationBL());

                                            ArrayIMTransferConfirmationBL[_row].st_warehouse_id = ArrayGrdHeaderSelected[j].st_from_warehouse_id.ToString().Trim();
                                            ArrayIMTransferConfirmationBL[_row].st_txn_type_code = dtTxnType.Rows[0]["ttt_txn_type_into_or_wh_ex_pod"].ToString().Trim();
                                            ArrayIMTransferConfirmationBL[_row].st_transfer_status = "Y";
                                            ArrayIMTransferConfirmationBL[_row].st_txn_quantity = Convert.ToInt32(drT.Cells["grdQtyReceivedTemp"].Value);
                                            ArrayIMTransferConfirmationBL[_row].st_txn_cost_value = Convert.ToInt64(drT.Cells["grdTotalCostTemp"].Value);
                                            ArrayIMTransferConfirmationBL[_row].st_product_id = drT.Cells["grdProductIDTemp"].Value.ToString().Trim();
                                            ArrayIMTransferConfirmationBL[_row].st_txn_type_index = _Idx;
                                            ArrayIMTransferConfirmationBL[_row].st_txn_date = dtTransferTxnDate.Value.Date;
                                            ArrayIMTransferConfirmationBL[_row].st_txn_reference = ArrayGrdHeaderSelected[j].st_txn_reference.ToString().Trim();
                                            ArrayIMTransferConfirmationBL[_row].st_txn_description = ArrayGrdHeaderSelected[j].st_txn_description.ToString().Trim();
                                            ArrayIMTransferConfirmationBL[_row].st_from_warehouse_id = ArrayGrdHeaderSelected[j].st_from_warehouse_id.ToString().Trim();
                                            ArrayIMTransferConfirmationBL[_row].st_to_warehouse_id = ArrayGrdHeaderSelected[j].st_to_warehouse_id.ToString().Trim();
                                            ArrayIMTransferConfirmationBL[_row].st_user_id = clsLogin.USERID.Trim();
                                            ArrayIMTransferConfirmationBL[_row].transitSts = dtTxnType.Rows[0]["ttt_with_transit_warehouse"].ToString().Trim();
                                            ArrayIMTransferConfirmationBL[_row].type = dtTxnType.Rows[0]["ttt_txn_type_out_from_org_wh"].ToString().Trim();
                                        }
                                    }
                                }
                                //INTRANSIT = 'Y'
                                else
                                {
                                    for (int K = 1; K <= 2; K++)
                                    {
                                        if (((drT.Cells["grdQtyReceivedTemp"].Value.ToString().Trim() == "") ? 0 : Convert.ToInt32(drT.Cells["grdQtyReceivedTemp"].Value)) != 0)
                                        {
                                            if (K == 1)
                                            {
                                                //PIO
                                                ArrayIMTransferConfirmationBL.Add(new IMTransferConfirmationBL());

                                                ArrayIMTransferConfirmationBL[_row].st_warehouse_id = dtWHTransit.Rows[0]["wh_transit_warehouse_id"].ToString().Trim();
                                                ArrayIMTransferConfirmationBL[_row].st_txn_type_code = dtTxnType.Rows[0]["ttt_txn_type_out_from_transit_ex_pod"].ToString().Trim();
                                                ArrayIMTransferConfirmationBL[_row].st_transfer_status = "Y";
                                                ArrayIMTransferConfirmationBL[_row].st_txn_quantity = Convert.ToInt32(drT.Cells["grdQtyReceivedTemp"].Value) * -1;
                                                ArrayIMTransferConfirmationBL[_row].st_txn_cost_value = Convert.ToInt64(drT.Cells["grdTotalCostTemp"].Value) * -1;
                                                ArrayIMTransferConfirmationBL[_row].st_product_id = drT.Cells["grdProductIDTemp"].Value.ToString().Trim();
                                                ArrayIMTransferConfirmationBL[_row].st_txn_type_index = _Idx;
                                                ArrayIMTransferConfirmationBL[_row].st_txn_date = dtTransferTxnDate.Value.Date;
                                                ArrayIMTransferConfirmationBL[_row].st_txn_reference = ArrayGrdHeaderSelected[j].st_txn_reference.ToString().Trim();
                                                ArrayIMTransferConfirmationBL[_row].st_txn_description = ArrayGrdHeaderSelected[j].st_txn_description.ToString().Trim();
                                                ArrayIMTransferConfirmationBL[_row].st_from_warehouse_id = ArrayGrdHeaderSelected[j].st_from_warehouse_id.ToString().Trim();
                                                ArrayIMTransferConfirmationBL[_row].st_to_warehouse_id = ArrayGrdHeaderSelected[j].st_to_warehouse_id.ToString().Trim();
                                                ArrayIMTransferConfirmationBL[_row].st_user_id = clsLogin.USERID.Trim();
                                                ArrayIMTransferConfirmationBL[_row].transitSts = dtTxnType.Rows[0]["ttt_with_transit_warehouse"].ToString().Trim();
                                                ArrayIMTransferConfirmationBL[_row].type = dtTxnType.Rows[0]["ttt_txn_type_in_to_transit_wh"].ToString().Trim();

                                                _row++;
                                            }
                                            //PTI
                                            else if (K == 2)
                                            {
                                                if (dtTxnType.Rows[0]["ttt_system_type"].ToString().Trim() == "O" || dtTxnType.Rows[0]["ttt_system_type"].ToString().Trim() == "B")
                                                {
                                                    ArrayIMTransferConfirmationBL.Add(new IMTransferConfirmationBL());

                                                    ArrayIMTransferConfirmationBL[_row].st_warehouse_id = ArrayGrdHeaderSelected[j].st_from_warehouse_id.ToString().Trim();
                                                    ArrayIMTransferConfirmationBL[_row].st_txn_type_code = dtTxnType.Rows[0]["ttt_txn_type_into_or_wh_ex_pod"].ToString().Trim();
                                                    ArrayIMTransferConfirmationBL[_row].st_transfer_status = "Y";
                                                    ArrayIMTransferConfirmationBL[_row].st_txn_quantity = Convert.ToInt32(drT.Cells["grdQtyReceivedTemp"].Value);
                                                    ArrayIMTransferConfirmationBL[_row].st_txn_cost_value = Convert.ToInt64(drT.Cells["grdTotalCostTemp"].Value);
                                                    ArrayIMTransferConfirmationBL[_row].st_product_id = drT.Cells["grdProductIDTemp"].Value.ToString().Trim();
                                                    ArrayIMTransferConfirmationBL[_row].st_txn_type_index = _Idx;
                                                    ArrayIMTransferConfirmationBL[_row].st_txn_date = dtTransferTxnDate.Value.Date;
                                                    ArrayIMTransferConfirmationBL[_row].st_txn_reference = ArrayGrdHeaderSelected[j].st_txn_reference.ToString().Trim();
                                                    ArrayIMTransferConfirmationBL[_row].st_txn_description = ArrayGrdHeaderSelected[j].st_txn_description.ToString().Trim();
                                                    ArrayIMTransferConfirmationBL[_row].st_from_warehouse_id = ArrayGrdHeaderSelected[j].st_from_warehouse_id.ToString().Trim();
                                                    ArrayIMTransferConfirmationBL[_row].st_to_warehouse_id = ArrayGrdHeaderSelected[j].st_to_warehouse_id.ToString().Trim();
                                                    ArrayIMTransferConfirmationBL[_row].st_user_id = clsLogin.USERID.Trim();
                                                    ArrayIMTransferConfirmationBL[_row].transitSts = dtTxnType.Rows[0]["ttt_with_transit_warehouse"].ToString().Trim();
                                                    ArrayIMTransferConfirmationBL[_row].type = dtTxnType.Rows[0]["ttt_txn_type_out_from_org_wh"].ToString().Trim();

                                                    _row++;
                                                }
                                            }
                                        }
                                    }
                                }

                                _Idx++;
                            }
                        }

                        if (ArrayIMTransferConfirmationBL.Count > 0)
                        {
                            //PROSES SIMPAN
                            bool _isSucess = IMRejectConfirmationAL.Post(ArrayIMTransferConfirmationBL);
                            if (_isSucess == true)
                            {
                                clsAlert.PushAlert("Reject Confirmation Sucessfully!", clsAlert.Type.Success);
                                btnSearch_Click(null, null);
                            }
                            else
                            {
                                clsAlert.PushAlert("Reject Confirmation Failed!", clsAlert.Type.Error);
                            }
                        }
                    }
                }
                else
                {
                    clsAlert.PushAlert("You have to Check The Reference first!", clsAlert.Type.Error);
                }
            }
            catch(Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void LoadCheckedGridHeader()
        {
            foreach (DataGridViewRow row in grdHeader.Rows)
            {
                for (int j = 0; j <= ArrayGrdHeaderSelected.Count - 1; j++)
                {
                    if (row.Cells["st_txn_reference"].Value.ToString().Trim() == ArrayGrdHeaderSelected[j].st_txn_reference.ToString().Trim())
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["grdCheck"];
                        chk.Value = Convert.ToBoolean(chk.TrueValue);
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

            IMTransferConfirmationBL = new IMTransferConfirmationBL()
            {
                st_txn_reference = getReference()
            };

            if(grdHeader.Rows.Count > 0)
            {
                //GET DATA FOR GRID
                dt = IMRejectConfirmationAL.ReadDetail(EnumFilter.GET_WITH_PAGING, IMTransferConfirmationBL, _CurrentPageD, _FetchLimit);
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
                dtCount = IMRejectConfirmationAL.ReadDetail(EnumFilter.GET_COUNT_ROWS, IMTransferConfirmationBL, _CurrentPageD, _FetchLimit);
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
            if(cboTxnType.Text.Trim().Length > 0)
            {
                if (cboWHFrom.Text.Trim().Length > 0)
                {
                    if (cboWHTo.Text.Trim().Length > 0)
                    {
                        if (cboWHFrom.Text.Trim() != cboWHTo.Text.Trim())
                        {
                            DataTable dtTransit = IMRejectConfirmationAL.GetTransitWHID(cboWHFrom.Text.Trim());
                            if (dtTransit.Rows.Count > 0)
                            {
                                _WarehouseTransit = dtTransit.Rows[0]["wh_transit_warehouse_id"].ToString().Trim();

                                if (_WarehouseTransit.Substring(0, 3) == "INT")
                                {
                                    bool _IsDate = (chbTxnDate.Checked == true) ? true : false;
                                    DateTime _FromDate = dtTxnDateFrom.Value;
                                    DateTime _ToDate = dtTxnDateTo.Value;

                                    //GET DATA FOR GRID
                                    IMTransferConfirmationBL = new IMTransferConfirmationBL()
                                    {
                                        st_gl_txn_type = cboTxnType.Text.Trim().ToString(),
                                        st_from_warehouse_id = cboWHFrom.Text.ToString().Trim(),
                                        st_to_warehouse_id = cboWHTo.Text.ToString().Trim(),
                                        st_txn_reference = txtRefenceNo.Text.Trim()
                                    };

                                    DataTable dt = IMRejectConfirmationAL.ReadHeader(EnumFilter.GET_WITH_PAGING, IMTransferConfirmationBL, _CurrentPageH, _FetchLimit, _IsDate, _FromDate, _ToDate);
                                    grdHeader.AutoGenerateColumns = false;
                                    grdHeader.DataSource = dt;

                                    ////GET COUNT FOR PAGING
                                    DataTable dtCount = IMRejectConfirmationAL.ReadHeader(EnumFilter.GET_COUNT_ROWS, IMTransferConfirmationBL, _CurrentPageH, _FetchLimit, _IsDate, _FromDate, _ToDate);
                                    _TotalPageH = (int)Math.Ceiling((Double)Convert.ToInt64(dtCount.Rows[0]["TotalRows"]) / _FetchLimit);
                                    lblPagingInfoH.Text = (Convert.ToInt32(_TotalPageH) > 0) ? "Pages : " + _CurrentPageH.ToString() + " / " + _TotalPageH : "Pages : - ";
                                    lblRowsH.Text = "Records : " + grdHeader.Rows.Count.ToString() + " Rows";
                                    PaginationH();
                                }
                                else
                                {
                                    clsAlert.PushAlert("Transit Warehouse Not Found, Please Contact Warehouse Admin!", clsAlert.Type.Error);
                                }
                            }
                            else
                            {
                                clsAlert.PushAlert("Transit Warehouse Not Found, Please Contact Warehouse Admin!", clsAlert.Type.Error);
                            }
                        }
                        else
                        {
                            clsAlert.PushAlert("The Warehouse From(To) Can not Same!", clsAlert.Type.Error);
                            cboWHTo.Focus();
                        }
                    }
                    else
                    {
                        clsAlert.PushAlert("The Warehouse (To) Can Not Blank!", clsAlert.Type.Error);
                        cboWHTo.Focus();
                    }
                }
                else
                {
                    clsAlert.PushAlert("The Warehouse (From) Can Not Blank!", clsAlert.Type.Error);
                    cboWHFrom.Focus();
                }
            }
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

            ToolTip toolTipSearch = new ToolTip();
            toolTipSearch.ShowAlways = true;
            toolTipSearch.SetToolTip(btnSearch, "SEARCH [F6]");

            ToolTip toolTipReject = new ToolTip();
            toolTipReject.ShowAlways = true;
            toolTipReject.SetToolTip(btnReject, "REJECT [F10]");

            ToolTip toolTipExit = new ToolTip();
            toolTipExit.ShowAlways = true;
            toolTipExit.SetToolTip(navClose, "EXIT [ESC]");
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
            settingPanel(clsEventButton.EnumAction.EDIT);
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.DELETE);
        }

        private void navPrint_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.PRINT);
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.EXIT);
        }


        private void navExport_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.EXPORT);
        }

        private void loadComboBox()
        {
            cboTxnType.DataSource = IMRejectConfirmationAL.GetTxnTypeToComboBox(clsLogin.USERID.ToString(), false);
            cboTxnType.ValueMember = "ValueMember";
            cboTxnType.DisplayMember = "DisplayMember";
            cboTxnType.SelectedIndex = 0;

            cboWHFrom.DataSource = IMRejectConfirmationAL.GetWarehouseFromToComboBox(false);
            cboWHFrom.ValueMember = "ValueMember";
            cboWHFrom.DisplayMember = "DisplayMember";
            cboWHFrom.SelectedIndex = -1;

            cboWHTo.DataSource = IMRejectConfirmationAL.GetWarehouseToToComboBox(true, clsLogin.USERID.ToString().Trim());
            cboWHTo.ValueMember = "ValueMember";
            cboWHTo.DisplayMember = "DisplayMember";
            cboWHTo.SelectedIndex = -1;
        }

        private void IM_RejectConfirmationUI_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            KeyPreview = true;

            _isLoad = true;
            loadComboBox();
            _isLoad = false;

            DataTable dtSysDate = IMRejectConfirmationAL.GetSystemDate();
            DataTable dtOpenDate = IMRejectConfirmationAL.GetDateOpenIM();

            if((Convert.ToDateTime(dtSysDate.Rows[0]["gfc_ending_date"]).Date.Month).ToString().Trim() == dtOpenDate.Rows[0]["gfc_period"].ToString().Trim())
            {
                dtTxnDateFrom.Value = Convert.ToDateTime(dtSysDate.Rows[0]["gfc_ending_date"]);
                dtTxnDateTo.Value = Convert.ToDateTime(dtSysDate.Rows[0]["gfc_ending_date"]);
            }
            else
            {
                dtTxnDateFrom.Value = Convert.ToDateTime(dtOpenDate.Rows[0]["gfc_ending_date"]);
                dtTxnDateTo.Value = Convert.ToDateTime(dtOpenDate.Rows[0]["gfc_ending_date"]);
            }

            dtTransferTxnDate.Value = Convert.ToDateTime(dtSysDate.Rows[0]["gfc_ending_date"]);

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
            grdDetailTemp.Rows.Clear();
            ArrayGrdHeaderSelected.Clear();
        }

        private void cboTxnType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_isLoad == false)
            {
                lblTxnTypeInfo.Text = cboTxnType.SelectedValue.ToString().ToUpper();
            }
        }

        private void IM_RejectConfirmationUI_KeyDown(object sender, KeyEventArgs e)
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
                            btnReject_Click(null, null);
                            break;
                        }
                }
            }
            else
            {
                this.ProcessTabKey(true);
            }
        }

        private void cboWHFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoad == false)
            {
                if(cboWHFrom.Text.Trim() != "")
                {
                    if (cboWHFrom.Text.Trim() == cboWHTo.Text.Trim())
                    {
                        clsAlert.PushAlert("The Warehouse From(To) Can not Same!", clsAlert.Type.Error);
                        cboWHFrom.Focus();
                    }
                }
                else
                {
                    clsAlert.PushAlert("The Warehouse (From) Can Not Blank!", clsAlert.Type.Error);
                    cboWHFrom.Focus();
                }
            }
        }

        private void cboWHTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoad == false)
            {
                if (cboWHTo.Text.Trim() != "")
                {
                    if (cboWHTo.Text.Trim() == cboWHFrom.Text.Trim())
                    {
                        clsAlert.PushAlert("The Warehouse From(To) Can not Same!", clsAlert.Type.Error);
                        cboWHTo.Focus();
                    }
                }
                else
                {
                    clsAlert.PushAlert("The Warehouse (To) Can Not Blank!", clsAlert.Type.Error);
                    cboWHTo.Focus();
                }
            }
        }

        private void txtRefenceNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void grdHeader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdHeader.CurrentCell.ColumnIndex == 0)
            {
                int i, _row;
                i = grdHeader.CurrentCell.RowIndex;

                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)grdHeader["grdCheck", i];
                if (Convert.ToBoolean(chk.Value) == Convert.ToBoolean(chk.FalseValue))
                {
                    //ADD TO ARRAY VARIABLE
                    ArrayGrdHeaderSelected.Add(new IMTransferConfirmationBL());

                    _row = (ArrayGrdHeaderSelected.Count == 0) ? 0 : ArrayGrdHeaderSelected.Count - 1;

                    ArrayGrdHeaderSelected[_row].st_txn_reference = grdHeader["st_txn_reference", i].Value.ToString().Trim();
                    ArrayGrdHeaderSelected[_row].st_txn_date = Convert.ToDateTime(grdHeader["st_txn_date", i].Value);
                    ArrayGrdHeaderSelected[_row].st_from_warehouse_id = grdHeader["st_from_warehouse_id", i].Value.ToString().Trim();
                    ArrayGrdHeaderSelected[_row].st_to_warehouse_id = grdHeader["st_to_warehouse_id", i].Value.ToString().Trim();
                    ArrayGrdHeaderSelected[_row].st_txn_description = grdHeader["st_txn_description", i].Value.ToString().Trim();
                    chk.Value = Convert.ToBoolean(chk.TrueValue);
                }
                else
                {
                    //REMOVE TO ARRAY VARIABLE
                    for (int j = 0; j <= ArrayGrdHeaderSelected.Count - 1; j++)
                    {
                        if (ArrayGrdHeaderSelected[j].st_txn_reference.ToString().Trim() == grdHeader["st_txn_reference", i].Value.ToString().Trim())
                        {
                            ArrayGrdHeaderSelected.RemoveAt(j);
                            chk.Value = Convert.ToBoolean(chk.FalseValue);
                            break;
                        }
                    }
                }
            }
        }

        private void chbTxnDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTxnDate.Checked == true)
            {
                dtTxnDateFrom.Enabled = false;
                dtTxnDateTo.Enabled = false;
            }
            else
            {
                dtTxnDateFrom.Enabled = true;
                dtTxnDateTo.Enabled = true;
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            settingPanel(clsEventButton.EnumAction.SAVE);
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
            LoadCheckedGridHeader();
        }

        private void btnPrevH_Click(object sender, EventArgs e)
        {
            _CurrentPageH--;
            PaginationH(true);
            DrawDatatableH();
            _CurrentPageD = 1;
            DrawDatatableD();
            LoadCheckedGridHeader();
        }

    }
}
