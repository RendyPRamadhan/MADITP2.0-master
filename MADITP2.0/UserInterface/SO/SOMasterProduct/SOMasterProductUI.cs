using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.Enums;
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
using MADITP2._0.ApplicationLogic.SO;
using MADITP2._0.BusinessLogic.SO;
using System.Collections;
using CrystalDecisions.CrystalReports.Engine;
using MADITP2._0.Report.SO.SOMasterProduct;
using MADITP2._0.ApplicationLogic;

namespace MADITP2._0.UserInterface.SO.SOMasterProduct
{
    public partial class SOMasterProductUI : Form
    {
        private SOMasterProductAL AppLogic;
        private static GlobalAL AppLogicGlobal;
        private SOMasterProductBL _Model;
        private clsGlobal Helper = new clsGlobal();
        private clsAlert Alert = new clsAlert();
        //private int _CurrentPage;
        private int _TotalPage;
        private static int CurrentPage, Offset, FetchLimit, TotalPage;
        private static string FormActiveName;
        private static string SQLQuery;
        private static string Category;
        ReportDocument cryRpt;

        private static clsEventButton ClsEventButton;
        public SOMasterProductUI()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                _Model = new SOMasterProductBL();
                Helper = new clsGlobal();
                AppLogic = new SOMasterProductAL(Helper);
                ClsEventButton = new clsEventButton();
                DrawFilterCombobox();
                FormMode(clsEventButton.EnumAction.VIEW);
                AppLogicGlobal = new GlobalAL(Helper);
            }
        }
        private void navView_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.NEW);
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.EDIT);
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.DELETE);
        }

        private void navPrint_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.PRINT);
        }
        private bool FormValidation(SOMasterProductBL Model)
        {
            bool IsValid = true;
            string MessageValidation = "";

            if (string.IsNullOrEmpty(Model.group_id))
            {
                IsValid = false;
                MessageValidation = "Module ID is required!";
            }
            if (string.IsNullOrEmpty(Model.subgroup_id))
            {
                IsValid = false;
                MessageValidation = "Module ID is required!";
            }
            else if (string.IsNullOrEmpty(Model.description))
            {
                IsValid = false;
                MessageValidation = "Description is required!";
            }
            else if (string.IsNullOrEmpty(Model.product_id))
            {
                IsValid = false;
                MessageValidation = "G/L Account is required!";
            }
            else if (string.IsNullOrEmpty(Model.active_flag))
            {
                IsValid = false;
                MessageValidation = "userdefinefield2 is required!";
            }
            else if (string.IsNullOrEmpty(Model.sap))
            {
                IsValid = false;
                MessageValidation = "userdefinefield3 is required!";
            }

            if (!IsValid)
            {
                Alert.PushAlert(MessageValidation, clsAlert.Type.Error);
            }

            return IsValid;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var Model = (SOMasterProductBL)bindingObjProductMaster.DataSource;
                bool IsValid = FormValidation(Model);

                if (IsValid)
                {
                    AppLogic.CMD(Model, SQLQuery);
                    if (SQLQuery == EnumState.Create.ToString())
                        Alert.PushAlert("Success Insert data", clsAlert.Type.Success);
                    else if (SQLQuery == EnumState.Update.ToString())
                        Alert.PushAlert("Success Update data", clsAlert.Type.Success);
                    else if (SQLQuery == EnumState.Delete.ToString())
                        Alert.PushAlert("Success Delete data", clsAlert.Type.Success);

                    FormMode(clsEventButton.EnumAction.VIEW);
                }
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
            /*
            try
            {
                var Model = new SOMasterProductBL();
                
                Model.group_id = cmbProductGroupID.SelectedValue.ToString();
                Model.subgroup_id = cmbProductSubGroupID.SelectedValue.ToString();
                Model.product_type = cmbProductType.SelectedValue.ToString();
                Model.product_id = txtProductID.Text;
                Model.description = txtProductDesc.Text;
                Model.sap = txtSAPCode.Text;
                if (cbStockItem.Checked = true)
                    Model.active_flag = "1";
                else
                    Model.active_flag = "0";


                Model.divtype = cmbCommissionType.SelectedValue.ToString();
                Model.productnamekey = txtProductNameKey.Text;
                Model.vendorid = cmbBuyFromVendorID.SelectedValue.ToString();
                Model.taxcode = cmbTaxID.SelectedValue.ToString();
                Model.disccode = cmbDiscScheduleID.SelectedValue.ToString();
                Model.uomivt = cmbUOMInventory.SelectedValue.ToString();
                Model.uomsales = cmbUOMSales.SelectedValue.ToString();
                Model.uompurch = cmbUOMPurchase.SelectedValue.ToString();
                Model.unitweight = txtWeightINGram.Text;
                Model.controlflag = cmbControlFlag.SelectedValue.ToString();
                Model.techconstrainflag = cmbConstrainFlag.SelectedValue.ToString();
                Model.divtype2 = cmbDevisionType.SelectedValue.ToString();


                Model.weight = txtWeight.Text;

                Model.divisiproduct = cmbDevisionProduct.SelectedValue.ToString();
                Model.jenisproduct = cmbJenisProduct.SelectedValue.ToString();
                Model.itemgroup = txtItemGroup.Text;
                Model.editionlanguage = txtEditionLanguage.Text;
                Model.convsales = txtConvSalesTOInvt.Text;
                Model.convpurch = txtConvPurcTOIvt.Text;
                Model.manufacturecode = txtManufacture.Text;
                
                if(cbStockItem.Checked == true)
                    Model.nonstockitemflag = "1";
                else
                    Model.nonstockitemflag = "0";

                if (cbProductDigital.Checked == true)
                    Model.productdigital = "1";
                else
                    Model.productdigital = "0";

                //String Category = "";

                if (cbDads.Checked == true)
                    Model.productdigital = "1|";

                if (cbMoms.Checked == true)
                    Model.productdigital = "2|";

                if (cbKids.Checked == true)
                    Model.productdigital = "3";


                //var Model = (SOMasterProductBL)bindingObjGroup.DataSource;
                bool IsValid = FormValidation(Model);
                
                                if (IsValid)
                                {
                                    AppLogic.CMD(Model, SQLQuery);

                                    if (SQLQuery == EnumState.Create.ToString())
                                        Alert.PushAlert("Success Insert data", clsAlert.Type.Success);
                                    else if (SQLQuery == EnumState.Update.ToString())
                                        Alert.PushAlert("Success Update data", clsAlert.Type.Success);
                                    else if (SQLQuery == EnumState.Delete.ToString())
                                        Alert.PushAlert("Success Delete data", clsAlert.Type.Success);

                                    FormMode(clsEventButton.EnumAction.VIEW);
                                }
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
            */
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            Pagination(true);
            InitializeGrid(_Model);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            Pagination(true);
            InitializeGrid(_Model);
        }

        
        private void FormMode(clsEventButton.EnumAction ActionType)
        {
            var Grid = dgvResult;

            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    ResetPaginationRules();
                    _Model = new SOMasterProductBL();
                    InitializeGrid(_Model);
                    PanelFormList.BringToFront();
                    FormActiveName = clsEventButton.EnumAction.VIEW.ToString();
                    break;

                case clsEventButton.EnumAction.NEW:
                    _Model = new SOMasterProductBL();
                    // InitializeObject(_Model);
                    PanelFormCreate.BringToFront();
                    btnSave.Text = "Save";
                    cmbProductGroupID.Enabled = true;
                    cmbProductSubGroupID.Enabled = true;
                    FormActiveName = clsEventButton.EnumAction.NEW.ToString();
                    SQLQuery = EnumState.Create.ToString();
                    break;

                case clsEventButton.EnumAction.EDIT:
                    if (FormActiveName == clsEventButton.EnumAction.VIEW.ToString())
                    {
                        PanelFormCreate.BringToFront();

                        if (Grid.Rows.Count == 0)
                        {
                            Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
                        }
                        else
                        {
                            if (Grid.SelectedRows.Count == 1)
                            {
                                btnSave.Text = "Update";
                                cmbProductGroupID.Enabled = false;
                                cmbProductSubGroupID.Enabled = false;
                                SQLQuery = EnumState.Update.ToString();

                               // var SubGroupID = Grid.CurrentRow.Cells["product_subgroup_id"].Value.ToString();
                                var ProductID = Grid.CurrentRow.Cells["product_id"].Value.ToString();

                                DataTable Data = AppLogic.GetByID(ProductID);

                                InitializeObject(Data);

                            }
                            else if (Grid.SelectedRows.Count > 1)
                            {
                                Alert.PushAlert("Please Dont Select Multiple Data", clsAlert.Type.Info);
                            }
                            else
                            {
                                Alert.PushAlert("Please Select Data", clsAlert.Type.Info);
                            }
                        }
                    }
                    else
                    {
                        Alert.PushAlert("Back to View Menu First!", clsAlert.Type.Warning);
                    }
                    FormActiveName = clsEventButton.EnumAction.EDIT.ToString();
                    break;

                case clsEventButton.EnumAction.DELETE:
                    if (FormActiveName == clsEventButton.EnumAction.VIEW.ToString())
                    {
                        if (Grid.Rows.Count == 0)
                        {
                            Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
                        }
                        else
                        {
                            if (Grid.SelectedRows.Count >= 1)
                            {
                                MessageBoxButtons ButttonDialog = MessageBoxButtons.YesNo;
                                DialogResult ResultDialog = MessageBox.Show("Are You Sure?", "Warning!", ButttonDialog);
                                if (ResultDialog == DialogResult.Yes)
                                {
                                    SQLQuery = EnumState.Delete.ToString();
                                    for (int i = 0; i < Grid.SelectedRows.Count; i++)
                                    {;
                                        var ProductID = Grid.CurrentRow.Cells["product_id"].Value.ToString();

                                        var Model = new SOMasterProductBL();
                                        Model.product_id = ProductID;

                                        AppLogic.CMD(Model, SQLQuery);

                                        //DataTable Data = AppLogic.GetByID(ProductID);
                                        //InitializeObject(Data);
                                    }
                                    Alert.PushAlert("Success Delete Data", clsAlert.Type.Success);
                                    FormMode(clsEventButton.EnumAction.VIEW);
                                }
                            }
                            else
                            {
                                Alert.PushAlert("Please Select Data", clsAlert.Type.Info);
                            }
                        }
                    }
                    else
                    {
                        Alert.PushAlert("Back to View Menu First!", clsAlert.Type.Warning);
                    }
                    break;

                case clsEventButton.EnumAction.PRINT:
                    if (FormActiveName == clsEventButton.EnumAction.VIEW.ToString())
                    {
                        FormActiveName = clsEventButton.EnumAction.PRINT.ToString();
                        PanelFormPrint.BringToFront();
                        _Model = new SOMasterProductBL();

                        this.Search(ref _Model);

                        InitializeReport(_Model);
                    }
                    else
                    {
                        Alert.PushAlert("Back to View Menu First!", clsAlert.Type.Warning);
                    }
                    break;

                case clsEventButton.EnumAction.EXPORT:
                    if (FormActiveName == clsEventButton.EnumAction.VIEW.ToString())
                    {
                        FormActiveName = clsEventButton.EnumAction.EXPORT.ToString();
                        _Model = new SOMasterProductBL();

                        this.Search(ref _Model);

                        var DataForExport = AppLogic.GetAllPaging(_Model, CurrentPage);

                        if (DataForExport.Rows.Count > 0)
                        {
                            clsExcel clExcel = new clsExcel();
                            using (var fbd = new FolderBrowserDialog())
                            {
                                DialogResult result = fbd.ShowDialog();
                                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                                {
                                    var path = fbd.SelectedPath;
                                    clExcel.ExportToExcel(path, DataForExport, EnumExcel.REPORT_MASTER_PRODUCT);
                                    Alert.PushAlert("The data successfully generated", clsAlert.Type.Success);
                                }
                            }
                        }
                        else
                        {
                            Alert.PushAlert("Data not found", clsAlert.Type.Info);
                        }
                    }
                    else
                    {
                        Alert.PushAlert("Back to View Menu First!", clsAlert.Type.Warning);
                    }
                    break;
            }
        }
        public void InitializeReport(SOMasterProductBL Model)
        {
            String ReportPath = "";
            String GroupS, SubgroupS, ProductTypeS, ActiveStatusS;
            cryRpt = new ReportDocument();
            DataSet data = new DataSet();
            DataTable dt = new DataTable();
            dt = AppLogic.GetAllPaging(_Model, CurrentPage);
            if (data != null)
            {
                //Report Instalize
                /* ReportPath = Application.StartupPath + "\\Report\\rptSOUnitHongkong.rpt";

                 cryRpt.Load(ReportPath);
                 cryRpt.SetDataSource(data);
                 rptViewer.ReportSource = cryRpt;
                 rptViewer.Refresh();
                */
                if(cmbProductGroupID.SelectedValue == "" || cmbProductGroupID.SelectedValue == "0")
                { GroupS = "All"; }
                else
                { GroupS = cmbProductGroupID.Text; }

                if (cmbSearchProductSubGroupID.SelectedValue == "" || cmbSearchProductSubGroupID.SelectedValue == "0")
                { SubgroupS = "All"; }
                else
                { SubgroupS = cmbSearchProductSubGroupID.Text; }

                if (cmbProductType.SelectedValue == "" || cmbProductType.SelectedValue == "0")
                { ProductTypeS = "All"; }
                else
                { ProductTypeS = cmbProductType.Text; }

                if (cmbSearchProductStatus.SelectedValue == "" || cmbSearchProductStatus.SelectedValue == "0")
                { ActiveStatusS = "All"; }
                else
                { ActiveStatusS = cmbSearchProductStatus.Text; }


                //Insert Data to Data Set
                data.Tables.Add(dt);
               
                //Create Table Head
                DataTable dtCompany = AppLogicGlobal.GetCompany();
                dtCompany.Columns.Add("mnu_menu_code");
                dtCompany.Columns.Add("group_search");
                dtCompany.Columns.Add("subgroup_search");
                dtCompany.Columns.Add("product_type_search");
                dtCompany.Columns.Add("active_status_search");

                dtCompany.Rows[0]["mnu_menu_code"] = this.Name.ToString();
                dtCompany.Rows[0]["group_search"] = GroupS;
                dtCompany.Rows[0]["subgroup_search"] = SubgroupS;
                dtCompany.Rows[0]["product_type_search"] = ProductTypeS;
                dtCompany.Rows[0]["active_status_search"] = ActiveStatusS;
                //data.Tables.Remove("Table1");
                data.Tables.Add(dtCompany);

                rptSOMasterProduct report = new rptSOMasterProduct();
                report.SetDataSource(data);
                rptViewer.ReportSource = report;
                rptViewer.Refresh();

            }
        }
        private void Pagination(Boolean onloading = false)
        {
            if (_TotalPage == 0)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
                return;
            }

            if (_TotalPage == CurrentPage)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
                if (CurrentPage > 1)
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

            if (CurrentPage < 2)
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
        public void ResetPaginationRules()
        {
            CurrentPage = 1;
            Offset = 0;
            FetchLimit = (int)EnumFetchData.DefaultLimit;
            TotalPage = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            _Model = new SOMasterProductBL();

            this.Search(ref _Model);
            InitializeGrid(_Model);
        }
        private void Search(ref SOMasterProductBL Model)
        {
            /*
            if (txtSearchProductID.Text == txtSearchProductID.TiraPlaceHolder)
            { Model.product_id = ""; }
            else { Model.product_id = txtSearchProductID.Text; }

            if (cmbSearchDivision.SelectedValue.ToString() == "0")
            { Model.division_id = ""; }
            else
            { Model.division_id = cmbSearchDivision.SelectedValue.ToString(); }
            */
            _Model.group_id = cmbSearchProductGroupID.SelectedValue.ToString();
            _Model.subgroup_id = cmbSearchProductSubGroupID.SelectedValue.ToString();
            _Model.product_type = cmbSearchProductType.SelectedValue.ToString();
            _Model.active_flag = cmbSearchProductStatus.SelectedValue.ToString();

            if (chkbSAPOnly.Checked)
            { _Model.sap = "1"; }
            else
            { _Model.sap = "0"; }

            if (txtSearchProductID.TiraPlaceHolder == txtSearchProductID.Text)
            { _Model.product_id = ""; }
            else
            { _Model.group_id = txtSearchProductID.Text; }

            if (txtSearchProductDesc.TiraPlaceHolder == txtSearchProductDesc.Text)
            { _Model.description = ""; }
            else
            { _Model.description = txtSearchProductDesc.Text; }

        }

        private void cmbSearchProductGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtInput = new DataTable();
            DataTable dtSearch = new DataTable();

            //if (string.IsNullOrEmpty(cmbSearchProductGroupID.SelectedValue.ToString()))
            if(cmbSearchProductGroupID.SelectedValue !=  null)
            {
                dtSearch = AppLogic.GetList_ProductSubGroup(clsEventButton.EnumAction.SEARCH.ToString(), cmbSearchProductGroupID.SelectedValue.ToString());
                dtInput = AppLogic.GetList_ProductSubGroup(clsEventButton.EnumAction.DISPLAY.ToString(), cmbSearchProductGroupID.SelectedValue.ToString());
                if (dtSearch != null && dtInput != null)
                {
                    cmbProductSubGroupID.DataSource = dtInput;
                    cmbProductSubGroupID.ValueMember = "product_subgroup_id";
                    cmbProductSubGroupID.DisplayMember = "product_subgroup_description";

                    cmbSearchProductSubGroupID.DataSource = dtSearch;
                    cmbSearchProductSubGroupID.ValueMember = "product_subgroup_id";
                    cmbSearchProductSubGroupID.DisplayMember = "product_subgroup_description";
                }
            }
            
        }

        private void cmbUOMInventory_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if(cmbUOMInventory.SelectedValue != null)
            txtUOMInventory.Text = cmbUOMInventory.SelectedValue.ToString();
        }

        private void cmbUOMSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUOMSales.SelectedValue != null)
                txtUOMSales.Text = cmbUOMSales.SelectedValue.ToString();
        }

        private void cmbUOMPurchase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUOMPurchase.SelectedValue != null)
                txtUOMPurchase.Text = cmbUOMPurchase.SelectedValue.ToString();
        }

        private void InitializeGrid(SOMasterProductBL Model)
        {
            try
            {
                DataTable data = AppLogic.GetAllPaging(_Model, CurrentPage);
                dgvResult.AutoGenerateColumns = false;
                dgvResult.DataSource = data;

                //Paging Initialize
                int DataCount = AppLogic.GetAllCount(Model);
                TotalPage = (int)Math.Ceiling((Double)DataCount / FetchLimit);
                if (Convert.ToInt32(TotalPage) > 0) { lblPagingInfo.Text = "Pages : " + CurrentPage.ToString() + " / " + TotalPage; } else { lblPagingInfo.Text = "Pages : - "; }
                lblRows.Text = "Records : " + dgvResult.Rows.Count.ToString() + " Rows";
                PaginationRules();
            }
            catch (Exception ex)
            {
                Alert.PushAlert("Something wrong", clsAlert.Type.Info);
            }
        }
        public void PaginationRules()
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

        private void DrawFilterCombobox()
        {

            DataTable dtInputGroup = new DataTable();
            DataTable dtSearchGroup = new DataTable();
            dtSearchGroup = AppLogic.GetList_ProductGroup(clsEventButton.EnumAction.SEARCH.ToString());
            dtInputGroup = AppLogic.GetList_ProductGroup(clsEventButton.EnumAction.DISPLAY.ToString());
            if(dtSearchGroup != null && dtInputGroup != null)
            {
                cmbProductGroupID.DataSource = dtInputGroup;
                cmbProductGroupID.ValueMember = "gp_product_group_id";
                cmbProductGroupID.DisplayMember = "gp_group_description";

                cmbSearchProductGroupID.DataSource = dtSearchGroup;
                cmbSearchProductGroupID.ValueMember = "gp_product_group_id";
                cmbSearchProductGroupID.DisplayMember = "gp_group_description";
            }

            DataTable dtInputProductType = new DataTable();
            DataTable dtSearchProductType = new DataTable();
            dtSearchProductType = AppLogic.GetList_ProductType(clsEventButton.EnumAction.SEARCH.ToString());
            dtInputProductType = AppLogic.GetList_ProductType(clsEventButton.EnumAction.DISPLAY.ToString());
            if (dtSearchProductType != null && dtInputProductType != null)
            {
                cmbProductType.DataSource = dtInputProductType;
                cmbProductType.ValueMember = "product_type_id";
                cmbProductType.DisplayMember = "product_type";

                cmbSearchProductType.DataSource = dtSearchProductType;
                cmbSearchProductType.ValueMember = "product_type_id";
                cmbSearchProductType.DisplayMember = "product_type";
            }
            DataTable dtInputStatus = new DataTable();
            DataTable dtSearchStatus = new DataTable();
            dtSearchStatus = AppLogic.GetList_ProductStatus(clsEventButton.EnumAction.SEARCH.ToString());
            dtInputStatus = AppLogic.GetList_ProductStatus(clsEventButton.EnumAction.DISPLAY.ToString());
            if (dtSearchStatus != null && dtInputStatus != null)
            {
               // cmbProductGroupID.DataSource = dtInput;
               // cmbProductGroupID.ValueMember = "status_type_id,";
                //cmbProductGroupID.DisplayMember = "status_type";

                cmbSearchProductStatus.DataSource = dtSearchStatus;
                cmbSearchProductStatus.ValueMember = "status_type_id";
                cmbSearchProductStatus.DisplayMember = "status_type";
             }

            DataTable dtInputJenisProduct = new DataTable();
            dtInputJenisProduct = AppLogic.GetList_JenisProduct(clsEventButton.EnumAction.DISPLAY.ToString());
            cmbJenisProduct.DataSource = dtInputJenisProduct;
            cmbJenisProduct.ValueMember = "pm_jenis_product";
            cmbJenisProduct.DisplayMember = "Descr";

            DataTable dtInputDevisiProduct = new DataTable();
            dtInputDevisiProduct = AppLogic.GetList_DivisiProduct(clsEventButton.EnumAction.DISPLAY.ToString());
            cmbDevisionProduct.DataSource = dtInputDevisiProduct;
            cmbDevisionProduct.ValueMember = "pm_product_division";
            cmbDevisionProduct.DisplayMember = "pm_product_division";



            DataTable dtInputDevisiType = new DataTable();
            dtInputDevisiType = AppLogic.GetList_DivisionType2(clsEventButton.EnumAction.DISPLAY.ToString());
            cmbDevisionType.DataSource = dtInputDevisiType;
            cmbDevisionType.ValueMember = "pm_division_type2";
            cmbDevisionType.DisplayMember = "commission_type";

            DataTable dtInputCommissionType = new DataTable();
            dtInputCommissionType = AppLogic.GetList_CommissionType(clsEventButton.EnumAction.DISPLAY.ToString());
            cmbCommissionType.DataSource = dtInputCommissionType;
            cmbCommissionType.ValueMember = "commission_type_id";
            cmbCommissionType.DisplayMember = "commission_type";

            DataTable dtInputDiscountProduct = new DataTable();
            dtInputDiscountProduct = AppLogic.GetList_DiscountProduct(clsEventButton.EnumAction.DISPLAY.ToString());
            cmbDiscScheduleID.DataSource = dtInputDiscountProduct;
            cmbDiscScheduleID.ValueMember = "d_discount_id";
            cmbDiscScheduleID.DisplayMember = "d_discount";

            DataTable dtInputTax = new DataTable();
            dtInputTax = AppLogic.GetList_Tax(clsEventButton.EnumAction.DISPLAY.ToString());
            cmbTaxID.DataSource = dtInputTax;
            cmbTaxID.ValueMember = "t_tax_id";
            cmbTaxID.DisplayMember = "t_tax";

            DataTable dtInputVendor = new DataTable();
            dtInputVendor = AppLogic.GetList_Vendor(clsEventButton.EnumAction.DISPLAY.ToString());
            cmbBuyFromVendorID.DataSource = dtInputVendor;
            cmbBuyFromVendorID.ValueMember = "v_vendor_id";
            cmbBuyFromVendorID.DisplayMember = "v_vendor";

            DataTable dtInputUOMIvt = new DataTable();
            DataTable dtInputUOMSls = new DataTable();
            DataTable dtInputUOMPur = new DataTable();
            dtInputUOMIvt = AppLogic.GetList_UOM(clsEventButton.EnumAction.DISPLAY.ToString());
            dtInputUOMSls = AppLogic.GetList_UOM(clsEventButton.EnumAction.DISPLAY.ToString());
            dtInputUOMPur = AppLogic.GetList_UOM(clsEventButton.EnumAction.DISPLAY.ToString()); 

            cmbUOMInventory.DataSource = dtInputUOMIvt;
            cmbUOMInventory.ValueMember = "umc_uom_code";
            cmbUOMInventory.DisplayMember = "umc_uom_description";

            cmbUOMSales.DataSource = dtInputUOMSls;
            cmbUOMSales.ValueMember = "umc_uom_code";
            cmbUOMSales.DisplayMember = "umc_uom_description";

            cmbUOMPurchase.DataSource = dtInputUOMPur;
            cmbUOMPurchase.ValueMember = "umc_uom_code";
            cmbUOMPurchase.DisplayMember = "umc_uom_description";

            DataTable dtInputControlFlag = new DataTable();
            DataTable dtInputConstrainFlag = new DataTable();
            dtInputControlFlag = AppLogic.GetList_ControlFlag(clsEventButton.EnumAction.DISPLAY.ToString());
            dtInputConstrainFlag = AppLogic.GetList_ConstrainFlag(clsEventButton.EnumAction.DISPLAY.ToString());

            cmbControlFlag.DataSource = dtInputControlFlag;
            cmbControlFlag.ValueMember = "pm_wh_control_flag";
            cmbControlFlag.DisplayMember = "pm_wh_control_flag";

            cmbConstrainFlag.DataSource = dtInputConstrainFlag;
            cmbConstrainFlag.ValueMember = "pm_technical_constrain_flag";
            cmbConstrainFlag.DisplayMember = "pm_technical_constrain_flag";

            DataTable dtInputUnitHongkong = new DataTable();
            dtInputUnitHongkong = AppLogic.GetList_UnitHongkong(clsEventButton.EnumAction.DISPLAY.ToString());

            cmbUnitHongkong.DataSource = dtInputUnitHongkong;
            cmbUnitHongkong.ValueMember = "hks_product_id";
            cmbUnitHongkong.DisplayMember = "hks_product_id";
        }

        private void cmbProductGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtInput = new DataTable();
            DataTable dtSearch = new DataTable();

            //if (string.IsNullOrEmpty(cmbSearchProductGroupID.SelectedValue.ToString()))
            if (cmbProductGroupID.SelectedValue != null)
            {
                dtInput = AppLogic.GetList_ProductSubGroup(clsEventButton.EnumAction.DISPLAY.ToString(), cmbProductGroupID.SelectedValue.ToString());
                if (dtSearch != null && dtInput != null)
                {
                    cmbProductSubGroupID.DataSource = dtInput;
                    cmbProductSubGroupID.ValueMember = "product_subgroup_id";
                    cmbProductSubGroupID.DisplayMember = "product_subgroup_description";

                }
            }
        }

        private void navExport_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            FormMode(clsEventButton.EnumAction.EXPORT);
        }

        public void InitializeObject(DataTable Model)
        {
            ClearDataBinding();
            bindingObjProductMaster.DataSource = Model;
            MappingDataBinding();
        }
        public void ClearDataBinding()
        {
            cmbProductGroupID.DataBindings.Clear();

            cmbProductGroupID.DataBindings.Clear();
            cmbProductSubGroupID.DataBindings.Clear();
            cmbProductType.DataBindings.Clear();
            txtProductID.DataBindings.Clear();
            txtProductDesc.DataBindings.Clear();
            txtSAPCode.DataBindings.Clear();
            /*
            if (cbStockItem.Checked = true)
                Model.active_flag = "1";
            else
                Model.active_flag = "0";
            */
            cbActiveLog.DataBindings.Clear();

            cmbCommissionType.DataBindings.Clear();
            txtProductNameKey.DataBindings.Clear();
            cmbBuyFromVendorID.DataBindings.Clear();
            cmbTaxID.DataBindings.Clear();
            cmbDiscScheduleID.DataBindings.Clear();
            cmbUOMInventory.DataBindings.Clear();
            cmbUOMSales.DataBindings.Clear();
            cmbUOMPurchase.DataBindings.Clear();
            txtWeightINGram.DataBindings.Clear();
            cmbControlFlag.DataBindings.Clear();
            cmbConstrainFlag.DataBindings.Clear();
            cmbDevisionType.DataBindings.Clear();


            txtWeight.DataBindings.Clear();

            cmbDevisionProduct.DataBindings.Clear();
            cmbJenisProduct.DataBindings.Clear();
            txtItemGroup.DataBindings.Clear();
            txtEditionLanguage.DataBindings.Clear();
            txtConvSalesTOInvt.DataBindings.Clear();
            txtConvPurcTOIvt.DataBindings.Clear();
            txtManufacture.DataBindings.Clear();
            /*
            if (cbStockItem.Checked == true)
                Model.nonstockitemflag = "1";
            else
                Model.nonstockitemflag = "0";

            if (cbProductDigital.Checked == true)
                Model.productdigital = "1";
            else
                Model.productdigital = "0";

            //String Category = "";

            if (cbDads.Checked == true)
                Model.productdigital = "1|";

            if (cbDads.Checked == true)
                Model.productdigital = "2|";

            if (cbDads.Checked == true)
                Model.productdigital = "3";
            */
            cbStockItem.DataBindings.Clear();
            cbProductDigital.DataBindings.Clear();
            cbDads.DataBindings.Clear();
            cbMoms.DataBindings.Clear();
            cbKids.DataBindings.Clear();
            txtCategory.DataBindings.Clear();
        }

        public void MappingDataBinding()
        {
            /*
		  [pm_active_flag] ,
		  [pm_creation_date],
		  [pm_last_update_date],
		  [pm_non_stocki_tem_flag],
		  [pm_digital] ,
		  [pm_user_id],
		  [pm_no_of_item] 
             * */
            //cbStockItem.Checked
            cbActiveLog.DataBindings.Add("Checked", bindingObjProductMaster, "active_flag", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbProductGroupID.DataBindings.Add("SelectedValue", bindingObjProductMaster, "product_group_id", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbProductSubGroupID.DataBindings.Add("SelectedValue", bindingObjProductMaster, "product_subgroup_id", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbProductType.DataBindings.Add("SelectedValue", bindingObjProductMaster, "product_type", true, DataSourceUpdateMode.OnPropertyChanged);
            txtProductID.DataBindings.Add("Text", bindingObjProductMaster, "product_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtProductDesc.DataBindings.Add("Text", bindingObjProductMaster, "product_description", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSAPCode.DataBindings.Add("Text", bindingObjProductMaster, "sap_cod", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbCommissionType.DataBindings.Add("SelectedValue", bindingObjProductMaster, "division_type", true, DataSourceUpdateMode.OnPropertyChanged);
            txtProductNameKey.DataBindings.Add("Text", bindingObjProductMaster, "product_namekey", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbBuyFromVendorID.DataBindings.Add("SelectedValue", bindingObjProductMaster, "vendor_id", true, DataSourceUpdateMode.OnPropertyChanged); ;
            cmbTaxID.DataBindings.Add("SelectedValue", bindingObjProductMaster, "tax_code", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbDiscScheduleID.DataBindings.Add("SelectedValue", bindingObjProductMaster, "discount_code", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbUOMInventory.DataBindings.Add("SelectedValue", bindingObjProductMaster, "uom_Inventory", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbUOMSales.DataBindings.Add("SelectedValue", bindingObjProductMaster, "uom_sales", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbUOMPurchase.DataBindings.Add("SelectedValue", bindingObjProductMaster, "uom_purchase", true, DataSourceUpdateMode.OnPropertyChanged);
            txtWeightINGram.DataBindings.Add("Text", bindingObjProductMaster, "weight", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbControlFlag.DataBindings.Add("SelectedValue", bindingObjProductMaster, "wh_control_flag", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbConstrainFlag.DataBindings.Add("SelectedValue", bindingObjProductMaster, "technical_constrain_flag", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbDevisionType.DataBindings.Add("SelectedValue", bindingObjProductMaster, "division_type2", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbDevisionProduct.DataBindings.Add("SelectedValue", bindingObjProductMaster, "product_division", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbJenisProduct.DataBindings.Add("SelectedValue", bindingObjProductMaster, "jenis_product", true, DataSourceUpdateMode.OnPropertyChanged);
            txtItemGroup.DataBindings.Add("Text", bindingObjProductMaster, "item_group", true, DataSourceUpdateMode.OnPropertyChanged);
            txtEditionLanguage.DataBindings.Add("Text", bindingObjProductMaster, "edition_language", true, DataSourceUpdateMode.OnPropertyChanged);
            txtConvSalesTOInvt.DataBindings.Add("Text", bindingObjProductMaster, "conversion_sales", true, DataSourceUpdateMode.OnPropertyChanged);
            txtConvPurcTOIvt.DataBindings.Add("Text", bindingObjProductMaster, "conversion_Purchase", true, DataSourceUpdateMode.OnPropertyChanged);
            txtManufacture.DataBindings.Add("Text", bindingObjProductMaster, "manufactur_code", true, DataSourceUpdateMode.OnPropertyChanged);

            txtWeight.DataBindings.Add("Text", bindingObjProductMaster, "unit_weight", true, DataSourceUpdateMode.OnPropertyChanged);
            cbStockItem.DataBindings.Add("Checked", bindingObjProductMaster, "non_stocki_tem_flag", true, DataSourceUpdateMode.OnPropertyChanged);
            cbProductDigital.DataBindings.Add("Checked", bindingObjProductMaster, "digital", true, DataSourceUpdateMode.OnPropertyChanged);

            txtCategory.DataBindings.Clear();
        }
    }
}
