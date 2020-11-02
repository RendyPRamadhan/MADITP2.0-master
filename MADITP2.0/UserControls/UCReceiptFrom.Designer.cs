namespace MADITP2._0.UserControls
{
    partial class UCReceiptFrom
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
            this.tiraGroupBox1 = new Tira.Component.TiraGroupBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new Tira.Component.TiraTextBox();
            this.lblCashCode = new System.Windows.Forms.Label();
            this.txtCashCode = new Tira.Component.TiraTextBox();
            this.lblTransAmount = new System.Windows.Forms.Label();
            this.txtTransAmount = new Tira.Component.TiraTextBox();
            this.dtTransDate = new System.Windows.Forms.DateTimePicker();
            this.lblTransDate = new System.Windows.Forms.Label();
            this.lblReceiptFrom = new System.Windows.Forms.Label();
            this.txtReceiptFrom = new Tira.Component.TiraTextBox();
            this.tiraGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tiraGroupBox1
            // 
            this.tiraGroupBox1.Controls.Add(this.lblRemarks);
            this.tiraGroupBox1.Controls.Add(this.txtRemarks);
            this.tiraGroupBox1.Controls.Add(this.lblCashCode);
            this.tiraGroupBox1.Controls.Add(this.txtCashCode);
            this.tiraGroupBox1.Controls.Add(this.lblTransAmount);
            this.tiraGroupBox1.Controls.Add(this.txtTransAmount);
            this.tiraGroupBox1.Controls.Add(this.dtTransDate);
            this.tiraGroupBox1.Controls.Add(this.lblTransDate);
            this.tiraGroupBox1.Controls.Add(this.lblReceiptFrom);
            this.tiraGroupBox1.Controls.Add(this.txtReceiptFrom);
            this.tiraGroupBox1.Location = new System.Drawing.Point(5, 0);
            this.tiraGroupBox1.Name = "tiraGroupBox1";
            this.tiraGroupBox1.Size = new System.Drawing.Size(312, 193);
            this.tiraGroupBox1.TabIndex = 217;
            this.tiraGroupBox1.TabStop = false;
            this.tiraGroupBox1.TiraBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.tiraGroupBox1.TiraTextColor = System.Drawing.Color.Black;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(9, 133);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(50, 13);
            this.lblRemarks.TabIndex = 240;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.ForeColor = System.Drawing.Color.DimGray;
            this.txtRemarks.Location = new System.Drawing.Point(96, 130);
            this.txtRemarks.MaxLength = 255;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(204, 50);
            this.txtRemarks.TabIndex = 241;
            this.txtRemarks.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtRemarks.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtRemarks.TiraMandatory = false;
            this.txtRemarks.TiraPlaceHolder = null;
            this.txtRemarks.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // lblCashCode
            // 
            this.lblCashCode.AutoSize = true;
            this.lblCashCode.Location = new System.Drawing.Point(9, 105);
            this.lblCashCode.Name = "lblCashCode";
            this.lblCashCode.Size = new System.Drawing.Size(62, 13);
            this.lblCashCode.TabIndex = 238;
            this.lblCashCode.Text = "Cash Code";
            // 
            // txtCashCode
            // 
            this.txtCashCode.BackColor = System.Drawing.SystemColors.Control;
            this.txtCashCode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtCashCode.Location = new System.Drawing.Point(96, 102);
            this.txtCashCode.MaxLength = 255;
            this.txtCashCode.Name = "txtCashCode";
            this.txtCashCode.ReadOnly = true;
            this.txtCashCode.Size = new System.Drawing.Size(204, 23);
            this.txtCashCode.TabIndex = 239;
            this.txtCashCode.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtCashCode.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtCashCode.TiraMandatory = false;
            this.txtCashCode.TiraPlaceHolder = null;
            this.txtCashCode.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // lblTransAmount
            // 
            this.lblTransAmount.AutoSize = true;
            this.lblTransAmount.Location = new System.Drawing.Point(9, 78);
            this.lblTransAmount.Name = "lblTransAmount";
            this.lblTransAmount.Size = new System.Drawing.Size(81, 13);
            this.lblTransAmount.TabIndex = 236;
            this.lblTransAmount.Text = "Trans. Amount";
            // 
            // txtTransAmount
            // 
            this.txtTransAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtTransAmount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransAmount.ForeColor = System.Drawing.Color.DimGray;
            this.txtTransAmount.Location = new System.Drawing.Point(96, 75);
            this.txtTransAmount.MaxLength = 255;
            this.txtTransAmount.Name = "txtTransAmount";
            this.txtTransAmount.ReadOnly = true;
            this.txtTransAmount.Size = new System.Drawing.Size(204, 23);
            this.txtTransAmount.TabIndex = 237;
            this.txtTransAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTransAmount.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtTransAmount.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtTransAmount.TiraMandatory = false;
            this.txtTransAmount.TiraPlaceHolder = null;
            this.txtTransAmount.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // dtTransDate
            // 
            this.dtTransDate.CustomFormat = "dd MMM yyyy";
            this.dtTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTransDate.Location = new System.Drawing.Point(97, 47);
            this.dtTransDate.Name = "dtTransDate";
            this.dtTransDate.Size = new System.Drawing.Size(106, 22);
            this.dtTransDate.TabIndex = 235;
            // 
            // lblTransDate
            // 
            this.lblTransDate.AutoSize = true;
            this.lblTransDate.Location = new System.Drawing.Point(9, 50);
            this.lblTransDate.Name = "lblTransDate";
            this.lblTransDate.Size = new System.Drawing.Size(64, 13);
            this.lblTransDate.TabIndex = 234;
            this.lblTransDate.Text = "Trans. Date";
            // 
            // lblReceiptFrom
            // 
            this.lblReceiptFrom.AutoSize = true;
            this.lblReceiptFrom.Location = new System.Drawing.Point(9, 22);
            this.lblReceiptFrom.Name = "lblReceiptFrom";
            this.lblReceiptFrom.Size = new System.Drawing.Size(74, 13);
            this.lblReceiptFrom.TabIndex = 232;
            this.lblReceiptFrom.Text = "Receipt From";
            // 
            // txtReceiptFrom
            // 
            this.txtReceiptFrom.BackColor = System.Drawing.Color.White;
            this.txtReceiptFrom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptFrom.ForeColor = System.Drawing.Color.DimGray;
            this.txtReceiptFrom.Location = new System.Drawing.Point(96, 19);
            this.txtReceiptFrom.MaxLength = 255;
            this.txtReceiptFrom.Name = "txtReceiptFrom";
            this.txtReceiptFrom.Size = new System.Drawing.Size(204, 23);
            this.txtReceiptFrom.TabIndex = 233;
            this.txtReceiptFrom.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtReceiptFrom.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtReceiptFrom.TiraMandatory = false;
            this.txtReceiptFrom.TiraPlaceHolder = null;
            this.txtReceiptFrom.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // UCReceiptFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tiraGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCReceiptFrom";
            this.Size = new System.Drawing.Size(321, 196);
            this.tiraGroupBox1.ResumeLayout(false);
            this.tiraGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Tira.Component.TiraGroupBox tiraGroupBox1;
        internal System.Windows.Forms.Label lblRemarks;
        internal System.Windows.Forms.Label lblCashCode;
        internal System.Windows.Forms.Label lblTransAmount;
        internal System.Windows.Forms.Label lblTransDate;
        internal System.Windows.Forms.Label lblReceiptFrom;
        internal Tira.Component.TiraTextBox txtRemarks;
        internal Tira.Component.TiraTextBox txtCashCode;
        internal Tira.Component.TiraTextBox txtTransAmount;
        internal System.Windows.Forms.DateTimePicker dtTransDate;
        internal Tira.Component.TiraTextBox txtReceiptFrom;
    }
}
