namespace MADITP2._0.UserControls
{
    partial class UCCheque
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
            this.tiraGroupBox2 = new Tira.Component.TiraGroupBox();
            this.cboCurrCode = new Tira.Component.TiraComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new Tira.Component.TiraTextBox();
            this.lblCurrRate = new System.Windows.Forms.Label();
            this.txtCurrRate = new Tira.Component.TiraTextBox();
            this.lblCurrCode = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtNo = new Tira.Component.TiraTextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.txtRef = new Tira.Component.TiraTextBox();
            this.tiraGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tiraGroupBox2
            // 
            this.tiraGroupBox2.Controls.Add(this.cboCurrCode);
            this.tiraGroupBox2.Controls.Add(this.lblAmount);
            this.tiraGroupBox2.Controls.Add(this.txtAmount);
            this.tiraGroupBox2.Controls.Add(this.lblCurrRate);
            this.tiraGroupBox2.Controls.Add(this.txtCurrRate);
            this.tiraGroupBox2.Controls.Add(this.lblCurrCode);
            this.tiraGroupBox2.Controls.Add(this.dtDate);
            this.tiraGroupBox2.Controls.Add(this.lblDate);
            this.tiraGroupBox2.Controls.Add(this.txtNo);
            this.tiraGroupBox2.Controls.Add(this.lblNo);
            this.tiraGroupBox2.Controls.Add(this.lblRef);
            this.tiraGroupBox2.Controls.Add(this.txtRef);
            this.tiraGroupBox2.Location = new System.Drawing.Point(4, 0);
            this.tiraGroupBox2.Name = "tiraGroupBox2";
            this.tiraGroupBox2.Size = new System.Drawing.Size(312, 193);
            this.tiraGroupBox2.TabIndex = 232;
            this.tiraGroupBox2.TabStop = false;
            this.tiraGroupBox2.Text = "Cheque / Giro";
            this.tiraGroupBox2.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.tiraGroupBox2.TiraTextColor = System.Drawing.Color.Black;
            // 
            // cboCurrCode
            // 
            this.cboCurrCode.BackColor = System.Drawing.Color.White;
            this.cboCurrCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurrCode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCurrCode.ForeColor = System.Drawing.Color.DimGray;
            this.cboCurrCode.FormattingEnabled = true;
            this.cboCurrCode.Location = new System.Drawing.Point(81, 102);
            this.cboCurrCode.Name = "cboCurrCode";
            this.cboCurrCode.Size = new System.Drawing.Size(219, 21);
            this.cboCurrCode.TabIndex = 248;
            this.cboCurrCode.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.cboCurrCode.TiraMandatory = false;
            this.cboCurrCode.TiraPlaceHolder = null;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(9, 160);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(48, 13);
            this.lblAmount.TabIndex = 246;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.DimGray;
            this.txtAmount.Location = new System.Drawing.Point(81, 157);
            this.txtAmount.MaxLength = 255;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(219, 23);
            this.txtAmount.TabIndex = 247;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtAmount.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtAmount.TiraMandatory = false;
            this.txtAmount.TiraPlaceHolder = null;
            this.txtAmount.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtUCCAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUCCAmount_KeyPress);
            // 
            // lblCurrRate
            // 
            this.lblCurrRate.AutoSize = true;
            this.lblCurrRate.Location = new System.Drawing.Point(9, 132);
            this.lblCurrRate.Name = "lblCurrRate";
            this.lblCurrRate.Size = new System.Drawing.Size(58, 13);
            this.lblCurrRate.TabIndex = 244;
            this.lblCurrRate.Text = "Curr. Rate";
            // 
            // txtCurrRate
            // 
            this.txtCurrRate.BackColor = System.Drawing.Color.White;
            this.txtCurrRate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrRate.ForeColor = System.Drawing.Color.DimGray;
            this.txtCurrRate.Location = new System.Drawing.Point(81, 129);
            this.txtCurrRate.MaxLength = 255;
            this.txtCurrRate.Name = "txtCurrRate";
            this.txtCurrRate.Size = new System.Drawing.Size(219, 23);
            this.txtCurrRate.TabIndex = 245;
            this.txtCurrRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCurrRate.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtCurrRate.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtCurrRate.TiraMandatory = false;
            this.txtCurrRate.TiraPlaceHolder = null;
            this.txtCurrRate.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtCurrRate.TextChanged += new System.EventHandler(this.txtUCCCurrRate_TextChanged);
            this.txtCurrRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUCCCurrRate_KeyPress);
            // 
            // lblCurrCode
            // 
            this.lblCurrCode.AutoSize = true;
            this.lblCurrCode.Location = new System.Drawing.Point(9, 105);
            this.lblCurrCode.Name = "lblCurrCode";
            this.lblCurrCode.Size = new System.Drawing.Size(62, 13);
            this.lblCurrCode.TabIndex = 242;
            this.lblCurrCode.Text = "Curr. Code";
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "dd MMM yyyy";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(81, 75);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(106, 22);
            this.dtDate.TabIndex = 241;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(8, 78);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 13);
            this.lblDate.TabIndex = 240;
            this.lblDate.Text = "Date";
            // 
            // txtNo
            // 
            this.txtNo.BackColor = System.Drawing.Color.White;
            this.txtNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo.ForeColor = System.Drawing.Color.DimGray;
            this.txtNo.Location = new System.Drawing.Point(81, 19);
            this.txtNo.MaxLength = 255;
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(219, 23);
            this.txtNo.TabIndex = 239;
            this.txtNo.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtNo.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtNo.TiraMandatory = false;
            this.txtNo.TiraPlaceHolder = null;
            this.txtNo.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(9, 23);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(22, 13);
            this.lblNo.TabIndex = 238;
            this.lblNo.Text = "No";
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(9, 50);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(27, 13);
            this.lblRef.TabIndex = 236;
            this.lblRef.Text = "Ref.";
            // 
            // txtRef
            // 
            this.txtRef.BackColor = System.Drawing.Color.White;
            this.txtRef.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.ForeColor = System.Drawing.Color.DimGray;
            this.txtRef.Location = new System.Drawing.Point(81, 46);
            this.txtRef.MaxLength = 255;
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(219, 23);
            this.txtRef.TabIndex = 237;
            this.txtRef.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtRef.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtRef.TiraMandatory = false;
            this.txtRef.TiraPlaceHolder = null;
            this.txtRef.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // UCCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tiraGroupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCCheque";
            this.Size = new System.Drawing.Size(321, 196);
            this.tiraGroupBox2.ResumeLayout(false);
            this.tiraGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Tira.Component.TiraGroupBox tiraGroupBox2;
        internal System.Windows.Forms.Label lblAmount;
        internal System.Windows.Forms.Label lblCurrRate;
        internal System.Windows.Forms.Label lblCurrCode;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label lblNo;
        internal System.Windows.Forms.Label lblRef;
        internal Tira.Component.TiraComboBox cboCurrCode;
        internal Tira.Component.TiraTextBox txtAmount;
        internal Tira.Component.TiraTextBox txtCurrRate;
        internal System.Windows.Forms.DateTimePicker dtDate;
        internal Tira.Component.TiraTextBox txtNo;
        internal Tira.Component.TiraTextBox txtRef;
    }
}
