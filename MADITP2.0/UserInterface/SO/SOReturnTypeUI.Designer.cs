namespace MADITP2._0.UserInterface.SO
{
    partial class SOReturnTypeUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.navClose = new Tira.Component.TiraButton();
            this.navExport = new Tira.Component.TiraButton();
            this.navPrint = new Tira.Component.TiraButton();
            this.navDelete = new Tira.Component.TiraButton();
            this.navEdit = new Tira.Component.TiraButton();
            this.navNew = new Tira.Component.TiraButton();
            this.navView = new Tira.Component.TiraButton();
            this.tiraDataGrid1 = new Tira.Component.TiraDataGrid();
            this.ot_return_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_invoice_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_inv_return_txn_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_return_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_create_kp_baru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_update_stock_allowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_update_achievement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_update_stock_allowed_pengganti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_update_acheivement_allowed_pengganti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_check_receipt_warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelView = new System.Windows.Forms.Panel();
            this.panelEditor = new System.Windows.Forms.Panel();
            this.buttonCancel = new Tira.Component.TiraButton();
            this.buttonSave = new Tira.Component.TiraButton();
            this.privilige = new Tira.Component.TiraGroupBox();
            this.createNewKP = new Tira.Component.TiraCheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.updateAchP = new Tira.Component.TiraCheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.updateStockP = new Tira.Component.TiraCheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.receiptWarehouse = new Tira.Component.TiraCheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.updateAch = new Tira.Component.TiraCheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.updateStock = new Tira.Component.TiraCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.returnGroup = new Tira.Component.TiraTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.invReturnType = new Tira.Component.TiraTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.invType = new Tira.Component.TiraTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.desc = new Tira.Component.TiraTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.returnType = new Tira.Component.TiraTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiraDataGrid1)).BeginInit();
            this.panelView.SuspendLayout();
            this.panelEditor.SuspendLayout();
            this.privilige.SuspendLayout();
            this.SuspendLayout();
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
            this.panelTopMenu.Size = new System.Drawing.Size(800, 30);
            this.panelTopMenu.TabIndex = 3;
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
            this.navClose.Location = new System.Drawing.Point(770, 0);
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
            // tiraDataGrid1
            // 
            this.tiraDataGrid1.AllowUserToAddRows = false;
            this.tiraDataGrid1.AllowUserToDeleteRows = false;
            this.tiraDataGrid1.AllowUserToOrderColumns = true;
            this.tiraDataGrid1.AllowUserToResizeColumns = false;
            this.tiraDataGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.tiraDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.tiraDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tiraDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tiraDataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tiraDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tiraDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tiraDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tiraDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tiraDataGrid1.ColumnHeadersHeight = 27;
            this.tiraDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tiraDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ot_return_type,
            this.ot_desc,
            this.ot_invoice_type,
            this.ot_inv_return_txn_type,
            this.ot_return_group,
            this.ot_create_kp_baru,
            this.ot_update_stock_allowed,
            this.ot_update_achievement,
            this.ot_update_stock_allowed_pengganti,
            this.ot_update_acheivement_allowed_pengganti,
            this.ot_check_receipt_warehouse});
            this.tiraDataGrid1.EnableHeadersVisualStyles = false;
            this.tiraDataGrid1.Location = new System.Drawing.Point(12, 6);
            this.tiraDataGrid1.Name = "tiraDataGrid1";
            this.tiraDataGrid1.ReadOnly = true;
            this.tiraDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tiraDataGrid1.RowHeadersVisible = false;
            this.tiraDataGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.tiraDataGrid1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.tiraDataGrid1.RowTemplate.Height = 25;
            this.tiraDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tiraDataGrid1.Size = new System.Drawing.Size(776, 200);
            this.tiraDataGrid1.TabIndex = 4;
            // 
            // ot_return_type
            // 
            this.ot_return_type.DataPropertyName = "ot_return_type";
            this.ot_return_type.HeaderText = "RETURN TYPE";
            this.ot_return_type.Name = "ot_return_type";
            this.ot_return_type.ReadOnly = true;
            this.ot_return_type.Width = 98;
            // 
            // ot_desc
            // 
            this.ot_desc.DataPropertyName = "ot_desc";
            this.ot_desc.HeaderText = "DESCRIPTION";
            this.ot_desc.Name = "ot_desc";
            this.ot_desc.ReadOnly = true;
            this.ot_desc.Width = 99;
            // 
            // ot_invoice_type
            // 
            this.ot_invoice_type.DataPropertyName = "ot_invoice_type";
            this.ot_invoice_type.HeaderText = "INVOICE TYPE";
            this.ot_invoice_type.Name = "ot_invoice_type";
            this.ot_invoice_type.ReadOnly = true;
            this.ot_invoice_type.Width = 99;
            // 
            // ot_inv_return_txn_type
            // 
            this.ot_inv_return_txn_type.DataPropertyName = "ot_inv_return_txn_type";
            this.ot_inv_return_txn_type.HeaderText = "IM TXN TYPE";
            this.ot_inv_return_txn_type.Name = "ot_inv_return_txn_type";
            this.ot_inv_return_txn_type.ReadOnly = true;
            this.ot_inv_return_txn_type.Width = 92;
            // 
            // ot_return_group
            // 
            this.ot_return_group.DataPropertyName = "ot_return_group";
            this.ot_return_group.HeaderText = "RETURN GROUP";
            this.ot_return_group.Name = "ot_return_group";
            this.ot_return_group.ReadOnly = true;
            this.ot_return_group.Width = 113;
            // 
            // ot_create_kp_baru
            // 
            this.ot_create_kp_baru.DataPropertyName = "ot_create_kp_baru";
            this.ot_create_kp_baru.HeaderText = "CREATE NEW KP";
            this.ot_create_kp_baru.Name = "ot_create_kp_baru";
            this.ot_create_kp_baru.ReadOnly = true;
            this.ot_create_kp_baru.Width = 111;
            // 
            // ot_update_stock_allowed
            // 
            this.ot_update_stock_allowed.DataPropertyName = "ot_update_stock_allowed";
            this.ot_update_stock_allowed.HeaderText = "UPDATE STOCK";
            this.ot_update_stock_allowed.Name = "ot_update_stock_allowed";
            this.ot_update_stock_allowed.ReadOnly = true;
            this.ot_update_stock_allowed.Width = 106;
            // 
            // ot_update_achievement
            // 
            this.ot_update_achievement.DataPropertyName = "ot_update_achievement";
            this.ot_update_achievement.HeaderText = "UPDATE ACHIEVEMENT";
            this.ot_update_achievement.Name = "ot_update_achievement";
            this.ot_update_achievement.ReadOnly = true;
            this.ot_update_achievement.Width = 147;
            // 
            // ot_update_stock_allowed_pengganti
            // 
            this.ot_update_stock_allowed_pengganti.DataPropertyName = "ot_update_stock_allowed_pengganti";
            this.ot_update_stock_allowed_pengganti.HeaderText = "UPDATE STOCK PENGGANTI";
            this.ot_update_stock_allowed_pengganti.Name = "ot_update_stock_allowed_pengganti";
            this.ot_update_stock_allowed_pengganti.ReadOnly = true;
            this.ot_update_stock_allowed_pengganti.Width = 169;
            // 
            // ot_update_acheivement_allowed_pengganti
            // 
            this.ot_update_acheivement_allowed_pengganti.DataPropertyName = "ot_update_acheivement_allowed_pengganti";
            this.ot_update_acheivement_allowed_pengganti.HeaderText = "UPDATE ACHIEVEMENT PENGGANTI";
            this.ot_update_acheivement_allowed_pengganti.Name = "ot_update_acheivement_allowed_pengganti";
            this.ot_update_acheivement_allowed_pengganti.ReadOnly = true;
            this.ot_update_acheivement_allowed_pengganti.Width = 210;
            // 
            // ot_check_receipt_warehouse
            // 
            this.ot_check_receipt_warehouse.DataPropertyName = "ot_check_receipt_warehouse";
            this.ot_check_receipt_warehouse.HeaderText = "RECEIPT WAREHOUSE";
            this.ot_check_receipt_warehouse.Name = "ot_check_receipt_warehouse";
            this.ot_check_receipt_warehouse.ReadOnly = true;
            this.ot_check_receipt_warehouse.Width = 142;
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.tiraDataGrid1);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 30);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(800, 420);
            this.panelView.TabIndex = 5;
            // 
            // panelEditor
            // 
            this.panelEditor.Controls.Add(this.buttonCancel);
            this.panelEditor.Controls.Add(this.buttonSave);
            this.panelEditor.Controls.Add(this.privilige);
            this.panelEditor.Controls.Add(this.returnGroup);
            this.panelEditor.Controls.Add(this.label5);
            this.panelEditor.Controls.Add(this.invReturnType);
            this.panelEditor.Controls.Add(this.label4);
            this.panelEditor.Controls.Add(this.invType);
            this.panelEditor.Controls.Add(this.label3);
            this.panelEditor.Controls.Add(this.desc);
            this.panelEditor.Controls.Add(this.label2);
            this.panelEditor.Controls.Add(this.returnType);
            this.panelEditor.Controls.Add(this.label1);
            this.panelEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditor.Location = new System.Drawing.Point(0, 30);
            this.panelEditor.Name = "panelEditor";
            this.panelEditor.Size = new System.Drawing.Size(800, 420);
            this.panelEditor.TabIndex = 6;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.buttonCancel.IconColor = System.Drawing.Color.Black;
            this.buttonCancel.IconSize = 20;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(244, 363);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Rotation = 0D;
            this.buttonCancel.Size = new System.Drawing.Size(80, 30);
            this.buttonCancel.TabIndex = 45;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.buttonSave.IconColor = System.Drawing.Color.White;
            this.buttonSave.IconSize = 20;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(330, 363);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Rotation = 0D;
            this.buttonSave.Size = new System.Drawing.Size(80, 30);
            this.buttonSave.TabIndex = 44;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.TiraLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // privilige
            // 
            this.privilige.Controls.Add(this.createNewKP);
            this.privilige.Controls.Add(this.label11);
            this.privilige.Controls.Add(this.updateAchP);
            this.privilige.Controls.Add(this.label10);
            this.privilige.Controls.Add(this.updateStockP);
            this.privilige.Controls.Add(this.label9);
            this.privilige.Controls.Add(this.receiptWarehouse);
            this.privilige.Controls.Add(this.label8);
            this.privilige.Controls.Add(this.updateAch);
            this.privilige.Controls.Add(this.label7);
            this.privilige.Controls.Add(this.updateStock);
            this.privilige.Controls.Add(this.label6);
            this.privilige.Location = new System.Drawing.Point(12, 219);
            this.privilige.Name = "privilige";
            this.privilige.Size = new System.Drawing.Size(398, 138);
            this.privilige.TabIndex = 10;
            this.privilige.TabStop = false;
            this.privilige.Text = "Privilege";
            this.privilige.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.privilige.TiraTextColor = System.Drawing.Color.Black;
            // 
            // createNewKP
            // 
            this.createNewKP.Location = new System.Drawing.Point(183, 112);
            this.createNewKP.Name = "createNewKP";
            this.createNewKP.Size = new System.Drawing.Size(100, 20);
            this.createNewKP.TabIndex = 22;
            this.createNewKP.Text = "No";
            this.createNewKP.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.createNewKP.UseVisualStyleBackColor = true;
            this.createNewKP.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Create New KP Pengganti";
            // 
            // updateAchP
            // 
            this.updateAchP.Location = new System.Drawing.Point(183, 73);
            this.updateAchP.Name = "updateAchP";
            this.updateAchP.Size = new System.Drawing.Size(100, 20);
            this.updateAchP.TabIndex = 20;
            this.updateAchP.Text = "No";
            this.updateAchP.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.updateAchP.UseVisualStyleBackColor = true;
            this.updateAchP.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Update Achievement Pengganti";
            // 
            // updateStockP
            // 
            this.updateStockP.Location = new System.Drawing.Point(183, 34);
            this.updateStockP.Name = "updateStockP";
            this.updateStockP.Size = new System.Drawing.Size(100, 20);
            this.updateStockP.TabIndex = 18;
            this.updateStockP.Text = "No";
            this.updateStockP.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.updateStockP.UseVisualStyleBackColor = true;
            this.updateStockP.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Update Stock Pengganti";
            // 
            // receiptWarehouse
            // 
            this.receiptWarehouse.Location = new System.Drawing.Point(9, 112);
            this.receiptWarehouse.Name = "receiptWarehouse";
            this.receiptWarehouse.Size = new System.Drawing.Size(100, 20);
            this.receiptWarehouse.TabIndex = 16;
            this.receiptWarehouse.Text = "No";
            this.receiptWarehouse.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.receiptWarehouse.UseVisualStyleBackColor = true;
            this.receiptWarehouse.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Receipt Warehouse";
            // 
            // updateAch
            // 
            this.updateAch.Location = new System.Drawing.Point(9, 73);
            this.updateAch.Name = "updateAch";
            this.updateAch.Size = new System.Drawing.Size(100, 20);
            this.updateAch.TabIndex = 14;
            this.updateAch.Text = "No";
            this.updateAch.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.updateAch.UseVisualStyleBackColor = true;
            this.updateAch.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Update Achievement";
            // 
            // updateStock
            // 
            this.updateStock.Location = new System.Drawing.Point(9, 34);
            this.updateStock.Name = "updateStock";
            this.updateStock.Size = new System.Drawing.Size(100, 20);
            this.updateStock.TabIndex = 12;
            this.updateStock.Text = "No";
            this.updateStock.TiraColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.updateStock.UseVisualStyleBackColor = true;
            this.updateStock.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Update Stock";
            // 
            // returnGroup
            // 
            this.returnGroup.BackColor = System.Drawing.Color.White;
            this.returnGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.returnGroup.ForeColor = System.Drawing.Color.DimGray;
            this.returnGroup.Location = new System.Drawing.Point(12, 190);
            this.returnGroup.MaxLength = 5;
            this.returnGroup.Name = "returnGroup";
            this.returnGroup.Size = new System.Drawing.Size(398, 23);
            this.returnGroup.TabIndex = 9;
            this.returnGroup.TiraBorderColor = System.Drawing.Color.Silver;
            this.returnGroup.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.returnGroup.TiraMandatory = false;
            this.returnGroup.TiraPlaceHolder = null;
            this.returnGroup.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Return Group";
            // 
            // invReturnType
            // 
            this.invReturnType.BackColor = System.Drawing.Color.White;
            this.invReturnType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.invReturnType.ForeColor = System.Drawing.Color.DimGray;
            this.invReturnType.Location = new System.Drawing.Point(12, 148);
            this.invReturnType.MaxLength = 3;
            this.invReturnType.Name = "invReturnType";
            this.invReturnType.Size = new System.Drawing.Size(398, 23);
            this.invReturnType.TabIndex = 7;
            this.invReturnType.TiraBorderColor = System.Drawing.Color.Silver;
            this.invReturnType.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.invReturnType.TiraMandatory = false;
            this.invReturnType.TiraPlaceHolder = null;
            this.invReturnType.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Invoice Return Txn Type";
            // 
            // invType
            // 
            this.invType.BackColor = System.Drawing.Color.White;
            this.invType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.invType.ForeColor = System.Drawing.Color.DimGray;
            this.invType.Location = new System.Drawing.Point(12, 106);
            this.invType.MaxLength = 5;
            this.invType.Name = "invType";
            this.invType.Size = new System.Drawing.Size(398, 23);
            this.invType.TabIndex = 5;
            this.invType.TiraBorderColor = System.Drawing.Color.Silver;
            this.invType.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.invType.TiraMandatory = false;
            this.invType.TiraPlaceHolder = null;
            this.invType.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Invoice Type";
            // 
            // desc
            // 
            this.desc.BackColor = System.Drawing.Color.White;
            this.desc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.desc.ForeColor = System.Drawing.Color.DimGray;
            this.desc.Location = new System.Drawing.Point(12, 64);
            this.desc.MaxLength = 50;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(398, 23);
            this.desc.TabIndex = 3;
            this.desc.TiraBorderColor = System.Drawing.Color.Silver;
            this.desc.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.desc.TiraMandatory = false;
            this.desc.TiraPlaceHolder = null;
            this.desc.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Return Type Description";
            // 
            // returnType
            // 
            this.returnType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(224)))));
            this.returnType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.returnType.ForeColor = System.Drawing.Color.DimGray;
            this.returnType.Location = new System.Drawing.Point(12, 22);
            this.returnType.MaxLength = 5;
            this.returnType.Name = "returnType";
            this.returnType.Size = new System.Drawing.Size(398, 23);
            this.returnType.TabIndex = 1;
            this.returnType.TiraBorderColor = System.Drawing.Color.Silver;
            this.returnType.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.returnType.TiraMandatory = true;
            this.returnType.TiraPlaceHolder = null;
            this.returnType.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return Type";
            // 
            // SOReturnTypeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelEditor);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelTopMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SOReturnTypeUI";
            this.Text = "SOReturnTypeUI";
            this.Load += new System.EventHandler(this.SOReturnTypeUI_Load);
            this.panelTopMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tiraDataGrid1)).EndInit();
            this.panelView.ResumeLayout(false);
            this.panelEditor.ResumeLayout(false);
            this.panelEditor.PerformLayout();
            this.privilige.ResumeLayout(false);
            this.privilige.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopMenu;
        private Tira.Component.TiraButton navClose;
        private Tira.Component.TiraButton navExport;
        private Tira.Component.TiraButton navPrint;
        private Tira.Component.TiraButton navDelete;
        private Tira.Component.TiraButton navEdit;
        private Tira.Component.TiraButton navNew;
        private Tira.Component.TiraButton navView;
        private Tira.Component.TiraDataGrid tiraDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_return_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_invoice_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_inv_return_txn_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_return_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_create_kp_baru;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_update_stock_allowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_update_achievement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_update_stock_allowed_pengganti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_update_acheivement_allowed_pengganti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_check_receipt_warehouse;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Panel panelEditor;
        private Tira.Component.TiraGroupBox privilige;
        private Tira.Component.TiraCheckBox createNewKP;
        private System.Windows.Forms.Label label11;
        private Tira.Component.TiraCheckBox updateAchP;
        private System.Windows.Forms.Label label10;
        private Tira.Component.TiraCheckBox updateStockP;
        private System.Windows.Forms.Label label9;
        private Tira.Component.TiraCheckBox receiptWarehouse;
        private System.Windows.Forms.Label label8;
        private Tira.Component.TiraCheckBox updateAch;
        private System.Windows.Forms.Label label7;
        private Tira.Component.TiraCheckBox updateStock;
        private System.Windows.Forms.Label label6;
        private Tira.Component.TiraTextBox returnGroup;
        private System.Windows.Forms.Label label5;
        private Tira.Component.TiraTextBox invReturnType;
        private System.Windows.Forms.Label label4;
        private Tira.Component.TiraTextBox invType;
        private System.Windows.Forms.Label label3;
        private Tira.Component.TiraTextBox desc;
        private System.Windows.Forms.Label label2;
        private Tira.Component.TiraTextBox returnType;
        private System.Windows.Forms.Label label1;
        private Tira.Component.TiraButton buttonCancel;
        private Tira.Component.TiraButton buttonSave;
    }
}