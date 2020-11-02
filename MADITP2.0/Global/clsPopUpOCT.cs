using MADITP2._0.ApplicationLogic.RC;
using MADITP2._0.businessLogic.RC;
using MADITP2._0.Enums;
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
    public partial class clsPopUpOCT : Form
    {
        private RCMasterODTAL Accessor;
        private RCRepMasterAL RepMasterAccessor;
        private clsGlobal Helper;
        private clsAlert Alert;
        private string octID;
        private string octNamaPeserta;
        private string octManagerId;
        private string octmanagerName;
        private string octRecruiterId;
        private string octRecruiterName;
        private string octBranchId;

        public clsPopUpOCT(clsGlobal helper, clsAlert alert)
        {
            InitializeComponent();

            Helper = helper;
            Alert = alert;
            Accessor = new RCMasterODTAL(Helper);
            RepMasterAccessor = new RCRepMasterAL(Helper, Alert);
        }

        public string OctID { get => octID; set => octID = value; }
        public string OctNamaPeserta { get => octNamaPeserta; set => octNamaPeserta = value; }
        public string OctManagerId { get => octManagerId; set => octManagerId = value; }
        public string OctmanagerName { get => octmanagerName; set => octmanagerName = value; }
        public string OctRecruiterId { get => octRecruiterId; set => octRecruiterId = value; }
        public string OctRecruiterName { get => octRecruiterName; set => octRecruiterName = value; }
        public string OctBranchId { get => octBranchId; set => octBranchId = value; }

        private void clsPopUpOctBA_Load(object sender, EventArgs e)
        {
            DrawDatatable();
        }

        private void DrawDatatable()
        {
            string search = "";
            if (txtSearch.Text.Length > 2)
            {
                search = txtSearch.Text;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Branch_Id");
            dt.Columns.Add("Rep_Id");
            dt.Columns.Add("Nama_Peserta");
            dt.Columns.Add("Manager_Id");
            dt.Columns.Add("Manager_Name");
            dt.Columns.Add("Recruiter_Id");
            dt.Columns.Add("Recruiter_Name");
            DataRow dr = null;
            List<RCMasterODTBL> ListMasterOdt = Accessor.AdvanceShowList(1, 25, search, OCTStatusActive.FLAG_NOT_X);
            ListMasterOdt.ForEach(delegate (RCMasterODTBL item)
            {
                dr = dt.NewRow();
                dr["Id"] = item.Id;
                dr["Branch_Id"] = item.Branch_Id;
                dr["Rep_Id"] = item.Rep_Id;
                dr["Nama_Peserta"] = item.Nama_Peserta;
                dr["Manager_Id"] = item.Manager_Id;
                dr["Manager_Name"] = item.Manager_Name;
                dr["Recruiter_Id"] = string.Empty;
                dr["Recruiter_Name"] = string.Empty;

                RCRepMasterBL RcRepMaster = RepMasterAccessor.Find(item.Rep_Id);
                if(RcRepMaster != null)
                {
                    dr["Manager_Id"] = RcRepMaster.managerId;
                    dr["Manager_Name"] = RcRepMaster.managerName;

                    RCRepMasterBL Recruiter = RepMasterAccessor.Find(RcRepMaster.recruiterId);
                    dr["Recruiter_Id"] = Recruiter.repId;
                    dr["Recruiter_Name"] = Recruiter.name;
                }

                dt.Rows.Add(dr);
            });

            dgvResult.DataSource = dt;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OctID))
            {
                Alert.PushAlert("Please, click atleast one data from the table!", clsAlert.Type.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    OctID = Helper.CastToString(dgvResult.CurrentRow.Cells["Id"].Value);
                    OctNamaPeserta = Helper.CastToString(dgvResult.CurrentRow.Cells["Nama_Peserta"].Value);
                    OctManagerId = Helper.CastToString(dgvResult.CurrentRow.Cells["Manager_Id"].Value);
                    OctmanagerName = Helper.CastToString(dgvResult.CurrentRow.Cells["Manager_Name"].Value);
                    OctRecruiterId = Helper.CastToString(dgvResult.CurrentRow.Cells["Manager_Id"].Value);
                    OctRecruiterName = Helper.CastToString(dgvResult.CurrentRow.Cells["Manager_Name"].Value);
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DrawDatatable();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && txtSearch.Text.Length == 0)
            {
                DrawDatatable(); 
            }
        }
    }
}
