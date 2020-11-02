namespace MADITP2._0.UserInterface.GS.GSFiscalCalendar
{
    partial class GS_FiscalCalendarUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelView = new System.Windows.Forms.Panel();
            this.groupBoxPaging = new Tira.Component.TiraGroupBox();
            this.lblPagingInfo = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.btnPrev = new Tira.Component.TiraButton();
            this.btnNext = new Tira.Component.TiraButton();
            this.groupBoxSearch = new Tira.Component.TiraGroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboSearchEntity = new Tira.Component.TiraComboBox();
            this.lblSearchEntity = new System.Windows.Forms.Label();
            this.cboSearchModule = new Tira.Component.TiraComboBox();
            this.lblSearchModule = new System.Windows.Forms.Label();
            this.txtBoxSearchFiscalPeriod = new Tira.Component.TiraTextBox();
            this.lblSearchFiscalPeriod = new System.Windows.Forms.Label();
            this.buttonSearch = new Tira.Component.TiraButton();
            this.dataGridFiscalCalendar = new Tira.Component.TiraDataGrid();
            this.period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.begining_period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ending_period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_of_days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.period_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actual_closed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiscal_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingObjFiscalCalendar = new System.Windows.Forms.BindingSource(this.components);
            this.cboEntity = new Tira.Component.TiraComboBox();
            this.cboModule = new Tira.Component.TiraComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxFiscalPeriod = new Tira.Component.TiraTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridFormEditor = new Tira.Component.TiraDataGrid();
            this.form_period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form_begining_date = new Tira.Component.TiraCalendarColumn();
            this.form_ending_date = new Tira.Component.TiraCalendarColumn();
            this.form_no_of_days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form_period_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelNew = new System.Windows.Forms.Panel();
            this.btnCancel = new Tira.Component.TiraButton();
            this.btnSave = new Tira.Component.TiraButton();
            this.btnUpdate = new Tira.Component.TiraButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.navClose = new Tira.Component.TiraButton();
            this.navExport = new Tira.Component.TiraButton();
            this.navPrint = new Tira.Component.TiraButton();
            this.navDelete = new Tira.Component.TiraButton();
            this.navEdit = new Tira.Component.TiraButton();
            this.navNew = new Tira.Component.TiraButton();
            this.navView = new Tira.Component.TiraButton();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.rptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panelView.SuspendLayout();
            this.groupBoxPaging.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiscalCalendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjFiscalCalendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFormEditor)).BeginInit();
            this.panelNew.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelTopMenu.SuspendLayout();
            this.pnlPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.groupBoxPaging);
            this.panelView.Controls.Add(this.groupBoxSearch);
            this.panelView.Controls.Add(this.dataGridFiscalCalendar);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1071, 604);
            this.panelView.TabIndex = 10;
            // 
            // groupBoxPaging
            // 
            this.groupBoxPaging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPaging.Controls.Add(this.lblPagingInfo);
            this.groupBoxPaging.Controls.Add(this.lblRows);
            this.groupBoxPaging.Controls.Add(this.btnPrev);
            this.groupBoxPaging.Controls.Add(this.btnNext);
            this.groupBoxPaging.Location = new System.Drawing.Point(12, 557);
            this.groupBoxPaging.Name = "groupBoxPaging";
            this.groupBoxPaging.Size = new System.Drawing.Size(1047, 35);
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
            this.btnPrev.Location = new System.Drawing.Point(975, 8);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Rotation = 0D;
            this.btnPrev.Size = new System.Drawing.Size(30, 25);
            this.btnPrev.TabIndex = 74;
            this.btnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrev.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnPrev.UseVisualStyleBackColor = false;
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
            this.btnNext.Location = new System.Drawing.Point(1011, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0D;
            this.btnNext.Size = new System.Drawing.Size(30, 25);
            this.btnNext.TabIndex = 73;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 6);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(1047, 224);
            this.groupBoxSearch.TabIndex = 3;
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
            this.tableLayoutPanel1.Controls.Add(this.lblSearchEntity, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboSearchModule, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSearchModule, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxSearchFiscalPeriod, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblSearchFiscalPeriod, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 23);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1030, 159);
            this.tableLayoutPanel1.TabIndex = 27;
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
            this.cboSearchEntity.Size = new System.Drawing.Size(1024, 23);
            this.cboSearchEntity.TabIndex = 24;
            this.cboSearchEntity.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboSearchEntity.TiraMandatory = false;
            this.cboSearchEntity.TiraPlaceHolder = "";
            // 
            // lblSearchEntity
            // 
            this.lblSearchEntity.AutoSize = true;
            this.lblSearchEntity.Location = new System.Drawing.Point(3, 0);
            this.lblSearchEntity.Name = "lblSearchEntity";
            this.lblSearchEntity.Size = new System.Drawing.Size(33, 13);
            this.lblSearchEntity.TabIndex = 27;
            this.lblSearchEntity.Text = "Entity";
            // 
            // cboSearchModule
            // 
            this.cboSearchModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchModule.BackColor = System.Drawing.Color.White;
            this.cboSearchModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboSearchModule.ForeColor = System.Drawing.Color.DimGray;
            this.cboSearchModule.FormattingEnabled = true;
            this.cboSearchModule.Location = new System.Drawing.Point(3, 72);
            this.cboSearchModule.Name = "cboSearchModule";
            this.cboSearchModule.Size = new System.Drawing.Size(1024, 23);
            this.cboSearchModule.TabIndex = 25;
            this.cboSearchModule.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboSearchModule.TiraMandatory = false;
            this.cboSearchModule.TiraPlaceHolder = "";
            // 
            // lblSearchModule
            // 
            this.lblSearchModule.AutoSize = true;
            this.lblSearchModule.Location = new System.Drawing.Point(3, 54);
            this.lblSearchModule.Name = "lblSearchModule";
            this.lblSearchModule.Size = new System.Drawing.Size(42, 13);
            this.lblSearchModule.TabIndex = 28;
            this.lblSearchModule.Text = "Module";
            // 
            // txtBoxSearchFiscalPeriod
            // 
            this.txtBoxSearchFiscalPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearchFiscalPeriod.BackColor = System.Drawing.Color.White;
            this.txtBoxSearchFiscalPeriod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxSearchFiscalPeriod.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxSearchFiscalPeriod.Location = new System.Drawing.Point(3, 126);
            this.txtBoxSearchFiscalPeriod.MaxLength = 255;
            this.txtBoxSearchFiscalPeriod.Name = "txtBoxSearchFiscalPeriod";
            this.txtBoxSearchFiscalPeriod.Size = new System.Drawing.Size(1024, 21);
            this.txtBoxSearchFiscalPeriod.TabIndex = 26;
            this.txtBoxSearchFiscalPeriod.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxSearchFiscalPeriod.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxSearchFiscalPeriod.TiraMandatory = false;
            this.txtBoxSearchFiscalPeriod.TiraPlaceHolder = "";
            this.txtBoxSearchFiscalPeriod.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // lblSearchFiscalPeriod
            // 
            this.lblSearchFiscalPeriod.AutoSize = true;
            this.lblSearchFiscalPeriod.Location = new System.Drawing.Point(3, 108);
            this.lblSearchFiscalPeriod.Name = "lblSearchFiscalPeriod";
            this.lblSearchFiscalPeriod.Size = new System.Drawing.Size(67, 13);
            this.lblSearchFiscalPeriod.TabIndex = 29;
            this.lblSearchFiscalPeriod.Text = "Fiscal Period";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonSearch.IconColor = System.Drawing.Color.White;
            this.buttonSearch.IconSize = 16;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(971, 188);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Rotation = 0D;
            this.buttonSearch.Size = new System.Drawing.Size(70, 23);
            this.buttonSearch.TabIndex = 22;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridFiscalCalendar
            // 
            this.dataGridFiscalCalendar.AllowUserToAddRows = false;
            this.dataGridFiscalCalendar.AllowUserToDeleteRows = false;
            this.dataGridFiscalCalendar.AllowUserToOrderColumns = true;
            this.dataGridFiscalCalendar.AllowUserToResizeColumns = false;
            this.dataGridFiscalCalendar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridFiscalCalendar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFiscalCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridFiscalCalendar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridFiscalCalendar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridFiscalCalendar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFiscalCalendar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridFiscalCalendar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFiscalCalendar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridFiscalCalendar.ColumnHeadersHeight = 22;
            this.dataGridFiscalCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridFiscalCalendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.period,
            this.begining_period,
            this.ending_period,
            this.no_of_days,
            this.period_status,
            this.actual_closed,
            this.group_id,
            this.fiscal_year});
            this.dataGridFiscalCalendar.EnableHeadersVisualStyles = false;
            this.dataGridFiscalCalendar.Location = new System.Drawing.Point(12, 236);
            this.dataGridFiscalCalendar.Name = "dataGridFiscalCalendar";
            this.dataGridFiscalCalendar.ReadOnly = true;
            this.dataGridFiscalCalendar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridFiscalCalendar.RowHeadersVisible = false;
            this.dataGridFiscalCalendar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridFiscalCalendar.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridFiscalCalendar.RowTemplate.Height = 25;
            this.dataGridFiscalCalendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFiscalCalendar.Size = new System.Drawing.Size(1047, 315);
            this.dataGridFiscalCalendar.TabIndex = 2;
            // 
            // period
            // 
            this.period.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.period.DataPropertyName = "period";
            this.period.HeaderText = "PERIOD";
            this.period.Name = "period";
            this.period.ReadOnly = true;
            // 
            // begining_period
            // 
            this.begining_period.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.begining_period.DataPropertyName = "begining_date";
            this.begining_period.HeaderText = "BEGIN PERIOD";
            this.begining_period.Name = "begining_period";
            this.begining_period.ReadOnly = true;
            // 
            // ending_period
            // 
            this.ending_period.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ending_period.DataPropertyName = "ending_date";
            this.ending_period.HeaderText = "END PERIOD";
            this.ending_period.Name = "ending_period";
            this.ending_period.ReadOnly = true;
            // 
            // no_of_days
            // 
            this.no_of_days.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.no_of_days.DataPropertyName = "no_of_days";
            this.no_of_days.HeaderText = "NO OF DAYS";
            this.no_of_days.Name = "no_of_days";
            this.no_of_days.ReadOnly = true;
            // 
            // period_status
            // 
            this.period_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.period_status.DataPropertyName = "period_status";
            this.period_status.HeaderText = "PERIOD STATUS";
            this.period_status.Name = "period_status";
            this.period_status.ReadOnly = true;
            // 
            // actual_closed
            // 
            this.actual_closed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.actual_closed.DataPropertyName = "actual_closed";
            this.actual_closed.HeaderText = "ACTUAL CLOSE DATE";
            this.actual_closed.Name = "actual_closed";
            this.actual_closed.ReadOnly = true;
            // 
            // group_id
            // 
            this.group_id.DataPropertyName = "group_id";
            this.group_id.HeaderText = "GROUP ID";
            this.group_id.Name = "group_id";
            this.group_id.ReadOnly = true;
            this.group_id.Visible = false;
            this.group_id.Width = 82;
            // 
            // fiscal_year
            // 
            this.fiscal_year.DataPropertyName = "fiscal_year";
            this.fiscal_year.HeaderText = "FISCAL YEAR";
            this.fiscal_year.Name = "fiscal_year";
            this.fiscal_year.ReadOnly = true;
            this.fiscal_year.Visible = false;
            this.fiscal_year.Width = 92;
            // 
            // cboEntity
            // 
            this.cboEntity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEntity.BackColor = System.Drawing.Color.White;
            this.cboEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboEntity.ForeColor = System.Drawing.Color.DimGray;
            this.cboEntity.FormattingEnabled = true;
            this.cboEntity.Location = new System.Drawing.Point(3, 18);
            this.cboEntity.Name = "cboEntity";
            this.cboEntity.Size = new System.Drawing.Size(1041, 23);
            this.cboEntity.TabIndex = 30;
            this.cboEntity.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboEntity.TiraMandatory = false;
            this.cboEntity.TiraPlaceHolder = null;
            // 
            // cboModule
            // 
            this.cboModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboModule.BackColor = System.Drawing.Color.White;
            this.cboModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboModule.ForeColor = System.Drawing.Color.DimGray;
            this.cboModule.FormattingEnabled = true;
            this.cboModule.Location = new System.Drawing.Point(3, 72);
            this.cboModule.Name = "cboModule";
            this.cboModule.Size = new System.Drawing.Size(1041, 23);
            this.cboModule.TabIndex = 31;
            this.cboModule.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboModule.TiraMandatory = false;
            this.cboModule.TiraPlaceHolder = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fiscal Period";
            // 
            // txtBoxFiscalPeriod
            // 
            this.txtBoxFiscalPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFiscalPeriod.BackColor = System.Drawing.Color.White;
            this.txtBoxFiscalPeriod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxFiscalPeriod.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxFiscalPeriod.Location = new System.Drawing.Point(3, 126);
            this.txtBoxFiscalPeriod.MaxLength = 255;
            this.txtBoxFiscalPeriod.Name = "txtBoxFiscalPeriod";
            this.txtBoxFiscalPeriod.Size = new System.Drawing.Size(1041, 23);
            this.txtBoxFiscalPeriod.TabIndex = 32;
            this.txtBoxFiscalPeriod.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxFiscalPeriod.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxFiscalPeriod.TiraMandatory = false;
            this.txtBoxFiscalPeriod.TiraPlaceHolder = null;
            this.txtBoxFiscalPeriod.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Module";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Entity";
            // 
            // dataGridFormEditor
            // 
            this.dataGridFormEditor.AllowUserToAddRows = false;
            this.dataGridFormEditor.AllowUserToDeleteRows = false;
            this.dataGridFormEditor.AllowUserToOrderColumns = true;
            this.dataGridFormEditor.AllowUserToResizeColumns = false;
            this.dataGridFormEditor.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridFormEditor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridFormEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridFormEditor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridFormEditor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridFormEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFormEditor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridFormEditor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFormEditor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridFormEditor.ColumnHeadersHeight = 22;
            this.dataGridFormEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridFormEditor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.form_period,
            this.form_begining_date,
            this.form_ending_date,
            this.form_no_of_days,
            this.form_period_status});
            this.dataGridFormEditor.EnableHeadersVisualStyles = false;
            this.dataGridFormEditor.Location = new System.Drawing.Point(12, 171);
            this.dataGridFormEditor.Name = "dataGridFormEditor";
            this.dataGridFormEditor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridFormEditor.RowHeadersVisible = false;
            this.dataGridFormEditor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridFormEditor.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridFormEditor.RowTemplate.Height = 25;
            this.dataGridFormEditor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFormEditor.Size = new System.Drawing.Size(1044, 375);
            this.dataGridFormEditor.TabIndex = 33;
            this.dataGridFormEditor.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFormEditor_CellValueChanged);
            // 
            // form_period
            // 
            this.form_period.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.form_period.DataPropertyName = "period";
            this.form_period.HeaderText = "PERIOD";
            this.form_period.Name = "form_period";
            // 
            // form_begining_date
            // 
            this.form_begining_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.form_begining_date.DataPropertyName = "begining_date";
            this.form_begining_date.HeaderText = "BEGIN PERIOD";
            this.form_begining_date.Name = "form_begining_date";
            this.form_begining_date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.form_begining_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // form_ending_date
            // 
            this.form_ending_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.form_ending_date.DataPropertyName = "ending_date";
            this.form_ending_date.HeaderText = "END PERIOD";
            this.form_ending_date.Name = "form_ending_date";
            this.form_ending_date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.form_ending_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // form_no_of_days
            // 
            this.form_no_of_days.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.form_no_of_days.DataPropertyName = "no_of_days";
            this.form_no_of_days.HeaderText = "NO OF DAYS";
            this.form_no_of_days.Name = "form_no_of_days";
            // 
            // form_period_status
            // 
            this.form_period_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.form_period_status.DataPropertyName = "period_status";
            this.form_period_status.HeaderText = "PERIOD STATUS";
            this.form_period_status.Name = "form_period_status";
            // 
            // panelNew
            // 
            this.panelNew.Controls.Add(this.panelView);
            this.panelNew.Controls.Add(this.btnCancel);
            this.panelNew.Controls.Add(this.btnSave);
            this.panelNew.Controls.Add(this.dataGridFormEditor);
            this.panelNew.Controls.Add(this.btnUpdate);
            this.panelNew.Controls.Add(this.tableLayoutPanel2);
            this.panelNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNew.Location = new System.Drawing.Point(0, 0);
            this.panelNew.Name = "panelNew";
            this.panelNew.Size = new System.Drawing.Size(1071, 604);
            this.panelNew.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnCancel.Location = new System.Drawing.Point(890, 552);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(976, 552);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnUpdate.IconColor = System.Drawing.Color.White;
            this.btnUpdate.IconSize = 20;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(976, 552);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Rotation = 0D;
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cboEntity, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtBoxFiscalPeriod, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.cboModule, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.905661F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.33962F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.132075F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.905661F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.33962F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.132075F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.905661F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.33962F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1047, 159);
            this.tableLayoutPanel2.TabIndex = 46;
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelTopMenu.Controls.Add(this.navClose);
            this.panelTopMenu.Controls.Add(this.navExport);
            this.panelTopMenu.Controls.Add(this.navPrint);
            this.panelTopMenu.Controls.Add(this.navDelete);
            this.panelTopMenu.Controls.Add(this.navEdit);
            this.panelTopMenu.Controls.Add(this.navNew);
            this.panelTopMenu.Controls.Add(this.navView);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(1071, 30);
            this.panelTopMenu.TabIndex = 12;
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
            this.navClose.Location = new System.Drawing.Point(1041, 0);
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
            this.navExport.Location = new System.Drawing.Point(335, 0);
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
            this.navPrint.Location = new System.Drawing.Point(270, 0);
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
            // navDelete
            // 
            this.navDelete.BackColor = System.Drawing.SystemColors.Control;
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
            this.navDelete.UseVisualStyleBackColor = false;
            this.navDelete.Click += new System.EventHandler(this.navDelete_Click);
            // 
            // navEdit
            // 
            this.navEdit.BackColor = System.Drawing.SystemColors.Control;
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
            this.navEdit.UseVisualStyleBackColor = false;
            this.navEdit.Click += new System.EventHandler(this.navEdit_Click);
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
            // pnlPrint
            // 
            this.pnlPrint.Controls.Add(this.panelNew);
            this.pnlPrint.Controls.Add(this.rptViewer);
            this.pnlPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrint.Location = new System.Drawing.Point(0, 30);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(1071, 604);
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
            this.rptViewer.Size = new System.Drawing.Size(1057, 529);
            this.rptViewer.TabIndex = 0;
            this.rptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // GS_FiscalCalendarUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 634);
            this.Controls.Add(this.pnlPrint);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "GS_FiscalCalendarUI";
            this.Text = "GS_FiscalCalendarUI";
            this.Load += new System.EventHandler(this.GS_FiscalCalendarUI_Load);
            this.panelView.ResumeLayout(false);
            this.groupBoxPaging.ResumeLayout(false);
            this.groupBoxPaging.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiscalCalendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjFiscalCalendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFormEditor)).EndInit();
            this.panelNew.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelTopMenu.ResumeLayout(false);
            this.pnlPrint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelView;
        private Tira.Component.TiraDataGrid dataGridFiscalCalendar;
        private Tira.Component.TiraGroupBox groupBoxSearch;
        private Tira.Component.TiraButton buttonSearch;
        private Tira.Component.TiraComboBox cboSearchModule;
        private Tira.Component.TiraComboBox cboSearchEntity;
        private Tira.Component.TiraTextBox txtBoxSearchFiscalPeriod;
        private System.Windows.Forms.BindingSource bindingObjFiscalCalendar;
        private Tira.Component.TiraComboBox cboEntity;
        private Tira.Component.TiraComboBox cboModule;
        private System.Windows.Forms.Label label3;
        private Tira.Component.TiraTextBox txtBoxFiscalPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Tira.Component.TiraDataGrid dataGridFormEditor;
        private System.Windows.Forms.Panel panelNew;
        private Tira.Component.TiraGroupBox groupBoxPaging;
        internal System.Windows.Forms.Label lblPagingInfo;
        internal System.Windows.Forms.Label lblRows;
        private Tira.Component.TiraButton btnPrev;
        private Tira.Component.TiraButton btnNext;
        private System.Windows.Forms.Panel panelTopMenu;
        private Tira.Component.TiraButton navClose;
        private Tira.Component.TiraButton navExport;
        private Tira.Component.TiraButton navPrint;
        private Tira.Component.TiraButton navDelete;
        private Tira.Component.TiraButton navEdit;
        private Tira.Component.TiraButton navNew;
        private Tira.Component.TiraButton navView;
        private Tira.Component.TiraButton btnCancel;
        private Tira.Component.TiraButton btnSave;
        private Tira.Component.TiraButton btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn period;
        private System.Windows.Forms.DataGridViewTextBoxColumn begining_period;
        private System.Windows.Forms.DataGridViewTextBoxColumn ending_period;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_of_days;
        private System.Windows.Forms.DataGridViewTextBoxColumn period_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn actual_closed;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiscal_year;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSearchEntity;
        private System.Windows.Forms.Label lblSearchModule;
        private System.Windows.Forms.Label lblSearchFiscalPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn form_period;
        private Tira.Component.TiraCalendarColumn form_begining_date;
        private Tira.Component.TiraCalendarColumn form_ending_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn form_no_of_days;
        private System.Windows.Forms.DataGridViewTextBoxColumn form_period_status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnlPrint;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewer;
    }
}