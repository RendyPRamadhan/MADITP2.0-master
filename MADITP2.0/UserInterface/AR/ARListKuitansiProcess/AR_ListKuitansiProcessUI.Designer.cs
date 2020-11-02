namespace MADITP2._0.UserInterface.AR.ARKuitansiProcess
{
    partial class AR_ListKuitansiProcessUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.navClose = new Tira.Component.TiraButton();
            this.navExport = new Tira.Component.TiraButton();
            this.navPrint = new Tira.Component.TiraButton();
            this.navNew = new Tira.Component.TiraButton();
            this.navView = new Tira.Component.TiraButton();
            this.panelNew = new System.Windows.Forms.Panel();
            this.panelView = new System.Windows.Forms.Panel();
            this.dataGridPrintKuitansiProcess = new Tira.Component.TiraDataGrid();
            this.entity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_period_process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current_period_process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSearch = new Tira.Component.TiraGroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboSearchEntity = new Tira.Component.TiraComboBox();
            this.cboSearchDivision = new Tira.Component.TiraComboBox();
            this.cboSearchBranch = new Tira.Component.TiraComboBox();
            this.lblSearchEntity = new System.Windows.Forms.Label();
            this.lblSearchBranch = new System.Windows.Forms.Label();
            this.lblSearchDivision = new System.Windows.Forms.Label();
            this.btnSearch = new Tira.Component.TiraButton();
            this.groupBoxPaging = new Tira.Component.TiraGroupBox();
            this.lblPagingInfo = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.btnPrev = new Tira.Component.TiraButton();
            this.btnNext = new Tira.Component.TiraButton();
            this.progressBarProcess = new System.Windows.Forms.ProgressBar();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblMandatoryBranchID = new System.Windows.Forms.Label();
            this.lblEntity = new System.Windows.Forms.Label();
            this.btnProcess = new Tira.Component.TiraButton();
            this.btnCancel = new Tira.Component.TiraButton();
            this.cboKWPeriodYear = new Tira.Component.TiraComboBox();
            this.cboKWPeriodMonth = new Tira.Component.TiraComboBox();
            this.cboDivision = new Tira.Component.TiraComboBox();
            this.cboBranch = new Tira.Component.TiraComboBox();
            this.cboEntity = new Tira.Component.TiraComboBox();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblKWPeriod = new System.Windows.Forms.Label();
            this.GroupBoxPeriod = new Tira.Component.TiraGroupBox();
            this.RbtnCurrentPeriod = new System.Windows.Forms.RadioButton();
            this.RbtnLastPeriod = new System.Windows.Forms.RadioButton();
            this.GroupBoxUpdatePeriod = new Tira.Component.TiraGroupBox();
            this.RbtnN = new System.Windows.Forms.RadioButton();
            this.RbtnY = new System.Windows.Forms.RadioButton();
            this.lblUpdatePeriod = new System.Windows.Forms.Label();
            this.groupBoxDataTidakTerproses = new Tira.Component.TiraGroupBox();
            this.listViewTidakTerproses = new System.Windows.Forms.ListView();
            this.customer_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.so_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alasan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bindingObjPrintKuitansiProcess = new System.Windows.Forms.BindingSource(this.components);
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.rptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTopMenu.SuspendLayout();
            this.panelNew.SuspendLayout();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrintKuitansiProcess)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxPaging.SuspendLayout();
            this.GroupBoxPeriod.SuspendLayout();
            this.GroupBoxUpdatePeriod.SuspendLayout();
            this.groupBoxDataTidakTerproses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjPrintKuitansiProcess)).BeginInit();
            this.pnlPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelTopMenu.Controls.Add(this.navClose);
            this.panelTopMenu.Controls.Add(this.navExport);
            this.panelTopMenu.Controls.Add(this.navPrint);
            this.panelTopMenu.Controls.Add(this.navNew);
            this.panelTopMenu.Controls.Add(this.navView);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(1203, 30);
            this.panelTopMenu.TabIndex = 14;
            // 
            // navClose
            // 
            this.navClose.BackColor = System.Drawing.SystemColors.Control;
            this.navClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.navClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.navClose.FlatAppearance.BorderSize = 0;
            this.navClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navClose.ForeColor = System.Drawing.Color.Black;
            this.navClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.navClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navClose.IconSize = 25;
            this.navClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.navClose.Location = new System.Drawing.Point(1173, 0);
            this.navClose.Name = "navClose";
            this.navClose.Rotation = 0D;
            this.navClose.Size = new System.Drawing.Size(30, 30);
            this.navClose.TabIndex = 9;
            this.navClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navClose.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navClose.UseVisualStyleBackColor = false;
            this.navClose.Click += new System.EventHandler(this.navClose_Click);
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
            this.navExport.Location = new System.Drawing.Point(195, 0);
            this.navExport.Name = "navExport";
            this.navExport.Rotation = 0D;
            this.navExport.Size = new System.Drawing.Size(75, 30);
            this.navExport.TabIndex = 6;
            this.navExport.Text = "Export";
            this.navExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navExport.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navExport.UseVisualStyleBackColor = false;
            this.navExport.Click += new System.EventHandler(this.navExport_Click);
            // 
            // navPrint
            // 
            this.navPrint.BackColor = System.Drawing.SystemColors.Control;
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
            this.navPrint.Location = new System.Drawing.Point(130, 0);
            this.navPrint.Name = "navPrint";
            this.navPrint.Rotation = 0D;
            this.navPrint.Size = new System.Drawing.Size(65, 30);
            this.navPrint.TabIndex = 5;
            this.navPrint.Text = "Print";
            this.navPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navPrint.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.navPrint.UseVisualStyleBackColor = false;
            this.navPrint.Click += new System.EventHandler(this.navPrint_Click);
            // 
            // navNew
            // 
            this.navNew.BackColor = System.Drawing.SystemColors.Control;
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
            this.navNew.UseVisualStyleBackColor = false;
            this.navNew.Click += new System.EventHandler(this.navNew_Click);
            // 
            // navView
            // 
            this.navView.BackColor = System.Drawing.SystemColors.Control;
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
            this.navView.UseVisualStyleBackColor = false;
            this.navView.Click += new System.EventHandler(this.navView_Click);
            // 
            // panelNew
            // 
            this.panelNew.BackColor = System.Drawing.Color.White;
            this.panelNew.Controls.Add(this.panelView);
            this.panelNew.Controls.Add(this.progressBarProcess);
            this.panelNew.Controls.Add(this.lblBranch);
            this.panelNew.Controls.Add(this.lblMandatoryBranchID);
            this.panelNew.Controls.Add(this.lblEntity);
            this.panelNew.Controls.Add(this.btnProcess);
            this.panelNew.Controls.Add(this.btnCancel);
            this.panelNew.Controls.Add(this.cboKWPeriodYear);
            this.panelNew.Controls.Add(this.cboKWPeriodMonth);
            this.panelNew.Controls.Add(this.cboDivision);
            this.panelNew.Controls.Add(this.cboBranch);
            this.panelNew.Controls.Add(this.cboEntity);
            this.panelNew.Controls.Add(this.lblDivision);
            this.panelNew.Controls.Add(this.lblKWPeriod);
            this.panelNew.Controls.Add(this.GroupBoxPeriod);
            this.panelNew.Controls.Add(this.GroupBoxUpdatePeriod);
            this.panelNew.Controls.Add(this.groupBoxDataTidakTerproses);
            this.panelNew.Controls.Add(this.label1);
            this.panelNew.Controls.Add(this.label2);
            this.panelNew.Controls.Add(this.label3);
            this.panelNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNew.Location = new System.Drawing.Point(0, 0);
            this.panelNew.Name = "panelNew";
            this.panelNew.Size = new System.Drawing.Size(1203, 717);
            this.panelNew.TabIndex = 15;
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.dataGridPrintKuitansiProcess);
            this.panelView.Controls.Add(this.groupBoxSearch);
            this.panelView.Controls.Add(this.groupBoxPaging);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1203, 717);
            this.panelView.TabIndex = 12;
            // 
            // dataGridPrintKuitansiProcess
            // 
            this.dataGridPrintKuitansiProcess.AllowUserToAddRows = false;
            this.dataGridPrintKuitansiProcess.AllowUserToDeleteRows = false;
            this.dataGridPrintKuitansiProcess.AllowUserToOrderColumns = true;
            this.dataGridPrintKuitansiProcess.AllowUserToResizeColumns = false;
            this.dataGridPrintKuitansiProcess.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridPrintKuitansiProcess.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPrintKuitansiProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPrintKuitansiProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridPrintKuitansiProcess.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridPrintKuitansiProcess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPrintKuitansiProcess.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridPrintKuitansiProcess.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPrintKuitansiProcess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPrintKuitansiProcess.ColumnHeadersHeight = 22;
            this.dataGridPrintKuitansiProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridPrintKuitansiProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entity,
            this.branch,
            this.division,
            this.last_period_process,
            this.year_last,
            this.current_period_process,
            this.year_current});
            this.dataGridPrintKuitansiProcess.EnableHeadersVisualStyles = false;
            this.dataGridPrintKuitansiProcess.Location = new System.Drawing.Point(10, 240);
            this.dataGridPrintKuitansiProcess.Name = "dataGridPrintKuitansiProcess";
            this.dataGridPrintKuitansiProcess.ReadOnly = true;
            this.dataGridPrintKuitansiProcess.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridPrintKuitansiProcess.RowHeadersVisible = false;
            this.dataGridPrintKuitansiProcess.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridPrintKuitansiProcess.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridPrintKuitansiProcess.RowTemplate.Height = 25;
            this.dataGridPrintKuitansiProcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPrintKuitansiProcess.Size = new System.Drawing.Size(1181, 419);
            this.dataGridPrintKuitansiProcess.TabIndex = 11;
            // 
            // entity
            // 
            this.entity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.entity.DataPropertyName = "entity";
            this.entity.HeaderText = "ENTITY";
            this.entity.Name = "entity";
            this.entity.ReadOnly = true;
            // 
            // branch
            // 
            this.branch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.branch.DataPropertyName = "branch";
            this.branch.HeaderText = "BRANCH";
            this.branch.Name = "branch";
            this.branch.ReadOnly = true;
            // 
            // division
            // 
            this.division.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.division.DataPropertyName = "division";
            this.division.HeaderText = "DIVISION";
            this.division.Name = "division";
            this.division.ReadOnly = true;
            // 
            // last_period_process
            // 
            this.last_period_process.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.last_period_process.DataPropertyName = "last_period_process";
            this.last_period_process.HeaderText = "LAST PERIOD";
            this.last_period_process.Name = "last_period_process";
            this.last_period_process.ReadOnly = true;
            // 
            // year_last
            // 
            this.year_last.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.year_last.DataPropertyName = "year_last";
            this.year_last.HeaderText = "LAST YEAR";
            this.year_last.Name = "year_last";
            this.year_last.ReadOnly = true;
            // 
            // current_period_process
            // 
            this.current_period_process.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.current_period_process.DataPropertyName = "current_period_process";
            this.current_period_process.HeaderText = "CURRENT PERIOD";
            this.current_period_process.Name = "current_period_process";
            this.current_period_process.ReadOnly = true;
            // 
            // year_current
            // 
            this.year_current.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.year_current.DataPropertyName = "year_current";
            this.year_current.HeaderText = "CURRENT YEAR";
            this.year_current.Name = "year_current";
            this.year_current.ReadOnly = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(1175, 222);
            this.groupBoxSearch.TabIndex = 10;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Filter";
            this.groupBoxSearch.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.groupBoxSearch.TiraTextColor = System.Drawing.Color.Black;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cboSearchEntity, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboSearchDivision, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cboSearchBranch, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSearchEntity, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSearchBranch, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSearchDivision, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.905661F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.33962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.132075F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.905661F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.33962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.132075F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.905661F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.33962F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1163, 159);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // cboSearchEntity
            // 
            this.cboSearchEntity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchEntity.BackColor = System.Drawing.Color.White;
            this.cboSearchEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboSearchEntity.ForeColor = System.Drawing.Color.DimGray;
            this.cboSearchEntity.FormattingEnabled = true;
            this.cboSearchEntity.Location = new System.Drawing.Point(3, 18);
            this.cboSearchEntity.Name = "cboSearchEntity";
            this.cboSearchEntity.Size = new System.Drawing.Size(1157, 23);
            this.cboSearchEntity.TabIndex = 26;
            this.cboSearchEntity.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboSearchEntity.TiraMandatory = false;
            this.cboSearchEntity.TiraPlaceHolder = "";
            // 
            // cboSearchDivision
            // 
            this.cboSearchDivision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchDivision.BackColor = System.Drawing.Color.White;
            this.cboSearchDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboSearchDivision.ForeColor = System.Drawing.Color.DimGray;
            this.cboSearchDivision.FormattingEnabled = true;
            this.cboSearchDivision.Location = new System.Drawing.Point(3, 126);
            this.cboSearchDivision.Name = "cboSearchDivision";
            this.cboSearchDivision.Size = new System.Drawing.Size(1157, 23);
            this.cboSearchDivision.TabIndex = 28;
            this.cboSearchDivision.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboSearchDivision.TiraMandatory = false;
            this.cboSearchDivision.TiraPlaceHolder = "";
            // 
            // cboSearchBranch
            // 
            this.cboSearchBranch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchBranch.BackColor = System.Drawing.Color.White;
            this.cboSearchBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboSearchBranch.ForeColor = System.Drawing.Color.DimGray;
            this.cboSearchBranch.FormattingEnabled = true;
            this.cboSearchBranch.Location = new System.Drawing.Point(3, 72);
            this.cboSearchBranch.Name = "cboSearchBranch";
            this.cboSearchBranch.Size = new System.Drawing.Size(1157, 23);
            this.cboSearchBranch.TabIndex = 27;
            this.cboSearchBranch.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboSearchBranch.TiraMandatory = false;
            this.cboSearchBranch.TiraPlaceHolder = "";
            // 
            // lblSearchEntity
            // 
            this.lblSearchEntity.AutoSize = true;
            this.lblSearchEntity.Location = new System.Drawing.Point(3, 0);
            this.lblSearchEntity.Name = "lblSearchEntity";
            this.lblSearchEntity.Size = new System.Drawing.Size(33, 13);
            this.lblSearchEntity.TabIndex = 29;
            this.lblSearchEntity.Text = "Entity";
            // 
            // lblSearchBranch
            // 
            this.lblSearchBranch.AutoSize = true;
            this.lblSearchBranch.Location = new System.Drawing.Point(3, 54);
            this.lblSearchBranch.Name = "lblSearchBranch";
            this.lblSearchBranch.Size = new System.Drawing.Size(41, 13);
            this.lblSearchBranch.TabIndex = 30;
            this.lblSearchBranch.Text = "Branch";
            // 
            // lblSearchDivision
            // 
            this.lblSearchDivision.AutoSize = true;
            this.lblSearchDivision.Location = new System.Drawing.Point(3, 108);
            this.lblSearchDivision.Name = "lblSearchDivision";
            this.lblSearchDivision.Size = new System.Drawing.Size(44, 13);
            this.lblSearchDivision.TabIndex = 31;
            this.lblSearchDivision.Text = "Division";
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
            this.btnSearch.IconSize = 16;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(1099, 191);
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
            // groupBoxPaging
            // 
            this.groupBoxPaging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPaging.Controls.Add(this.lblPagingInfo);
            this.groupBoxPaging.Controls.Add(this.lblRows);
            this.groupBoxPaging.Controls.Add(this.btnPrev);
            this.groupBoxPaging.Controls.Add(this.btnNext);
            this.groupBoxPaging.Location = new System.Drawing.Point(16, 665);
            this.groupBoxPaging.Name = "groupBoxPaging";
            this.groupBoxPaging.Size = new System.Drawing.Size(1175, 35);
            this.groupBoxPaging.TabIndex = 4;
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
            this.btnPrev.Location = new System.Drawing.Point(1103, 8);
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
            this.btnNext.Location = new System.Drawing.Point(1139, 8);
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
            // progressBarProcess
            // 
            this.progressBarProcess.Location = new System.Drawing.Point(130, 192);
            this.progressBarProcess.Name = "progressBarProcess";
            this.progressBarProcess.Size = new System.Drawing.Size(355, 23);
            this.progressBarProcess.TabIndex = 363;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(42, 72);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(41, 13);
            this.lblBranch.TabIndex = 355;
            this.lblBranch.Text = "Branch";
            // 
            // lblMandatoryBranchID
            // 
            this.lblMandatoryBranchID.AutoSize = true;
            this.lblMandatoryBranchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMandatoryBranchID.ForeColor = System.Drawing.Color.Red;
            this.lblMandatoryBranchID.Location = new System.Drawing.Point(81, 29);
            this.lblMandatoryBranchID.Name = "lblMandatoryBranchID";
            this.lblMandatoryBranchID.Size = new System.Drawing.Size(20, 25);
            this.lblMandatoryBranchID.TabIndex = 352;
            this.lblMandatoryBranchID.Text = "*";
            // 
            // lblEntity
            // 
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(43, 35);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(33, 13);
            this.lblEntity.TabIndex = 348;
            this.lblEntity.Text = "Entity";
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnProcess.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProcess.FlatAppearance.BorderSize = 0;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnProcess.IconColor = System.Drawing.Color.White;
            this.btnProcess.IconSize = 20;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.Location = new System.Drawing.Point(405, 227);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Rotation = 0D;
            this.btnProcess.Size = new System.Drawing.Size(80, 30);
            this.btnProcess.TabIndex = 39;
            this.btnProcess.Text = "Process";
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcess.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconSize = 20;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(319, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboKWPeriodYear
            // 
            this.cboKWPeriodYear.BackColor = System.Drawing.Color.White;
            this.cboKWPeriodYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboKWPeriodYear.ForeColor = System.Drawing.Color.DimGray;
            this.cboKWPeriodYear.FormattingEnabled = true;
            this.cboKWPeriodYear.Location = new System.Drawing.Point(309, 151);
            this.cboKWPeriodYear.Name = "cboKWPeriodYear";
            this.cboKWPeriodYear.Size = new System.Drawing.Size(176, 23);
            this.cboKWPeriodYear.TabIndex = 360;
            this.cboKWPeriodYear.Text = "Year";
            this.cboKWPeriodYear.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboKWPeriodYear.TiraMandatory = false;
            this.cboKWPeriodYear.TiraPlaceHolder = "Year";
            // 
            // cboKWPeriodMonth
            // 
            this.cboKWPeriodMonth.BackColor = System.Drawing.Color.White;
            this.cboKWPeriodMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboKWPeriodMonth.ForeColor = System.Drawing.Color.DimGray;
            this.cboKWPeriodMonth.FormattingEnabled = true;
            this.cboKWPeriodMonth.Location = new System.Drawing.Point(130, 151);
            this.cboKWPeriodMonth.Name = "cboKWPeriodMonth";
            this.cboKWPeriodMonth.Size = new System.Drawing.Size(165, 23);
            this.cboKWPeriodMonth.TabIndex = 359;
            this.cboKWPeriodMonth.Text = "Month";
            this.cboKWPeriodMonth.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboKWPeriodMonth.TiraMandatory = false;
            this.cboKWPeriodMonth.TiraPlaceHolder = "Month";
            // 
            // cboDivision
            // 
            this.cboDivision.BackColor = System.Drawing.Color.White;
            this.cboDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboDivision.ForeColor = System.Drawing.Color.DimGray;
            this.cboDivision.FormattingEnabled = true;
            this.cboDivision.Location = new System.Drawing.Point(130, 94);
            this.cboDivision.Name = "cboDivision";
            this.cboDivision.Size = new System.Drawing.Size(355, 23);
            this.cboDivision.TabIndex = 358;
            this.cboDivision.Text = "Division";
            this.cboDivision.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboDivision.TiraMandatory = false;
            this.cboDivision.TiraPlaceHolder = "Division";
            // 
            // cboBranch
            // 
            this.cboBranch.BackColor = System.Drawing.Color.White;
            this.cboBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboBranch.ForeColor = System.Drawing.Color.DimGray;
            this.cboBranch.FormattingEnabled = true;
            this.cboBranch.Location = new System.Drawing.Point(130, 62);
            this.cboBranch.Name = "cboBranch";
            this.cboBranch.Size = new System.Drawing.Size(355, 23);
            this.cboBranch.TabIndex = 357;
            this.cboBranch.Text = "Branch";
            this.cboBranch.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboBranch.TiraMandatory = false;
            this.cboBranch.TiraPlaceHolder = "Branch";
            // 
            // cboEntity
            // 
            this.cboEntity.BackColor = System.Drawing.Color.White;
            this.cboEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboEntity.ForeColor = System.Drawing.Color.DimGray;
            this.cboEntity.FormattingEnabled = true;
            this.cboEntity.Location = new System.Drawing.Point(130, 29);
            this.cboEntity.Name = "cboEntity";
            this.cboEntity.Size = new System.Drawing.Size(355, 23);
            this.cboEntity.TabIndex = 356;
            this.cboEntity.Text = "Entity";
            this.cboEntity.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboEntity.TiraMandatory = false;
            this.cboEntity.TiraPlaceHolder = "Entity";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(43, 104);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 362;
            this.lblDivision.Text = "Division";
            // 
            // lblKWPeriod
            // 
            this.lblKWPeriod.AutoSize = true;
            this.lblKWPeriod.Location = new System.Drawing.Point(43, 161);
            this.lblKWPeriod.Name = "lblKWPeriod";
            this.lblKWPeriod.Size = new System.Drawing.Size(58, 13);
            this.lblKWPeriod.TabIndex = 361;
            this.lblKWPeriod.Text = "KW Period";
            // 
            // GroupBoxPeriod
            // 
            this.GroupBoxPeriod.Controls.Add(this.RbtnCurrentPeriod);
            this.GroupBoxPeriod.Controls.Add(this.RbtnLastPeriod);
            this.GroupBoxPeriod.Location = new System.Drawing.Point(45, 279);
            this.GroupBoxPeriod.Name = "GroupBoxPeriod";
            this.GroupBoxPeriod.Size = new System.Drawing.Size(200, 96);
            this.GroupBoxPeriod.TabIndex = 370;
            this.GroupBoxPeriod.TabStop = false;
            this.GroupBoxPeriod.Text = "Period";
            this.GroupBoxPeriod.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.GroupBoxPeriod.TiraTextColor = System.Drawing.Color.Black;
            this.GroupBoxPeriod.Visible = false;
            // 
            // RbtnCurrentPeriod
            // 
            this.RbtnCurrentPeriod.AutoSize = true;
            this.RbtnCurrentPeriod.Location = new System.Drawing.Point(21, 62);
            this.RbtnCurrentPeriod.Name = "RbtnCurrentPeriod";
            this.RbtnCurrentPeriod.Size = new System.Drawing.Size(92, 17);
            this.RbtnCurrentPeriod.TabIndex = 366;
            this.RbtnCurrentPeriod.Text = "Current Period";
            this.RbtnCurrentPeriod.UseVisualStyleBackColor = true;
            // 
            // RbtnLastPeriod
            // 
            this.RbtnLastPeriod.AutoSize = true;
            this.RbtnLastPeriod.Checked = true;
            this.RbtnLastPeriod.Location = new System.Drawing.Point(21, 25);
            this.RbtnLastPeriod.Name = "RbtnLastPeriod";
            this.RbtnLastPeriod.Size = new System.Drawing.Size(78, 17);
            this.RbtnLastPeriod.TabIndex = 365;
            this.RbtnLastPeriod.TabStop = true;
            this.RbtnLastPeriod.Text = "Last Period";
            this.RbtnLastPeriod.UseVisualStyleBackColor = true;
            // 
            // GroupBoxUpdatePeriod
            // 
            this.GroupBoxUpdatePeriod.Controls.Add(this.RbtnN);
            this.GroupBoxUpdatePeriod.Controls.Add(this.RbtnY);
            this.GroupBoxUpdatePeriod.Controls.Add(this.lblUpdatePeriod);
            this.GroupBoxUpdatePeriod.Location = new System.Drawing.Point(251, 279);
            this.GroupBoxUpdatePeriod.Name = "GroupBoxUpdatePeriod";
            this.GroupBoxUpdatePeriod.Size = new System.Drawing.Size(127, 96);
            this.GroupBoxUpdatePeriod.TabIndex = 371;
            this.GroupBoxUpdatePeriod.TabStop = false;
            this.GroupBoxUpdatePeriod.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.GroupBoxUpdatePeriod.TiraTextColor = System.Drawing.Color.Black;
            this.GroupBoxUpdatePeriod.Visible = false;
            // 
            // RbtnN
            // 
            this.RbtnN.AutoSize = true;
            this.RbtnN.Checked = true;
            this.RbtnN.Location = new System.Drawing.Point(58, 58);
            this.RbtnN.Name = "RbtnN";
            this.RbtnN.Size = new System.Drawing.Size(33, 17);
            this.RbtnN.TabIndex = 369;
            this.RbtnN.TabStop = true;
            this.RbtnN.Text = "N";
            this.RbtnN.UseVisualStyleBackColor = true;
            // 
            // RbtnY
            // 
            this.RbtnY.AutoSize = true;
            this.RbtnY.Location = new System.Drawing.Point(19, 58);
            this.RbtnY.Name = "RbtnY";
            this.RbtnY.Size = new System.Drawing.Size(32, 17);
            this.RbtnY.TabIndex = 368;
            this.RbtnY.Text = "Y";
            this.RbtnY.UseVisualStyleBackColor = true;
            // 
            // lblUpdatePeriod
            // 
            this.lblUpdatePeriod.AutoSize = true;
            this.lblUpdatePeriod.Location = new System.Drawing.Point(16, 28);
            this.lblUpdatePeriod.Name = "lblUpdatePeriod";
            this.lblUpdatePeriod.Size = new System.Drawing.Size(75, 13);
            this.lblUpdatePeriod.TabIndex = 367;
            this.lblUpdatePeriod.Text = "Update Period";
            // 
            // groupBoxDataTidakTerproses
            // 
            this.groupBoxDataTidakTerproses.Controls.Add(this.listViewTidakTerproses);
            this.groupBoxDataTidakTerproses.Location = new System.Drawing.Point(500, 29);
            this.groupBoxDataTidakTerproses.Name = "groupBoxDataTidakTerproses";
            this.groupBoxDataTidakTerproses.Size = new System.Drawing.Size(571, 228);
            this.groupBoxDataTidakTerproses.TabIndex = 372;
            this.groupBoxDataTidakTerproses.TabStop = false;
            this.groupBoxDataTidakTerproses.Text = "Data yang kemungkinan tidak terproses";
            this.groupBoxDataTidakTerproses.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.groupBoxDataTidakTerproses.TiraTextColor = System.Drawing.Color.Black;
            this.groupBoxDataTidakTerproses.Visible = false;
            // 
            // listViewTidakTerproses
            // 
            this.listViewTidakTerproses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTidakTerproses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.customer_id,
            this.so_number,
            this.item_number,
            this.alasan});
            this.listViewTidakTerproses.HideSelection = false;
            this.listViewTidakTerproses.Location = new System.Drawing.Point(11, 19);
            this.listViewTidakTerproses.Name = "listViewTidakTerproses";
            this.listViewTidakTerproses.Size = new System.Drawing.Size(554, 203);
            this.listViewTidakTerproses.TabIndex = 364;
            this.listViewTidakTerproses.UseCompatibleStateImageBehavior = false;
            // 
            // customer_id
            // 
            this.customer_id.Text = "CUSTOMER ID";
            this.customer_id.Width = 100;
            // 
            // so_number
            // 
            this.so_number.Text = "KP NUMBER";
            this.so_number.Width = 100;
            // 
            // item_number
            // 
            this.item_number.Text = "INVOICE NUMBER";
            this.item_number.Width = 100;
            // 
            // alasan
            // 
            this.alasan.Text = "ALASAN";
            this.alasan.Width = 200;
            // 
            // pnlPrint
            // 
            this.pnlPrint.BackColor = System.Drawing.Color.White;
            this.pnlPrint.Controls.Add(this.panelNew);
            this.pnlPrint.Controls.Add(this.rptViewer);
            this.pnlPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrint.Location = new System.Drawing.Point(0, 30);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(1203, 717);
            this.pnlPrint.TabIndex = 69;
            this.pnlPrint.Visible = false;
            // 
            // rptViewer
            // 
            this.rptViewer.ActiveViewIndex = -1;
            this.rptViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptViewer.Location = new System.Drawing.Point(7, 37);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ShowCloseButton = false;
            this.rptViewer.ShowLogo = false;
            this.rptViewer.Size = new System.Drawing.Size(1189, 672);
            this.rptViewer.TabIndex = 0;
            this.rptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(81, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 373;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(81, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 374;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(104, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 375;
            this.label3.Text = "*";
            // 
            // AR_ListKuitansiProcessUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 747);
            this.Controls.Add(this.pnlPrint);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "AR_ListKuitansiProcessUI";
            this.Text = "AR_ListKuitansiProcessUI";
            this.Load += new System.EventHandler(this.AR_PrintKuitansiProcessUI_Load);
            this.panelTopMenu.ResumeLayout(false);
            this.panelNew.ResumeLayout(false);
            this.panelNew.PerformLayout();
            this.panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrintKuitansiProcess)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxPaging.ResumeLayout(false);
            this.groupBoxPaging.PerformLayout();
            this.GroupBoxPeriod.ResumeLayout(false);
            this.GroupBoxPeriod.PerformLayout();
            this.GroupBoxUpdatePeriod.ResumeLayout(false);
            this.GroupBoxUpdatePeriod.PerformLayout();
            this.groupBoxDataTidakTerproses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjPrintKuitansiProcess)).EndInit();
            this.pnlPrint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopMenu;
        private Tira.Component.TiraButton navClose;
        private Tira.Component.TiraButton navExport;
        private Tira.Component.TiraButton navPrint;
        private Tira.Component.TiraButton navNew;
        private Tira.Component.TiraButton navView;
        private System.Windows.Forms.Panel panelNew;
        private System.Windows.Forms.Panel panelView;
        private Tira.Component.TiraDataGrid dataGridPrintKuitansiProcess;
        private Tira.Component.TiraGroupBox groupBoxSearch;
        private Tira.Component.TiraButton btnSearch;
        private Tira.Component.TiraGroupBox groupBoxPaging;
        internal System.Windows.Forms.Label lblPagingInfo;
        internal System.Windows.Forms.Label lblRows;
        private Tira.Component.TiraButton btnPrev;
        private Tira.Component.TiraButton btnNext;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblMandatoryBranchID;
        private System.Windows.Forms.Label lblEntity;
        private Tira.Component.TiraButton btnProcess;
        private Tira.Component.TiraButton btnCancel;
        private Tira.Component.TiraComboBox cboSearchDivision;
        private Tira.Component.TiraComboBox cboSearchBranch;
        private Tira.Component.TiraComboBox cboSearchEntity;
        private System.Windows.Forms.Label lblKWPeriod;
        private Tira.Component.TiraComboBox cboKWPeriodYear;
        private Tira.Component.TiraComboBox cboKWPeriodMonth;
        private Tira.Component.TiraComboBox cboDivision;
        private Tira.Component.TiraComboBox cboBranch;
        private Tira.Component.TiraComboBox cboEntity;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.DataGridViewTextBoxColumn entity;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn division;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_period_process;
        private System.Windows.Forms.DataGridViewTextBoxColumn year_last;
        private System.Windows.Forms.DataGridViewTextBoxColumn current_period_process;
        private System.Windows.Forms.DataGridViewTextBoxColumn year_current;
        private System.Windows.Forms.ProgressBar progressBarProcess;
        private System.Windows.Forms.ListView listViewTidakTerproses;
        private System.Windows.Forms.BindingSource bindingObjPrintKuitansiProcess;
        private Tira.Component.TiraGroupBox GroupBoxPeriod;
        private System.Windows.Forms.RadioButton RbtnCurrentPeriod;
        private System.Windows.Forms.RadioButton RbtnLastPeriod;
        private Tira.Component.TiraGroupBox GroupBoxUpdatePeriod;
        private System.Windows.Forms.RadioButton RbtnN;
        private System.Windows.Forms.RadioButton RbtnY;
        private System.Windows.Forms.Label lblUpdatePeriod;
        private Tira.Component.TiraGroupBox groupBoxDataTidakTerproses;
        private System.Windows.Forms.ColumnHeader customer_id;
        private System.Windows.Forms.ColumnHeader so_number;
        private System.Windows.Forms.ColumnHeader item_number;
        private System.Windows.Forms.ColumnHeader alasan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSearchEntity;
        private System.Windows.Forms.Label lblSearchBranch;
        private System.Windows.Forms.Label lblSearchDivision;
        private System.Windows.Forms.Panel pnlPrint;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}