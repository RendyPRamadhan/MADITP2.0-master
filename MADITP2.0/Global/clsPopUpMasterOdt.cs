using MADITP2._0.ApplicationLogic.RC;
using MADITP2._0.businessLogic.RC;
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
    public partial class clsPopUpMasterOdt : Form
    {
        private RCMasterODTAL Accessor;
        private clsGlobal Helper;
        private clsAlert Alert;
        private string octID;
        private string octNamaPeserta;

        public string OctID { get => octID; set => octID = value; }
        public string OctNamaPeserta { get => octNamaPeserta; set => octNamaPeserta = value; }

        public clsPopUpMasterOdt(clsGlobal helper, clsAlert alert)
        {
            InitializeComponent();
            Helper = helper;
            Alert = alert;
            Accessor = new RCMasterODTAL(Helper);
            CenterToScreen();
        }

        private void clsPopUpMasterOdt_Load(object sender, EventArgs e)
        {
            DrawDatatable();
        }

        private void DrawDatatable()
        {
            string search = "";
            if(txtSearch.Text.Length > 2)
            {
                search = txtSearch.Text;
            }

            List<RCMasterODTBL> source = Accessor.AdvanceShowList(1, 25, search);
            dgvResult.AutoGenerateColumns = false;
            dgvResult.DataSource = source;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DrawDatatable();
            }
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    OctID = dgvResult.CurrentRow.Cells["Id"].Value.ToString();
                    octNamaPeserta = dgvResult.CurrentRow.Cells["Nama_Peserta"].Value.ToString();
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OctID))
            {
                Alert.PushAlert("Please, click atleast one data from the table!", clsAlert.Type.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void clsPopUpMasterOdt_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
