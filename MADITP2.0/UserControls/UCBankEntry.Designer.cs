namespace MADITP2._0.UserControls
{
    partial class UCBankEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grd = new Tira.Component.TiraDataGrid();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GLAccountBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GLAccountDivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GLAccountDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GLAccountMajor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GLAccountMajor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GLAccountMinor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GLAccountAnalysis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GLAccountFiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new Tira.Component.TiraDataGridCheckBox();
            this.DCRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebitRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFooter = new Tira.Component.TiraGroupBox();
            this.lblOutOfBalanceValueCredit = new System.Windows.Forms.Label();
            this.lblOutOfBalanceValueDebit = new System.Windows.Forms.Label();
            this.lblCashCode = new System.Windows.Forms.Label();
            this.lblCashCodeValue = new System.Windows.Forms.Label();
            this.lblOutOfBalance = new System.Windows.Forms.Label();
            this.txtTotalKredit = new Tira.Component.TiraTextBox();
            this.txtTotalDebit = new Tira.Component.TiraTextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.txtMessage = new Tira.Component.TiraTextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.grpFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.AllowUserToOrderColumns = true;
            this.grd.AllowUserToResizeColumns = false;
            this.grd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grd.ColumnHeadersHeight = 22;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.GLAccountBranch,
            this.GLAccountDivision,
            this.GLAccountDepartment,
            this.GLAccountMajor1,
            this.GLAccountMajor2,
            this.GLAccountMinor,
            this.GLAccountAnalysis,
            this.GLAccountFiler,
            this.AddBook,
            this.TransactionDescription,
            this.DC,
            this.Debit,
            this.Credit,
            this.Delete,
            this.DCRes,
            this.DebitRes,
            this.CreditRes,
            this.CashCode});
            this.grd.EnableHeadersVisualStyles = false;
            this.grd.Location = new System.Drawing.Point(3, 3);
            this.grd.Name = "grd";
            this.grd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grd.RowHeadersVisible = false;
            this.grd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(189)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.grd.RowsDefaultCellStyle = dataGridViewCellStyle17;
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd.Size = new System.Drawing.Size(949, 286);
            this.grd.TabIndex = 2;
            this.grd.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grd_CellBeginEdit);
            this.grd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellClick);
            this.grd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellContentClick);
            this.grd.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellEndEdit);
            this.grd.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grd_CellFormatting);
            this.grd.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grd_EditingControlShowing);
            this.grd.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grd_RowsAdded);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "001";
            this.No.DefaultCellStyle = dataGridViewCellStyle3;
            this.No.HeaderText = "NO";
            this.No.MinimumWidth = 25;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 26;
            // 
            // GLAccountBranch
            // 
            this.GLAccountBranch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "00";
            this.GLAccountBranch.DefaultCellStyle = dataGridViewCellStyle4;
            this.GLAccountBranch.HeaderText = "";
            this.GLAccountBranch.MaxInputLength = 2;
            this.GLAccountBranch.MinimumWidth = 25;
            this.GLAccountBranch.Name = "GLAccountBranch";
            this.GLAccountBranch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GLAccountBranch.Width = 25;
            // 
            // GLAccountDivision
            // 
            this.GLAccountDivision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "00";
            this.GLAccountDivision.DefaultCellStyle = dataGridViewCellStyle5;
            this.GLAccountDivision.HeaderText = "";
            this.GLAccountDivision.MaxInputLength = 2;
            this.GLAccountDivision.MinimumWidth = 25;
            this.GLAccountDivision.Name = "GLAccountDivision";
            this.GLAccountDivision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GLAccountDivision.Width = 25;
            // 
            // GLAccountDepartment
            // 
            this.GLAccountDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = "00";
            this.GLAccountDepartment.DefaultCellStyle = dataGridViewCellStyle6;
            this.GLAccountDepartment.HeaderText = "";
            this.GLAccountDepartment.MaxInputLength = 2;
            this.GLAccountDepartment.MinimumWidth = 25;
            this.GLAccountDepartment.Name = "GLAccountDepartment";
            this.GLAccountDepartment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GLAccountDepartment.Width = 25;
            // 
            // GLAccountMajor1
            // 
            this.GLAccountMajor1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GLAccountMajor1.DefaultCellStyle = dataGridViewCellStyle7;
            this.GLAccountMajor1.HeaderText = "";
            this.GLAccountMajor1.MaxInputLength = 1;
            this.GLAccountMajor1.MinimumWidth = 25;
            this.GLAccountMajor1.Name = "GLAccountMajor1";
            this.GLAccountMajor1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GLAccountMajor1.Width = 25;
            // 
            // GLAccountMajor2
            // 
            this.GLAccountMajor2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GLAccountMajor2.DefaultCellStyle = dataGridViewCellStyle8;
            this.GLAccountMajor2.HeaderText = "";
            this.GLAccountMajor2.MaxInputLength = 4;
            this.GLAccountMajor2.MinimumWidth = 40;
            this.GLAccountMajor2.Name = "GLAccountMajor2";
            this.GLAccountMajor2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GLAccountMajor2.Width = 40;
            // 
            // GLAccountMinor
            // 
            this.GLAccountMinor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GLAccountMinor.DefaultCellStyle = dataGridViewCellStyle9;
            this.GLAccountMinor.HeaderText = "";
            this.GLAccountMinor.MaxInputLength = 2;
            this.GLAccountMinor.MinimumWidth = 25;
            this.GLAccountMinor.Name = "GLAccountMinor";
            this.GLAccountMinor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GLAccountMinor.Width = 25;
            // 
            // GLAccountAnalysis
            // 
            this.GLAccountAnalysis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GLAccountAnalysis.DefaultCellStyle = dataGridViewCellStyle10;
            this.GLAccountAnalysis.HeaderText = "";
            this.GLAccountAnalysis.MaxInputLength = 2;
            this.GLAccountAnalysis.MinimumWidth = 25;
            this.GLAccountAnalysis.Name = "GLAccountAnalysis";
            this.GLAccountAnalysis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GLAccountAnalysis.Width = 25;
            // 
            // GLAccountFiler
            // 
            this.GLAccountFiler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.NullValue = "000";
            this.GLAccountFiler.DefaultCellStyle = dataGridViewCellStyle11;
            this.GLAccountFiler.HeaderText = "";
            this.GLAccountFiler.MaxInputLength = 3;
            this.GLAccountFiler.MinimumWidth = 40;
            this.GLAccountFiler.Name = "GLAccountFiler";
            this.GLAccountFiler.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GLAccountFiler.Width = 40;
            // 
            // AddBook
            // 
            this.AddBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AddBook.HeaderText = "ADD BOOK";
            this.AddBook.MinimumWidth = 100;
            this.AddBook.Name = "AddBook";
            this.AddBook.ReadOnly = true;
            // 
            // TransactionDescription
            // 
            this.TransactionDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TransactionDescription.HeaderText = "TRANSACTION DESCRIPTION";
            this.TransactionDescription.MinimumWidth = 200;
            this.TransactionDescription.Name = "TransactionDescription";
            // 
            // DC
            // 
            this.DC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DC.DefaultCellStyle = dataGridViewCellStyle12;
            this.DC.HeaderText = "D/C";
            this.DC.MaxInputLength = 1;
            this.DC.MinimumWidth = 35;
            this.DC.Name = "DC";
            this.DC.Width = 35;
            // 
            // Debit
            // 
            this.Debit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.NullValue = null;
            this.Debit.DefaultCellStyle = dataGridViewCellStyle13;
            this.Debit.HeaderText = "DEBIT";
            this.Debit.MinimumWidth = 120;
            this.Debit.Name = "Debit";
            this.Debit.Width = 120;
            // 
            // Credit
            // 
            this.Credit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.NullValue = null;
            this.Credit.DefaultCellStyle = dataGridViewCellStyle14;
            this.Credit.HeaderText = "CREDIT";
            this.Credit.MinimumWidth = 120;
            this.Credit.Name = "Credit";
            this.Credit.Width = 120;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.NullValue = "false";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle15;
            this.Delete.FalseValue = "false";
            this.Delete.HeaderText = "DEL";
            this.Delete.Name = "Delete";
            this.Delete.TrueValue = "true";
            this.Delete.Width = 32;
            // 
            // DCRes
            // 
            this.DCRes.HeaderText = "DCRES";
            this.DCRes.Name = "DCRes";
            this.DCRes.Visible = false;
            this.DCRes.Width = 65;
            // 
            // DebitRes
            // 
            this.DebitRes.HeaderText = "DEBITRES";
            this.DebitRes.Name = "DebitRes";
            this.DebitRes.Visible = false;
            this.DebitRes.Width = 79;
            // 
            // CreditRes
            // 
            this.CreditRes.HeaderText = "CREDITRES";
            this.CreditRes.Name = "CreditRes";
            this.CreditRes.Visible = false;
            this.CreditRes.Width = 87;
            // 
            // CashCode
            // 
            this.CashCode.HeaderText = "CASHCODE";
            this.CashCode.Name = "CashCode";
            this.CashCode.Visible = false;
            this.CashCode.Width = 89;
            // 
            // grpFooter
            // 
            this.grpFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFooter.Controls.Add(this.lblOutOfBalanceValueCredit);
            this.grpFooter.Controls.Add(this.lblOutOfBalanceValueDebit);
            this.grpFooter.Controls.Add(this.lblCashCode);
            this.grpFooter.Controls.Add(this.lblCashCodeValue);
            this.grpFooter.Controls.Add(this.lblOutOfBalance);
            this.grpFooter.Controls.Add(this.txtTotalKredit);
            this.grpFooter.Controls.Add(this.txtTotalDebit);
            this.grpFooter.Controls.Add(this.lblTotalAmount);
            this.grpFooter.Controls.Add(this.lblInformation);
            this.grpFooter.Controls.Add(this.txtMessage);
            this.grpFooter.Controls.Add(this.lblMessage);
            this.grpFooter.Location = new System.Drawing.Point(3, 292);
            this.grpFooter.Name = "grpFooter";
            this.grpFooter.Size = new System.Drawing.Size(950, 70);
            this.grpFooter.TabIndex = 126;
            this.grpFooter.TabStop = false;
            this.grpFooter.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.grpFooter.TiraTextColor = System.Drawing.Color.Black;
            // 
            // lblOutOfBalanceValueCredit
            // 
            this.lblOutOfBalanceValueCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutOfBalanceValueCredit.ForeColor = System.Drawing.Color.Red;
            this.lblOutOfBalanceValueCredit.Location = new System.Drawing.Point(801, 45);
            this.lblOutOfBalanceValueCredit.Name = "lblOutOfBalanceValueCredit";
            this.lblOutOfBalanceValueCredit.Size = new System.Drawing.Size(124, 13);
            this.lblOutOfBalanceValueCredit.TabIndex = 126;
            this.lblOutOfBalanceValueCredit.Text = "lblOutBalValueCredit";
            this.lblOutOfBalanceValueCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutOfBalanceValueDebit
            // 
            this.lblOutOfBalanceValueDebit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutOfBalanceValueDebit.ForeColor = System.Drawing.Color.Red;
            this.lblOutOfBalanceValueDebit.Location = new System.Drawing.Point(674, 45);
            this.lblOutOfBalanceValueDebit.Name = "lblOutOfBalanceValueDebit";
            this.lblOutOfBalanceValueDebit.Size = new System.Drawing.Size(122, 13);
            this.lblOutOfBalanceValueDebit.TabIndex = 125;
            this.lblOutOfBalanceValueDebit.Text = "lblOutBalValueDebit";
            this.lblOutOfBalanceValueDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCashCode
            // 
            this.lblCashCode.AutoSize = true;
            this.lblCashCode.Location = new System.Drawing.Point(385, 45);
            this.lblCashCode.Name = "lblCashCode";
            this.lblCashCode.Size = new System.Drawing.Size(68, 13);
            this.lblCashCode.TabIndex = 124;
            this.lblCashCode.Text = "Cash Code :";
            // 
            // lblCashCodeValue
            // 
            this.lblCashCodeValue.AutoSize = true;
            this.lblCashCodeValue.Location = new System.Drawing.Point(451, 45);
            this.lblCashCodeValue.Name = "lblCashCodeValue";
            this.lblCashCodeValue.Size = new System.Drawing.Size(100, 13);
            this.lblCashCodeValue.TabIndex = 123;
            this.lblCashCodeValue.Text = "lblCashCodeValue";
            // 
            // lblOutOfBalance
            // 
            this.lblOutOfBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutOfBalance.AutoSize = true;
            this.lblOutOfBalance.Location = new System.Drawing.Point(579, 45);
            this.lblOutOfBalance.Name = "lblOutOfBalance";
            this.lblOutOfBalance.Size = new System.Drawing.Size(91, 13);
            this.lblOutOfBalance.TabIndex = 122;
            this.lblOutOfBalance.Text = "Out Of Balance :";
            // 
            // txtTotalKredit
            // 
            this.txtTotalKredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalKredit.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalKredit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalKredit.ForeColor = System.Drawing.Color.Black;
            this.txtTotalKredit.Location = new System.Drawing.Point(799, 17);
            this.txtTotalKredit.MaxLength = 255;
            this.txtTotalKredit.Name = "txtTotalKredit";
            this.txtTotalKredit.ReadOnly = true;
            this.txtTotalKredit.Size = new System.Drawing.Size(126, 23);
            this.txtTotalKredit.TabIndex = 121;
            this.txtTotalKredit.Text = "0";
            this.txtTotalKredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalKredit.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtTotalKredit.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtTotalKredit.TiraMandatory = false;
            this.txtTotalKredit.TiraPlaceHolder = null;
            this.txtTotalKredit.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // txtTotalDebit
            // 
            this.txtTotalDebit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalDebit.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalDebit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDebit.ForeColor = System.Drawing.Color.Black;
            this.txtTotalDebit.Location = new System.Drawing.Point(673, 17);
            this.txtTotalDebit.MaxLength = 255;
            this.txtTotalDebit.Name = "txtTotalDebit";
            this.txtTotalDebit.ReadOnly = true;
            this.txtTotalDebit.Size = new System.Drawing.Size(122, 23);
            this.txtTotalDebit.TabIndex = 120;
            this.txtTotalDebit.Text = "0";
            this.txtTotalDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalDebit.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtTotalDebit.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtTotalDebit.TiraMandatory = false;
            this.txtTotalDebit.TiraPlaceHolder = null;
            this.txtTotalDebit.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(589, 20);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(82, 13);
            this.lblTotalAmount.TabIndex = 119;
            this.lblTotalAmount.Text = "Total Amount :";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(68, 45);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(81, 13);
            this.lblInformation.TabIndex = 118;
            this.lblInformation.Text = "lblInformation";
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.SystemColors.Control;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.ForeColor = System.Drawing.Color.Black;
            this.txtMessage.Location = new System.Drawing.Point(69, 17);
            this.txtMessage.MaxLength = 255;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(485, 23);
            this.txtMessage.TabIndex = 117;
            this.txtMessage.Text = "Ready..";
            this.txtMessage.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtMessage.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtMessage.TiraMandatory = false;
            this.txtMessage.TiraPlaceHolder = null;
            this.txtMessage.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(8, 20);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(58, 13);
            this.lblMessage.TabIndex = 116;
            this.lblMessage.Text = "Message :";
            // 
            // UCBankEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpFooter);
            this.Controls.Add(this.grd);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCBankEntry";
            this.Size = new System.Drawing.Size(955, 366);
            this.Load += new System.EventHandler(this.UCBankEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.grpFooter.ResumeLayout(false);
            this.grpFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Tira.Component.TiraGroupBox grpFooter;
        internal System.Windows.Forms.Label lblOutOfBalanceValueDebit;
        internal System.Windows.Forms.Label lblCashCode;
        internal System.Windows.Forms.Label lblCashCodeValue;
        internal System.Windows.Forms.Label lblOutOfBalance;
        internal Tira.Component.TiraTextBox txtTotalKredit;
        internal Tira.Component.TiraTextBox txtTotalDebit;
        internal System.Windows.Forms.Label lblTotalAmount;
        internal System.Windows.Forms.Label lblInformation;
        internal Tira.Component.TiraTextBox txtMessage;
        internal System.Windows.Forms.Label lblMessage;
        internal System.Windows.Forms.Label lblOutOfBalanceValueCredit;
        internal Tira.Component.TiraDataGrid grd;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn GLAccountBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn GLAccountDivision;
        private System.Windows.Forms.DataGridViewTextBoxColumn GLAccountDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn GLAccountMajor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GLAccountMajor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GLAccountMinor;
        private System.Windows.Forms.DataGridViewTextBoxColumn GLAccountAnalysis;
        private System.Windows.Forms.DataGridViewTextBoxColumn GLAccountFiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private Tira.Component.TiraDataGridCheckBox Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebitRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashCode;
    }
}
