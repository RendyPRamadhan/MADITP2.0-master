namespace MADITP2._0.UserInterface.SO.SOUploadResi
{
    partial class SOUploadResiUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.PanelFormCreate = new System.Windows.Forms.Panel();
            this.GroupBoxProcess = new Tira.Component.TiraGroupBox();
            this.chkAll = new Tira.Component.TiraCheckBox();
            this.groupBoxSearch = new Tira.Component.TiraGroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPaging = new Tira.Component.TiraGroupBox();
            this.lblPagingInfo = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.groupBoxSelectFile = new Tira.Component.TiraGroupBox();
            this.cmbSheet = new Tira.Component.TiraComboBox();
            this.txtSearchBankTypeID = new Tira.Component.TiraTextBox();
            this.dgvResult = new Tira.Component.TiraDataGrid();
            this.CHECK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOKP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRANCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WAREHOUSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELIVERYMEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KP_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO_INV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INV_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOSEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACT_DELIV_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOSHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EKSPEDISI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PanelFormPrint = new System.Windows.Forms.Panel();
            this.rptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnProcess = new Tira.Component.TiraButton();
            this.btnSearch = new Tira.Component.TiraButton();
            this.btnPrev = new Tira.Component.TiraButton();
            this.btnNext = new Tira.Component.TiraButton();
            this.btnSelectFile = new Tira.Component.TiraButton();
            this.navExport = new Tira.Component.TiraButton();
            this.navPrint = new Tira.Component.TiraButton();
            this.navDelete = new Tira.Component.TiraButton();
            this.navEdit = new Tira.Component.TiraButton();
            this.navNew = new Tira.Component.TiraButton();
            this.navView = new Tira.Component.TiraButton();
            this.panelTopMenu.SuspendLayout();
            this.PanelFormCreate.SuspendLayout();
            this.GroupBoxProcess.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxPaging.SuspendLayout();
            this.groupBoxSelectFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.PanelFormPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.White;
            this.panelTopMenu.Controls.Add(this.navExport);
            this.panelTopMenu.Controls.Add(this.navPrint);
            this.panelTopMenu.Controls.Add(this.navDelete);
            this.panelTopMenu.Controls.Add(this.navEdit);
            this.panelTopMenu.Controls.Add(this.navNew);
            this.panelTopMenu.Controls.Add(this.navView);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(1253, 30);
            this.panelTopMenu.TabIndex = 492;
            // 
            // PanelFormCreate
            // 
            this.PanelFormCreate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelFormCreate.Controls.Add(this.GroupBoxProcess);
            this.PanelFormCreate.Controls.Add(this.groupBoxSearch);
            this.PanelFormCreate.Controls.Add(this.groupBoxPaging);
            this.PanelFormCreate.Controls.Add(this.groupBoxSelectFile);
            this.PanelFormCreate.Controls.Add(this.dgvResult);
            this.PanelFormCreate.Location = new System.Drawing.Point(118, 91);
            this.PanelFormCreate.Name = "PanelFormCreate";
            this.PanelFormCreate.Size = new System.Drawing.Size(808, 559);
            this.PanelFormCreate.TabIndex = 493;
            // 
            // GroupBoxProcess
            // 
            this.GroupBoxProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxProcess.Controls.Add(this.btnProcess);
            this.GroupBoxProcess.Controls.Add(this.chkAll);
            this.GroupBoxProcess.Location = new System.Drawing.Point(12, 470);
            this.GroupBoxProcess.Name = "GroupBoxProcess";
            this.GroupBoxProcess.Size = new System.Drawing.Size(784, 50);
            this.GroupBoxProcess.TabIndex = 6;
            this.GroupBoxProcess.TabStop = false;
            this.GroupBoxProcess.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.GroupBoxProcess.TiraTextColor = System.Drawing.Color.Black;
            // 
            // chkAll
            // 
            this.chkAll.Location = new System.Drawing.Point(11, 17);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(100, 20);
            this.chkAll.TabIndex = 0;
            this.chkAll.Text = "Check All";
            this.chkAll.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.label3);
            this.groupBoxSearch.Controls.Add(this.dateTimePicker1);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 6);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(784, 86);
            this.groupBoxSearch.TabIndex = 3;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Filter";
            this.groupBoxSearch.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.groupBoxSearch.TiraTextColor = System.Drawing.Color.Black;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "KP Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // groupBoxPaging
            // 
            this.groupBoxPaging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPaging.Controls.Add(this.lblPagingInfo);
            this.groupBoxPaging.Controls.Add(this.lblRows);
            this.groupBoxPaging.Controls.Add(this.btnPrev);
            this.groupBoxPaging.Controls.Add(this.btnNext);
            this.groupBoxPaging.Location = new System.Drawing.Point(12, 429);
            this.groupBoxPaging.Name = "groupBoxPaging";
            this.groupBoxPaging.Size = new System.Drawing.Size(784, 35);
            this.groupBoxPaging.TabIndex = 5;
            this.groupBoxPaging.TabStop = false;
            this.groupBoxPaging.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.groupBoxPaging.TiraTextColor = System.Drawing.Color.Black;
            // 
            // lblPagingInfo
            // 
            this.lblPagingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPagingInfo.AutoSize = true;
            this.lblPagingInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagingInfo.Location = new System.Drawing.Point(8, 14);
            this.lblPagingInfo.Name = "lblPagingInfo";
            this.lblPagingInfo.Size = new System.Drawing.Size(75, 13);
            this.lblPagingInfo.TabIndex = 72;
            this.lblPagingInfo.Text = "lblPagingInfo";
            // 
            // lblRows
            // 
            this.lblRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRows.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.ForeColor = System.Drawing.Color.Black;
            this.lblRows.Location = new System.Drawing.Point(151, 14);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(106, 13);
            this.lblRows.TabIndex = 71;
            this.lblRows.Text = "Records : 0";
            this.lblRows.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBoxSelectFile
            // 
            this.groupBoxSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSelectFile.Controls.Add(this.cmbSheet);
            this.groupBoxSelectFile.Controls.Add(this.txtSearchBankTypeID);
            this.groupBoxSelectFile.Controls.Add(this.btnSelectFile);
            this.groupBoxSelectFile.Location = new System.Drawing.Point(12, 6);
            this.groupBoxSelectFile.Name = "groupBoxSelectFile";
            this.groupBoxSelectFile.Size = new System.Drawing.Size(784, 86);
            this.groupBoxSelectFile.TabIndex = 3;
            this.groupBoxSelectFile.TabStop = false;
            this.groupBoxSelectFile.Text = "Filter";
            this.groupBoxSelectFile.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.groupBoxSelectFile.TiraTextColor = System.Drawing.Color.Black;
            // 
            // cmbSheet
            // 
            this.cmbSheet.BackColor = System.Drawing.Color.White;
            this.cmbSheet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSheet.ForeColor = System.Drawing.Color.DimGray;
            this.cmbSheet.FormattingEnabled = true;
            this.cmbSheet.Location = new System.Drawing.Point(25, 35);
            this.cmbSheet.Name = "cmbSheet";
            this.cmbSheet.Size = new System.Drawing.Size(150, 23);
            this.cmbSheet.TabIndex = 27;
            this.cmbSheet.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cmbSheet.TiraMandatory = false;
            this.cmbSheet.TiraPlaceHolder = null;
            this.cmbSheet.Visible = false;
            this.cmbSheet.SelectedIndexChanged += new System.EventHandler(this.cmbSheet_SelectedIndexChanged);
            // 
            // txtSearchBankTypeID
            // 
            this.txtSearchBankTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBankTypeID.BackColor = System.Drawing.Color.White;
            this.txtSearchBankTypeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchBankTypeID.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchBankTypeID.Location = new System.Drawing.Point(25, 35);
            this.txtSearchBankTypeID.MaxLength = 255;
            this.txtSearchBankTypeID.Name = "txtSearchBankTypeID";
            this.txtSearchBankTypeID.Size = new System.Drawing.Size(623, 21);
            this.txtSearchBankTypeID.TabIndex = 26;
            this.txtSearchBankTypeID.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtSearchBankTypeID.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtSearchBankTypeID.TiraMandatory = false;
            this.txtSearchBankTypeID.TiraPlaceHolder = "";
            this.txtSearchBankTypeID.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToOrderColumns = true;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResult.ColumnHeadersHeight = 22;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHECK,
            this.NUM,
            this.NOKP,
            this.BRANCH,
            this.WAREHOUSE,
            this.DELIVERYMEN,
            this.KP_DATE,
            this.NO_INV,
            this.INV_DATE,
            this.NOSEQ,
            this.ACT_DELIV_DATE,
            this.NOSHP,
            this.RESI,
            this.EKSPEDISI});
            this.dgvResult.EnableHeadersVisualStyles = false;
            this.dgvResult.Location = new System.Drawing.Point(12, 111);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvResult.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResult.RowTemplate.Height = 25;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(784, 311);
            this.dgvResult.TabIndex = 2;
            // 
            // CHECK
            // 
            this.CHECK.DataPropertyName = "CHECK";
            this.CHECK.HeaderText = "CHECK";
            this.CHECK.Name = "CHECK";
            this.CHECK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHECK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CHECK.Width = 64;
            // 
            // NUM
            // 
            this.NUM.DataPropertyName = "NUM";
            this.NUM.HeaderText = "NO.";
            this.NUM.Name = "NUM";
            this.NUM.Width = 50;
            // 
            // NOKP
            // 
            this.NOKP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOKP.DataPropertyName = "NOKP";
            this.NOKP.HeaderText = "NOKP";
            this.NOKP.Name = "NOKP";
            // 
            // BRANCH
            // 
            this.BRANCH.HeaderText = "BRANCH";
            this.BRANCH.Name = "BRANCH";
            this.BRANCH.Width = 73;
            // 
            // WAREHOUSE
            // 
            this.WAREHOUSE.HeaderText = "WAREHOUSE";
            this.WAREHOUSE.Name = "WAREHOUSE";
            this.WAREHOUSE.Width = 98;
            // 
            // DELIVERYMEN
            // 
            this.DELIVERYMEN.HeaderText = "DELIVERYMEN";
            this.DELIVERYMEN.Name = "DELIVERYMEN";
            this.DELIVERYMEN.Width = 101;
            // 
            // KP_DATE
            // 
            this.KP_DATE.HeaderText = "KP_DATE";
            this.KP_DATE.Name = "KP_DATE";
            this.KP_DATE.Width = 73;
            // 
            // NO_INV
            // 
            this.NO_INV.HeaderText = "NO_INV";
            this.NO_INV.Name = "NO_INV";
            this.NO_INV.Width = 70;
            // 
            // INV_DATE
            // 
            this.INV_DATE.HeaderText = "INV_DATE";
            this.INV_DATE.Name = "INV_DATE";
            this.INV_DATE.Width = 79;
            // 
            // NOSEQ
            // 
            this.NOSEQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOSEQ.DataPropertyName = "NOSEQ";
            this.NOSEQ.HeaderText = "NOSEQ";
            this.NOSEQ.Name = "NOSEQ";
            // 
            // ACT_DELIV_DATE
            // 
            this.ACT_DELIV_DATE.HeaderText = "ACT_DELIV_DATE";
            this.ACT_DELIV_DATE.Name = "ACT_DELIV_DATE";
            this.ACT_DELIV_DATE.Width = 115;
            // 
            // NOSHP
            // 
            this.NOSHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOSHP.DataPropertyName = "NOSHP";
            this.NOSHP.HeaderText = "NOSHP";
            this.NOSHP.Name = "NOSHP";
            // 
            // RESI
            // 
            this.RESI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RESI.DataPropertyName = "RESI";
            this.RESI.HeaderText = "RESI";
            this.RESI.Name = "RESI";
            // 
            // EKSPEDISI
            // 
            this.EKSPEDISI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EKSPEDISI.DataPropertyName = "EKSPEDISI";
            this.EKSPEDISI.HeaderText = "EKSPEDISI";
            this.EKSPEDISI.Name = "EKSPEDISI";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PanelFormPrint
            // 
            this.PanelFormPrint.BackColor = System.Drawing.Color.White;
            this.PanelFormPrint.Controls.Add(this.rptViewer);
            this.PanelFormPrint.Location = new System.Drawing.Point(17, 212);
            this.PanelFormPrint.Name = "PanelFormPrint";
            this.PanelFormPrint.Size = new System.Drawing.Size(960, 664);
            this.PanelFormPrint.TabIndex = 507;
            // 
            // rptViewer
            // 
            this.rptViewer.ActiveViewIndex = -1;
            this.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptViewer.Location = new System.Drawing.Point(18, 25);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.Size = new System.Drawing.Size(960, 664);
            this.rptViewer.TabIndex = 0;
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnProcess.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProcess.FlatAppearance.BorderSize = 0;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnProcess.IconColor = System.Drawing.Color.White;
            this.btnProcess.IconSize = 16;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.Location = new System.Drawing.Point(695, 17);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Rotation = 0D;
            this.btnProcess.Size = new System.Drawing.Size(70, 23);
            this.btnProcess.TabIndex = 23;
            this.btnProcess.Text = "Proses";
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcess.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconSize = 16;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(738, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnPrev.Location = new System.Drawing.Point(712, 8);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Rotation = 0D;
            this.btnPrev.Size = new System.Drawing.Size(30, 25);
            this.btnPrev.TabIndex = 74;
            this.btnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrev.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnPrev.UseVisualStyleBackColor = false;
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
            this.btnNext.Location = new System.Drawing.Point(748, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0D;
            this.btnNext.Size = new System.Drawing.Size(30, 25);
            this.btnNext.TabIndex = 73;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSelectFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelectFile.FlatAppearance.BorderSize = 0;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSelectFile.ForeColor = System.Drawing.Color.White;
            this.btnSelectFile.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSelectFile.IconColor = System.Drawing.Color.White;
            this.btnSelectFile.IconSize = 16;
            this.btnSelectFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectFile.Location = new System.Drawing.Point(677, 33);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Rotation = 0D;
            this.btnSelectFile.Size = new System.Drawing.Size(88, 23);
            this.btnSelectFile.TabIndex = 22;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectFile.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // navExport
            // 
            this.navExport.BackColor = System.Drawing.Color.White;
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
            this.navExport.Location = new System.Drawing.Point(335, 0);
            this.navExport.Name = "navExport";
            this.navExport.Rotation = 0D;
            this.navExport.Size = new System.Drawing.Size(75, 30);
            this.navExport.TabIndex = 6;
            this.navExport.Text = "Export";
            this.navExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navExport.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navExport.UseVisualStyleBackColor = true;
            this.navExport.Click += new System.EventHandler(this.navExport_Click);
            // 
            // navPrint
            // 
            this.navPrint.BackColor = System.Drawing.Color.White;
            this.navPrint.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.navPrint.FlatAppearance.BorderSize = 0;
            this.navPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navPrint.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navPrint.ForeColor = System.Drawing.Color.Black;
            this.navPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.navPrint.IconColor = System.Drawing.Color.Black;
            this.navPrint.IconSize = 20;
            this.navPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navPrint.Location = new System.Drawing.Point(270, 0);
            this.navPrint.Name = "navPrint";
            this.navPrint.Rotation = 0D;
            this.navPrint.Size = new System.Drawing.Size(65, 30);
            this.navPrint.TabIndex = 5;
            this.navPrint.Text = "Print";
            this.navPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navPrint.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navPrint.UseVisualStyleBackColor = true;
            this.navPrint.Click += new System.EventHandler(this.navPrint_Click);
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
            // SOUploadResiUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 792);
            this.Controls.Add(this.PanelFormPrint);
            this.Controls.Add(this.PanelFormCreate);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "SOUploadResiUI";
            this.Text = "SOUploadResiUI";
            this.panelTopMenu.ResumeLayout(false);
            this.PanelFormCreate.ResumeLayout(false);
            this.GroupBoxProcess.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxPaging.ResumeLayout(false);
            this.groupBoxPaging.PerformLayout();
            this.groupBoxSelectFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.PanelFormPrint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTopMenu;
        private Tira.Component.TiraButton navExport;
        private Tira.Component.TiraButton navPrint;
        private Tira.Component.TiraButton navDelete;
        private Tira.Component.TiraButton navEdit;
        private Tira.Component.TiraButton navNew;
        private Tira.Component.TiraButton navView;
        private System.Windows.Forms.Panel PanelFormCreate;
        private Tira.Component.TiraGroupBox groupBoxPaging;
        internal System.Windows.Forms.Label lblPagingInfo;
        internal System.Windows.Forms.Label lblRows;
        private Tira.Component.TiraButton btnPrev;
        private Tira.Component.TiraButton btnNext;
        private Tira.Component.TiraGroupBox groupBoxSelectFile;
        private Tira.Component.TiraTextBox txtSearchBankTypeID;
        private Tira.Component.TiraButton btnSelectFile;
        private Tira.Component.TiraDataGrid dgvResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Tira.Component.TiraComboBox cmbSheet;
        private Tira.Component.TiraGroupBox GroupBoxProcess;
        private Tira.Component.TiraButton btnProcess;
        private Tira.Component.TiraCheckBox chkAll;
        private Tira.Component.TiraGroupBox groupBoxSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Tira.Component.TiraButton btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelFormPrint;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHECK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOKP;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRANCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn WAREHOUSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DELIVERYMEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KP_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO_INV;
        private System.Windows.Forms.DataGridViewTextBoxColumn INV_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOSEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACT_DELIV_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOSHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESI;
        private System.Windows.Forms.DataGridViewTextBoxColumn EKSPEDISI;
    }
}