namespace MADITP2._0.UserInterface.AR.ARListKuitansiSlipUnprocessAll
{
    partial class AR_ListKuitansiSlipUnprocessAllUI
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
            this.navView = new Tira.Component.TiraButton();
            this.panelView = new System.Windows.Forms.Panel();
            this.groupBoxPaging = new Tira.Component.TiraGroupBox();
            this.lblPagingInfo = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.btnPrev = new Tira.Component.TiraButton();
            this.btnNext = new Tira.Component.TiraButton();
            this.groupBoxSearch = new Tira.Component.TiraGroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSearchBranch = new Tira.Component.TiraComboBox();
            this.cboSearchDivision = new Tira.Component.TiraComboBox();
            this.txtBoxSearchInvoiceNo = new Tira.Component.TiraTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxSearchKpNo = new Tira.Component.TiraTextBox();
            this.btnProcess = new Tira.Component.TiraButton();
            this.cbCheckAll = new Tira.Component.TiraCheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboSearchEntity = new Tira.Component.TiraComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSearchYear = new Tira.Component.TiraComboBox();
            this.cboSearchMonth = new Tira.Component.TiraComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExecute = new Tira.Component.TiraButton();
            this.dataGridListKuitansiSlipUnprocessAll = new Tira.Component.TiraDataGrid();
            this.select = new Tira.Component.TiraDataGridCheckBox();
            this.entity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instalments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_kw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instalments_per_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kw_period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.rptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bindingObjSearch = new System.Windows.Forms.BindingSource(this.components);
            this.panelTopMenu.SuspendLayout();
            this.panelView.SuspendLayout();
            this.groupBoxPaging.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListKuitansiSlipUnprocessAll)).BeginInit();
            this.pnlPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelTopMenu.Controls.Add(this.navClose);
            this.panelTopMenu.Controls.Add(this.navExport);
            this.panelTopMenu.Controls.Add(this.navPrint);
            this.panelTopMenu.Controls.Add(this.navView);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(1112, 30);
            this.panelTopMenu.TabIndex = 16;
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
            this.navClose.Location = new System.Drawing.Point(1082, 0);
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
            this.navExport.Location = new System.Drawing.Point(130, 0);
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
            this.navPrint.Location = new System.Drawing.Point(65, 0);
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
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.White;
            this.panelView.Controls.Add(this.groupBoxPaging);
            this.panelView.Controls.Add(this.groupBoxSearch);
            this.panelView.Controls.Add(this.dataGridListKuitansiSlipUnprocessAll);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 30);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1112, 719);
            this.panelView.TabIndex = 17;
            // 
            // groupBoxPaging
            // 
            this.groupBoxPaging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPaging.Controls.Add(this.lblPagingInfo);
            this.groupBoxPaging.Controls.Add(this.lblRows);
            this.groupBoxPaging.Controls.Add(this.btnPrev);
            this.groupBoxPaging.Controls.Add(this.btnNext);
            this.groupBoxPaging.Location = new System.Drawing.Point(12, 676);
            this.groupBoxPaging.Name = "groupBoxPaging";
            this.groupBoxPaging.Size = new System.Drawing.Size(1093, 35);
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
            this.btnPrev.Location = new System.Drawing.Point(1021, 8);
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
            this.btnNext.Location = new System.Drawing.Point(1057, 8);
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
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxSearch.Controls.Add(this.btnProcess);
            this.groupBoxSearch.Controls.Add(this.cbCheckAll);
            this.groupBoxSearch.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxSearch.Controls.Add(this.btnExecute);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 6);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(1088, 234);
            this.groupBoxSearch.TabIndex = 3;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.groupBoxSearch.TiraTextColor = System.Drawing.Color.Black;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboSearchBranch, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboSearchDivision, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxSearchInvoiceNo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxSearchKpNo, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1076, 113);
            this.tableLayoutPanel1.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Division";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Branch";
            // 
            // cboSearchBranch
            // 
            this.cboSearchBranch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchBranch.BackColor = System.Drawing.Color.White;
            this.cboSearchBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboSearchBranch.ForeColor = System.Drawing.Color.DimGray;
            this.cboSearchBranch.FormattingEnabled = true;
            this.cboSearchBranch.Location = new System.Drawing.Point(3, 28);
            this.cboSearchBranch.Name = "cboSearchBranch";
            this.cboSearchBranch.Size = new System.Drawing.Size(521, 23);
            this.cboSearchBranch.TabIndex = 43;
            this.cboSearchBranch.Text = "Branch";
            this.cboSearchBranch.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboSearchBranch.TiraMandatory = false;
            this.cboSearchBranch.TiraPlaceHolder = "Branch";
            // 
            // cboSearchDivision
            // 
            this.cboSearchDivision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchDivision.BackColor = System.Drawing.Color.White;
            this.cboSearchDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboSearchDivision.ForeColor = System.Drawing.Color.DimGray;
            this.cboSearchDivision.FormattingEnabled = true;
            this.cboSearchDivision.Location = new System.Drawing.Point(3, 86);
            this.cboSearchDivision.Name = "cboSearchDivision";
            this.cboSearchDivision.Size = new System.Drawing.Size(521, 23);
            this.cboSearchDivision.TabIndex = 44;
            this.cboSearchDivision.Text = "Division";
            this.cboSearchDivision.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboSearchDivision.TiraMandatory = false;
            this.cboSearchDivision.TiraPlaceHolder = "Division";
            // 
            // txtBoxSearchInvoiceNo
            // 
            this.txtBoxSearchInvoiceNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearchInvoiceNo.BackColor = System.Drawing.Color.White;
            this.txtBoxSearchInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxSearchInvoiceNo.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxSearchInvoiceNo.Location = new System.Drawing.Point(551, 28);
            this.txtBoxSearchInvoiceNo.MaxLength = 255;
            this.txtBoxSearchInvoiceNo.Name = "txtBoxSearchInvoiceNo";
            this.txtBoxSearchInvoiceNo.Size = new System.Drawing.Size(522, 23);
            this.txtBoxSearchInvoiceNo.TabIndex = 47;
            this.txtBoxSearchInvoiceNo.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxSearchInvoiceNo.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxSearchInvoiceNo.TiraMandatory = false;
            this.txtBoxSearchInvoiceNo.TiraPlaceHolder = "";
            this.txtBoxSearchInvoiceNo.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Invoice No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "KP No";
            // 
            // txtBoxSearchKpNo
            // 
            this.txtBoxSearchKpNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearchKpNo.BackColor = System.Drawing.Color.White;
            this.txtBoxSearchKpNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxSearchKpNo.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxSearchKpNo.Location = new System.Drawing.Point(551, 86);
            this.txtBoxSearchKpNo.MaxLength = 255;
            this.txtBoxSearchKpNo.Name = "txtBoxSearchKpNo";
            this.txtBoxSearchKpNo.Size = new System.Drawing.Size(522, 23);
            this.txtBoxSearchKpNo.TabIndex = 49;
            this.txtBoxSearchKpNo.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxSearchKpNo.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxSearchKpNo.TiraMandatory = false;
            this.txtBoxSearchKpNo.TiraPlaceHolder = "";
            this.txtBoxSearchKpNo.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnProcess.Enabled = false;
            this.btnProcess.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProcess.FlatAppearance.BorderSize = 0;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnProcess.IconColor = System.Drawing.Color.White;
            this.btnProcess.IconSize = 16;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.Location = new System.Drawing.Point(911, 200);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Rotation = 0D;
            this.btnProcess.Size = new System.Drawing.Size(81, 23);
            this.btnProcess.TabIndex = 52;
            this.btnProcess.Text = "Process";
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcess.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // cbCheckAll
            // 
            this.cbCheckAll.Enabled = false;
            this.cbCheckAll.Location = new System.Drawing.Point(6, 203);
            this.cbCheckAll.Name = "cbCheckAll";
            this.cbCheckAll.Size = new System.Drawing.Size(100, 20);
            this.cbCheckAll.TabIndex = 53;
            this.cbCheckAll.Text = "Check All";
            this.cbCheckAll.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cbCheckAll.UseVisualStyleBackColor = true;
            this.cbCheckAll.CheckedChanged += new System.EventHandler(this.cbCheckAll_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.5F));
            this.tableLayoutPanel2.Controls.Add(this.cboSearchEntity, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboSearchYear, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.cboSearchMonth, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1076, 56);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // cboSearchEntity
            // 
            this.cboSearchEntity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchEntity.BackColor = System.Drawing.Color.White;
            this.cboSearchEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboSearchEntity.ForeColor = System.Drawing.Color.DimGray;
            this.cboSearchEntity.FormattingEnabled = true;
            this.cboSearchEntity.Location = new System.Drawing.Point(3, 24);
            this.cboSearchEntity.Name = "cboSearchEntity";
            this.cboSearchEntity.Size = new System.Drawing.Size(521, 23);
            this.cboSearchEntity.TabIndex = 42;
            this.cboSearchEntity.Text = "Entity";
            this.cboSearchEntity.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboSearchEntity.TiraMandatory = false;
            this.cboSearchEntity.TiraPlaceHolder = "Entity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Entity";
            // 
            // cboSearchYear
            // 
            this.cboSearchYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchYear.BackColor = System.Drawing.Color.White;
            this.cboSearchYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboSearchYear.ForeColor = System.Drawing.Color.DimGray;
            this.cboSearchYear.FormattingEnabled = true;
            this.cboSearchYear.Location = new System.Drawing.Point(814, 24);
            this.cboSearchYear.Name = "cboSearchYear";
            this.cboSearchYear.Size = new System.Drawing.Size(259, 23);
            this.cboSearchYear.TabIndex = 51;
            this.cboSearchYear.Text = "Year";
            this.cboSearchYear.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboSearchYear.TiraMandatory = false;
            this.cboSearchYear.TiraPlaceHolder = "Year";
            // 
            // cboSearchMonth
            // 
            this.cboSearchMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchMonth.BackColor = System.Drawing.Color.White;
            this.cboSearchMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboSearchMonth.ForeColor = System.Drawing.Color.Black;
            this.cboSearchMonth.FormattingEnabled = true;
            this.cboSearchMonth.Location = new System.Drawing.Point(551, 24);
            this.cboSearchMonth.Name = "cboSearchMonth";
            this.cboSearchMonth.Size = new System.Drawing.Size(257, 23);
            this.cboSearchMonth.TabIndex = 50;
            this.cboSearchMonth.Text = "Month";
            this.cboSearchMonth.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboSearchMonth.TiraMandatory = false;
            this.cboSearchMonth.TiraPlaceHolder = "Division";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(814, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Month";
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnExecute.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExecute.FlatAppearance.BorderSize = 0;
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecute.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExecute.ForeColor = System.Drawing.Color.White;
            this.btnExecute.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnExecute.IconColor = System.Drawing.Color.White;
            this.btnExecute.IconSize = 16;
            this.btnExecute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExecute.Location = new System.Drawing.Point(998, 199);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Rotation = 0D;
            this.btnExecute.Size = new System.Drawing.Size(81, 23);
            this.btnExecute.TabIndex = 41;
            this.btnExecute.Text = "Execute";
            this.btnExecute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExecute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExecute.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // dataGridListKuitansiSlipUnprocessAll
            // 
            this.dataGridListKuitansiSlipUnprocessAll.AllowUserToAddRows = false;
            this.dataGridListKuitansiSlipUnprocessAll.AllowUserToDeleteRows = false;
            this.dataGridListKuitansiSlipUnprocessAll.AllowUserToOrderColumns = true;
            this.dataGridListKuitansiSlipUnprocessAll.AllowUserToResizeColumns = false;
            this.dataGridListKuitansiSlipUnprocessAll.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridListKuitansiSlipUnprocessAll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridListKuitansiSlipUnprocessAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridListKuitansiSlipUnprocessAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridListKuitansiSlipUnprocessAll.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridListKuitansiSlipUnprocessAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridListKuitansiSlipUnprocessAll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridListKuitansiSlipUnprocessAll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridListKuitansiSlipUnprocessAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridListKuitansiSlipUnprocessAll.ColumnHeadersHeight = 22;
            this.dataGridListKuitansiSlipUnprocessAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridListKuitansiSlipUnprocessAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.entity,
            this.branch,
            this.division,
            this.customer_id,
            this.kp,
            this.invoice,
            this.instalments,
            this.last_kw,
            this.instalments_per_amount,
            this.due_date,
            this.invoice_date,
            this.kw_period});
            this.dataGridListKuitansiSlipUnprocessAll.EnableHeadersVisualStyles = false;
            this.dataGridListKuitansiSlipUnprocessAll.Location = new System.Drawing.Point(12, 246);
            this.dataGridListKuitansiSlipUnprocessAll.Name = "dataGridListKuitansiSlipUnprocessAll";
            this.dataGridListKuitansiSlipUnprocessAll.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridListKuitansiSlipUnprocessAll.RowHeadersVisible = false;
            this.dataGridListKuitansiSlipUnprocessAll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridListKuitansiSlipUnprocessAll.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridListKuitansiSlipUnprocessAll.RowTemplate.Height = 25;
            this.dataGridListKuitansiSlipUnprocessAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridListKuitansiSlipUnprocessAll.Size = new System.Drawing.Size(1088, 424);
            this.dataGridListKuitansiSlipUnprocessAll.TabIndex = 2;
            // 
            // select
            // 
            this.select.DataPropertyName = "is_selected";
            this.select.HeaderText = "              ";
            this.select.MinimumWidth = 20;
            this.select.Name = "select";
            this.select.Width = 53;
            // 
            // entity
            // 
            this.entity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.entity.DataPropertyName = "entity_id";
            this.entity.HeaderText = "ENTITY";
            this.entity.Name = "entity";
            // 
            // branch
            // 
            this.branch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.branch.DataPropertyName = "branch_id";
            this.branch.HeaderText = "BRANCH";
            this.branch.Name = "branch";
            // 
            // division
            // 
            this.division.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.division.DataPropertyName = "division_id";
            this.division.HeaderText = "DIVISION";
            this.division.Name = "division";
            // 
            // customer_id
            // 
            this.customer_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "CUSTOMER ID";
            this.customer_id.Name = "customer_id";
            this.customer_id.Width = 102;
            // 
            // kp
            // 
            this.kp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kp.DataPropertyName = "kp";
            this.kp.HeaderText = "KP";
            this.kp.Name = "kp";
            // 
            // invoice
            // 
            this.invoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.invoice.DataPropertyName = "invoice";
            this.invoice.HeaderText = "INVOICE";
            this.invoice.Name = "invoice";
            // 
            // instalments
            // 
            this.instalments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.instalments.DataPropertyName = "instalments";
            this.instalments.HeaderText = "INSTALMENTS";
            this.instalments.Name = "instalments";
            // 
            // last_kw
            // 
            this.last_kw.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.last_kw.DataPropertyName = "lastkw";
            this.last_kw.HeaderText = "LAST KW";
            this.last_kw.Name = "last_kw";
            // 
            // instalments_per_amount
            // 
            this.instalments_per_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.instalments_per_amount.DataPropertyName = "instalments_per_amount";
            this.instalments_per_amount.HeaderText = "INSTALMENTS PER AMOUNT";
            this.instalments_per_amount.Name = "instalments_per_amount";
            this.instalments_per_amount.Width = 173;
            // 
            // due_date
            // 
            this.due_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.due_date.DataPropertyName = "due_date";
            this.due_date.HeaderText = "DUE DATE";
            this.due_date.Name = "due_date";
            // 
            // invoice_date
            // 
            this.invoice_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.invoice_date.DataPropertyName = "invoice_date";
            this.invoice_date.HeaderText = "INVOICE DATE";
            this.invoice_date.Name = "invoice_date";
            this.invoice_date.Width = 102;
            // 
            // kw_period
            // 
            this.kw_period.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kw_period.DataPropertyName = "kw_period";
            this.kw_period.HeaderText = "KW PERIOD";
            this.kw_period.Name = "kw_period";
            // 
            // pnlPrint
            // 
            this.pnlPrint.BackColor = System.Drawing.Color.White;
            this.pnlPrint.Controls.Add(this.rptViewer);
            this.pnlPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrint.Location = new System.Drawing.Point(0, 30);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(1112, 719);
            this.pnlPrint.TabIndex = 68;
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
            this.rptViewer.Size = new System.Drawing.Size(1098, 674);
            this.rptViewer.TabIndex = 0;
            this.rptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // AR_ListKuitansiSlipUnprocessAllUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 749);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.pnlPrint);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "AR_ListKuitansiSlipUnprocessAllUI";
            this.Text = "AR_ListKuitansiSlipUnprocessAllUI";
            this.Load += new System.EventHandler(this.AR_ListKuitansiSlipUnprocessAllUI_Load);
            this.panelTopMenu.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            this.groupBoxPaging.ResumeLayout(false);
            this.groupBoxPaging.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListKuitansiSlipUnprocessAll)).EndInit();
            this.pnlPrint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTopMenu;
        private Tira.Component.TiraButton navClose;
        private Tira.Component.TiraButton navPrint;
        private Tira.Component.TiraButton navView;
        private Tira.Component.TiraButton navExport;
        private System.Windows.Forms.Panel panelView;
        private Tira.Component.TiraGroupBox groupBoxPaging;
        internal System.Windows.Forms.Label lblPagingInfo;
        internal System.Windows.Forms.Label lblRows;
        private Tira.Component.TiraButton btnPrev;
        private Tira.Component.TiraButton btnNext;
        private Tira.Component.TiraGroupBox groupBoxSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Tira.Component.TiraTextBox txtBoxSearchKpNo;
        private Tira.Component.TiraComboBox cboSearchBranch;
        private Tira.Component.TiraComboBox cboSearchDivision;
        private Tira.Component.TiraTextBox txtBoxSearchInvoiceNo;
        private Tira.Component.TiraButton btnProcess;
        private Tira.Component.TiraCheckBox cbCheckAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private Tira.Component.TiraComboBox cboSearchYear;
        private Tira.Component.TiraComboBox cboSearchMonth;
        private Tira.Component.TiraComboBox cboSearchEntity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Tira.Component.TiraButton btnExecute;
        private Tira.Component.TiraDataGrid dataGridListKuitansiSlipUnprocessAll;
        private System.Windows.Forms.Panel pnlPrint;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewer;
        private Tira.Component.TiraDataGridCheckBox select;
        private System.Windows.Forms.DataGridViewTextBoxColumn entity;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn division;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kp;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn instalments;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_kw;
        private System.Windows.Forms.DataGridViewTextBoxColumn instalments_per_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn due_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn kw_period;
        private System.Windows.Forms.BindingSource bindingObjSearch;
    }
}