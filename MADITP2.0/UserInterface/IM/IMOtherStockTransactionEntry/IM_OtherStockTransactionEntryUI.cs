using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.ApplicationLogic.IM;
using MADITP2._0.businessLogic.GS;
using MADITP2._0.BusinessLogic.GS;
using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.IM.IMOtherStockTransactionEntry
{
    public partial class IM_OtherStockTransactionEntryUI : Form
    {
        private static IMOtherStockTransactionEntryBL Model;
        private static IMOtherStockTransactionEntryAL AppLogic;
        private static clsAlert Alert;
        private static clsGlobal Helper;
        private static clsEventButton ClsEventButton;
        private static string FormActiveName;
        private static int CurrentPage, Offset, FetchLimit, TotalPage;
        private static readonly string CurrentUserID = clsLogin.USERID;
        private static List<IMTransactionTypeBL> ListTxnType;
        private static List<IMMasterWarehouseBL> ListWarehouse;
        private static GSSequenceNumberEditorAL AppLogicSequence;

        public IM_OtherStockTransactionEntryUI()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(IM_OtherStockTransactionEntryUI_KeyDown);
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                Model = new IMOtherStockTransactionEntryBL();
                Helper = new clsGlobal();
                AppLogic = new IMOtherStockTransactionEntryAL(Helper);
                ClsEventButton = new clsEventButton();
                AppLogicSequence = new GSSequenceNumberEditorAL(Helper);
            }
        }

        #region Method Non Event
        private void InitializeObject(IMOtherStockTransactionEntryBL Model)
        {
            ClearDataBinding();
            bindingObjOtherStock.DataSource = Model;
            MappingDataBinding();
        }

        private void ClearDataBinding()
        {
            cboNewWarehouseID.DataBindings.Clear();
            cboNewTxnType.DataBindings.Clear();
            txtBoxReference.DataBindings.Clear();
            txtBoxNewMemo.DataBindings.Clear();
            dtpNewTxnDate.DataBindings.Clear();
        }

        private void MappingDataBinding()
        {
            cboNewWarehouseID.DataBindings.Add("SelectedValue", bindingObjOtherStock, "warehouse_id", true, DataSourceUpdateMode.OnPropertyChanged);
            cboNewTxnType.DataBindings.Add("SelectedValue", bindingObjOtherStock, "txn_type_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxReference.DataBindings.Add("Text", bindingObjOtherStock, "reference", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxNewMemo.DataBindings.Add("Text", bindingObjOtherStock, "memo", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpNewTxnDate.DataBindings.Add("Value", bindingObjOtherStock, "txn_date", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void InitializeGrid(IMOtherStockTransactionEntryBL Model)
        {
            try
            {
                var data = AppLogic.GetAllPaging(Model, Offset);
                if (data.Count > 0)
                {
                    dataGridOtherStock.AutoGenerateColumns = false;
                    dataGridOtherStock.DataSource = data;

                    //Paging Initialize
                    int DataCount = AppLogic.GetAllCount(Model);
                    TotalPage = (int)Math.Ceiling((Double)DataCount / FetchLimit);
                    if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfo.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfo.Text = "Pages : - "; }
                    lblRows.Text = "Records : " + dataGridOtherStock.Rows.Count.ToString() + " Rows";
                    PaginationRules();
                }
                else
                {
                    dataGridOtherStock.DataSource = null;
                    Alert.PushAlert("Data not found", clsAlert.Type.Info);
                }
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

        private void PaginationRules()
        {
            if (TotalPage == 0)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
            }
            else if (TotalPage == CurrentPage)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
                if (CurrentPage > 1)
                {
                    btnPrev.Enabled = true;
                }
            }
            else if (CurrentPage < 2)
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
            }
            else
            {
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        private void ResetPaginationRules()
        {
            CurrentPage = 1;
            Offset = 0;
            FetchLimit = (int)EnumFetchData.DefaultLimit;
            TotalPage = 0;
        }

        private bool CheckSequence()
        {
            var DataHeader = (IMOtherStockTransactionEntryBL)bindingObjOtherStock.DataSource;
            var DataSequence = new GSSequenceNumberEditorBL();

            bool IsSequenceValid = true;
            string MessageValidation = string.Empty;
            if (DataHeader != null)
            {
                if (!string.IsNullOrEmpty(DataHeader.warehouse_id) && !string.IsNullOrEmpty(DataHeader.txn_type_id))
                {
                    var SequenceCode = $"IM{Helper.CastToString(DataHeader.warehouse_id).Trim()}{DataHeader.txn_type_id.Trim()}";
                    DataSequence = AppLogicSequence.GetByID(SequenceCode);

                    if (DataSequence == null)
                    {
                        IsSequenceValid = false;
                        MessageValidation = $"Cannot find data sequence, please contact administrator";
                    }
                    else if (DataSequence.last_number + 1 >= DataSequence.maximum)
                    {
                        IsSequenceValid = false;
                        MessageValidation = $"Sequence for exceeds limit, please contact administrator";
                    }

                    if (!IsSequenceValid)
                    {
                        Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
                        cboNewWarehouseID.SelectedValue = string.Empty;
                        cboNewTxnType.SelectedValue = string.Empty;
                    }
                }
            }
            return IsSequenceValid;
        }

        private void FormMode(clsEventButton.EnumAction ActionType)
        {
            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    Helper.SetActive(navView);
                    Model = new IMOtherStockTransactionEntryBL();
                    ResetPaginationRules();
                    GetDataComboBoxWarehouse();
                    GetDataComboBoxGroup();
                    GetDataComboBoxTxnType();
                    panelView.Show();
                    dataGridOtherStock.DataSource = null;
                    break;
                case clsEventButton.EnumAction.NEW:
                    FormActiveName = clsEventButton.EnumAction.NEW.ToString();
                    Helper.SetActive(navNew);
                    ResetFormNew();
                    panelView.Hide();
                    break;
            }
        }

        private void ResetFormNew()
        {
            Model = new IMOtherStockTransactionEntryBL()
            {
                txn_type_id = string.Empty,
                warehouse_id = string.Empty,
                txn_date = DateTime.Now.ToString()
            };
            GetDataTxnTypeByUserID();
            GetDataWarehouse();
            GetDataComboBoxTxnType();
            txtBoxNewMemo.Enabled = true;
            txtBoxReference.Enabled = true;
            cboNewWarehouseID.Enabled = true;
            cboNewTxnType.Enabled = true;
            btnLineEntry.Enabled = true;
            InitializeObject(Model);
        }

        private void GetDataComboBoxWarehouse()
        {
            var IsUserWh = AppLogic.IsUserWarehouse(CurrentUserID);
            var DataWarehouse = AppLogic.GetComboboxWarehouse(IsUserWh ? string.Empty : CurrentUserID);

            bindingObjSearchWarehouse.DataSource = new List<ComboBoxViewModel>(DataWarehouse);
            bindingObjNewWarehouse.DataSource = new List<ComboBoxViewModel>(DataWarehouse);

            cboSearchWarehouseID.DataSource = bindingObjSearchWarehouse.DataSource;
            cboSearchWarehouseID.DisplayMember = "DisplayMember";
            cboSearchWarehouseID.ValueMember = "ValueMember";

            cboNewWarehouseID.DataSource = bindingObjNewWarehouse.DataSource;
            cboNewWarehouseID.DisplayMember = "DisplayMember";
            cboNewWarehouseID.ValueMember = "ValueMember";
        }

        private void GetDataComboBoxTxnType()
        {
            var DataTxnType = AppLogic.GetComboboxTxnType(
                FormActiveName == clsEventButton.EnumAction.VIEW.ToString() ?
                string.Empty : CurrentUserID);

            bindingObjSearchTxnType.DataSource = new List<ComboBoxViewModel>(DataTxnType);
            bindingObjNewTxnType.DataSource = new List<ComboBoxViewModel>(DataTxnType);

            cboSearchTxnType.DataSource = bindingObjSearchTxnType.DataSource;
            cboSearchTxnType.DisplayMember = "DisplayMember";
            cboSearchTxnType.ValueMember = "ValueMember";

            cboNewTxnType.DataSource = bindingObjNewTxnType.DataSource;
            cboNewTxnType.DisplayMember = "DisplayMember";
            cboNewTxnType.ValueMember = "ValueMember";
        }

        private void GetDataTxnTypeByUserID()
        {
            ListTxnType = AppLogic.GetTxnTypeByUserID(CurrentUserID);
        }

        private void GetDataWarehouse()
        {
            ListWarehouse = AppLogic.GetDataWarehouse();
        }

        private void GetDataComboBoxGroup()
        {
            cboSearchGroup.DataSource = AppLogic.GetComboboxGroup();
            cboSearchGroup.DisplayMember = "DisplayMember";
            cboSearchGroup.ValueMember = "ValueMember";
        }

        private void GetDataComboBoxSubGroup(string GroupID)
        {
            cboSearchSubGroup.DataSource = AppLogic.GetComboboxSubGroup(GroupID);
            cboSearchSubGroup.DisplayMember = "DisplayMember";
            cboSearchSubGroup.ValueMember = "ValueMember";
        }

        private bool FormValidation(IMOtherStockTransactionEntryBL Model)
        {
            bool IsValid = true;
            string MessageValidation = "";

            if (string.IsNullOrEmpty(Model.warehouse_id))
            {
                IsValid = false;
                MessageValidation = "Warehouse ID is required!";
            }
            else if (string.IsNullOrEmpty(Model.txn_type_id))
            {
                IsValid = false;
                MessageValidation = "Txn Type is required!";
            }
            else if (string.IsNullOrEmpty(Model.reference))
            {
                IsValid = false;
                MessageValidation = "Reference is required!";
            }
            else if (string.IsNullOrEmpty(Model.txn_date))
            {
                IsValid = false;
                MessageValidation = "Txn Date is required!";
            }
            else if (string.IsNullOrEmpty(Model.memo))
            {
                IsValid = false;
                MessageValidation = "Memo is required!";
            }

            if (!IsValid)
            {
                Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
            }

            return IsValid;
        }

        private bool GridValidation(List<IMOtherStockTransactionEntryBL> ListData)
        {
            bool IsValid = true;
            string MessageValidation = "";
            foreach (var item in ListData)
            {
                if (string.IsNullOrEmpty(item.product_id))
                {
                    IsValid = false;
                    MessageValidation = "Product ID is required!";
                    break;
                }
                else if (string.IsNullOrEmpty(item.product_description))
                {
                    IsValid = false;
                    MessageValidation = "Product Description is required!";
                    break;
                }
                else if (string.IsNullOrEmpty(item.qty))
                {
                    IsValid = false;
                    MessageValidation = "Quantity is required!";
                    break;
                }
            }

            if (!IsValid)
            {
                Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
            }

            return IsValid;
        }

        private void GetFiscalIM(string EntityID)
        {
            GSFiscalCalendarAL AppLogicFiscal = new GSFiscalCalendarAL(Helper);
            GSFiscalCalendarBL ModelFiscal = new GSFiscalCalendarBL()
            {
                group_id = $"IM",
                entity_id = EntityID
            };

            var DataFiscal = AppLogicFiscal.GetAll(ModelFiscal).Where(x => x.period_status.Trim() == "O").FirstOrDefault();
            var Today = DateTime.Now;

            if (DataFiscal != null)
            {
                var BeginingDate = (DateTime)DataFiscal.begining_date;
                var EndingDate = (DateTime)DataFiscal.ending_date;

                dtpNewTxnDate.MaxDate = EndingDate;
                dtpNewTxnDate.MinDate = BeginingDate;

                if (Today < EndingDate && Today > BeginingDate)
                {
                    dtpNewTxnDate.Value = Today;
                }
                else
                {
                    dtpNewTxnDate.Value = EndingDate;
                }
            }
        }

        private void ResetGrid()
        {
            dataGridNewOtherStock.DataSource = null;
            dataGridNewOtherStock.Refresh();
        }

        private void ClearGrid(int RowIndex)
        {
            for (int i = 1; i < dataGridNewOtherStock.Rows[RowIndex].Cells.Count; i++)
            {
                dataGridNewOtherStock.Rows[RowIndex].Cells[i].Value = null;
            }
        }

        #endregion

        private void IM_OtherStockTransactionEntryUI_Load(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void IM_OtherStockTransactionEntryUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Tab)
            {
                clsEventButton.EnumAction _ActionType = ClsEventButton.getEventType(e.KeyCode.ToString());

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
                            //navEdit_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.DELETE:
                        {
                            //navDelete_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.PRINT:
                        {
                            //navPrint_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.EXPORT:
                        {
                            //navExport_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.SEARCH:
                        {
                            btnSearch_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.SAVE:
                        {
                            //btnSave_Click(null, null);
                            break;
                        }
                    case clsEventButton.EnumAction.CANCEL:
                        {
                            //btnCancel_Click(null, null);
                            break;
                        }
                }
            }
            else
            {
                this.ProcessTabKey(true);
            }
        }

        private void cbSearchRangeDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSearchRangeDate.Checked)
            {
                dtpSearchFrom.Enabled = true;
                dtpSearchTo.Enabled = true;
            }
            else
            {
                dtpSearchFrom.Enabled = false;
                dtpSearchTo.Enabled = false;
            }
        }

        private void navView_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.NEW);
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboSearchGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataComboBoxSubGroup($"{cboSearchGroup.SelectedValue}");
        }

        private void btnSearchLookUpProduct_Click(object sender, EventArgs e)
        {
            clsPopUpProduct LookUpProduct = new clsPopUpProduct(Helper, Alert);
            if (LookUpProduct.ShowDialog() == DialogResult.OK)
            {
                txtBoxSearchProductID.Text = LookUpProduct._ProductID;
                txtBoxSearchProductName.Text = LookUpProduct._ProductDescription;
            }
        }

        private void btnLineEntry_Click(object sender, EventArgs e)
        {
            var Model = (IMOtherStockTransactionEntryBL)bindingObjOtherStock.DataSource;
            var IsValid = FormValidation(Model);

            if (IsValid)
            {
                dataGridNewOtherStock.Enabled = true;
                dataGridNewOtherStock.AutoGenerateColumns = false;
                dataGridNewOtherStock.DataSource = new List<IMOtherStockTransactionEntryBL>()
                {
                    new IMOtherStockTransactionEntryBL(){ product_id = string.Empty }
                };
                dataGridNewOtherStock.Focus();
                dataGridNewOtherStock.CurrentCell = dataGridNewOtherStock.Rows[0].Cells[0];
                btnLineEntry.Enabled = false;
                cboNewWarehouseID.Enabled = false;
                cboNewTxnType.Enabled = false;
                txtBoxNewMemo.Enabled = false;
                txtBoxReference.Enabled = false;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var DataHeader = (IMOtherStockTransactionEntryBL)bindingObjOtherStock.DataSource;
            var DataGrid = (List<IMOtherStockTransactionEntryBL>)dataGridNewOtherStock.DataSource;

            if (DataGrid == null)
            {
                Alert.PushAlert("Please Click The LineEntry First", clsAlert.Type.Error);
            }
            else
            {
                bool IsGridValid = GridValidation(DataGrid.Where(x => !string.IsNullOrEmpty(x.product_id)).ToList());

                if (IsGridValid)
                {
                    var SequenceCode = $"IM{Helper.CastToString(cboNewWarehouseID.SelectedValue).Trim()}{Helper.CastToString(cboNewTxnType.SelectedValue).Trim()}";
                    var DataSequence = AppLogicSequence.GetByID(SequenceCode);
                    var DataTxn = ListTxnType.Where(x => x.Txn_type_code.Trim() == Helper.CastToString(cboNewTxnType.SelectedValue).Trim()).FirstOrDefault();
                    var DataWarehouse = ListWarehouse.Where(x => x.warehouse_id.Trim() == Helper.CastToString(cboNewWarehouseID.SelectedValue).Trim()).FirstOrDefault();

                    bool IsSequenceValid = CheckSequence();

                    if (IsSequenceValid)
                    {
                        try
                        {
                            var Insert = AppLogic.Insert(DataHeader, DataGrid, DataWarehouse, DataTxn, SequenceCode);
                            Alert.PushAlert($"{Insert}", clsAlert.Type.Success);
                            FormMode(clsEventButton.EnumAction.VIEW);
                            ResetGrid();
                        }
                        catch (Exception ex)
                        {
                            Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void dataGridNewOtherStock_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridNewOtherStock.Refresh();
        }

        private void cboNewWarehouseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var SelectedWarehouseID = $"{cboNewWarehouseID.SelectedValue}";
            if (FormActiveName == clsEventButton.EnumAction.NEW.ToString() && !string.IsNullOrEmpty(SelectedWarehouseID))
            {
                var EntityID = ListWarehouse.Where(x => x.warehouse_id == SelectedWarehouseID).FirstOrDefault();
                GetFiscalIM(EntityID.gl_entity);
            }
            CheckSequence();
        }

        private void dataGridNewOtherStock_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (btnLineEntry.Enabled == false && dataGridNewOtherStock.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                var DataHeader = (IMOtherStockTransactionEntryBL)bindingObjOtherStock.DataSource;
                var DataGrid = (List<IMOtherStockTransactionEntryBL>)dataGridNewOtherStock.DataSource;
                var ProductID = $"{dataGridNewOtherStock.Rows[e.RowIndex].Cells[0].Value}";
                var Quantity = dataGridNewOtherStock.Rows[e.RowIndex].Cells[2].Value;
                var UnitCost = dataGridNewOtherStock.Rows[e.RowIndex].Cells[3].Value;
                var TotalCost = dataGridNewOtherStock.Rows[e.RowIndex].Cells[4].Value;
                var QuantityAvailable = dataGridNewOtherStock.Rows[e.RowIndex].Cells[7].Value;
                var SelectedTxnType = $"{cboNewTxnType.SelectedValue}";
                var SelectedWarehouse = $"{cboNewWarehouseID.SelectedValue}";
                var DataDetailSelectedWarehouse = ListWarehouse.Where(x => x.warehouse_id.Trim() == SelectedWarehouse.Trim()).FirstOrDefault();

                bool IsValid = true;
                string MessageValidation = string.Empty;

                if (string.IsNullOrEmpty(ProductID) && e.ColumnIndex == 2)
                {
                    IsValid = false;
                    MessageValidation = "Please fill in the product id first";
                }

                if (!IsValid)
                {
                    Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
                }
                else
                {
                    if (e.ColumnIndex == 0) //Column Product id
                    {
                        //ClearGrid(e.RowIndex);
                        bool IsDuplicateProduct = false;

                        for (int i = 0; i < dataGridNewOtherStock.Rows.Count; i++)
                        {
                            if (e.RowIndex != i && $"{dataGridNewOtherStock.Rows[i].Cells[0].Value}" == ProductID)
                            {
                                IsDuplicateProduct = true;
                                Alert.PushAlert("Duplicate Product", clsAlert.Type.Error);
                                break;
                            }
                        }

                        if (!IsDuplicateProduct)
                        {
                            string Digital = (SelectedTxnType == "POR" || SelectedTxnType == "ROP") && DataDetailSelectedWarehouse.digital == "Y"
                                ? "Y" : "N";
                            var DataProduct = AppLogic.GetProductByID(Digital, ProductID);
                            var DataUnitCost = AppLogic.GetUnitCostByProductID(ProductID);
                            var DataStockBalance = AppLogic.GetStockBalanceByProductIDAndWarehouseID(ProductID, DataHeader.warehouse_id);

                            bool IsDataFromDbValid = true;

                            if (DataProduct == null)
                            {
                                MessageValidation = "Product not found";
                                IsDataFromDbValid = false;
                            }
                            else if (DataUnitCost == null)
                            {
                                MessageValidation = "Unit cost not found";
                                IsDataFromDbValid = false;
                            }
                            else if (DataUnitCost.unit_cost == "0")
                            {
                                MessageValidation = "Product cost still zero";
                                IsDataFromDbValid = false;
                            }
                            else if (DataStockBalance == null)
                            {
                                MessageValidation = "Stock balance not found";
                                IsDataFromDbValid = false;
                            }

                            if (!IsDataFromDbValid)
                            {
                                Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
                                ClearGrid(e.RowIndex);
                            }
                            else
                            {
                                try
                                {
                                    foreach (var item in DataGrid)
                                    {
                                        if (item.product_id == ProductID)
                                        {
                                            item.product_description = DataProduct.product_description;
                                            item.product_type = DataProduct.product_type == "M" ? "Multiline"
                                                : DataProduct.product_type == "S" ? "Single"
                                                : DataProduct.product_type == "P" ? "Package" : string.Empty;
                                            item.unit_cost = DataUnitCost.unit_cost;
                                            item.qty_on_hand = DataStockBalance == null ? "0" : DataStockBalance.qty_on_hand;
                                            item.qty_available = DataStockBalance == null ? "0" : DataStockBalance.qty_available;

                                        }
                                    }
                                    dataGridNewOtherStock.DataSource = null;
                                    dataGridNewOtherStock.DataSource = DataGrid;
                                }
                                catch (Exception ex)
                                {
                                    Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
                                }
                            }
                        }
                    }
                    else if (e.ColumnIndex == 2) //Column Qty
                    {
                        int QtyInteger;
                        if (!int.TryParse(Convert.ToString(Quantity), out QtyInteger))
                        {
                            foreach (var item in DataGrid)
                            {
                                if (item.product_id == ProductID)
                                {
                                    item.qty = string.Empty;
                                }
                            }
                            Alert.PushAlert("Must be numeric", clsAlert.Type.Warning);
                        }
                        else
                        {
                            IMTransactionTypeBL DetailSelectedTxnType = ListTxnType.Where(x => x.Txn_type_code.Trim() == SelectedTxnType).FirstOrDefault();
                            if (DetailSelectedTxnType.Negate_qty_entered == "Y" && Helper.CastToInt(Quantity) > 0)
                            {
                                Quantity = Helper.CastToInt(Quantity) * -1;
                            }

                            if (Helper.CastToInt(Quantity) * -1 > Helper.CastToInt(QuantityAvailable))
                            {
                                Alert.PushAlert($"Product Stock Not Enought, Available Stock : {QuantityAvailable}", clsAlert.Type.Error);
                            }

                            TotalCost = Convert.ToDecimal(UnitCost) * Helper.CastToInt(Quantity);

                            foreach (var item in DataGrid)
                            {
                                if (item.product_id == ProductID)
                                {
                                    item.qty = $"{Quantity}";
                                    item.total_cost = $"{TotalCost}";
                                }
                            }

                            if (DataGrid.Where(x => x.product_id == "").Count() == 0)
                            {
                                DataGrid.Add(new IMOtherStockTransactionEntryBL() { product_id = string.Empty });
                                dataGridNewOtherStock.DataSource = null;
                                dataGridNewOtherStock.DataSource = DataGrid;
                                dataGridNewOtherStock.Refresh();
                            }
                        }
                    }
                }
            }

        }

        private void btnCancelLineEntry_Click(object sender, EventArgs e)
        {
            btnLineEntry.Enabled = true;
            cboNewWarehouseID.Enabled = true;
            cboNewTxnType.Enabled = true;
            txtBoxNewMemo.Enabled = true;
            txtBoxReference.Enabled = true;
            ResetGrid();
        }

        private void cboNewTxnType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckSequence();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var RangeDateFrom = dtpSearchFrom.Value.ToString();
            var RangeDateTo = dtpSearchTo.Value.ToString();

            if (!cbSearchRangeDate.Checked)
            {
                RangeDateFrom = string.Empty;
                RangeDateTo = string.Empty;
            }

            Model = new IMOtherStockTransactionEntryBL()
            {
                warehouse_id = $"{cboSearchWarehouseID.SelectedValue}",
                print_date = $"{dtpSearchPrintDate.Value}",
                txn_type_id = $"{cboSearchTxnType.SelectedValue}",
                product_id = $"{txtBoxSearchProductID.Text}",
                group_id = $"{cboSearchGroup.SelectedValue}",
                sub_group_id = $"{cboSearchSubGroup.SelectedValue}",
                range_date_from = $"{RangeDateFrom}",
                range_date_to = $"{RangeDateTo}"
            };

            InitializeGrid(Model);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            Offset += FetchLimit;
            InitializeGrid(Model);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            Offset -= FetchLimit;
            InitializeGrid(Model);
        }
    }
}