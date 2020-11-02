using MADITP2._0.ApplicationLogic;
using MADITP2._0.ApplicationLogic.AR;
using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.Global;
using MADITP2._0.Report.AR.ARPrintKuitansiSementara;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MADITP2._0.UserInterface.AR.ARPrintKuitansiSementara
{
    public partial class AR_PrintKuitansiSementaraUI : Form
    {
        private static ARPrintKuitansiSementaraBL Model;
        private static ARPrintKuitansiSementaraAL AppLogic;
        private static clsAlert Alert;
        private static clsGlobal Helper;
        private static clsEventButton ClsEventButton;
        private static GlobalAL AppLogicGlobal;
        private static clsReport HelperReport;

        public AR_PrintKuitansiSementaraUI()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(AR_PrintKuitansiSementaraUI_KeyDown);
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Alert = new clsAlert();
                Model = new ARPrintKuitansiSementaraBL();
                Helper = new clsGlobal();
                AppLogic = new ARPrintKuitansiSementaraAL(Helper);
                ClsEventButton = new clsEventButton();
                AppLogicGlobal = new GlobalAL(Helper);
                HelperReport = new clsReport();
            }
        }
        #region Method Non Event
        public void InitializeObject(ARPrintKuitansiSementaraBL Model)
        {
            ClearDataBinding();
            bindingObjPrintKuitansiSementara.DataSource = Model;
            MappingDataBinding();
        }

        private void ClearDataBinding()
        {
            txtBoxInvoice.DataBindings.Clear();
            txtBoxCustomerName.DataBindings.Clear();
            txtBoxAddress1.DataBindings.Clear();
            txtBoxAddress2.DataBindings.Clear();
            txtBoxAddress3.DataBindings.Clear();
            txtBoxTelephone.DataBindings.Clear();
            txtBoxJumlah.DataBindings.Clear();
            txtBoxKeterangan.DataBindings.Clear();
        }

        private void MappingDataBinding()
        {
            txtBoxInvoice.DataBindings.Add("Text", bindingObjPrintKuitansiSementara, "no_invoice", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxCustomerName.DataBindings.Add("Text", bindingObjPrintKuitansiSementara, "customer_name", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxAddress1.DataBindings.Add("Text", bindingObjPrintKuitansiSementara, "address1", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxAddress2.DataBindings.Add("Text", bindingObjPrintKuitansiSementara, "address2", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxAddress3.DataBindings.Add("Text", bindingObjPrintKuitansiSementara, "address3", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxTelephone.DataBindings.Add("Text", bindingObjPrintKuitansiSementara, "telephone", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxJumlah.DataBindings.Add("Text", bindingObjPrintKuitansiSementara, "jumlah", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxKeterangan.DataBindings.Add("Text", bindingObjPrintKuitansiSementara, "keterangan", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void FormMode(clsEventButton.EnumAction ActionType)
        {
            switch (ActionType)
            {
                case clsEventButton.EnumAction.VIEW:
                    Helper.SetActive(navView);
                    pnlPrint.Show();
                    panelView.Show();
                    InitializeObject(Model);
                    break;

                case clsEventButton.EnumAction.PRINT:
                    Helper.SetActive(navPrint);
                    panelView.Hide();

                    rptARPrintKuitansiSementara report = new rptARPrintKuitansiSementara();
                    report.SetParameterValue("CompanyAddress", Model.company_address == null ? string.Empty : Model.company_address);
                    report.SetParameterValue("CompanyEmail", Model.email == null ? string.Empty : Model.email);
                    report.SetParameterValue("CompanyPhone", Model.telephone == null ? string.Empty : Model.telephone);
                    report.SetParameterValue("CompanyFax", Model.fax == null ? string.Empty : Model.fax);
                    report.SetParameterValue("EntityID", Model.entity_id == null ? string.Empty : Model.entity_id);
                    report.SetParameterValue("BranchID", Model.branch_id == null ? string.Empty : Model.branch_id);
                    report.SetParameterValue("CustomerName", Model.customer_name == null ? string.Empty : Model.customer_name);
                    report.SetParameterValue("CustomerID", Model.customer_id == null ? string.Empty : Model.customer_id);
                    report.SetParameterValue("RepID", Model.rep_id == null ? string.Empty : Model.rep_id);
                    report.SetParameterValue("RepName", Model.rep_name == null ? string.Empty : Model.rep_name);
                    report.SetParameterValue("CustomerAddress1", Model.address1 == null ? string.Empty : Model.address1);
                    report.SetParameterValue("CustomerAddress2", Model.address2 == null ? string.Empty : Model.address2);
                    report.SetParameterValue("CustomerAddress3", Model.address3 == null ? string.Empty : Model.address3);
                    report.SetParameterValue("CustomerTelephone", Model.telephone == null ? string.Empty : Model.telephone);
                    report.SetParameterValue("Jumlah", Model.jumlah == null ? string.Empty : Model.jumlah);
                    report.SetParameterValue("Keterangan", Model.keterangan == null ? string.Empty : Model.keterangan);
                    report.SetParameterValue("JumlahTerbilang", Helper.Terbilang(Convert.ToDecimal(Model.jumlah)));
                    report.SetParameterValue("NoKuitansi", Model.no_invoice == null ? string.Empty : Model.no_invoice);
                    report.SetParameterValue("BranchName", Model.branch_name == null ? string.Empty : Model.branch_name);
                    rptViewer.ReportSource = report;
                    break;
            }
        }
        #endregion
        private void AR_PrintKuitansiSementaraUI_Load(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void AR_PrintKuitansiSementaraUI_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void navView_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.VIEW);
        }

        private void navPrint_Click(object sender, EventArgs e)
        {
            FormMode(clsEventButton.EnumAction.PRINT);
        }

        private void txtBoxInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtBoxInvoice.Text))
            {
                Model = new ARPrintKuitansiSementaraBL()
                {
                    no_invoice = $"{txtBoxInvoice.Text}"
                };

                Model = AppLogic.GetData(Model);
                InitializeObject(Model);
            }
        }

        private void txtBoxJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                Alert.PushAlert("Number only", clsAlert.Type.Info);
            }
        }

        private void txtBoxJumlah_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxJumlah.Text))
            {
                string value = txtBoxJumlah.Text.Replace(",", "");
                txtBoxJumlah.Text = Convert.ToDecimal(value).ToString("#,##");
                txtBoxJumlah.Select(txtBoxJumlah.Text.Length, 0);
            }
        }
    }
}
