using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MADITP2._0.ApplicationLogic.CB;
using MADITP2._0.Global;
using MADITP2._0.BusinessLogic.CB;

namespace MADITP2._0.UserControls
{
    public partial class UCCBOtherDoc : UserControl
    {
        clsGlobal Helper;
        //clsAlert clsAlert;
        CBOtherDocsAL CBOtherDocsAL;
        public enum ePrintDoc { eAll = 0, ePayment = 1, eReceipt = 2, eVoided = 3, eNotVoided = 4 };
        private bool _IsLoad;
        private string _FiscalYear;

        public UCCBOtherDoc()
        {
            InitializeComponent();
            Helper = new clsGlobal();
            CBOtherDocsAL = new CBOtherDocsAL(Helper);
        }

        internal void loadForm()
        {


            loadDataComboBox();

            lblBankIDInfo.Text = string.Empty;
            lblBankAccountInfo.Text = string.Empty;
            lblVoucherTypeInfo.Text = string.Empty;


        }

        private void loadDataComboBox()
        {
            _IsLoad = true;

            //LOAD BANK ID
            cboBankID.DataSource = CBOtherDocsAL.GetBankToComboBox(true);
            cboBankID.ValueMember = "DisplayMember";
            cboBankID.DisplayMember = "ValueMember";
            cboBankID.SelectedIndex = 0;

            //LOAD BANK ACCOUNT
            loadBankAccount();

            //LOAD VOUCHER TYPE
            cboVoucherType.DataSource = CBOtherDocsAL.GetVoucherTypeToComboBox(true);
            cboVoucherType.ValueMember = "DisplayMember";
            cboVoucherType.DisplayMember = "ValueMember";
            cboVoucherType.SelectedIndex = 0;

            //LOAD RECEIPT
            cboReceipt.Items.Clear();
            cboReceipt.Items.Add("Payment");
            cboReceipt.Items.Add("Receipt");
            cboReceipt.Items.Add("Voided");
            cboReceipt.Items.Add("Not Voided");
            cboReceipt.SelectedIndex = 0;

            _IsLoad = false;
        }

        private void loadBankAccount()
        {
            cboBankAccount.DataSource = CBOtherDocsAL.GetBankSubIDToComboBox(true, cboBankID.Text.Trim());
            cboBankAccount.ValueMember = "DisplayMember";
            cboBankAccount.DisplayMember = "ValueMember";
            cboBankAccount.SelectedIndex = 0;
        }

        public void _ShowDoc(ePrintDoc ePrintDoc)
        {
            switch (ePrintDoc)
            {
                case ePrintDoc.ePayment:
                    cboReceipt.SelectedIndex = 0;
                    cboReceipt.Enabled = false;

                    break;
                case ePrintDoc.eReceipt:
                    cboReceipt.SelectedIndex = 1;
                    cboReceipt.Enabled = false;

                    break;
                case ePrintDoc.eVoided:
                    cboReceipt.SelectedIndex = 2;
                    cboReceipt.Enabled = false;

                    break;
                case ePrintDoc.eNotVoided:
                    cboReceipt.SelectedIndex = 3;
                    cboReceipt.Enabled = false;

                    break;
                default:
                    cboReceipt.SelectedIndex = 0;
                    cboReceipt.Enabled = true;

                    break;
            }
        }

        private void UCCBOtherDoc_Load(object sender, EventArgs e)
        {

        }

        private void cboBankID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_IsLoad == false)
            {
                lblBankIDInfo.Text = string.Empty;
                lblBankAccountInfo.Text = string.Empty;

                loadBankAccount();

                lblBankIDInfo.Text = cboBankID.SelectedValue.ToString();
                cboBankAccount.Text = cboBankID.SelectedValue.ToString();
            }
        }

        private void cboBankAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_IsLoad == false)
            {
                lblBankAccountInfo.Text = cboBankAccount.SelectedValue.ToString();
            }
        }

        private void cboVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_IsLoad == false)
            {
                lblVoucherTypeInfo.Text = cboVoucherType.SelectedValue.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
