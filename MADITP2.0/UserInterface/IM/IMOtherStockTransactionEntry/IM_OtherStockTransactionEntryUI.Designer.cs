namespace MADITP2._0.UserInterface.IM.IMOtherStockTransactionEntry
{
    partial class IM_OtherStockTransactionEntryUI
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
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.navClose = new Tira.Component.TiraButton();
            this.navNew = new Tira.Component.TiraButton();
            this.navView = new Tira.Component.TiraButton();
            this.panelNew = new System.Windows.Forms.Panel();
            this.btnCancelLineEntry = new Tira.Component.TiraButton();
            this.panelView = new System.Windows.Forms.Panel();
            this.dataGridOtherStock = new Tira.Component.TiraDataGrid();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSearch = new Tira.Component.TiraGroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxSearchProductName = new Tira.Component.TiraTextBox();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.btnSearchLookUpProduct = new Tira.Component.TiraButton();
            this.txtBoxSearchProductID = new Tira.Component.TiraTextBox();
            this.lblSearchProductName = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpSearchTo = new System.Windows.Forms.DateTimePicker();
            this.dtpSearchFrom = new System.Windows.Forms.DateTimePicker();
            this.lblSearchTo = new System.Windows.Forms.Label();
            this.cbSearchRangeDate = new Tira.Component.TiraCheckBox();
            this.lblSearchTxnType = new System.Windows.Forms.Label();
            this.lblSearchRangeDate = new System.Windows.Forms.Label();
            this.lblSearchFrom = new System.Windows.Forms.Label();
            this.cboSearchTxnType = new Tira.Component.TiraComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearchWarehouseID = new System.Windows.Forms.Label();
            this.cboSearchGroup = new Tira.Component.TiraComboBox();
            this.lblSearchGroup = new System.Windows.Forms.Label();
            this.cboSearchWarehouseID = new Tira.Component.TiraComboBox();
            this.dtpSearchPrintDate = new System.Windows.Forms.DateTimePicker();
            this.lblSearchPrintDate = new System.Windows.Forms.Label();
            this.lblSearchSubGroup = new System.Windows.Forms.Label();
            this.cboSearchSubGroup = new Tira.Component.TiraComboBox();
            this.btnSearch = new Tira.Component.TiraButton();
            this.groupBoxPaging = new Tira.Component.TiraGroupBox();
            this.lblPagingInfo = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.btnPrev = new Tira.Component.TiraButton();
            this.btnNext = new Tira.Component.TiraButton();
            this.dataGridNewOtherStock = new Tira.Component.TiraDataGrid();
            this.new_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_product_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_unit_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_product_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_qty_on_hand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_qty_available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboNewWarehouseID = new Tira.Component.TiraComboBox();
            this.lblWarehouseID = new System.Windows.Forms.Label();
            this.lblMemo = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.txtBoxReference = new Tira.Component.TiraTextBox();
            this.txtBoxNewMemo = new Tira.Component.TiraTextBox();
            this.cboNewTxnType = new Tira.Component.TiraComboBox();
            this.lblTxnType = new System.Windows.Forms.Label();
            this.lblTxnDate = new System.Windows.Forms.Label();
            this.dtpNewTxnDate = new System.Windows.Forms.DateTimePicker();
            this.btnLineEntry = new Tira.Component.TiraButton();
            this.btnSave = new Tira.Component.TiraButton();
            this.btnCancel = new Tira.Component.TiraButton();
            this.bindingObjOtherStock = new System.Windows.Forms.BindingSource(this.components);
            this.bindingObjSearchWarehouse = new System.Windows.Forms.BindingSource(this.components);
            this.bindingObjNewWarehouse = new System.Windows.Forms.BindingSource(this.components);
            this.bindingObjSearchTxnType = new System.Windows.Forms.BindingSource(this.components);
            this.bindingObjNewTxnType = new System.Windows.Forms.BindingSource(this.components);
            this.panelTopMenu.SuspendLayout();
            this.panelNew.SuspendLayout();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOtherStock)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxPaging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNewOtherStock)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjOtherStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjSearchWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjNewWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjSearchTxnType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjNewTxnType)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelTopMenu.Controls.Add(this.navClose);
            this.panelTopMenu.Controls.Add(this.navNew);
            this.panelTopMenu.Controls.Add(this.navView);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(1203, 30);
            this.panelTopMenu.TabIndex = 13;
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
            this.panelNew.Controls.Add(this.dataGridNewOtherStock);
            this.panelNew.Controls.Add(this.tableLayoutPanel2);
            this.panelNew.Controls.Add(this.btnSave);
            this.panelNew.Controls.Add(this.btnCancel);
            this.panelNew.Controls.Add(this.btnCancelLineEntry);
            this.panelNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNew.Location = new System.Drawing.Point(0, 30);
            this.panelNew.Name = "panelNew";
            this.panelNew.Size = new System.Drawing.Size(1203, 671);
            this.panelNew.TabIndex = 12;
            // 
            // btnCancelLineEntry
            // 
            this.btnCancelLineEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelLineEntry.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelLineEntry.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelLineEntry.FlatAppearance.BorderSize = 0;
            this.btnCancelLineEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelLineEntry.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancelLineEntry.ForeColor = System.Drawing.Color.Black;
            this.btnCancelLineEntry.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.btnCancelLineEntry.IconColor = System.Drawing.Color.Black;
            this.btnCancelLineEntry.IconSize = 20;
            this.btnCancelLineEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelLineEntry.Location = new System.Drawing.Point(890, 607);
            this.btnCancelLineEntry.Name = "btnCancelLineEntry";
            this.btnCancelLineEntry.Rotation = 0D;
            this.btnCancelLineEntry.Size = new System.Drawing.Size(126, 30);
            this.btnCancelLineEntry.TabIndex = 357;
            this.btnCancelLineEntry.Text = "Cancel Line Entry";
            this.btnCancelLineEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelLineEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelLineEntry.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnCancelLineEntry.UseVisualStyleBackColor = false;
            this.btnCancelLineEntry.Click += new System.EventHandler(this.btnCancelLineEntry_Click);
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.dataGridOtherStock);
            this.panelView.Controls.Add(this.groupBoxSearch);
            this.panelView.Controls.Add(this.groupBoxPaging);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1203, 671);
            this.panelView.TabIndex = 12;
            // 
            // dataGridOtherStock
            // 
            this.dataGridOtherStock.AllowUserToAddRows = false;
            this.dataGridOtherStock.AllowUserToDeleteRows = false;
            this.dataGridOtherStock.AllowUserToOrderColumns = true;
            this.dataGridOtherStock.AllowUserToResizeColumns = false;
            this.dataGridOtherStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridOtherStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridOtherStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOtherStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridOtherStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridOtherStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridOtherStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridOtherStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridOtherStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridOtherStock.ColumnHeadersHeight = 22;
            this.dataGridOtherStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridOtherStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_description,
            this.transaction_date,
            this.transaction_type,
            this.sequence,
            this.qty,
            this.group_id,
            this.sub_group_id,
            this.reference});
            this.dataGridOtherStock.EnableHeadersVisualStyles = false;
            this.dataGridOtherStock.Location = new System.Drawing.Point(12, 314);
            this.dataGridOtherStock.Name = "dataGridOtherStock";
            this.dataGridOtherStock.ReadOnly = true;
            this.dataGridOtherStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridOtherStock.RowHeadersVisible = false;
            this.dataGridOtherStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridOtherStock.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridOtherStock.RowTemplate.Height = 25;
            this.dataGridOtherStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOtherStock.Size = new System.Drawing.Size(1175, 299);
            this.dataGridOtherStock.TabIndex = 11;
            // 
            // product_id
            // 
            this.product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "PRODUCT ID";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            // 
            // product_description
            // 
            this.product_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.product_description.DataPropertyName = "product_description";
            this.product_description.HeaderText = "PRODUCT DESCRIPTION";
            this.product_description.Name = "product_description";
            this.product_description.ReadOnly = true;
            this.product_description.Width = 153;
            // 
            // transaction_date
            // 
            this.transaction_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transaction_date.DataPropertyName = "transaction_date";
            this.transaction_date.HeaderText = "TRANSACTION DATE";
            this.transaction_date.Name = "transaction_date";
            this.transaction_date.ReadOnly = true;
            // 
            // transaction_type
            // 
            this.transaction_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transaction_type.DataPropertyName = "transaction_type";
            this.transaction_type.HeaderText = "TRANSACTION TYPE";
            this.transaction_type.Name = "transaction_type";
            this.transaction_type.ReadOnly = true;
            // 
            // sequence
            // 
            this.sequence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sequence.DataPropertyName = "sequence";
            this.sequence.HeaderText = "SEQUENCE";
            this.sequence.Name = "sequence";
            this.sequence.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "QTY";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // group_id
            // 
            this.group_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.group_id.DataPropertyName = "group_id";
            this.group_id.HeaderText = "GROUP";
            this.group_id.Name = "group_id";
            this.group_id.ReadOnly = true;
            // 
            // sub_group_id
            // 
            this.sub_group_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sub_group_id.DataPropertyName = "sub_group_id";
            this.sub_group_id.HeaderText = "SUB GROUP";
            this.sub_group_id.Name = "sub_group_id";
            this.sub_group_id.ReadOnly = true;
            // 
            // reference
            // 
            this.reference.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reference.DataPropertyName = "reference";
            this.reference.HeaderText = "REFERENCE";
            this.reference.Name = "reference";
            this.reference.ReadOnly = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.tableLayoutPanel5);
            this.groupBoxSearch.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxSearch.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 18);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(1175, 290);
            this.groupBoxSearch.TabIndex = 10;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Filter";
            this.groupBoxSearch.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.groupBoxSearch.TiraTextColor = System.Drawing.Color.Black;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.95918F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.040816F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.txtBoxSearchProductName, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblSearchProduct, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnSearchLookUpProduct, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtBoxSearchProductID, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblSearchProductName, 3, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 138);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1165, 50);
            this.tableLayoutPanel5.TabIndex = 63;
            // 
            // txtBoxSearchProductName
            // 
            this.txtBoxSearchProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearchProductName.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxSearchProductName.Enabled = false;
            this.txtBoxSearchProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxSearchProductName.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxSearchProductName.Location = new System.Drawing.Point(596, 28);
            this.txtBoxSearchProductName.MaxLength = 255;
            this.txtBoxSearchProductName.Name = "txtBoxSearchProductName";
            this.txtBoxSearchProductName.ReadOnly = true;
            this.txtBoxSearchProductName.Size = new System.Drawing.Size(566, 19);
            this.txtBoxSearchProductName.TabIndex = 65;
            this.txtBoxSearchProductName.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxSearchProductName.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxSearchProductName.TiraMandatory = false;
            this.txtBoxSearchProductName.TiraPlaceHolder = null;
            this.txtBoxSearchProductName.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Location = new System.Drawing.Point(3, 0);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(44, 13);
            this.lblSearchProduct.TabIndex = 56;
            this.lblSearchProduct.Text = "Product";
            // 
            // btnSearchLookUpProduct
            // 
            this.btnSearchLookUpProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchLookUpProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSearchLookUpProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchLookUpProduct.FlatAppearance.BorderSize = 0;
            this.btnSearchLookUpProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchLookUpProduct.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearchLookUpProduct.ForeColor = System.Drawing.Color.Black;
            this.btnSearchLookUpProduct.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnSearchLookUpProduct.IconColor = System.Drawing.Color.White;
            this.btnSearchLookUpProduct.IconSize = 18;
            this.btnSearchLookUpProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchLookUpProduct.Location = new System.Drawing.Point(550, 28);
            this.btnSearchLookUpProduct.Name = "btnSearchLookUpProduct";
            this.btnSearchLookUpProduct.Rotation = 0D;
            this.btnSearchLookUpProduct.Size = new System.Drawing.Size(17, 19);
            this.btnSearchLookUpProduct.TabIndex = 64;
            this.btnSearchLookUpProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchLookUpProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchLookUpProduct.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSearchLookUpProduct.UseVisualStyleBackColor = false;
            this.btnSearchLookUpProduct.Click += new System.EventHandler(this.btnSearchLookUpProduct_Click);
            // 
            // txtBoxSearchProductID
            // 
            this.txtBoxSearchProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearchProductID.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxSearchProductID.Enabled = false;
            this.txtBoxSearchProductID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxSearchProductID.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxSearchProductID.Location = new System.Drawing.Point(3, 28);
            this.txtBoxSearchProductID.MaxLength = 255;
            this.txtBoxSearchProductID.Name = "txtBoxSearchProductID";
            this.txtBoxSearchProductID.ReadOnly = true;
            this.txtBoxSearchProductID.Size = new System.Drawing.Size(541, 19);
            this.txtBoxSearchProductID.TabIndex = 63;
            this.txtBoxSearchProductID.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxSearchProductID.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxSearchProductID.TiraMandatory = false;
            this.txtBoxSearchProductID.TiraPlaceHolder = null;
            this.txtBoxSearchProductID.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // lblSearchProductName
            // 
            this.lblSearchProductName.AutoSize = true;
            this.lblSearchProductName.Location = new System.Drawing.Point(596, 0);
            this.lblSearchProductName.Name = "lblSearchProductName";
            this.lblSearchProductName.Size = new System.Drawing.Size(75, 13);
            this.lblSearchProductName.TabIndex = 66;
            this.lblSearchProductName.Text = "Product Name";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.5F));
            this.tableLayoutPanel3.Controls.Add(this.dtpSearchTo, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpSearchFrom, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblSearchTo, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbSearchRangeDate, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblSearchTxnType, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblSearchRangeDate, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblSearchFrom, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.cboSearchTxnType, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 193);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1166, 57);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // dtpSearchTo
            // 
            this.dtpSearchTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSearchTo.Enabled = false;
            this.dtpSearchTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchTo.Location = new System.Drawing.Point(928, 31);
            this.dtpSearchTo.Name = "dtpSearchTo";
            this.dtpSearchTo.Size = new System.Drawing.Size(235, 20);
            this.dtpSearchTo.TabIndex = 3;
            // 
            // dtpSearchFrom
            // 
            this.dtpSearchFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSearchFrom.Enabled = false;
            this.dtpSearchFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchFrom.Location = new System.Drawing.Point(666, 31);
            this.dtpSearchFrom.Name = "dtpSearchFrom";
            this.dtpSearchFrom.Size = new System.Drawing.Size(233, 20);
            this.dtpSearchFrom.TabIndex = 2;
            // 
            // lblSearchTo
            // 
            this.lblSearchTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchTo.AutoSize = true;
            this.lblSearchTo.Location = new System.Drawing.Point(908, 28);
            this.lblSearchTo.Name = "lblSearchTo";
            this.lblSearchTo.Size = new System.Drawing.Size(14, 26);
            this.lblSearchTo.TabIndex = 58;
            this.lblSearchTo.Text = "To";
            // 
            // cbSearchRangeDate
            // 
            this.cbSearchRangeDate.Location = new System.Drawing.Point(666, 3);
            this.cbSearchRangeDate.Name = "cbSearchRangeDate";
            this.cbSearchRangeDate.Size = new System.Drawing.Size(51, 20);
            this.cbSearchRangeDate.TabIndex = 59;
            this.cbSearchRangeDate.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cbSearchRangeDate.UseVisualStyleBackColor = true;
            this.cbSearchRangeDate.CheckedChanged += new System.EventHandler(this.cbSearchRangeDate_CheckedChanged);
            // 
            // lblSearchTxnType
            // 
            this.lblSearchTxnType.AutoSize = true;
            this.lblSearchTxnType.Location = new System.Drawing.Point(3, 0);
            this.lblSearchTxnType.Name = "lblSearchTxnType";
            this.lblSearchTxnType.Size = new System.Drawing.Size(52, 13);
            this.lblSearchTxnType.TabIndex = 54;
            this.lblSearchTxnType.Text = "Txn Type";
            // 
            // lblSearchRangeDate
            // 
            this.lblSearchRangeDate.AutoSize = true;
            this.lblSearchRangeDate.Location = new System.Drawing.Point(597, 0);
            this.lblSearchRangeDate.Name = "lblSearchRangeDate";
            this.lblSearchRangeDate.Size = new System.Drawing.Size(42, 26);
            this.lblSearchRangeDate.TabIndex = 56;
            this.lblSearchRangeDate.Text = "Range Date";
            // 
            // lblSearchFrom
            // 
            this.lblSearchFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchFrom.AutoSize = true;
            this.lblSearchFrom.Location = new System.Drawing.Point(630, 28);
            this.lblSearchFrom.Name = "lblSearchFrom";
            this.lblSearchFrom.Size = new System.Drawing.Size(30, 13);
            this.lblSearchFrom.TabIndex = 57;
            this.lblSearchFrom.Text = "From";
            // 
            // cboSearchTxnType
            // 
            this.cboSearchTxnType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchTxnType.BackColor = System.Drawing.Color.White;
            this.cboSearchTxnType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboSearchTxnType.ForeColor = System.Drawing.Color.DimGray;
            this.cboSearchTxnType.FormattingEnabled = true;
            this.cboSearchTxnType.Location = new System.Drawing.Point(3, 31);
            this.cboSearchTxnType.Name = "cboSearchTxnType";
            this.cboSearchTxnType.Size = new System.Drawing.Size(565, 23);
            this.cboSearchTxnType.TabIndex = 55;
            this.cboSearchTxnType.Text = "Txn Type";
            this.cboSearchTxnType.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboSearchTxnType.TiraMandatory = false;
            this.cboSearchTxnType.TiraPlaceHolder = "Txn Type";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.Controls.Add(this.lblSearchWarehouseID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboSearchGroup, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSearchGroup, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboSearchWarehouseID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpSearchPrintDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSearchPrintDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSearchSubGroup, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboSearchSubGroup, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1166, 111);
            this.tableLayoutPanel1.TabIndex = 62;
            // 
            // lblSearchWarehouseID
            // 
            this.lblSearchWarehouseID.AutoSize = true;
            this.lblSearchWarehouseID.Location = new System.Drawing.Point(3, 0);
            this.lblSearchWarehouseID.Name = "lblSearchWarehouseID";
            this.lblSearchWarehouseID.Size = new System.Drawing.Size(76, 13);
            this.lblSearchWarehouseID.TabIndex = 60;
            this.lblSearchWarehouseID.Text = "Warehouse ID";
            // 
            // cboSearchGroup
            // 
            this.cboSearchGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchGroup.BackColor = System.Drawing.Color.White;
            this.cboSearchGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboSearchGroup.ForeColor = System.Drawing.Color.Black;
            this.cboSearchGroup.FormattingEnabled = true;
            this.cboSearchGroup.Location = new System.Drawing.Point(3, 73);
            this.cboSearchGroup.Name = "cboSearchGroup";
            this.cboSearchGroup.Size = new System.Drawing.Size(565, 23);
            this.cboSearchGroup.TabIndex = 56;
            this.cboSearchGroup.Text = "Group";
            this.cboSearchGroup.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboSearchGroup.TiraMandatory = false;
            this.cboSearchGroup.TiraPlaceHolder = "Txn Type";
            this.cboSearchGroup.SelectedIndexChanged += new System.EventHandler(this.cboSearchGroup_SelectedIndexChanged);
            // 
            // lblSearchGroup
            // 
            this.lblSearchGroup.AutoSize = true;
            this.lblSearchGroup.Location = new System.Drawing.Point(3, 54);
            this.lblSearchGroup.Name = "lblSearchGroup";
            this.lblSearchGroup.Size = new System.Drawing.Size(36, 13);
            this.lblSearchGroup.TabIndex = 55;
            this.lblSearchGroup.Text = "Group";
            // 
            // cboSearchWarehouseID
            // 
            this.cboSearchWarehouseID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchWarehouseID.BackColor = System.Drawing.Color.White;
            this.cboSearchWarehouseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboSearchWarehouseID.ForeColor = System.Drawing.Color.DimGray;
            this.cboSearchWarehouseID.FormattingEnabled = true;
            this.cboSearchWarehouseID.Location = new System.Drawing.Point(3, 19);
            this.cboSearchWarehouseID.Name = "cboSearchWarehouseID";
            this.cboSearchWarehouseID.Size = new System.Drawing.Size(565, 23);
            this.cboSearchWarehouseID.TabIndex = 43;
            this.cboSearchWarehouseID.Text = "Warehouse ID";
            this.cboSearchWarehouseID.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboSearchWarehouseID.TiraMandatory = false;
            this.cboSearchWarehouseID.TiraPlaceHolder = "Warehouse ID";
            // 
            // dtpSearchPrintDate
            // 
            this.dtpSearchPrintDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSearchPrintDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchPrintDate.Location = new System.Drawing.Point(597, 19);
            this.dtpSearchPrintDate.Name = "dtpSearchPrintDate";
            this.dtpSearchPrintDate.Size = new System.Drawing.Size(566, 20);
            this.dtpSearchPrintDate.TabIndex = 55;
            // 
            // lblSearchPrintDate
            // 
            this.lblSearchPrintDate.AutoSize = true;
            this.lblSearchPrintDate.Location = new System.Drawing.Point(597, 0);
            this.lblSearchPrintDate.Name = "lblSearchPrintDate";
            this.lblSearchPrintDate.Size = new System.Drawing.Size(54, 13);
            this.lblSearchPrintDate.TabIndex = 61;
            this.lblSearchPrintDate.Text = "Print Date";
            // 
            // lblSearchSubGroup
            // 
            this.lblSearchSubGroup.AutoSize = true;
            this.lblSearchSubGroup.Location = new System.Drawing.Point(597, 54);
            this.lblSearchSubGroup.Name = "lblSearchSubGroup";
            this.lblSearchSubGroup.Size = new System.Drawing.Size(58, 13);
            this.lblSearchSubGroup.TabIndex = 57;
            this.lblSearchSubGroup.Text = "Sub Group";
            // 
            // cboSearchSubGroup
            // 
            this.cboSearchSubGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchSubGroup.BackColor = System.Drawing.Color.White;
            this.cboSearchSubGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboSearchSubGroup.ForeColor = System.Drawing.Color.DimGray;
            this.cboSearchSubGroup.FormattingEnabled = true;
            this.cboSearchSubGroup.Location = new System.Drawing.Point(597, 73);
            this.cboSearchSubGroup.Name = "cboSearchSubGroup";
            this.cboSearchSubGroup.Size = new System.Drawing.Size(566, 23);
            this.cboSearchSubGroup.TabIndex = 58;
            this.cboSearchSubGroup.Text = "Sub Group";
            this.cboSearchSubGroup.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboSearchSubGroup.TiraMandatory = false;
            this.cboSearchSubGroup.TiraPlaceHolder = "Sub Group";
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
            this.btnSearch.Location = new System.Drawing.Point(1104, 254);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(65, 23);
            this.btnSearch.TabIndex = 40;
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
            this.groupBoxPaging.Location = new System.Drawing.Point(16, 619);
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
            // dataGridNewOtherStock
            // 
            this.dataGridNewOtherStock.AllowUserToDeleteRows = false;
            this.dataGridNewOtherStock.AllowUserToOrderColumns = true;
            this.dataGridNewOtherStock.AllowUserToResizeColumns = false;
            this.dataGridNewOtherStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridNewOtherStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridNewOtherStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridNewOtherStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridNewOtherStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridNewOtherStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridNewOtherStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridNewOtherStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridNewOtherStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridNewOtherStock.ColumnHeadersHeight = 22;
            this.dataGridNewOtherStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridNewOtherStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.new_product_id,
            this.new_product_description,
            this.new_qty,
            this.new_unit_cost,
            this.new_total_cost,
            this.new_product_type,
            this.new_qty_on_hand,
            this.new_qty_available});
            this.dataGridNewOtherStock.Enabled = false;
            this.dataGridNewOtherStock.EnableHeadersVisualStyles = false;
            this.dataGridNewOtherStock.Location = new System.Drawing.Point(16, 188);
            this.dataGridNewOtherStock.Name = "dataGridNewOtherStock";
            this.dataGridNewOtherStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridNewOtherStock.RowHeadersVisible = false;
            this.dataGridNewOtherStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridNewOtherStock.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridNewOtherStock.RowTemplate.Height = 25;
            this.dataGridNewOtherStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridNewOtherStock.Size = new System.Drawing.Size(1175, 413);
            this.dataGridNewOtherStock.TabIndex = 352;
            this.dataGridNewOtherStock.DataSourceChanged += new System.EventHandler(this.dataGridNewOtherStock_DataSourceChanged);
            this.dataGridNewOtherStock.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNewOtherStock_CellValueChanged);
            // 
            // new_product_id
            // 
            this.new_product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.new_product_id.DataPropertyName = "product_id";
            this.new_product_id.HeaderText = "PRODUCT ID";
            this.new_product_id.Name = "new_product_id";
            // 
            // new_product_description
            // 
            this.new_product_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.new_product_description.DataPropertyName = "product_description";
            this.new_product_description.HeaderText = "PRODUCT DESCRIPTION";
            this.new_product_description.Name = "new_product_description";
            this.new_product_description.ReadOnly = true;
            // 
            // new_qty
            // 
            this.new_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.new_qty.DataPropertyName = "qty";
            this.new_qty.HeaderText = "QUANTITY";
            this.new_qty.Name = "new_qty";
            // 
            // new_unit_cost
            // 
            this.new_unit_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.new_unit_cost.DataPropertyName = "unit_cost";
            this.new_unit_cost.HeaderText = "UNIT COST";
            this.new_unit_cost.Name = "new_unit_cost";
            this.new_unit_cost.ReadOnly = true;
            this.new_unit_cost.Visible = false;
            // 
            // new_total_cost
            // 
            this.new_total_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.new_total_cost.DataPropertyName = "total_cost";
            this.new_total_cost.HeaderText = "TOTAL COST";
            this.new_total_cost.Name = "new_total_cost";
            this.new_total_cost.ReadOnly = true;
            this.new_total_cost.Visible = false;
            // 
            // new_product_type
            // 
            this.new_product_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.new_product_type.DataPropertyName = "product_type";
            this.new_product_type.HeaderText = "PRODUCT TYPE";
            this.new_product_type.Name = "new_product_type";
            this.new_product_type.ReadOnly = true;
            // 
            // new_qty_on_hand
            // 
            this.new_qty_on_hand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.new_qty_on_hand.DataPropertyName = "qty_on_hand";
            this.new_qty_on_hand.HeaderText = "QTY ON HAND";
            this.new_qty_on_hand.Name = "new_qty_on_hand";
            this.new_qty_on_hand.ReadOnly = true;
            // 
            // new_qty_available
            // 
            this.new_qty_available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.new_qty_available.DataPropertyName = "qty_available";
            this.new_qty_available.HeaderText = "QTY AVAILABLE";
            this.new_qty_available.Name = "new_qty_available";
            this.new_qty_available.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel2.Controls.Add(this.cboNewWarehouseID, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblWarehouseID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblMemo, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblReference, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtBoxReference, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtBoxNewMemo, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.cboNewTxnType, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTxnType, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTxnDate, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.dtpNewTxnDate, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnLineEntry, 2, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.28828F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.57656F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.28828F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.57656F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.28828F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.98206F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1182, 176);
            this.tableLayoutPanel2.TabIndex = 351;
            // 
            // cboNewWarehouseID
            // 
            this.cboNewWarehouseID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNewWarehouseID.BackColor = System.Drawing.Color.White;
            this.cboNewWarehouseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboNewWarehouseID.ForeColor = System.Drawing.Color.DimGray;
            this.cboNewWarehouseID.FormattingEnabled = true;
            this.cboNewWarehouseID.Location = new System.Drawing.Point(3, 21);
            this.cboNewWarehouseID.Name = "cboNewWarehouseID";
            this.cboNewWarehouseID.Size = new System.Drawing.Size(573, 23);
            this.cboNewWarehouseID.TabIndex = 44;
            this.cboNewWarehouseID.Text = "Warehouse ID";
            this.cboNewWarehouseID.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboNewWarehouseID.TiraMandatory = false;
            this.cboNewWarehouseID.TiraPlaceHolder = "Warehouse ID";
            this.cboNewWarehouseID.SelectedIndexChanged += new System.EventHandler(this.cboNewWarehouseID_SelectedIndexChanged);
            // 
            // lblWarehouseID
            // 
            this.lblWarehouseID.AutoSize = true;
            this.lblWarehouseID.Location = new System.Drawing.Point(3, 0);
            this.lblWarehouseID.Name = "lblWarehouseID";
            this.lblWarehouseID.Size = new System.Drawing.Size(76, 13);
            this.lblWarehouseID.TabIndex = 0;
            this.lblWarehouseID.Text = "Warehouse ID";
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(3, 108);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(36, 13);
            this.lblMemo.TabIndex = 4;
            this.lblMemo.Text = "Memo";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(3, 54);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(57, 13);
            this.lblReference.TabIndex = 2;
            this.lblReference.Text = "Reference";
            // 
            // txtBoxReference
            // 
            this.txtBoxReference.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxReference.BackColor = System.Drawing.Color.White;
            this.txtBoxReference.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxReference.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxReference.Location = new System.Drawing.Point(3, 75);
            this.txtBoxReference.MaxLength = 255;
            this.txtBoxReference.Name = "txtBoxReference";
            this.txtBoxReference.Size = new System.Drawing.Size(573, 23);
            this.txtBoxReference.TabIndex = 57;
            this.txtBoxReference.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxReference.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxReference.TiraMandatory = false;
            this.txtBoxReference.TiraPlaceHolder = null;
            this.txtBoxReference.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // txtBoxNewMemo
            // 
            this.txtBoxNewMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNewMemo.BackColor = System.Drawing.Color.White;
            this.txtBoxNewMemo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxNewMemo.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxNewMemo.Location = new System.Drawing.Point(3, 129);
            this.txtBoxNewMemo.MaxLength = 255;
            this.txtBoxNewMemo.Multiline = true;
            this.txtBoxNewMemo.Name = "txtBoxNewMemo";
            this.txtBoxNewMemo.Size = new System.Drawing.Size(573, 44);
            this.txtBoxNewMemo.TabIndex = 58;
            this.txtBoxNewMemo.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxNewMemo.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxNewMemo.TiraMandatory = false;
            this.txtBoxNewMemo.TiraPlaceHolder = null;
            this.txtBoxNewMemo.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // cboNewTxnType
            // 
            this.cboNewTxnType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNewTxnType.BackColor = System.Drawing.Color.White;
            this.cboNewTxnType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboNewTxnType.ForeColor = System.Drawing.Color.DimGray;
            this.cboNewTxnType.FormattingEnabled = true;
            this.cboNewTxnType.Location = new System.Drawing.Point(605, 21);
            this.cboNewTxnType.Name = "cboNewTxnType";
            this.cboNewTxnType.Size = new System.Drawing.Size(574, 23);
            this.cboNewTxnType.TabIndex = 56;
            this.cboNewTxnType.Text = "Txn Type";
            this.cboNewTxnType.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboNewTxnType.TiraMandatory = false;
            this.cboNewTxnType.TiraPlaceHolder = "Txn Type";
            this.cboNewTxnType.SelectedIndexChanged += new System.EventHandler(this.cboNewTxnType_SelectedIndexChanged);
            // 
            // lblTxnType
            // 
            this.lblTxnType.AutoSize = true;
            this.lblTxnType.Location = new System.Drawing.Point(605, 0);
            this.lblTxnType.Name = "lblTxnType";
            this.lblTxnType.Size = new System.Drawing.Size(52, 13);
            this.lblTxnType.TabIndex = 1;
            this.lblTxnType.Text = "Txn Type";
            // 
            // lblTxnDate
            // 
            this.lblTxnDate.AutoSize = true;
            this.lblTxnDate.Location = new System.Drawing.Point(605, 54);
            this.lblTxnDate.Name = "lblTxnDate";
            this.lblTxnDate.Size = new System.Drawing.Size(48, 13);
            this.lblTxnDate.TabIndex = 3;
            this.lblTxnDate.Text = "TxnDate";
            // 
            // dtpNewTxnDate
            // 
            this.dtpNewTxnDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNewTxnDate.Enabled = false;
            this.dtpNewTxnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNewTxnDate.Location = new System.Drawing.Point(605, 75);
            this.dtpNewTxnDate.Name = "dtpNewTxnDate";
            this.dtpNewTxnDate.Size = new System.Drawing.Size(574, 20);
            this.dtpNewTxnDate.TabIndex = 59;
            // 
            // btnLineEntry
            // 
            this.btnLineEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnLineEntry.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLineEntry.FlatAppearance.BorderSize = 0;
            this.btnLineEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLineEntry.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLineEntry.ForeColor = System.Drawing.Color.White;
            this.btnLineEntry.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnLineEntry.IconColor = System.Drawing.Color.White;
            this.btnLineEntry.IconSize = 20;
            this.btnLineEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLineEntry.Location = new System.Drawing.Point(605, 129);
            this.btnLineEntry.Name = "btnLineEntry";
            this.btnLineEntry.Rotation = 0D;
            this.btnLineEntry.Size = new System.Drawing.Size(94, 30);
            this.btnLineEntry.TabIndex = 352;
            this.btnLineEntry.Text = "Line Entry";
            this.btnLineEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLineEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLineEntry.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnLineEntry.UseVisualStyleBackColor = false;
            this.btnLineEntry.Click += new System.EventHandler(this.btnLineEntry_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnSave.Location = new System.Drawing.Point(1108, 607);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 348;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnCancel.Location = new System.Drawing.Point(1022, 607);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 349;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // IM_OtherStockTransactionEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 701);
            this.Controls.Add(this.panelNew);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "IM_OtherStockTransactionEntryUI";
            this.Text = "IM_OtherStockTransactionEntryUI";
            this.Load += new System.EventHandler(this.IM_OtherStockTransactionEntryUI_Load);
            this.panelTopMenu.ResumeLayout(false);
            this.panelNew.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOtherStock)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxPaging.ResumeLayout(false);
            this.groupBoxPaging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNewOtherStock)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjOtherStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjSearchWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjNewWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjSearchTxnType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjNewTxnType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Tira.Component.TiraButton navNew;
        private Tira.Component.TiraButton navView;
        private Tira.Component.TiraButton navClose;
        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.Panel panelNew;
        private System.Windows.Forms.Panel panelView;
        private Tira.Component.TiraDataGrid dataGridOtherStock;
        private Tira.Component.TiraGroupBox groupBoxSearch;
        private Tira.Component.TiraButton btnSearch;
        private Tira.Component.TiraGroupBox groupBoxPaging;
        internal System.Windows.Forms.Label lblPagingInfo;
        internal System.Windows.Forms.Label lblRows;
        private Tira.Component.TiraButton btnPrev;
        private Tira.Component.TiraButton btnNext;
        private Tira.Component.TiraComboBox cboSearchWarehouseID;
        private Tira.Component.TiraComboBox cboSearchSubGroup;
        private System.Windows.Forms.Label lblSearchSubGroup;
        private Tira.Component.TiraComboBox cboSearchGroup;
        private System.Windows.Forms.Label lblSearchGroup;
        private System.Windows.Forms.Label lblSearchTxnType;
        private System.Windows.Forms.Label lblSearchRangeDate;
        private Tira.Component.TiraCheckBox cbSearchRangeDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblWarehouseID;
        private Tira.Component.TiraButton btnCancel;
        private Tira.Component.TiraButton btnSave;
        private Tira.Component.TiraDataGrid dataGridNewOtherStock;
        private Tira.Component.TiraButton btnLineEntry;
        private Tira.Component.TiraComboBox cboNewTxnType;
        private Tira.Component.TiraComboBox cboNewWarehouseID;
        private System.Windows.Forms.Label lblTxnType;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label lblTxnDate;
        private Tira.Component.TiraTextBox txtBoxReference;
        private Tira.Component.TiraTextBox txtBoxNewMemo;
        private System.Windows.Forms.DateTimePicker dtpNewTxnDate;
        private System.Windows.Forms.BindingSource bindingObjOtherStock;
        private System.Windows.Forms.DateTimePicker dtpSearchPrintDate;
        private Tira.Component.TiraComboBox cboSearchTxnType;
        private System.Windows.Forms.Label lblSearchFrom;
        private System.Windows.Forms.DateTimePicker dtpSearchFrom;
        private System.Windows.Forms.Label lblSearchTo;
        private System.Windows.Forms.DateTimePicker dtpSearchTo;
        private Tira.Component.TiraTextBox txtBoxSearchProductID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSearchWarehouseID;
        private System.Windows.Forms.Label lblSearchPrintDate;
        private Tira.Component.TiraButton btnSearchLookUpProduct;
        private Tira.Component.TiraTextBox txtBoxSearchProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_group_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_product_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_unit_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_total_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_product_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_qty_on_hand;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_qty_available;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblSearchProductName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Tira.Component.TiraButton btnCancelLineEntry;
        private System.Windows.Forms.BindingSource bindingObjSearchWarehouse;
        private System.Windows.Forms.BindingSource bindingObjNewWarehouse;
        private System.Windows.Forms.BindingSource bindingObjSearchTxnType;
        private System.Windows.Forms.BindingSource bindingObjNewTxnType;
    }
}