using MADITP2._0.ApplicationLogic.SO;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.SO.SOInvoice
{
    public partial class SOInvoiceUI : Form
    {
        private int _CurrentPage;
        private int _FetchLimit;
        private int _TotalPage;
        private clsGlobal Helper;
        private clsHardcoded Hardcoded;
        private clsAlert Alert;
        private SOKpHeaderAL Accessor;
        private SOKPHeaderBL _KpHeader;
        private SOInvoiceHeaderAL InvoiceHeaderAccessor;
        private bool IsProcessable1;
        private bool IsProcessable2;

        public SOInvoiceUI()
        {
            InitializeComponent();

            _CurrentPage = 1;
            _FetchLimit = (int)EnumFetchData.DefaultLimit;

            Helper = new clsGlobal();
            Alert = new clsAlert();
            Hardcoded = new clsHardcoded();

            InvoiceHeaderAccessor = new SOInvoiceHeaderAL(Helper);
            Accessor = new SOKpHeaderAL(
                Helper,
                new ApplicationLogic.RC.RCRepMasterAL(Helper, null),
                new ApplicationLogic.GS.GSEntityAL(Helper),
                new ApplicationLogic.GS.GSBranchAL(Helper));
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            Pagination(true);
            DrawDatatable();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Helper.ResetAllFormControls(tiraGroupBox1);
            Helper.ResetAllFormControls(tiraGroupBox2);
            Helper.ResetAllFormControls(tiraGroupBox3);
            Helper.ResetAllFormControls(tiraGroupBox4);

            Pagination(true);
            DrawDatatable();
        }

        private void SOInvoiceUI_Load(object sender, EventArgs e)
        {
            DrawComboboxFilter();

            Pagination(true);
            DrawDatatable();
        }

        private void DrawDatatable()
        {
            int rows = Accessor.CountRows();
            _TotalPage = (int)Math.Ceiling(Convert.ToDouble(rows) / _FetchLimit);
            txtPagingInfo.Text = _CurrentPage.ToString() + "/" + _TotalPage;
            if (rows == 0)
            {
                Alert.PushAlert("No record found!", clsAlert.Type.Info);
                return;
            }

            string EntityID = Helper.CastToString(cmbFilterEntity.SelectedValue);
            string BranchId = Helper.CastToString(cmbFilterBranch.SelectedValue);
            string SalesType = Helper.CastToString(cmbFilterSalesType.SelectedValue);
            string InvoiceNumber = Helper.CastToString(txtFilterInvoiceNumber.Text);
            string KpNumber = Helper.CastToString(txtFilterKPNumber.Text);
            string KpStatus = Helper.CastToString(cmbFilterStatusKP.SelectedValue);
            string CODStatus = Helper.CastToString(cmbFilterStatusCOD.SelectedValue);
            string VerificationStatus = Helper.CastToString(cmbFilterStatusVerification.SelectedValue);
            string DeliveryStatus = Helper.CastToString(cmbFilterStatusDelivery.SelectedValue);
            string DPStatus = Helper.CastToString(cmbFilterStatusDP.SelectedValue);
            string InvoiceStatus = Helper.CastToString(cmbFilterStatusInvoice.SelectedValue);

            string KpDateStart = "";
            string KpDateEnd = "";
            if(chkUseKpDate.Checked)
            {
                KpDateStart = dtKpDateStart.Value.ToString("yyyy-MM-dd 00:00");
                KpDateEnd = dtKpDateEnd.Value.ToString("yyyy-MM-dd 23:59");
            }

            string DelivDateStart = "";
            string DelivDateEnd = "";
            if (chkUseKpDate.Checked)
            {
                DelivDateStart = dtDelivDateStart.Value.ToString("yyyy-MM-dd 00:00");
                DelivDateEnd = dtDelivDateEnd.Value.ToString("yyyy-MM-dd 23:59");
            }

            List<SOKPHeaderBL> source = Accessor.AdvanceShowList(
                _CurrentPage, _FetchLimit, 
                EntityID, BranchId, 
                SalesType, InvoiceNumber, 
                KpNumber, KpStatus, 
                CODStatus, VerificationStatus, 
                DeliveryStatus, DPStatus, 
                InvoiceStatus, 
                KpDateStart, KpDateEnd,
                DelivDateStart, DelivDateEnd);
            dgvResult.AutoGenerateColumns = false;
            dgvResult.DataSource = CreateDataSource(source);

            Pagination();
        }

        private DataTable CreateDataSource(List<SOKPHeaderBL> Source)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]{
                new DataColumn() {Caption = "KP Number",ColumnName = "Skh_so_kp_number"},
                new DataColumn() {Caption = "KP Date",ColumnName = "Skh_so_kp_date"},
                new DataColumn() {Caption = "Invoice No",ColumnName = "Skh_invoice_number"},
                new DataColumn() {Caption = "Invoice Date",ColumnName = "Skh_invoice_date"},
                new DataColumn() {Caption = "Status Invoice",ColumnName = "Skh_status_of_invoice"},
                new DataColumn() {Caption = "Rep ID",ColumnName = "Skh_rep_id"},
                new DataColumn() {Caption = "Rep Name",ColumnName = "RepMaster_name"},
                new DataColumn() {Caption = "Kp Status",ColumnName = "Skh_status_of_so_kp"},
                new DataColumn() {Caption = "Division",ColumnName = "Skh_division_id"},
                new DataColumn() {Caption = "LOG",ColumnName = "Skh_log"}
            });

            Source.ForEach(delegate(SOKPHeaderBL Item) {
                DataRow _Element = dt.NewRow();
                _Element["Skh_so_kp_number"] = Item.Skh_so_kp_number;
                _Element["Skh_so_kp_date"] = Item.Skh_so_kp_date;
                _Element["Skh_invoice_number"] = Item.Skh_invoice_number;
                _Element["Skh_invoice_date"] = Item.Skh_invoice_date;
                _Element["Skh_status_of_invoice"] = Hardcoded.GetInvoiceStatus(Item.Skh_status_of_invoice);
                _Element["Skh_rep_id"] = Item.Skh_rep_id;
                _Element["RepMaster_name"] = Helper.CastToString(Item.RepMaster.name);
                _Element["Skh_status_of_so_kp"] = Hardcoded.GetKpStatus(Item.Skh_status_of_so_kp);
                _Element["Skh_division_id"] = Helper.CastToString(Item.Skh_division_id);
                _Element["Skh_log"] = Helper.CastToString(Item.Skh_log);

                dt.Rows.Add(_Element);
            });

            return dt;
        }

        private void Pagination(Boolean onloading = false)
        {
            if (_TotalPage == 0)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
                return;
            }

            if (_TotalPage == _CurrentPage)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
                if (_CurrentPage > 1)
                {
                    btnPrev.Enabled = true;
                }

                return;
            }

            if (onloading)
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = false;

                return;
            }

            if (_CurrentPage < 2)
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
            }
            else
            {
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }

            return;
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvResult.Rows)
            {
                /// check if colum is not checked
                if (Convert.ToBoolean(row.Cells[1].Value) == false)
                {
                    continue;
                }

                string mKpNumber = Helper.CastToString(row.Cells[0].Value);

                /// to process the invoice, use variable mNoInvoice instead. mInvoiceNumber only for checking
                string mInvoiceNumber = Helper.CastToString(row.Cells[3].Value); 

                string mKpStatus = Helper.CastToString(row.Cells[11].Value);
                string mDivisionID = Helper.CastToString(row.Cells[20].Value);

                string mInterfaceToGL = "N";
                string mInvoiceType = "";
                string mLineType = "";
                string mNoInvoice = "";
                DateTime mInvoiceDate = DateTime.Now;
                string mEntity = "";
                string mDiv = "";
                string mBranch = "";
                string mCust = "";
                double mInvAMT = 0;

                /// check invoice number
                if (mInvoiceNumber != string.Empty)
                {
                    Alert.PushAlert(mInvoiceNumber + " is already processed!", clsAlert.Type.Error);
                    continue;
                }

                /// check Kp Status
                if (mKpStatus != "Release")
                {
                    Alert.PushAlert("Invalid KP Status! KP Status: " + mKpStatus, clsAlert.Type.Error);
                    continue;
                }

                TaxReminder();
                if(IsProcessable1)
                {
                    bool Info = InvoiceHeaderAccessor.CreateNewInvoice(
                        mDivisionID,
                        mKpNumber,
                        dtInvoiceDate.Value,
                        clsLogin.USERID
                    );

                    if(!Info)
                    {
                        Alert.PushAlert(InvoiceHeaderAccessor.Reason, clsAlert.Type.Error);
                        continue;
                    }

                    DataTable dataTable = InvoiceHeaderAccessor.CheckInvoiceInterfacing(mKpNumber);
                    if(dataTable.Rows.Count > 0)
                    {
                        DataRow nRow = dataTable.Rows[0];
                        mInterfaceToGL = Helper.CastToString(nRow["sit_interface_to_gl"]);
                        mInvoiceType = Helper.CastToString(nRow["sit_invoice_type"]);
                        mLineType = Helper.CastToString(nRow["sit_line_type"]);
                        mNoInvoice = Helper.CastToString(nRow["sih_so_invoice_number"]);
                        mInvoiceDate = (DateTime)Helper.CastToDatetime(nRow["sih_so_invoice_date"]);
                        mEntity = Helper.CastToString(nRow["sih_entity_id"]);
                        mDiv = Helper.CastToString(nRow["sih_division_id"]);
                        mBranch = Helper.CastToString(nRow["sih_branch_id"]);
                        mCust = Helper.CastToString(nRow["sih_customer_id"]);
                        mInvAMT = Convert.ToDouble(nRow["sih_total_inv_amount"]);
                    }

                    if(mInterfaceToGL == "Y" && mLineType == "D")
                    {
                        DataTableCollection result = InvoiceHeaderAccessor.CheckARBalance(mNoInvoice, mInvoiceType);
                        string ARStatus = (string)result[0].Rows[0].ItemArray.ElementAt(0);
                        string COANumber = (string)result[0].Rows[0].ItemArray.ElementAt(1);

                        if(ARStatus == "U")
                        {
                            Alert.PushAlert($"Invoice number : {mNoInvoice} unbalance!", clsAlert.Type.Warning);
                            continue;
                        }

                        if(ARStatus == "NF")
                        {
                            Alert.PushAlert($"Invalid COA Number {COANumber} In Invoice Type", clsAlert.Type.Warning);
                            continue;
                        }

                        if(ARStatus == "COST")
                        {
                            Alert.PushAlert($"Invoice number : {mNoInvoice} COST unbalance!", clsAlert.Type.Warning);
                            continue;
                        }
                    }

                    try
                    {
                        InvoiceHeaderAccessor.ProcessARInterface(mNoInvoice, mKpNumber, clsLogin.USERID, mInvoiceDate, mEntity, mBranch, mDiv, mCust, mInvAMT);

                        Alert.PushAlert("Invoice Created!", clsAlert.Type.Success);
                    }
                    catch (Exception Err)
                    {
                        Alert.PushAlert(Err.Message, clsAlert.Type.Error);
                        Console.WriteLine(Err.StackTrace);
                    }
                }
                else
                {
                    Alert.PushAlert($"KP Number : {mKpNumber} is not processable", clsAlert.Type.Error);
                    continue;
                }
            }
        }

        private void DrawComboboxFilter()
        {
            cmbFilterStatusKP.DataSource = Hardcoded.GetListKpStatus();
            cmbFilterStatusKP.ValueMember = "ValueMember";
            cmbFilterStatusKP.DisplayMember = "DisplayMember";

            cmbFilterStatusInvoice.DataSource = Hardcoded.GetListInvoiceStatus();
            cmbFilterStatusInvoice.ValueMember = "ValueMember";
            cmbFilterStatusInvoice.DisplayMember = "DisplayMember";
            
            cmbFilterStatusVerification.DataSource = Hardcoded.GetListVerificationStatus();
            cmbFilterStatusVerification.ValueMember = "ValueMember";
            cmbFilterStatusVerification.DisplayMember = "DisplayMember";
            
            cmbFilterStatusDelivery.DataSource = Hardcoded.GetListDeliveryStatus();
            cmbFilterStatusDelivery.ValueMember = "ValueMember";
            cmbFilterStatusDelivery.DisplayMember = "DisplayMember";
            
            cmbFilterStatusDP.DataSource = Hardcoded.GetListDPStatus();
            cmbFilterStatusDP.ValueMember = "ValueMember";
            cmbFilterStatusDP.DisplayMember = "DisplayMember";
            
            cmbFilterStatusCOD.DataSource = Hardcoded.GetListCODStatus();
            cmbFilterStatusCOD.ValueMember = "ValueMember";
            cmbFilterStatusCOD.DisplayMember = "DisplayMember";
        }

        private void TaxReminder()
        {
            DataTable dt = Accessor.TaxReminder("NOPJK");
            if(dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    var gst_start_number = Helper.CastToInt(row["gst_start_number"]);
                    var gst_end_number = Helper.CastToInt(row["gst_end_number"]);
                    var last_number = Helper.CastToInt(row["last_number"]);

                    if(last_number >= gst_end_number)
                    {
                        Alert.PushAlert("Proses Invoice Lock !,Tax Number not Available", clsAlert.Type.Error);
                        IsProcessable1 = false;

                        return;
                    }

                    if(last_number - gst_start_number >= ((gst_end_number - gst_start_number) - (10 / 100 * (gst_end_number - gst_start_number))))
                    {
                        IsProcessable1 = true;
                    }
                    else
                    {
                        IsProcessable1 = true;
                    }
                }
            }

            dt = Accessor.TaxReminder("PJK");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var gst_start_number = Helper.CastToInt(row["gst_start_number"]);
                    var gst_end_number = Helper.CastToInt(row["gst_end_number"]);
                    var last_number = Helper.CastToInt(row["last_number"]);

                    if (last_number >= gst_end_number)
                    {
                        Alert.PushAlert("Proses Invoice Lock !,Tax Number not Available", clsAlert.Type.Error);
                        IsProcessable2 = false;

                        return;
                    }

                    if (last_number - gst_start_number >= ((gst_end_number - gst_start_number) - (10 / 100 * (gst_end_number - gst_start_number))))
                    {
                        IsProcessable2 = true;
                    }
                    else
                    {
                        IsProcessable2 = true;
                    }
                }
            }
        }
    }
}
