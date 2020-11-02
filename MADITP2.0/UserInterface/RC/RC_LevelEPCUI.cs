using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Contracts;
using MADITP2._0.businessLogic.RC;
using MADITP2._0.DataAccess.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;

namespace MADITP2._0.userInterface.RC
{
    public partial class RC_LevelEPCUI : Form
    {
        public static RCLevelEPCBO DataMemberVm = null;
        internal EnumState enumState;
        RCLevelEPCDA DataMemberCtrl = null;
        internal DataTable DataToExport = null;
        public RC_LevelEPCUI()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                DataMemberCtrl = new RCLevelEPCDA();
                DataToExport = new DataTable();
            }
        }

        internal void SetState(EnumState enumState)
        {
            this.enumState = enumState;
            switch (enumState)
            {
                case EnumState.Create:
                    btnSave.Text = "Save";
                    TextReadOnly(false);
                    cmbGroup.Enabled = true;
                    break;
                case EnumState.Update:
                    btnSave.Text = "Update";
                    TextReadOnly(false);
                    cmbGroup.Enabled = false;
                    break;
                case EnumState.Delete:
                    btnSave.Text = "Delete";
                    cmbGroup.Enabled = false;
                    txtPosisi.Enabled = false;
                    break;
                default:
                    this.Enabled = false;
                    break;
            }
        }
        private void TextReadOnly(bool value)
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    var txt = item as TextBox;
                    txt.ReadOnly = value;
                }
            }
        }
        private void load_LevelEPC()
        {
            try
            {
                groupBox2.Visible = false;
                DataMemberCtrl = new RCLevelEPCDA();
                var data = DataMemberCtrl.Read(EnumFilter.GET_ALL, DataMemberVm);
                dtGrid.DataSource = data;
                DataToExport = data;

            }
            catch (SystemException dex)
            {
                MessageBox.Show(dex.Message.ToString());
            }
        }

    
        public void RefreshComboBox()
        {
            try
            {
                cmbFilter.DataSource = DataMemberCtrl.GetLevelEPC();
                cmbFilter.DisplayMember = "DisplayMember";
                cmbFilter.ValueMember = "ValueMember";
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RC_LevelEPCUI_Load(object sender, EventArgs e)
        {
            load_LevelEPC();
            RefreshComboBox();
        }

        private void dtGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    dtGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    dtGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 128);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    DataMemberVm = new RCLevelEPCBO()
                    {
                        group_id = $"{dtGrid.Rows[e.RowIndex].Cells[0].Value}",
                        position_id = $"{dtGrid.Rows[e.RowIndex].Cells[1].Value}"
                    };
                    lblRepId.Text = $"Rep ID: {DataMemberVm.group_id}";
                    lblName.Text = $"Name: {DataMemberVm.position_id}";
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                DataMemberVm = new RCLevelEPCBO();
                DataMemberVm.group_id = "";
                DataMemberVm.position_id = "";
                DataMemberCtrl = new RCLevelEPCDA();
                var data = DataMemberCtrl.Read(EnumFilter.GET_ALL , DataMemberVm);
                dtGrid.DataSource = data;

                RefreshComboBox();
               
                txt_position.Text = "";
                txtPosisi.Text = "";

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataMemberCtrl = new RCLevelEPCDA();
                DataMemberVm = new RCLevelEPCBO();
                if (cmbFilter.SelectedIndex > 0 && txt_position.Text == "")
                {
                    txt_position.Text = "";

                    DataMemberVm.group_id = cmbFilter.SelectedValue.ToString();
                    DataMemberVm.position_id = "";
                    var result = DataMemberCtrl.Read(EnumFilter.GET_SEARCH_ID, DataMemberVm);
                    dtGrid.DataSource = result;
                }
                else if (cmbFilter.SelectedIndex < 1 && txt_position.Text != "")
                {
                    DataMemberVm.position_id = txt_position.Text.ToString();
                    var result = DataMemberCtrl.Read(EnumFilter.GET_SEARCH_NAME, DataMemberVm);
                    dtGrid.DataSource = result;
                }
                else if (cmbFilter.SelectedIndex > 0 && txt_position.Text != "")
                {
                    DataMemberVm.group_id = cmbFilter.SelectedValue.ToString();
                    DataMemberVm.position_id = txt_position.Text.ToString();
                    var result = DataMemberCtrl.Read(EnumFilter.GET_ID_NAME, DataMemberVm);
                    dtGrid.DataSource = result;
                }
                else
                {
                    DataMemberVm.group_id = "";
                    DataMemberVm.position_id = "";
                    var result = DataMemberCtrl.Read(EnumFilter.GET_ALL, DataMemberVm);
                    dtGrid.DataSource = result;
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataMemberCtrl = new RCLevelEPCDA();
                DataMemberVm = new RCLevelEPCBO();
                if (cmbFilter.SelectedIndex > 0)
                {
                    txt_position.Text = "";
                    
                    DataMemberVm.group_id = cmbFilter.SelectedValue.ToString();
                    DataMemberVm.position_id = "";
                    var result = DataMemberCtrl.Read(EnumFilter.GET_SEARCH_ID, DataMemberVm);
                    dtGrid.DataSource = result;
                    DataToExport = result;
                }
                else if (cmbFilter.SelectedIndex <1 && txt_position.Text!="")
                {
                    DataMemberVm.position_id = txt_position.Text.ToString();
                    var result = DataMemberCtrl.Read(EnumFilter.GET_SEARCH_NAME, DataMemberVm);
                    dtGrid.DataSource = result;
                    DataToExport = result;
                }
                else if (cmbFilter.SelectedIndex > 1 && txt_position.Text != "")
                {
                    DataMemberVm.group_id = cmbFilter.SelectedValue.ToString();
                    DataMemberVm.position_id = txt_position.Text.ToString();
                    var result = DataMemberCtrl.Read(EnumFilter.GET_ID_NAME, DataMemberVm);
                    dtGrid.DataSource = result;
                    DataToExport = result;
                }
                else
                {
                    DataMemberVm.group_id = "";
                    DataMemberVm.position_id = "";
                    var result = DataMemberCtrl.Read(EnumFilter.GET_ALL, DataMemberVm);
                    dtGrid.DataSource = result;
                    DataToExport = result;
                }
               
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        

            if (DataMemberVm == null)
            {
                MessageBox.Show("Please select at least one data in List", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
   
            }
            else
            {
                groupBox2.Visible = true;
                cmbGroup.DataSource = DataMemberCtrl.GetLevelEPC();
                cmbGroup.DisplayMember = "DisplayMember";
                cmbGroup.ValueMember = "ValueMember";

                groupBox2.Visible = true;
                SetData(DataMemberVm);
                SetState(EnumState.Delete);
            }
        }

        internal void SetData(RCLevelEPCBO dataMember)
        {
            cmbGroup.SelectedValue = dataMember.group_id;
            txtPosisi.Text = dataMember.position_id;
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
            groupBox2.Visible = false;
            
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            groupBox2.Visible = true;

            SetState(EnumState.Create);
            DataMemberVm = new RCLevelEPCBO();
            DataMemberVm = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                DataMemberCtrl = new RCLevelEPCDA();
                if (enumState == EnumState.Create)
                {
                    var DataMember = new RCLevelEPCBO()
                    {
                        group_id = $"{cmbGroup.SelectedValue}",
                        position_id = txtPosisi.Text
                      
                    };
                    DataMemberCtrl.Post(DataMember);
                }
                else if (enumState == EnumState.Update)
                {
                    var DataMember = new RCLevelEPCBO()
                    {
                        group_id = $"{cmbGroup.SelectedValue}",
                        position_id = txtPosisi.Text
                    };
                    DataMemberCtrl.Put(DataMember);
                }
                else if (enumState == EnumState.Delete)
                {
                    DataMemberCtrl.Delete($"{cmbGroup.SelectedValue}",txtPosisi.Text);
                }
                btnRefresh_Click(sender, e);
                groupBox2.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
            groupBox2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           

            if (DataMemberVm == null)
            {
                MessageBox.Show("Please select at least one data in List", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                groupBox2.Visible = true;
                cmbGroup.DataSource = DataMemberCtrl.GetLevelEPC();
                cmbGroup.DisplayMember = "DisplayMember";
                cmbGroup.ValueMember = "ValueMember";

                SetData(DataMemberVm);
                SetState(EnumState.Update);
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                clsExcel clExcel = new clsExcel();

                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        var path = fbd.SelectedPath;
                        clExcel.ExportToExcel(path, DataToExport,EnumExcel.REPORT_LEVEL_EPC);
                        MessageBox.Show("The data successfully generated..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
