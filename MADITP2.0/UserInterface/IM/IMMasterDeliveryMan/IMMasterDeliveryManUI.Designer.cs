namespace MADITP2._0.UserInterface.IM.IMMasterDeliveryMan
{
    partial class IMMasterDeliveryManUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.navExport = new Tira.Component.TiraButton();
            this.navDelete = new Tira.Component.TiraButton();
            this.navEdit = new Tira.Component.TiraButton();
            this.navNew = new Tira.Component.TiraButton();
            this.navView = new Tira.Component.TiraButton();
            this.PanelFormCreate = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDelivery_man_short_name = new Tira.Component.TiraTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVehicle_police_number = new Tira.Component.TiraTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSim_number = new Tira.Component.TiraTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDelivery_man_name = new Tira.Component.TiraTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDivisionID = new Tira.Component.TiraComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBranchID = new Tira.Component.TiraComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDelivery_man_id = new Tira.Component.TiraTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEntityID = new Tira.Component.TiraComboBox();
            this.buttonCancel = new Tira.Component.TiraButton();
            this.btnSave = new Tira.Component.TiraButton();
            this.PanelFormList = new System.Windows.Forms.Panel();
            this.tiraGroupBox1 = new Tira.Component.TiraGroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSearch = new Tira.Component.TiraButton();
            this.txtFilterSearch = new Tira.Component.TiraTextBox();
            this.dgvResult = new Tira.Component.TiraDataGrid();
            this.btnPrev = new Tira.Component.TiraButton();
            this.btnNext = new Tira.Component.TiraButton();
            this.txtPagingInfo = new System.Windows.Forms.Label();
            this.Delivery_man_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_man_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entry_last_update_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbFilterDivision = new Tira.Component.TiraComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFilterBranch = new Tira.Component.TiraComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbFilterEntity = new Tira.Component.TiraComboBox();
            this.panelTopMenu.SuspendLayout();
            this.PanelFormCreate.SuspendLayout();
            this.PanelFormList.SuspendLayout();
            this.tiraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.White;
            this.panelTopMenu.Controls.Add(this.navExport);
            this.panelTopMenu.Controls.Add(this.navDelete);
            this.panelTopMenu.Controls.Add(this.navEdit);
            this.panelTopMenu.Controls.Add(this.navNew);
            this.panelTopMenu.Controls.Add(this.navView);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(800, 30);
            this.panelTopMenu.TabIndex = 488;
            // 
            // navExport
            // 
            this.navExport.BackColor = System.Drawing.SystemColors.Control;
            this.navExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.navExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.navExport.FlatAppearance.BorderSize = 0;
            this.navExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navExport.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navExport.ForeColor = System.Drawing.Color.Black;
            this.navExport.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.navExport.IconColor = System.Drawing.Color.Black;
            this.navExport.IconSize = 20;
            this.navExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navExport.Location = new System.Drawing.Point(270, 0);
            this.navExport.Name = "navExport";
            this.navExport.Rotation = 0D;
            this.navExport.Size = new System.Drawing.Size(75, 30);
            this.navExport.TabIndex = 7;
            this.navExport.Text = "Export";
            this.navExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navExport.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navExport.UseVisualStyleBackColor = false;
            this.navExport.Click += new System.EventHandler(this.navExport_Click);
            // 
            // navDelete
            // 
            this.navDelete.BackColor = System.Drawing.Color.White;
            this.navDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.navDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.navDelete.FlatAppearance.BorderSize = 0;
            this.navDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navDelete.ForeColor = System.Drawing.Color.Black;
            this.navDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.navDelete.IconColor = System.Drawing.Color.Black;
            this.navDelete.IconSize = 20;
            this.navDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navDelete.Location = new System.Drawing.Point(195, 0);
            this.navDelete.Name = "navDelete";
            this.navDelete.Rotation = 0D;
            this.navDelete.Size = new System.Drawing.Size(75, 30);
            this.navDelete.TabIndex = 4;
            this.navDelete.Text = "Delete";
            this.navDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navDelete.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navDelete.UseVisualStyleBackColor = true;
            this.navDelete.Click += new System.EventHandler(this.navDelete_Click);
            // 
            // navEdit
            // 
            this.navEdit.BackColor = System.Drawing.Color.White;
            this.navEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.navEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.navEdit.FlatAppearance.BorderSize = 0;
            this.navEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navEdit.ForeColor = System.Drawing.Color.Black;
            this.navEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.navEdit.IconColor = System.Drawing.Color.Black;
            this.navEdit.IconSize = 20;
            this.navEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navEdit.Location = new System.Drawing.Point(130, 0);
            this.navEdit.Name = "navEdit";
            this.navEdit.Rotation = 0D;
            this.navEdit.Size = new System.Drawing.Size(65, 30);
            this.navEdit.TabIndex = 3;
            this.navEdit.Text = "Edit";
            this.navEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navEdit.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navEdit.UseVisualStyleBackColor = true;
            this.navEdit.Click += new System.EventHandler(this.navEdit_Click);
            // 
            // navNew
            // 
            this.navNew.BackColor = System.Drawing.Color.White;
            this.navNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.navNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.navNew.FlatAppearance.BorderSize = 0;
            this.navNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navNew.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navNew.ForeColor = System.Drawing.Color.Black;
            this.navNew.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.navNew.IconColor = System.Drawing.Color.Black;
            this.navNew.IconSize = 20;
            this.navNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navNew.Location = new System.Drawing.Point(65, 0);
            this.navNew.Name = "navNew";
            this.navNew.Rotation = 0D;
            this.navNew.Size = new System.Drawing.Size(65, 30);
            this.navNew.TabIndex = 2;
            this.navNew.Text = "New";
            this.navNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navNew.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navNew.UseVisualStyleBackColor = true;
            this.navNew.Click += new System.EventHandler(this.navNew_Click);
            // 
            // navView
            // 
            this.navView.BackColor = System.Drawing.Color.White;
            this.navView.Dock = System.Windows.Forms.DockStyle.Left;
            this.navView.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.navView.FlatAppearance.BorderSize = 0;
            this.navView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navView.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navView.ForeColor = System.Drawing.Color.Black;
            this.navView.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.navView.IconColor = System.Drawing.Color.Black;
            this.navView.IconSize = 20;
            this.navView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navView.Location = new System.Drawing.Point(0, 0);
            this.navView.Name = "navView";
            this.navView.Rotation = 0D;
            this.navView.Size = new System.Drawing.Size(65, 30);
            this.navView.TabIndex = 1;
            this.navView.Text = "View";
            this.navView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navView.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navView.UseVisualStyleBackColor = true;
            this.navView.Click += new System.EventHandler(this.navView_Click);
            // 
            // PanelFormCreate
            // 
            this.PanelFormCreate.BackColor = System.Drawing.Color.White;
            this.PanelFormCreate.Controls.Add(this.label7);
            this.PanelFormCreate.Controls.Add(this.txtDelivery_man_short_name);
            this.PanelFormCreate.Controls.Add(this.label6);
            this.PanelFormCreate.Controls.Add(this.txtVehicle_police_number);
            this.PanelFormCreate.Controls.Add(this.label5);
            this.PanelFormCreate.Controls.Add(this.txtSim_number);
            this.PanelFormCreate.Controls.Add(this.label4);
            this.PanelFormCreate.Controls.Add(this.txtDelivery_man_name);
            this.PanelFormCreate.Controls.Add(this.label2);
            this.PanelFormCreate.Controls.Add(this.cmbDivisionID);
            this.PanelFormCreate.Controls.Add(this.label1);
            this.PanelFormCreate.Controls.Add(this.cmbBranchID);
            this.PanelFormCreate.Controls.Add(this.label3);
            this.PanelFormCreate.Controls.Add(this.txtDelivery_man_id);
            this.PanelFormCreate.Controls.Add(this.label9);
            this.PanelFormCreate.Controls.Add(this.cmbEntityID);
            this.PanelFormCreate.Controls.Add(this.buttonCancel);
            this.PanelFormCreate.Controls.Add(this.btnSave);
            this.PanelFormCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormCreate.Location = new System.Drawing.Point(0, 30);
            this.PanelFormCreate.Name = "PanelFormCreate";
            this.PanelFormCreate.Size = new System.Drawing.Size(800, 511);
            this.PanelFormCreate.TabIndex = 490;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 109;
            this.label7.Text = "Delivery Man Short Name";
            // 
            // txtDelivery_man_short_name
            // 
            this.txtDelivery_man_short_name.BackColor = System.Drawing.Color.White;
            this.txtDelivery_man_short_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDelivery_man_short_name.ForeColor = System.Drawing.Color.DimGray;
            this.txtDelivery_man_short_name.Location = new System.Drawing.Point(380, 146);
            this.txtDelivery_man_short_name.MaxLength = 40;
            this.txtDelivery_man_short_name.Name = "txtDelivery_man_short_name";
            this.txtDelivery_man_short_name.Size = new System.Drawing.Size(260, 23);
            this.txtDelivery_man_short_name.TabIndex = 108;
            this.txtDelivery_man_short_name.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtDelivery_man_short_name.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtDelivery_man_short_name.TiraMandatory = false;
            this.txtDelivery_man_short_name.TiraPlaceHolder = null;
            this.txtDelivery_man_short_name.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 107;
            this.label6.Text = "Police Number";
            // 
            // txtVehicle_police_number
            // 
            this.txtVehicle_police_number.BackColor = System.Drawing.Color.White;
            this.txtVehicle_police_number.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtVehicle_police_number.ForeColor = System.Drawing.Color.DimGray;
            this.txtVehicle_police_number.Location = new System.Drawing.Point(15, 204);
            this.txtVehicle_police_number.MaxLength = 12;
            this.txtVehicle_police_number.Name = "txtVehicle_police_number";
            this.txtVehicle_police_number.Size = new System.Drawing.Size(286, 23);
            this.txtVehicle_police_number.TabIndex = 106;
            this.txtVehicle_police_number.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtVehicle_police_number.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtVehicle_police_number.TiraMandatory = false;
            this.txtVehicle_police_number.TiraPlaceHolder = null;
            this.txtVehicle_police_number.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 105;
            this.label5.Text = "License Card No";
            // 
            // txtSim_number
            // 
            this.txtSim_number.BackColor = System.Drawing.Color.White;
            this.txtSim_number.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSim_number.ForeColor = System.Drawing.Color.DimGray;
            this.txtSim_number.Location = new System.Drawing.Point(380, 204);
            this.txtSim_number.MaxLength = 10;
            this.txtSim_number.Name = "txtSim_number";
            this.txtSim_number.Size = new System.Drawing.Size(190, 23);
            this.txtSim_number.TabIndex = 104;
            this.txtSim_number.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtSim_number.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtSim_number.TiraMandatory = false;
            this.txtSim_number.TiraPlaceHolder = null;
            this.txtSim_number.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 103;
            this.label4.Text = "Delivery Man Name";
            // 
            // txtDelivery_man_name
            // 
            this.txtDelivery_man_name.BackColor = System.Drawing.Color.White;
            this.txtDelivery_man_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDelivery_man_name.ForeColor = System.Drawing.Color.DimGray;
            this.txtDelivery_man_name.Location = new System.Drawing.Point(380, 89);
            this.txtDelivery_man_name.MaxLength = 40;
            this.txtDelivery_man_name.Name = "txtDelivery_man_name";
            this.txtDelivery_man_name.Size = new System.Drawing.Size(383, 23);
            this.txtDelivery_man_name.TabIndex = 102;
            this.txtDelivery_man_name.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtDelivery_man_name.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtDelivery_man_name.TiraMandatory = false;
            this.txtDelivery_man_name.TiraPlaceHolder = null;
            this.txtDelivery_man_name.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "Division";
            // 
            // cmbDivisionID
            // 
            this.cmbDivisionID.BackColor = System.Drawing.Color.White;
            this.cmbDivisionID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDivisionID.ForeColor = System.Drawing.Color.DimGray;
            this.cmbDivisionID.FormattingEnabled = true;
            this.cmbDivisionID.Location = new System.Drawing.Point(15, 146);
            this.cmbDivisionID.Name = "cmbDivisionID";
            this.cmbDivisionID.Size = new System.Drawing.Size(286, 23);
            this.cmbDivisionID.TabIndex = 100;
            this.cmbDivisionID.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cmbDivisionID.TiraMandatory = false;
            this.cmbDivisionID.TiraPlaceHolder = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Branch";
            // 
            // cmbBranchID
            // 
            this.cmbBranchID.BackColor = System.Drawing.Color.White;
            this.cmbBranchID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbBranchID.ForeColor = System.Drawing.Color.DimGray;
            this.cmbBranchID.FormattingEnabled = true;
            this.cmbBranchID.Location = new System.Drawing.Point(15, 89);
            this.cmbBranchID.Name = "cmbBranchID";
            this.cmbBranchID.Size = new System.Drawing.Size(286, 23);
            this.cmbBranchID.TabIndex = 98;
            this.cmbBranchID.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cmbBranchID.TiraMandatory = false;
            this.cmbBranchID.TiraPlaceHolder = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Delivery Man ID";
            // 
            // txtDelivery_man_id
            // 
            this.txtDelivery_man_id.BackColor = System.Drawing.Color.White;
            this.txtDelivery_man_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDelivery_man_id.ForeColor = System.Drawing.Color.DimGray;
            this.txtDelivery_man_id.Location = new System.Drawing.Point(380, 34);
            this.txtDelivery_man_id.MaxLength = 8;
            this.txtDelivery_man_id.Name = "txtDelivery_man_id";
            this.txtDelivery_man_id.Size = new System.Drawing.Size(190, 23);
            this.txtDelivery_man_id.TabIndex = 96;
            this.txtDelivery_man_id.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtDelivery_man_id.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtDelivery_man_id.TiraMandatory = false;
            this.txtDelivery_man_id.TiraPlaceHolder = null;
            this.txtDelivery_man_id.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Entity";
            // 
            // cmbEntityID
            // 
            this.cmbEntityID.BackColor = System.Drawing.Color.White;
            this.cmbEntityID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbEntityID.ForeColor = System.Drawing.Color.DimGray;
            this.cmbEntityID.FormattingEnabled = true;
            this.cmbEntityID.Location = new System.Drawing.Point(15, 34);
            this.cmbEntityID.Name = "cmbEntityID";
            this.cmbEntityID.Size = new System.Drawing.Size(286, 23);
            this.cmbEntityID.TabIndex = 88;
            this.cmbEntityID.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cmbEntityID.TiraMandatory = false;
            this.cmbEntityID.TiraPlaceHolder = null;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.buttonCancel.IconColor = System.Drawing.Color.Black;
            this.buttonCancel.IconSize = 20;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(624, 474);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Rotation = 0D;
            this.buttonCancel.Size = new System.Drawing.Size(70, 30);
            this.buttonCancel.TabIndex = 68;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconSize = 20;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(700, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(82, 30);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PanelFormList
            // 
            this.PanelFormList.BackColor = System.Drawing.Color.White;
            this.PanelFormList.Controls.Add(this.tiraGroupBox1);
            this.PanelFormList.Controls.Add(this.dgvResult);
            this.PanelFormList.Controls.Add(this.btnPrev);
            this.PanelFormList.Controls.Add(this.btnNext);
            this.PanelFormList.Controls.Add(this.txtPagingInfo);
            this.PanelFormList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormList.Location = new System.Drawing.Point(0, 30);
            this.PanelFormList.Name = "PanelFormList";
            this.PanelFormList.Size = new System.Drawing.Size(800, 511);
            this.PanelFormList.TabIndex = 491;
            // 
            // tiraGroupBox1
            // 
            this.tiraGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tiraGroupBox1.Controls.Add(this.label11);
            this.tiraGroupBox1.Controls.Add(this.cmbFilterEntity);
            this.tiraGroupBox1.Controls.Add(this.label10);
            this.tiraGroupBox1.Controls.Add(this.cmbFilterBranch);
            this.tiraGroupBox1.Controls.Add(this.label8);
            this.tiraGroupBox1.Controls.Add(this.cmbFilterDivision);
            this.tiraGroupBox1.Controls.Add(this.label19);
            this.tiraGroupBox1.Controls.Add(this.btnSearch);
            this.tiraGroupBox1.Controls.Add(this.txtFilterSearch);
            this.tiraGroupBox1.Location = new System.Drawing.Point(21, 6);
            this.tiraGroupBox1.Name = "tiraGroupBox1";
            this.tiraGroupBox1.Size = new System.Drawing.Size(767, 133);
            this.tiraGroupBox1.TabIndex = 5;
            this.tiraGroupBox1.TabStop = false;
            this.tiraGroupBox1.Text = "Filter";
            this.tiraGroupBox1.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.tiraGroupBox1.TiraTextColor = System.Drawing.Color.Black;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(361, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconSize = 20;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(652, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilterSearch
            // 
            this.txtFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterSearch.BackColor = System.Drawing.Color.White;
            this.txtFilterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtFilterSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtFilterSearch.Location = new System.Drawing.Point(364, 94);
            this.txtFilterSearch.MaxLength = 255;
            this.txtFilterSearch.Name = "txtFilterSearch";
            this.txtFilterSearch.Size = new System.Drawing.Size(264, 23);
            this.txtFilterSearch.TabIndex = 3;
            this.txtFilterSearch.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtFilterSearch.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtFilterSearch.TiraMandatory = false;
            this.txtFilterSearch.TiraPlaceHolder = null;
            this.txtFilterSearch.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToOrderColumns = true;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.dgvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvResult.ColumnHeadersHeight = 22;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delivery_man_id,
            this.Delivery_man_name,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Entry_last_update_date});
            this.dgvResult.EnableHeadersVisualStyles = false;
            this.dgvResult.Location = new System.Drawing.Point(22, 146);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvResult.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvResult.RowTemplate.Height = 25;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(766, 311);
            this.dgvResult.TabIndex = 4;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPrev.ForeColor = System.Drawing.Color.Black;
            this.btnPrev.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft;
            this.btnPrev.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnPrev.IconSize = 20;
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.Location = new System.Drawing.Point(722, 469);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Rotation = 0D;
            this.btnPrev.Size = new System.Drawing.Size(27, 31);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrev.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
            this.btnNext.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnNext.IconSize = 20;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(757, 470);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0D;
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 1;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtPagingInfo
            // 
            this.txtPagingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPagingInfo.AutoSize = true;
            this.txtPagingInfo.Location = new System.Drawing.Point(18, 479);
            this.txtPagingInfo.Name = "txtPagingInfo";
            this.txtPagingInfo.Size = new System.Drawing.Size(66, 13);
            this.txtPagingInfo.TabIndex = 3;
            this.txtPagingInfo.Text = "_page_info_";
            // 
            // Delivery_man_id
            // 
            this.Delivery_man_id.DataPropertyName = "Delivery_man_id";
            this.Delivery_man_id.HeaderText = "Delivery Man ID";
            this.Delivery_man_id.Name = "Delivery_man_id";
            this.Delivery_man_id.ReadOnly = true;
            this.Delivery_man_id.Width = 106;
            // 
            // Delivery_man_name
            // 
            this.Delivery_man_name.DataPropertyName = "Delivery_man_name";
            this.Delivery_man_name.HeaderText = "Delivery Man Name";
            this.Delivery_man_name.Name = "Delivery_man_name";
            this.Delivery_man_name.ReadOnly = true;
            this.Delivery_man_name.Width = 123;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Short_name";
            this.Column2.HeaderText = "Delivery Man Short name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 149;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Entity_id";
            this.Column3.HeaderText = "Entity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 56;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Branch_id";
            this.Column4.HeaderText = "Branch";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 64;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Divison_id";
            this.Column5.HeaderText = "Divison";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 65;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Sim_number";
            this.Column6.HeaderText = "License Number";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 107;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "User_id";
            this.Column7.HeaderText = "UserID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 44;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Vehicle_police_number";
            this.Column8.HeaderText = "Police Number";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 99;
            // 
            // Entry_last_update_date
            // 
            this.Entry_last_update_date.DataPropertyName = "Entry_last_update_date";
            this.Entry_last_update_date.HeaderText = "Last Update";
            this.Entry_last_update_date.Name = "Entry_last_update_date";
            this.Entry_last_update_date.ReadOnly = true;
            this.Entry_last_update_date.Width = 88;
            // 
            // cmbFilterDivision
            // 
            this.cmbFilterDivision.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFilterDivision.ForeColor = System.Drawing.Color.Black;
            this.cmbFilterDivision.FormattingEnabled = true;
            this.cmbFilterDivision.Location = new System.Drawing.Point(35, 94);
            this.cmbFilterDivision.Name = "cmbFilterDivision";
            this.cmbFilterDivision.Size = new System.Drawing.Size(280, 23);
            this.cmbFilterDivision.TabIndex = 6;
            this.cmbFilterDivision.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cmbFilterDivision.TiraMandatory = false;
            this.cmbFilterDivision.TiraPlaceHolder = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Division";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Branch";
            // 
            // cmbFilterBranch
            // 
            this.cmbFilterBranch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFilterBranch.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFilterBranch.FormattingEnabled = true;
            this.cmbFilterBranch.Location = new System.Drawing.Point(35, 40);
            this.cmbFilterBranch.Name = "cmbFilterBranch";
            this.cmbFilterBranch.Size = new System.Drawing.Size(280, 23);
            this.cmbFilterBranch.TabIndex = 8;
            this.cmbFilterBranch.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cmbFilterBranch.TiraMandatory = false;
            this.cmbFilterBranch.TiraPlaceHolder = null;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Entity";
            // 
            // cmbFilterEntity
            // 
            this.cmbFilterEntity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFilterEntity.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFilterEntity.FormattingEnabled = true;
            this.cmbFilterEntity.Location = new System.Drawing.Point(364, 40);
            this.cmbFilterEntity.Name = "cmbFilterEntity";
            this.cmbFilterEntity.Size = new System.Drawing.Size(388, 23);
            this.cmbFilterEntity.TabIndex = 10;
            this.cmbFilterEntity.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cmbFilterEntity.TiraMandatory = false;
            this.cmbFilterEntity.TiraPlaceHolder = null;
            // 
            // IMMasterDeliveryManUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.PanelFormList);
            this.Controls.Add(this.PanelFormCreate);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "IMMasterDeliveryManUI";
            this.Text = "IMMasterDeliveryManUI";
            this.Load += new System.EventHandler(this.IMMasterDeliveryManUI_Load);
            this.panelTopMenu.ResumeLayout(false);
            this.PanelFormCreate.ResumeLayout(false);
            this.PanelFormCreate.PerformLayout();
            this.PanelFormList.ResumeLayout(false);
            this.PanelFormList.PerformLayout();
            this.tiraGroupBox1.ResumeLayout(false);
            this.tiraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopMenu;
        private Tira.Component.TiraButton navExport;
        private Tira.Component.TiraButton navDelete;
        private Tira.Component.TiraButton navEdit;
        private Tira.Component.TiraButton navNew;
        private Tira.Component.TiraButton navView;
        private System.Windows.Forms.Panel PanelFormCreate;
        private System.Windows.Forms.Label label3;
        private Tira.Component.TiraTextBox txtDelivery_man_id;
        private System.Windows.Forms.Label label9;
        private Tira.Component.TiraComboBox cmbEntityID;
        private Tira.Component.TiraButton buttonCancel;
        private Tira.Component.TiraButton btnSave;
        private System.Windows.Forms.Label label2;
        private Tira.Component.TiraComboBox cmbDivisionID;
        private System.Windows.Forms.Label label1;
        private Tira.Component.TiraComboBox cmbBranchID;
        private System.Windows.Forms.Label label7;
        private Tira.Component.TiraTextBox txtDelivery_man_short_name;
        private System.Windows.Forms.Label label6;
        private Tira.Component.TiraTextBox txtVehicle_police_number;
        private System.Windows.Forms.Label label5;
        private Tira.Component.TiraTextBox txtSim_number;
        private System.Windows.Forms.Label label4;
        private Tira.Component.TiraTextBox txtDelivery_man_name;
        private System.Windows.Forms.Panel PanelFormList;
        private Tira.Component.TiraGroupBox tiraGroupBox1;
        private System.Windows.Forms.Label label19;
        private Tira.Component.TiraButton btnSearch;
        private Tira.Component.TiraTextBox txtFilterSearch;
        private Tira.Component.TiraDataGrid dgvResult;
        private Tira.Component.TiraButton btnPrev;
        private Tira.Component.TiraButton btnNext;
        private System.Windows.Forms.Label txtPagingInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_man_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_man_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entry_last_update_date;
        private System.Windows.Forms.Label label11;
        private Tira.Component.TiraComboBox cmbFilterEntity;
        private System.Windows.Forms.Label label10;
        private Tira.Component.TiraComboBox cmbFilterBranch;
        private System.Windows.Forms.Label label8;
        private Tira.Component.TiraComboBox cmbFilterDivision;
    }
}