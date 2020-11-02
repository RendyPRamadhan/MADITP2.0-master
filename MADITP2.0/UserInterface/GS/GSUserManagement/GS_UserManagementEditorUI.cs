using MADITP2._0.BusinessLogic.GS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MADITP2._0.userInterface.GS.GSUserManagement
{
    public partial class GS_UserManagementEditorUI : Form
    {
        private int _clicked;
        private int _EnumType;
        private string _ID;
        private GSUserManagementBL DataMemberCtrl;

        public GS_UserManagementEditorUI(int ClickedGrid, int eNumMenu, string ID)
        {
            InitializeComponent();
            DataMemberCtrl = new GSUserManagementBL();
            _clicked = ClickedGrid;
            _EnumType = eNumMenu;
            _ID = ID;
        }

        private void GS_UserManagementEditorUI_Load(object sender, EventArgs e)
        {
            if (_clicked==0)
            {
                this.Width = 338;
                this.Height = 324;
                pnlGroupUser.Visible = true;
                pnlUser.Visible = false;
                txtGroupID.Text = "";
                txtGroupDescription.Text = "";

                if (_EnumType==0)
                {
                    txtGroupID.Enabled = true;
                    txtGroupDescription.Enabled = true;
                    label3.Text = label3.Text.ToString().Trim() + " - New";
                }
                if(_EnumType == 1)
                {
                    label3.Text = label3.Text.ToString().Trim() + " - Edit";
                    txtGroupID.Enabled = false;
                    txtGroupDescription.Enabled = true;
                    txtGroupID.Text = _ID;
                    //DataTable dtDesc = DataMemberCtrl.GroupDesc(_ID);

                    //foreach (DataRow dr in dtDesc.Rows)
                    //{
                    //    txtGroupDescription.Text = dr["gug_group_desc"].ToString().Trim();
                    //}
                }
            }
            else
            {
                this.Width = 580;
                this.Height = 503;
                pnlUser.Visible = true;
                pnlGroupUser.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_clicked == 0)
            {

            }
             this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
