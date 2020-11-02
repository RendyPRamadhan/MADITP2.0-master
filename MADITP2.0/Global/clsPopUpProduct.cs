using MADITP2._0.ApplicationLogic.IM;
using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.DataAccess.IM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MADITP2._0.Global
{
    public partial class clsPopUpProduct : Form
    {
        private static clsGlobal Helper;
        private static clsAlert Alert;
        //private static IMMasterProductGroupAL AppLogic;
        //private static IMMasterProductGroupBL Model;
        private static IMOtherStockTransactionEntryDA DataAccess;
        public string _ProductID, _ProductDescription;

        public clsPopUpProduct(clsGlobal helper, clsAlert alert)
        {
            InitializeComponent();
            Helper = helper;
            Alert = alert;
            //AppLogic = new IMMasterProductGroupAL(Helper);
            //Model = new IMMasterProductGroupBL();
            DataAccess = new IMOtherStockTransactionEntryDA(Helper);

        }

        private void clsPopUpProduct_Load(object sender, EventArgs e)
        {
            InitializeGrid(string.Empty);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_ProductID))
            {
                Alert.PushAlert("Please, click atleast one data from the table!", clsAlert.Type.Warning);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    _ProductID = $"{dataGridProduct.CurrentRow.Cells["product_id"].Value}";
                    _ProductDescription = $"{dataGridProduct.CurrentRow.Cells["product_description"].Value}";
                }
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }


        private void navClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }


        private void txtBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            var text = txtBoxSearch.Text;
            dataGridProduct.DataSource = null;
            InitializeGrid(text);
        }

        public void InitializeGrid(string TextSearch)
        {
            try
            {
                var data = DataAccess.GetMasterProduct(TextSearch);
                dataGridProduct.AutoGenerateColumns = false;
                dataGridProduct.DataSource = data;
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message.ToString(), clsAlert.Type.Error);
            }
        }

    }
}
