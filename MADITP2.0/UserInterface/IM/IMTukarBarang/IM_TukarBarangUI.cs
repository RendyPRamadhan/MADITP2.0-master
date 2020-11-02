using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.ApplicationLogic.IM;
using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.IM.IMTukarBarang
{
    public partial class IM_TukarBarangUI : Form
    {
        private static IMTukarBarangBL Model;
        private static IMTukarBarangAL AppLogic;
        private static clsAlert Alert;
        private static clsGlobal Helper;
        private static clsEventButton ClsEventButton;
        private static string FormActiveName;
        private static int CurrentPage, Offset, FetchLimit, TotalPage;
        private static readonly string CurrentUserID = clsLogin.USERID;
        private static List<IMTransactionTypeBL> ListTxnType;
        private static List<IMMasterWarehouseBL> ListWarehouse;
        private static readonly string TxnTypeIn = "RBT", TxnTypeOut = "TBR";
        private static bool IsUiReady = false;
        private static GSSequenceNumberEditorAL AppLogicSequence;

        public IM_TukarBarangUI()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(IM_TukarBarangUI_KeyDown);
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                Model = new IMTukarBarangBL();
                Helper = new clsGlobal();
                AppLogic = new IMTukarBarangAL(Helper);
                ClsEventButton = new clsEventButton();
                AppLogicSequence = new GSSequenceNumberEditorAL(Helper);
            }
        }

        #region Method Non Event
        private void InitializeObject(IMTukarBarangBL Model)
        {
            ClearDataBinding();
            bindingObjTukarBarang.DataSource = Model;
            MappingDataBinding();
        }

        private void ClearDataBinding()
        {
            cboNewInWarehouseID.DataBindings.Clear();
            cboNewOutWarehouseID.DataBindings.Clear();
            txtBoxReference.DataBindings.Clear();
            txtBoxNewMemo.DataBindings.Clear();
            dtpNewTxnDate.DataBindings.Clear();
        }

        private void MappingDataBinding()
        {
            cboNewInWarehouseID.DataBindings.Add("SelectedValue", bindingObjTukarBarang, "warehouse_id_in", true, DataSourceUpdateMode.OnPropertyChanged);
            cboNewOutWarehouseID.DataBindings.Add("SelectedValue", bindingObjTukarBarang, "warehouse_id_out", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxReference.DataBindings.Add("Text", bindingObjTukarBarang, "txn_reference", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxNewMemo.DataBindings.Add("Text", bindingObjTukarBarang, "memo", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpNewTxnDate.DataBindings.Add("Value", bindingObjTukarBarang, "txn_date", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void GetDataComboBoxWarehouse()
        {
            IMOtherStockTransactionEntryAL AppLogicOtherStock = new IMOtherStockTransactionEntryAL(Helper);
            var IsUserWh = AppLogicOtherStock.IsUserWarehouse(CurrentUserID);
            var DataWarehouse = AppLogicOtherStock.GetComboboxWarehouse(IsUserWh ? string.Empty : CurrentUserID);

            bindingObjSearchWarehouseID.DataSource = new List<ComboBoxViewModel>(DataWarehouse);
            bindingObjNewOutWarehouseID.DataSource = new List<ComboBoxViewModel>(DataWarehouse);
            bindingObjNewInWarehouseID.DataSource = new List<ComboBoxViewModel>(DataWarehouse);

            cboSearchWarehouseID.DataSource = bindingObjSearchWarehouseID.DataSource;
            cboSearchWarehouseID.DisplayMember = "DisplayMember";
            cboSearchWarehouseID.ValueMember = "ValueMember";

            cboNewOutWarehouseID.DataSource = bindingObjNewOutWarehouseID.DataSource;
            cboNewOutWarehouseID.DisplayMember = "DisplayMember";
            cboNewOutWarehouseID.ValueMember = "ValueMember";

            cboNewInWarehouseID.DataSource = bindingObjNewInWarehouseID.DataSource;
            cboNewInWarehouseID.DisplayMember = "DisplayMember";
            cboNewInWarehouseID.ValueMember = "ValueMember";
        }

        private void InitializeGrid(IMTukarBarangBL Model)
        {
            try
            {
                var data = AppLogic.GetAllPaging(Model, Offset);
                if (data.Count > 0)
                {
                    dataGridTukarBarang.AutoGenerateColumns = false;
                    dataGridTukarBarang.DataSource = data;

                    //Paging Initialize
                    int DataCount = AppLogic.GetAllCount(Model);
                    TotalPage = (int)Math.Ceiling((Double)DataCount / FetchLimit);
                    if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfo.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfo.Text = "Pages : - "; }
                    lblRows.Text = "Records : " + dataGridTukarBarang.Rows.Count.ToString() + " Rows";
                    PaginationRules();
                }
                else
                {
                    dataGridTukarBarang.DataSource = null;
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

        private void FormMode(clsEventButton.EnumAction ActionType)
        {
            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    IsUiReady = false;
                    Helper.SetActive(navView);
                    Model = new IMTukarBarangBL();
                    GetDataComboBoxWarehouse();
                    GetDataWarehouse();
                    panelView.Show();
                    IsUiReady = true;
                    break;
                case clsEventButton.EnumAction.NEW:
                    FormActiveName = clsEventButton.EnumAction.NEW.ToString();
                    IsUiReady = false;
                    Helper.SetActive(navNew);
                    panelView.Hide();
                    ResetFormNew();
                    IsUiReady = true;
                    break;
            }
        }

        public bool FormValidation(IMTukarBarangBL Model)
        {
            bool IsValid = true;
            string MessageValidation = string.Empty;

            if (string.IsNullOrEmpty(Model.warehouse_id_in))
            {
                IsValid = false;
                MessageValidation = "Warehouse ID in required!";
            }
            else if (string.IsNullOrEmpty(Model.warehouse_id_out))
            {
                IsValid = false;
                MessageValidation = "Warehouse ID out required!";
            }
            else if (string.IsNullOrEmpty(Model.txn_reference))
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

        public bool GridValidation(List<IMTukarBarangBL> ListData)
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
                else if (string.IsNullOrEmpty(item.txn_quantity))
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

        private void ResetGrid()
        {
            dataGridNewTukarBarang.DataSource = null;
        }

        private void GetTxnType(string TxnType)
        {
            ListTxnType = AppLogic.GetTxnType(TxnType);
        }

        private void GetDataWarehouse()
        {
            IMOtherStockTransactionEntryAL AppLogicOtherStock = new IMOtherStockTransactionEntryAL(Helper);
            ListWarehouse = AppLogicOtherStock.GetDataWarehouse();
        }

        private void ClearGrid(int RowIndex, int StartIndex)
        {
            for (int i = StartIndex; i < dataGridNewTukarBarang.Rows[RowIndex].Cells.Count; i++)
            {
                dataGridNewTukarBarang.Rows[RowIndex].Cells[i].Value = null;
            }
        }

        private void ResetFormNew() 
        {
            var IsUserTbrRbt = AppLogic.IsUserTbrRbt(CurrentUserID);
            if (IsUserTbrRbt)
            {
                groupBoxTotalCostY.Visible = true;
                groupBoxTotalCostN.Visible = false;
            }
            else
            {
                groupBoxTotalCostY.Visible = false;
                groupBoxTotalCostN.Visible = true;
            }

            Model = new IMTukarBarangBL()
            {
                txn_date = DateTime.Now.ToString(),
                warehouse_id_in = string.Empty,
                warehouse_id_out = string.Empty
            };
            InitializeObject(Model);
            dataGridNewTukarBarang.DataSource = null;
            btnProcess.Enabled = true;
            btnCancelProcess.Enabled = false;
            btnBack.Enabled = false;
            cboNewInWarehouseID.Enabled = true;
            cboNewOutWarehouseID.Enabled = true;
            txtBoxNewMemo.Enabled = true;
            txtBoxReference.Enabled = true;
            txtBoxNewTotalCostOutN.BackColor = Color.White;
            txtBoxNewTotalCostInN.BackColor = Color.White;
        }

        #endregion
        private void IM_TukarBarangUI_Load(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void IM_TukarBarangUI_KeyDown(object sender, KeyEventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Model = new IMTukarBarangBL()
            {
                warehouse_id = $"{cboSearchWarehouseID.SelectedValue}",
                product_id = $"{txtBoxSearchProductID.Text}",
                txn_date_from = $" ",
                txn_date_to = $" "
            };

            InitializeGrid(Model);
        }

        private void navView_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.NEW);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var DataHeader = (IMTukarBarangBL)bindingObjTukarBarang.DataSource;
            var DataGrid = (List<IMTukarBarangBL>)dataGridNewTukarBarang.DataSource;

            if (DataGrid == null)
            {
                Alert.PushAlert("Please Click Process First", clsAlert.Type.Error);
            }
            else
            {
                bool IsCostValid = true;
                string MessageValidation = string.Empty;

                if (Convert.ToDecimal(txtBoxNewTotalCostOutY.Text) > Convert.ToDecimal(txtBoxNewTotalCostInY.Text))
                {
                    IsCostValid = false;
                    MessageValidation = "Cost barang keluar lebih besar";
                }
                else if (Convert.ToDecimal(txtBoxNewTotalCostOutY.Text) == 0)
                {
                    IsCostValid = false;
                    MessageValidation = "Tidak ada Txn Out";
                }
                else if (Convert.ToDecimal(txtBoxNewTotalCostInY.Text) == 0)
                {
                    IsCostValid = false;
                    MessageValidation = "Tidak ada Txn In";
                }

                if (!IsCostValid)
                {
                    Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
                }
                else
                {
                    bool IsGridValid = GridValidation(DataGrid.Where(x => !string.IsNullOrEmpty(x.product_id)).ToList());

                    if (IsGridValid)
                    {
                        IMOtherStockTransactionEntryAL OtherStockAL = new IMOtherStockTransactionEntryAL(Helper);
                        var SequenceCodeIn = $"IM{Helper.CastToString(DataHeader.warehouse_id_in).Trim()}{TxnTypeIn}";
                        var SequenceCodeOut = $"IM{Helper.CastToString(DataHeader.warehouse_id_out).Trim()}{TxnTypeOut}";
                        var DataSequenceIn = AppLogicSequence.GetByID(SequenceCodeIn);
                        var DataSequenceOut = AppLogicSequence.GetByID(SequenceCodeOut);
                        Int64 SequenceIn = DataSequenceIn.last_number + 1;
                        Int64 SequenceOut = DataSequenceOut.last_number + 1;

                        bool IsSequenceValid = true;

                        if (DataSequenceIn == null)
                        {
                            IsSequenceValid = false;
                            MessageValidation = $"Cannot find data sequence {DataHeader.warehouse_id_in}, please contact administrator";
                        }
                        else if (DataSequenceOut == null)
                        {
                            IsSequenceValid = false;
                            MessageValidation = $"Cannot find data sequence {DataHeader.warehouse_id_out}, please contact administrator";
                        }
                        else if (SequenceIn >= DataSequenceIn.maximum)
                        {
                            IsSequenceValid = false;
                            MessageValidation = $"Sequence for {DataHeader.warehouse_id_in} exceeds limit, please contact administrator";
                        }
                        else if (SequenceOut >= DataSequenceOut.maximum)
                        {
                            IsSequenceValid = false;
                            MessageValidation = $"Sequence for {DataHeader.warehouse_id_out} exceeds limit, please contact administrator";
                        }

                        if (!IsSequenceValid)
                        {
                            Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
                        }
                        else
                        {
                            try
                            {
                                var res = AppLogic.Insert(DataHeader, DataGrid, ListWarehouse, SequenceCodeIn, SequenceCodeOut);
                                Alert.PushAlert($"Succes with sequence in : {SequenceIn} and sequence out : {SequenceOut}", clsAlert.Type.Success);
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var Model = (IMTukarBarangBL)bindingObjTukarBarang.DataSource;
            var IsValid = FormValidation(Model);

            if (IsValid)
            {
                var DataHarcoded = AppLogic.ReadGSGenHarcoded();
                List<ComboBoxViewModel> ComboboxTxn = (from DataRow dr in DataHarcoded.Rows
                                                       select new ComboBoxViewModel()
                                                       {
                                                           DisplayMember = $"{dr["gh_function_code"]} - {dr["gh_function_desc"]}",
                                                           ValueMember = Helper.CastToString(dr["gh_function_desc"])
                                                       }).ToList();

                DataGridViewComboBoxColumn cell1 = (DataGridViewComboBoxColumn)(dataGridNewTukarBarang.Columns["new_type"]);
                cell1.DataSource = ComboboxTxn;
                cell1.DisplayMember = "DisplayMember";
                cell1.ValueMember = "ValueMember";
                dataGridNewTukarBarang.Enabled = true;
                dataGridNewTukarBarang.AutoGenerateColumns = false;
                dataGridNewTukarBarang.DataSource = new List<IMTukarBarangBL>()
                {
                    new IMTukarBarangBL(){ product_id = string.Empty }
                };
                dataGridNewTukarBarang.Focus();
                dataGridNewTukarBarang.CurrentCell = dataGridNewTukarBarang.Rows[0].Cells[0];
                btnProcess.Enabled = false;
                cboNewInWarehouseID.Enabled = false;
                cboNewOutWarehouseID.Enabled = false;
                txtBoxNewMemo.Enabled = false;
                txtBoxReference.Enabled = false;
                btnCancelProcess.Enabled = true;
            }
        }

        private void dataGridNewTukarBarang_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridNewTukarBarang.Refresh();
        }

        private void dataGridNewTukarBarang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (btnProcess.Enabled == false)
            {
                IMOtherStockTransactionEntryAL AppLogicOtherStock = new IMOtherStockTransactionEntryAL(Helper);
                var DataHeader = (IMTukarBarangBL)bindingObjTukarBarang.DataSource;
                var DataGrid = (List<IMTukarBarangBL>)dataGridNewTukarBarang.DataSource;
                var SelectedWarehouseIDIn = $"{cboNewInWarehouseID.SelectedValue}";
                var SelectedWarehouseIDOut = $"{cboNewOutWarehouseID.SelectedValue}";
                var Type = dataGridNewTukarBarang.Rows[e.RowIndex].Cells[0].Value;
                var ProductID = $"{dataGridNewTukarBarang.Rows[e.RowIndex].Cells[1].Value}";
                var Quantity = dataGridNewTukarBarang.Rows[e.RowIndex].Cells[3].Value;
                var UnitCost = dataGridNewTukarBarang.Rows[e.RowIndex].Cells[4].Value;
                var TotalCost = dataGridNewTukarBarang.Rows[e.RowIndex].Cells[5].Value;
                var QuantityAvailable = dataGridNewTukarBarang.Rows[e.RowIndex].Cells[8].Value;
                var Check = dataGridNewTukarBarang.Rows[e.RowIndex].Cells[9].Value;

                bool IsValid = true;
                string MessageValidation = string.Empty;

                if ((string.IsNullOrEmpty($"{Type}") && e.ColumnIndex == 1)
                    || string.IsNullOrEmpty($"{Type}") && e.ColumnIndex == 3)
                {
                    IsValid = false;
                    MessageValidation = "Select type first";
                }
                else if (string.IsNullOrEmpty(ProductID) && e.ColumnIndex == 3)
                {
                    MessageValidation = "Input product ID first";
                    IsValid = false;
                }

                if (!IsValid)
                {
                    Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
                    ClearGrid(e.RowIndex,2);
                }
                else
                {
                    if (e.ColumnIndex == 0) //Column Type
                    {
                        ClearGrid(e.RowIndex,1);
                    }
                    else if (e.ColumnIndex == 1) // Column product id
                    {
                        ClearGrid(e.RowIndex,2);

                        bool IsDuplicateProduct = false;

                        for (int i = 0; i < dataGridNewTukarBarang.Rows.Count; i++)
                        {
                            if (e.RowIndex != i && $"{dataGridNewTukarBarang.Rows[i].Cells[1].Value}" == ProductID)
                            {
                                IsDuplicateProduct = true;
                                Alert.PushAlert("Duplicate product", clsAlert.Type.Info);
                                break;
                            }
                        }

                        if (!IsDuplicateProduct)
                        {
                            var DataProduct = AppLogicOtherStock.GetProductByID("N", ProductID);
                            var DataUnitCost = AppLogicOtherStock.GetUnitCostByProductID(ProductID);
                            var DataStockBalance = AppLogicOtherStock.GetStockBalanceByProductIDAndWarehouseID(ProductID,
                                        Type.ToString() == TxnTypeIn ? DataHeader.warehouse_id_in : DataHeader.warehouse_id_out);

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
                                ClearGrid(e.RowIndex,2);
                            }
                            else
                            {
                                try
                                {
                                    foreach (var item in DataGrid)
                                    {
                                        if (item.product_id == ProductID)
                                        {
                                            item.txn_type_code = Type.ToString();
                                            item.product_description = DataProduct.product_description;
                                            item.product_type = DataProduct.product_type == "M" ? "Multiline"
                                                    : DataProduct.product_type == "S" ? "Single"
                                                    : DataProduct.product_type == "P" ? "Package" : string.Empty;
                                            item.unit_cost = DataUnitCost.unit_cost;
                                            item.qty_on_hand = DataStockBalance.qty_on_hand;
                                            item.qty_available = DataStockBalance.qty_available;
                                        }
                                    }
                                    dataGridNewTukarBarang.DataSource = null;
                                    dataGridNewTukarBarang.DataSource = DataGrid;
                                }
                                catch (Exception ex)
                                {
                                    Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
                                }
                            }
                        }

                    }
                    else if (e.ColumnIndex == 3) //Column qty
                    {

                        int QtyInteger;
                        if (!int.TryParse(Convert.ToString(Quantity), out QtyInteger))
                        {
                            foreach (var item in DataGrid)
                            {
                                if (item.product_id == ProductID)
                                {
                                    item.txn_quantity = string.Empty;
                                }
                            }
                            Alert.PushAlert("Must be numeric", clsAlert.Type.Warning);
                        }
                        else
                        {
                            GetTxnType(Helper.CastToString(Type));
                            var DataTxnType = ListTxnType.FirstOrDefault();

                            if (DataTxnType.Negate_qty_entered == "Y" && Convert.ToInt32(Quantity) > 0)
                            {
                                Quantity = Helper.CastToInt(Quantity) * -1;
                            }

                            if (Helper.CastToInt(Quantity) * -1 > Helper.CastToInt(QuantityAvailable))
                            {
                                Alert.PushAlert($"Product Stock Not Enought, Available Stock : {QuantityAvailable}", clsAlert.Type.Error);
                            }

                            TotalCost = Convert.ToDecimal(UnitCost) * Helper.CastToInt(Quantity);

                            if (Type.ToString() == "RBT")
                            {
                                txtBoxNewTotalCostInY.Text = (Convert.ToDecimal(txtBoxNewTotalCostInY.Text) + Convert.ToDecimal(TotalCost)).ToString();
                            }
                            else
                            {
                                txtBoxNewTotalCostOutY.Text = (Convert.ToDecimal(txtBoxNewTotalCostOutY.Text) + Convert.ToDecimal(TotalCost)).ToString();
                            }

                            if (Convert.ToDecimal(txtBoxNewTotalCostInY.Text) > Convert.ToDecimal(txtBoxNewTotalCostOutY.Text))
                            {
                                txtBoxNewTotalCostOutY.BackColor = Color.FromArgb(255, 224, 192); //MERAH
                                txtBoxNewTotalCostInY.BackColor = Color.FromArgb(192, 255, 192); // IJO 

                                txtBoxNewTotalCostOutN.BackColor = Color.FromArgb(255, 224, 192); //MERAH
                                txtBoxNewTotalCostInN.BackColor = Color.FromArgb(192, 255, 192); // IJO
                            }
                            else if (Convert.ToDecimal(txtBoxNewTotalCostInY.Text) < Convert.ToDecimal(txtBoxNewTotalCostOutY.Text))
                            {
                                txtBoxNewTotalCostInY.BackColor = Color.FromArgb(192, 255, 192);
                                txtBoxNewTotalCostOutY.BackColor = Color.FromArgb(255, 224, 192);

                                txtBoxNewTotalCostOutN.BackColor = Color.FromArgb(192, 255, 192);
                                txtBoxNewTotalCostInN.BackColor = Color.FromArgb(255, 224, 192);
                            }
                            else if (Convert.ToDecimal(txtBoxNewTotalCostOutY.Text) == Convert.ToDecimal(txtBoxNewTotalCostInY.Text))
                            {
                                txtBoxNewTotalCostOutY.BackColor = Color.FromArgb(255, 224, 192);
                                txtBoxNewTotalCostInY.BackColor = Color.FromArgb(255, 224, 192);

                                txtBoxNewTotalCostOutN.BackColor = Color.FromArgb(255, 224, 192);
                                txtBoxNewTotalCostInN.BackColor = Color.FromArgb(255, 224, 192);
                            }

                            foreach (var item in DataGrid)
                            {
                                if (item.product_id == ProductID)
                                {
                                    item.txn_quantity = $"{Quantity}";
                                    item.check = true;
                                    item.total_cost = $"{TotalCost}";
                                }
                            }

                            if (DataGrid.Where(x => x.product_id == "" || x.txn_type_code == null).Count() == 0)
                            {
                                DataGrid.Add(new IMTukarBarangBL() { product_id = string.Empty });
                                dataGridNewTukarBarang.DataSource = null;
                                dataGridNewTukarBarang.DataSource = DataGrid;
                                btnBack.Enabled = true;
                            }
                        }
                    }
                }
            }
        }

        private void cboNewOutWarehouseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsUiReady && cboNewOutWarehouseID.SelectedValue.ToString() != string.Empty)
            {
                var DataHeader = (IMTukarBarangBL)bindingObjTukarBarang.DataSource;
                var SequenceCodeOut = $"IM{Helper.CastToString(DataHeader.warehouse_id_out).Trim()}{TxnTypeOut}";
                var DataSequenceOut = AppLogicSequence.GetByID(SequenceCodeOut);

                bool IsSequenceValid = true;
                string MessageValidation = string.Empty;

                if (DataSequenceOut == null)
                {
                    IsSequenceValid = false;
                    MessageValidation = $"Cannot find data sequence {DataHeader.warehouse_id_out}, please contact administrator";
                }
                else if (DataSequenceOut.last_number + 1 >= DataSequenceOut.maximum)
                {
                    IsSequenceValid = false;
                    MessageValidation = $"Sequence for {DataHeader.warehouse_id_out} exceeds limit, please contact administrator";
                }

                if (!IsSequenceValid)
                {
                    Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
                    cboNewOutWarehouseID.SelectedValue = string.Empty;
                }
            }
        }

        private void btnCancelProcess_Click(object sender, EventArgs e)
        {
            btnProcess.Enabled = true;
            cboNewInWarehouseID.Enabled = true;
            cboNewOutWarehouseID.Enabled = true;
            txtBoxNewMemo.Enabled = true;
            txtBoxReference.Enabled = true;
            txtBoxNewTotalCostInY.BackColor = Color.White;
            txtBoxNewTotalCostInY.Text = string.Empty;
            txtBoxNewTotalCostOutY.BackColor = Color.White;
            txtBoxNewTotalCostOutY.Text = string.Empty;

            ResetGrid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var DataGrid = (List<IMTukarBarangBL>)dataGridNewTukarBarang.DataSource;

            if (DataGrid.Where(x => x.txn_quantity != null).Count() > 1)
            {
                DataGrid.RemoveAt(DataGrid.Count() - 2);
                dataGridNewTukarBarang.DataSource = null;
                dataGridNewTukarBarang.DataSource = DataGrid;
            }
        }

        private void btnSearchLookUpProduct_Click(object sender, EventArgs e)
        {
            clsPopUpProduct LookUpProduct = new clsPopUpProduct(Helper,Alert);
            if (LookUpProduct.ShowDialog() == DialogResult.OK)
            {
                txtBoxSearchProductID.Text = LookUpProduct._ProductID;
                txtBoxSearchProductName.Text = LookUpProduct._ProductDescription;
            }
        }

        private void cboNewInWarehouseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsUiReady && cboNewInWarehouseID.SelectedValue.ToString() != string.Empty)
            {
                var DataHeader = (IMTukarBarangBL)bindingObjTukarBarang.DataSource;
                var SequenceCodeIn = $"IM{Helper.CastToString(DataHeader.warehouse_id_in).Trim()}{TxnTypeIn}";
                var DataSequenceIn = AppLogicSequence.GetByID(SequenceCodeIn);

                bool IsSequenceValid = true;
                string MessageValidation = string.Empty;

                if (DataSequenceIn == null)
                {
                    IsSequenceValid = false;
                    MessageValidation = $"Cannot find data sequence {DataHeader.warehouse_id_in}, please contact administrator";
                }
                else if (DataSequenceIn.last_number + 1 >= DataSequenceIn.maximum)
                {
                    IsSequenceValid = false;
                    MessageValidation = $"Sequence for {DataHeader.warehouse_id_in} exceeds limit, please contact administrator";
                }

                if (!IsSequenceValid)
                {
                    Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
                    cboNewInWarehouseID.SelectedValue = string.Empty;
                }
            }
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            Close();
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