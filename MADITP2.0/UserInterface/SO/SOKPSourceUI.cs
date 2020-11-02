using System;
using System.Windows.Forms;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.ApplicationLogic.SO;
using System.Linq;
using System.Text;

namespace MADITP2._0.UserInterface.SO
{
    public partial class SOKPSourceUI : Form
    {
        private int AppState;
        clsAlert Alert;
        clsGlobal Helper;
        SOKPSourceBL Entity;
        SOKPSourceAL Accessor;
        public SOKPSourceUI()
        {
            Alert = new clsAlert();
            Helper = new clsGlobal();
            Entity = new SOKPSourceBL();
            Accessor = new SOKPSourceAL(Helper, Alert);

            InitializeComponent();
        }

        private void SOKPSourceUI_Load(object sender, EventArgs e)
        {
            LoadData();
            ComboBoxGroup();
            navView.PerformClick();
        }

        private void navView_Click(object sender, EventArgs e)
        {
            Helper.SetActive(sender);
            panelView.BringToFront();
        }

        private void navNew_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Create);
            Helper.SetActive(sender);
            Helper.ResetAllFormControls(panelEditor);
            panelEditor.BringToFront();
            GetKpId();
        }

        private void navEdit_Click(object sender, EventArgs e)
        {
            SetState(EnumState.Update);
            Helper.SetActive(sender);
            Helper.ResetAllFormControls(panelEditor);
            panelEditor.BringToFront();

            var dt = tiraDataGrid1;
            kpId.Text = dt.CurrentRow.Cells["ks_id"].Value.ToString();
            kpDesc.Text = dt.CurrentRow.Cells["ks_source"].Value.ToString();
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            navView.PerformClick();
            Entity.ks_id = tiraDataGrid1.CurrentRow.Cells["ks_id"].Value.ToString();
            if (clsDialog.ShowDialog($"Are you sure want delete KP ID {Entity.ks_id} ?") == DialogResult.Yes)
            {
                Accessor.Delete(Entity);
                LoadData();
            }
        }

        private void navPrint_Click(object sender, EventArgs e)
        {

        }

        private void navExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Choose location";
            sfd.DefaultExt = "csv";
            sfd.FileName = "KP Source";
            sfd.ShowDialog();
            if (sfd.FileName == "")
                return;

            var sb = new StringBuilder();
            var headers = tiraDataGrid1.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in tiraDataGrid1.Rows)
                sb.AppendLine(string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(cell => "\"" + cell.Value + "\"").ToArray()));

            try
            {
                System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
            }
            catch (Exception ex)
            {
                Alert.PushAlert(ex.Message, clsAlert.Type.Error);
            }
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Entity.ks_id = kpId.Text;
            Entity.ks_source = kpDesc.Text;

            if (AppState == (int)EnumState.Create)
            {
                Accessor.Create(Entity);
                LoadData();
                navView.PerformClick();
                return;
            }

            if (AppState == (int)EnumState.Update)
            {
                Accessor.Update(Entity);
                LoadData();
                navView.PerformClick();
                return;
            }

            Alert.PushAlert("Invalid APPSTATE. Current state : " + AppState, clsAlert.Type.Error);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            navView.PerformClick();
            Helper.ResetAllFormControls(panelEditor);
        }

        private void LoadData()
        {
            tiraDataGrid1.AutoGenerateColumns = false;
            tiraDataGrid1.DataSource = Accessor.Read();
        }

        private void ComboBoxGroup()
        {
            kpGroup.DataSource = Accessor.GetSourceGroup();
            kpGroup.DisplayMember = "DisplayMember";
            kpGroup.ValueMember = "ValueMember";
        }

        private void SetState(EnumState enumState)
        {
            switch (enumState)
            {
                case EnumState.Create:
                    AppState = (int)EnumState.Create;
                    buttonSave.Text = "Save";
                    break;
                case EnumState.Update:
                    AppState = (int)EnumState.Update;
                    buttonSave.Text = "Update";
                    break;
                default:
                    AppState = 404;
                    this.Enabled = false;
                    break;
            }
        }

        private void GetKpId()
        {
            if (tiraDataGrid1.Rows.Count > 0)
            {
                int nRowIndex = tiraDataGrid1.Rows.Count - 1;
                object newID = tiraDataGrid1.Rows[nRowIndex].Cells["ks_id"].Value.ToString();
                int ID = Convert.ToInt32(newID) + 1;
                kpId.Text = ID.ToString();
            }
            else
            {
                kpId.Text = "1";
            }
        }
    }
}
