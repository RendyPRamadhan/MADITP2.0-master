namespace MADITP2._0.UserInterface.IM.IMTransferType
{
    partial class IMTransferTypeUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.navExport = new Tira.Component.TiraButton();
            this.navDelete = new Tira.Component.TiraButton();
            this.navEdit = new Tira.Component.TiraButton();
            this.navNew = new Tira.Component.TiraButton();
            this.navView = new Tira.Component.TiraButton();
            this.PanelFormList = new System.Windows.Forms.Panel();
            this.tiraGroupBox1 = new Tira.Component.TiraGroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSearch = new Tira.Component.TiraButton();
            this.txtFilterSearch = new Tira.Component.TiraTextBox();
            this.dgvResult = new Tira.Component.TiraDataGrid();
            this.Transfer_txn_type_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transfer_txn_type_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txn_type_out_from_transit_ex_pod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txn_type_into_or_wh_ex_pod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrev = new Tira.Component.TiraButton();
            this.btnNext = new Tira.Component.TiraButton();
            this.txtPagingInfo = new System.Windows.Forms.Label();
            this.PanelFormCreate = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSystemType = new Tira.Component.TiraComboBox();
            this.chkConfirmTransferRequired = new Tira.Component.TiraCheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTypeInOrgExPOD = new Tira.Component.TiraTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTypeOutTransitExPOD = new Tira.Component.TiraTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTypeInDestination = new Tira.Component.TiraTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTypeOutTransit = new Tira.Component.TiraTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTypeInTransit = new Tira.Component.TiraTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTypeOutOrg = new Tira.Component.TiraTextBox();
            this.chkWithTransit = new Tira.Component.TiraCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTransferDescription = new Tira.Component.TiraTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransferTypeID = new Tira.Component.TiraTextBox();
            this.buttonCancel = new Tira.Component.TiraButton();
            this.btnSave = new Tira.Component.TiraButton();
            this.panelTopMenu.SuspendLayout();
            this.PanelFormList.SuspendLayout();
            this.tiraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.PanelFormCreate.SuspendLayout();
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
            this.panelTopMenu.Size = new System.Drawing.Size(921, 30);
            this.panelTopMenu.TabIndex = 486;
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
            this.PanelFormList.Size = new System.Drawing.Size(921, 523);
            this.PanelFormList.TabIndex = 487;
            // 
            // tiraGroupBox1
            // 
            this.tiraGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tiraGroupBox1.Controls.Add(this.label19);
            this.tiraGroupBox1.Controls.Add(this.btnSearch);
            this.tiraGroupBox1.Controls.Add(this.txtFilterSearch);
            this.tiraGroupBox1.Location = new System.Drawing.Point(21, 6);
            this.tiraGroupBox1.Name = "tiraGroupBox1";
            this.tiraGroupBox1.Size = new System.Drawing.Size(888, 82);
            this.tiraGroupBox1.TabIndex = 5;
            this.tiraGroupBox1.TabStop = false;
            this.tiraGroupBox1.Text = "Filter";
            this.tiraGroupBox1.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.tiraGroupBox1.TiraTextColor = System.Drawing.Color.Black;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 31);
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
            this.btnSearch.Location = new System.Drawing.Point(782, 50);
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
            this.txtFilterSearch.Location = new System.Drawing.Point(9, 50);
            this.txtFilterSearch.MaxLength = 255;
            this.txtFilterSearch.Name = "txtFilterSearch";
            this.txtFilterSearch.Size = new System.Drawing.Size(754, 23);
            this.txtFilterSearch.TabIndex = 3;
            this.txtFilterSearch.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtFilterSearch.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtFilterSearch.TiraMandatory = false;
            this.txtFilterSearch.TiraPlaceHolder = null;
            this.txtFilterSearch.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtFilterSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterSearch_KeyDown);
            this.txtFilterSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilterSearch_KeyUp);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToOrderColumns = true;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResult.ColumnHeadersHeight = 22;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Transfer_txn_type_code,
            this.Transfer_txn_type_description,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Txn_type_out_from_transit_ex_pod,
            this.Txn_type_into_or_wh_ex_pod});
            this.dgvResult.EnableHeadersVisualStyles = false;
            this.dgvResult.Location = new System.Drawing.Point(22, 94);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvResult.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResult.RowTemplate.Height = 25;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(887, 363);
            this.dgvResult.TabIndex = 4;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            // 
            // Transfer_txn_type_code
            // 
            this.Transfer_txn_type_code.DataPropertyName = "Transfer_txn_type_code";
            this.Transfer_txn_type_code.HeaderText = "Code";
            this.Transfer_txn_type_code.Name = "Transfer_txn_type_code";
            this.Transfer_txn_type_code.ReadOnly = true;
            this.Transfer_txn_type_code.Width = 55;
            // 
            // Transfer_txn_type_description
            // 
            this.Transfer_txn_type_description.DataPropertyName = "Transfer_txn_type_description";
            this.Transfer_txn_type_description.HeaderText = "Description";
            this.Transfer_txn_type_description.Name = "Transfer_txn_type_description";
            this.Transfer_txn_type_description.ReadOnly = true;
            this.Transfer_txn_type_description.Width = 83;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "With_transit_warehouse";
            this.Column2.HeaderText = "With Transit";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 87;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "System_type";
            this.Column3.HeaderText = "System Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 91;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Confirmation_transfer_required";
            this.Column4.HeaderText = "TF Contif Required";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 119;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Txn_type_out_from_org_wh";
            this.Column5.HeaderText = "IM Tran Type Out from Org. WH";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 182;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Txn_type_in_to_transit_wh";
            this.Column6.HeaderText = "IM Tran Type IN to Transit WH";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 177;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Txn_type_out_from_transit_wh";
            this.Column7.HeaderText = "IM Tran Type Out from Transit WH";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 175;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Txn_type_in_to_destination_wh";
            this.Column8.HeaderText = "IM Tran Type In to Destination WH";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 196;
            // 
            // Txn_type_out_from_transit_ex_pod
            // 
            this.Txn_type_out_from_transit_ex_pod.DataPropertyName = "Txn_type_out_from_transit_ex_pod";
            this.Txn_type_out_from_transit_ex_pod.HeaderText = "IM Tran Type Out from Transit Ex POD";
            this.Txn_type_out_from_transit_ex_pod.Name = "Txn_type_out_from_transit_ex_pod";
            this.Txn_type_out_from_transit_ex_pod.ReadOnly = true;
            this.Txn_type_out_from_transit_ex_pod.Width = 213;
            // 
            // Txn_type_into_or_wh_ex_pod
            // 
            this.Txn_type_into_or_wh_ex_pod.DataPropertyName = "Txn_type_into_or_wh_ex_pod";
            this.Txn_type_into_or_wh_ex_pod.HeaderText = "IM Tran Type In to Org WH ex POD";
            this.Txn_type_into_or_wh_ex_pod.Name = "Txn_type_into_or_wh_ex_pod";
            this.Txn_type_into_or_wh_ex_pod.ReadOnly = true;
            this.Txn_type_into_or_wh_ex_pod.Width = 200;
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
            this.btnPrev.Location = new System.Drawing.Point(843, 481);
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
            this.btnNext.Location = new System.Drawing.Point(878, 482);
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
            this.txtPagingInfo.Location = new System.Drawing.Point(18, 491);
            this.txtPagingInfo.Name = "txtPagingInfo";
            this.txtPagingInfo.Size = new System.Drawing.Size(66, 13);
            this.txtPagingInfo.TabIndex = 3;
            this.txtPagingInfo.Text = "_page_info_";
            // 
            // PanelFormCreate
            // 
            this.PanelFormCreate.BackColor = System.Drawing.Color.White;
            this.PanelFormCreate.Controls.Add(this.label9);
            this.PanelFormCreate.Controls.Add(this.cmbSystemType);
            this.PanelFormCreate.Controls.Add(this.chkConfirmTransferRequired);
            this.PanelFormCreate.Controls.Add(this.label7);
            this.PanelFormCreate.Controls.Add(this.txtTypeInOrgExPOD);
            this.PanelFormCreate.Controls.Add(this.label8);
            this.PanelFormCreate.Controls.Add(this.txtTypeOutTransitExPOD);
            this.PanelFormCreate.Controls.Add(this.label6);
            this.PanelFormCreate.Controls.Add(this.txtTypeInDestination);
            this.PanelFormCreate.Controls.Add(this.label5);
            this.PanelFormCreate.Controls.Add(this.txtTypeOutTransit);
            this.PanelFormCreate.Controls.Add(this.label4);
            this.PanelFormCreate.Controls.Add(this.txtTypeInTransit);
            this.PanelFormCreate.Controls.Add(this.label3);
            this.PanelFormCreate.Controls.Add(this.txtTypeOutOrg);
            this.PanelFormCreate.Controls.Add(this.chkWithTransit);
            this.PanelFormCreate.Controls.Add(this.label2);
            this.PanelFormCreate.Controls.Add(this.txtTransferDescription);
            this.PanelFormCreate.Controls.Add(this.label1);
            this.PanelFormCreate.Controls.Add(this.txtTransferTypeID);
            this.PanelFormCreate.Controls.Add(this.buttonCancel);
            this.PanelFormCreate.Controls.Add(this.btnSave);
            this.PanelFormCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormCreate.Location = new System.Drawing.Point(0, 30);
            this.PanelFormCreate.Name = "PanelFormCreate";
            this.PanelFormCreate.Size = new System.Drawing.Size(921, 523);
            this.PanelFormCreate.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "System Type";
            // 
            // cmbSystemType
            // 
            this.cmbSystemType.BackColor = System.Drawing.Color.White;
            this.cmbSystemType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSystemType.ForeColor = System.Drawing.Color.DimGray;
            this.cmbSystemType.FormattingEnabled = true;
            this.cmbSystemType.Location = new System.Drawing.Point(469, 103);
            this.cmbSystemType.Name = "cmbSystemType";
            this.cmbSystemType.Size = new System.Drawing.Size(150, 23);
            this.cmbSystemType.TabIndex = 88;
            this.cmbSystemType.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cmbSystemType.TiraMandatory = false;
            this.cmbSystemType.TiraPlaceHolder = null;
            // 
            // chkConfirmTransferRequired
            // 
            this.chkConfirmTransferRequired.Location = new System.Drawing.Point(469, 239);
            this.chkConfirmTransferRequired.Name = "chkConfirmTransferRequired";
            this.chkConfirmTransferRequired.Size = new System.Drawing.Size(186, 20);
            this.chkConfirmTransferRequired.TabIndex = 87;
            this.chkConfirmTransferRequired.Text = "Confirm Transfer Required";
            this.chkConfirmTransferRequired.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkConfirmTransferRequired.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "IM Iran Type IN to Org WH ex POD";
            // 
            // txtTypeInOrgExPOD
            // 
            this.txtTypeInOrgExPOD.BackColor = System.Drawing.Color.White;
            this.txtTypeInOrgExPOD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTypeInOrgExPOD.ForeColor = System.Drawing.Color.DimGray;
            this.txtTypeInOrgExPOD.Location = new System.Drawing.Point(249, 238);
            this.txtTypeInOrgExPOD.MaxLength = 255;
            this.txtTypeInOrgExPOD.Name = "txtTypeInOrgExPOD";
            this.txtTypeInOrgExPOD.Size = new System.Drawing.Size(150, 23);
            this.txtTypeInOrgExPOD.TabIndex = 84;
            this.txtTypeInOrgExPOD.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtTypeInOrgExPOD.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtTypeInOrgExPOD.TiraMandatory = false;
            this.txtTypeInOrgExPOD.TiraPlaceHolder = null;
            this.txtTypeInOrgExPOD.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "IM Iran Type Out From Transit ex POD";
            // 
            // txtTypeOutTransitExPOD
            // 
            this.txtTypeOutTransitExPOD.BackColor = System.Drawing.Color.White;
            this.txtTypeOutTransitExPOD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTypeOutTransitExPOD.ForeColor = System.Drawing.Color.DimGray;
            this.txtTypeOutTransitExPOD.Location = new System.Drawing.Point(12, 238);
            this.txtTypeOutTransitExPOD.MaxLength = 255;
            this.txtTypeOutTransitExPOD.Name = "txtTypeOutTransitExPOD";
            this.txtTypeOutTransitExPOD.Size = new System.Drawing.Size(150, 23);
            this.txtTypeOutTransitExPOD.TabIndex = 82;
            this.txtTypeOutTransitExPOD.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtTypeOutTransitExPOD.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtTypeOutTransitExPOD.TiraMandatory = false;
            this.txtTypeOutTransitExPOD.TiraPlaceHolder = null;
            this.txtTypeOutTransitExPOD.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "IM Iran Type IN To Destination WH";
            // 
            // txtTypeInDestination
            // 
            this.txtTypeInDestination.BackColor = System.Drawing.Color.White;
            this.txtTypeInDestination.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTypeInDestination.ForeColor = System.Drawing.Color.DimGray;
            this.txtTypeInDestination.Location = new System.Drawing.Point(249, 169);
            this.txtTypeInDestination.MaxLength = 255;
            this.txtTypeInDestination.Name = "txtTypeInDestination";
            this.txtTypeInDestination.Size = new System.Drawing.Size(150, 23);
            this.txtTypeInDestination.TabIndex = 80;
            this.txtTypeInDestination.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtTypeInDestination.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtTypeInDestination.TiraMandatory = false;
            this.txtTypeInDestination.TiraPlaceHolder = null;
            this.txtTypeInDestination.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "IM Iran Type Out From Transit WH";
            // 
            // txtTypeOutTransit
            // 
            this.txtTypeOutTransit.BackColor = System.Drawing.Color.White;
            this.txtTypeOutTransit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTypeOutTransit.ForeColor = System.Drawing.Color.DimGray;
            this.txtTypeOutTransit.Location = new System.Drawing.Point(12, 169);
            this.txtTypeOutTransit.MaxLength = 255;
            this.txtTypeOutTransit.Name = "txtTypeOutTransit";
            this.txtTypeOutTransit.Size = new System.Drawing.Size(150, 23);
            this.txtTypeOutTransit.TabIndex = 78;
            this.txtTypeOutTransit.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtTypeOutTransit.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtTypeOutTransit.TiraMandatory = false;
            this.txtTypeOutTransit.TiraPlaceHolder = null;
            this.txtTypeOutTransit.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "IM Iran Type IN To Transit WH";
            // 
            // txtTypeInTransit
            // 
            this.txtTypeInTransit.BackColor = System.Drawing.Color.White;
            this.txtTypeInTransit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTypeInTransit.ForeColor = System.Drawing.Color.DimGray;
            this.txtTypeInTransit.Location = new System.Drawing.Point(249, 103);
            this.txtTypeInTransit.MaxLength = 255;
            this.txtTypeInTransit.Name = "txtTypeInTransit";
            this.txtTypeInTransit.Size = new System.Drawing.Size(150, 23);
            this.txtTypeInTransit.TabIndex = 76;
            this.txtTypeInTransit.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtTypeInTransit.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtTypeInTransit.TiraMandatory = false;
            this.txtTypeInTransit.TiraPlaceHolder = null;
            this.txtTypeInTransit.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "IM Iran Type Out From Org. WH";
            // 
            // txtTypeOutOrg
            // 
            this.txtTypeOutOrg.BackColor = System.Drawing.Color.White;
            this.txtTypeOutOrg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTypeOutOrg.ForeColor = System.Drawing.Color.DimGray;
            this.txtTypeOutOrg.Location = new System.Drawing.Point(12, 103);
            this.txtTypeOutOrg.MaxLength = 255;
            this.txtTypeOutOrg.Name = "txtTypeOutOrg";
            this.txtTypeOutOrg.Size = new System.Drawing.Size(150, 23);
            this.txtTypeOutOrg.TabIndex = 74;
            this.txtTypeOutOrg.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtTypeOutOrg.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtTypeOutOrg.TiraMandatory = false;
            this.txtTypeOutOrg.TiraPlaceHolder = null;
            this.txtTypeOutOrg.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // chkWithTransit
            // 
            this.chkWithTransit.Location = new System.Drawing.Point(469, 170);
            this.chkWithTransit.Name = "chkWithTransit";
            this.chkWithTransit.Size = new System.Drawing.Size(186, 20);
            this.chkWithTransit.TabIndex = 73;
            this.chkWithTransit.Text = "With Transit WH";
            this.chkWithTransit.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkWithTransit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Description";
            // 
            // txtTransferDescription
            // 
            this.txtTransferDescription.BackColor = System.Drawing.Color.White;
            this.txtTransferDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTransferDescription.ForeColor = System.Drawing.Color.DimGray;
            this.txtTransferDescription.Location = new System.Drawing.Point(249, 37);
            this.txtTransferDescription.MaxLength = 255;
            this.txtTransferDescription.Name = "txtTransferDescription";
            this.txtTransferDescription.Size = new System.Drawing.Size(429, 23);
            this.txtTransferDescription.TabIndex = 71;
            this.txtTransferDescription.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtTransferDescription.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtTransferDescription.TiraMandatory = false;
            this.txtTransferDescription.TiraPlaceHolder = null;
            this.txtTransferDescription.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Transfer Type ID";
            // 
            // txtTransferTypeID
            // 
            this.txtTransferTypeID.BackColor = System.Drawing.Color.White;
            this.txtTransferTypeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTransferTypeID.ForeColor = System.Drawing.Color.DimGray;
            this.txtTransferTypeID.Location = new System.Drawing.Point(12, 37);
            this.txtTransferTypeID.MaxLength = 255;
            this.txtTransferTypeID.Name = "txtTransferTypeID";
            this.txtTransferTypeID.Size = new System.Drawing.Size(150, 23);
            this.txtTransferTypeID.TabIndex = 69;
            this.txtTransferTypeID.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtTransferTypeID.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtTransferTypeID.TiraMandatory = false;
            this.txtTransferTypeID.TiraPlaceHolder = null;
            this.txtTransferTypeID.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
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
            this.buttonCancel.Location = new System.Drawing.Point(745, 474);
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
            this.btnSave.Location = new System.Drawing.Point(821, 474);
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
            // IMTransferTypeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 553);
            this.Controls.Add(this.PanelFormCreate);
            this.Controls.Add(this.PanelFormList);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "IMTransferTypeUI";
            this.Text = "Master Transfer Type";
            this.Load += new System.EventHandler(this.IMTransferTypeUI_Load);
            this.panelTopMenu.ResumeLayout(false);
            this.PanelFormList.ResumeLayout(false);
            this.PanelFormList.PerformLayout();
            this.tiraGroupBox1.ResumeLayout(false);
            this.tiraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.PanelFormCreate.ResumeLayout(false);
            this.PanelFormCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopMenu;
        private Tira.Component.TiraButton navExport;
        private Tira.Component.TiraButton navDelete;
        private Tira.Component.TiraButton navEdit;
        private Tira.Component.TiraButton navNew;
        private Tira.Component.TiraButton navView;
        private System.Windows.Forms.Panel PanelFormList;
        private Tira.Component.TiraGroupBox tiraGroupBox1;
        private System.Windows.Forms.Label label19;
        private Tira.Component.TiraButton btnSearch;
        private Tira.Component.TiraTextBox txtFilterSearch;
        private Tira.Component.TiraDataGrid dgvResult;
        private Tira.Component.TiraButton btnPrev;
        private Tira.Component.TiraButton btnNext;
        private System.Windows.Forms.Label txtPagingInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transfer_txn_type_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transfer_txn_type_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txn_type_out_from_transit_ex_pod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txn_type_into_or_wh_ex_pod;
        private System.Windows.Forms.Panel PanelFormCreate;
        private System.Windows.Forms.Label label2;
        private Tira.Component.TiraTextBox txtTransferDescription;
        private System.Windows.Forms.Label label1;
        private Tira.Component.TiraTextBox txtTransferTypeID;
        private Tira.Component.TiraButton buttonCancel;
        private Tira.Component.TiraButton btnSave;
        private Tira.Component.TiraCheckBox chkWithTransit;
        private System.Windows.Forms.Label label6;
        private Tira.Component.TiraTextBox txtTypeInDestination;
        private System.Windows.Forms.Label label5;
        private Tira.Component.TiraTextBox txtTypeOutTransit;
        private System.Windows.Forms.Label label4;
        private Tira.Component.TiraTextBox txtTypeInTransit;
        private System.Windows.Forms.Label label3;
        private Tira.Component.TiraTextBox txtTypeOutOrg;
        private System.Windows.Forms.Label label7;
        private Tira.Component.TiraTextBox txtTypeInOrgExPOD;
        private System.Windows.Forms.Label label8;
        private Tira.Component.TiraTextBox txtTypeOutTransitExPOD;
        private Tira.Component.TiraCheckBox chkConfirmTransferRequired;
        private System.Windows.Forms.Label label9;
        private Tira.Component.TiraComboBox cmbSystemType;
    }
}