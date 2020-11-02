using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MADITP2._0.Global;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.ApplicationLogic.SO;
using MADITP2._0.DataAccess.SO;

namespace MADITP2._0.UserInterface.SO
{
    public partial class SOKPCancelUI : Form
    {
        clsAlert Alert;
        clsGlobal Helper;
        SOKPCancelBL Entity;
        SOKPCancelAL Accessor;

        public SOKPCancelUI()
        {
            Alert = new clsAlert();
            Helper = new clsGlobal();
            Entity = new SOKPCancelBL();
            Accessor = new SOKPCancelAL(Helper, Alert);

            InitializeComponent();
        }

        private void SOKPCancelUI_Load(object sender, EventArgs e)
        {
            navView.PerformClick();
        }

        private void navView_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
        }

        private void navNew_Click(object sender, EventArgs e)
        {

        }

        private void navEdit_Click(object sender, EventArgs e)
        {

        }

        private void navDelete_Click(object sender, EventArgs e)
        {

        }

        private void navPrint_Click(object sender, EventArgs e)
        {

        }

        private void navExport_Click(object sender, EventArgs e)
        {

        }

        private void navClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textKpNumber.Text))
                Alert.PushAlert("SO / KP Number Cannot Empty", clsAlert.Type.Warning);
            else
            {
                Entity.Skh_so_kp_number = textKpNumber.Text;
                tiraDataGrid1.AutoGenerateColumns = false;
                tiraDataGrid1.DataSource = Accessor.SearchData(Entity);
                if (tiraDataGrid1.Rows.Count == 0)
                    Alert.PushAlert("Data Not Found, KP Number", clsAlert.Type.Error);
                if (tiraDataGrid1.Rows.Count > 0)
                {
                    tiraDataGrid3.AutoGenerateColumns = false;
                    tiraDataGrid3.DataSource = Accessor.ReadProduct(Entity);
                    if (tiraDataGrid3.Rows.Count == 0)
                        Alert.PushAlert("Product Not Found", clsAlert.Type.Error);

                    textEntity.Text = tiraDataGrid1.CurrentRow.Cells["entityname"].Value.ToString();
                    textBranch.Text = tiraDataGrid1.CurrentRow.Cells["branchname"].Value.ToString();
                    textDivision.Text = tiraDataGrid1.CurrentRow.Cells["divisionname"].Value.ToString();
                }
                else
                {
                    tiraDataGrid2.DataSource = null;
                    tiraDataGrid2.Rows.Clear();
                    tiraDataGrid3.DataSource = null;
                    tiraDataGrid3.Rows.Clear();
                }
            }
        }

        private void textKpNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (textKpNumber.Text.Length.Equals(0))
                    Alert.PushAlert("SO / KP Number Cannot Empty", clsAlert.Type.Warning);
                else
                    buttonSearch.PerformClick();
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            var dt = tiraDataGrid1;

            if (dt.Rows.Count == 0)
                Alert.PushAlert("Please Search Data", clsAlert.Type.Info);
            else
            {
                if (dt.SelectedRows.Count > 0)
                {
                    Entity.Skh_so_kp_number = dt.CurrentRow.Cells["skh_so_kp_number"].Value.ToString();
                    Entity.Skh_price_list_id = dt.CurrentRow.Cells["skh_price_list_id"].Value.ToString();
                    Entity.Skh_reason_type = reasonType.SelectedText;
                    Entity.Skh_reason_detail = reasonDetail.Text;
                    if (reasonType.SelectedItem == null)
                        Alert.PushAlert("Please Select Reason Type", clsAlert.Type.Info);
                    else if (String.IsNullOrEmpty(reasonDetail.Text))
                        Alert.PushAlert("Please Fill Reason Detail", clsAlert.Type.Info);
                    else
                    {
                        if (clsDialog.ShowDialog($"Are you sure want cancel KP Number {Entity.Skh_so_kp_number} ?") == DialogResult.Yes)
                        {
                            Accessor.Update(Entity);
                        }
                    }
                }
                else
                    Alert.PushAlert("Please Select Data", clsAlert.Type.Info);
            }
        }
    }
}
