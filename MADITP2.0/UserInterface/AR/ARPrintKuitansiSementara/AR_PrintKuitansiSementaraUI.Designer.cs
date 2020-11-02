namespace MADITP2._0.UserInterface.AR.ARPrintKuitansiSementara
{
    partial class AR_PrintKuitansiSementaraUI
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
            this.navClose = new Tira.Component.TiraButton();
            this.navPrint = new Tira.Component.TiraButton();
            this.bindingObjPrintKuitansiSementara = new System.Windows.Forms.BindingSource(this.components);
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.navView = new Tira.Component.TiraButton();
            this.panelView = new System.Windows.Forms.Panel();
            this.txtBoxTelephone = new Tira.Component.TiraTextBox();
            this.txtBoxAddress3 = new Tira.Component.TiraTextBox();
            this.txtBoxAddress2 = new Tira.Component.TiraTextBox();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblNoInvoice = new System.Windows.Forms.Label();
            this.txtBoxKeterangan = new Tira.Component.TiraTextBox();
            this.txtBoxJumlah = new Tira.Component.TiraTextBox();
            this.txtBoxAddress1 = new Tira.Component.TiraTextBox();
            this.txtBoxCustomerName = new Tira.Component.TiraTextBox();
            this.txtBoxInvoice = new Tira.Component.TiraTextBox();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.rptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjPrintKuitansiSementara)).BeginInit();
            this.panelTopMenu.SuspendLayout();
            this.panelView.SuspendLayout();
            this.pnlPrint.SuspendLayout();
            this.SuspendLayout();
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
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelTopMenu.Controls.Add(this.navClose);
            this.panelTopMenu.Controls.Add(this.navPrint);
            this.panelTopMenu.Controls.Add(this.navView);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(1112, 30);
            this.panelTopMenu.TabIndex = 16;
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
            this.panelView.Controls.Add(this.txtBoxTelephone);
            this.panelView.Controls.Add(this.txtBoxAddress3);
            this.panelView.Controls.Add(this.txtBoxAddress2);
            this.panelView.Controls.Add(this.lblKeterangan);
            this.panelView.Controls.Add(this.lblJumlah);
            this.panelView.Controls.Add(this.lblAlamat);
            this.panelView.Controls.Add(this.lblNoInvoice);
            this.panelView.Controls.Add(this.txtBoxKeterangan);
            this.panelView.Controls.Add(this.txtBoxJumlah);
            this.panelView.Controls.Add(this.txtBoxAddress1);
            this.panelView.Controls.Add(this.txtBoxCustomerName);
            this.panelView.Controls.Add(this.txtBoxInvoice);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1112, 719);
            this.panelView.TabIndex = 17;
            // 
            // txtBoxTelephone
            // 
            this.txtBoxTelephone.BackColor = System.Drawing.Color.White;
            this.txtBoxTelephone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxTelephone.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxTelephone.Location = new System.Drawing.Point(270, 160);
            this.txtBoxTelephone.MaxLength = 255;
            this.txtBoxTelephone.Name = "txtBoxTelephone";
            this.txtBoxTelephone.Size = new System.Drawing.Size(612, 23);
            this.txtBoxTelephone.TabIndex = 11;
            this.txtBoxTelephone.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxTelephone.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxTelephone.TiraMandatory = false;
            this.txtBoxTelephone.TiraPlaceHolder = null;
            this.txtBoxTelephone.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // txtBoxAddress3
            // 
            this.txtBoxAddress3.BackColor = System.Drawing.Color.White;
            this.txtBoxAddress3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxAddress3.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxAddress3.Location = new System.Drawing.Point(270, 131);
            this.txtBoxAddress3.MaxLength = 255;
            this.txtBoxAddress3.Name = "txtBoxAddress3";
            this.txtBoxAddress3.Size = new System.Drawing.Size(612, 23);
            this.txtBoxAddress3.TabIndex = 10;
            this.txtBoxAddress3.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxAddress3.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxAddress3.TiraMandatory = false;
            this.txtBoxAddress3.TiraPlaceHolder = null;
            this.txtBoxAddress3.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // txtBoxAddress2
            // 
            this.txtBoxAddress2.BackColor = System.Drawing.Color.White;
            this.txtBoxAddress2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxAddress2.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxAddress2.Location = new System.Drawing.Point(270, 102);
            this.txtBoxAddress2.MaxLength = 255;
            this.txtBoxAddress2.Name = "txtBoxAddress2";
            this.txtBoxAddress2.Size = new System.Drawing.Size(612, 23);
            this.txtBoxAddress2.TabIndex = 9;
            this.txtBoxAddress2.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxAddress2.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxAddress2.TiraMandatory = false;
            this.txtBoxAddress2.TiraPlaceHolder = null;
            this.txtBoxAddress2.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Location = new System.Drawing.Point(146, 255);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(62, 13);
            this.lblKeterangan.TabIndex = 8;
            this.lblKeterangan.Text = "Keterangan";
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Location = new System.Drawing.Point(147, 210);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(40, 13);
            this.lblJumlah.TabIndex = 7;
            this.lblJumlah.Text = "Jumlah";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(147, 77);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(39, 13);
            this.lblAlamat.TabIndex = 6;
            this.lblAlamat.Text = "Alamat";
            // 
            // lblNoInvoice
            // 
            this.lblNoInvoice.AutoSize = true;
            this.lblNoInvoice.Location = new System.Drawing.Point(147, 45);
            this.lblNoInvoice.Name = "lblNoInvoice";
            this.lblNoInvoice.Size = new System.Drawing.Size(59, 13);
            this.lblNoInvoice.TabIndex = 5;
            this.lblNoInvoice.Text = "No Invoice";
            // 
            // txtBoxKeterangan
            // 
            this.txtBoxKeterangan.BackColor = System.Drawing.Color.White;
            this.txtBoxKeterangan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxKeterangan.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxKeterangan.Location = new System.Drawing.Point(270, 245);
            this.txtBoxKeterangan.MaxLength = 255;
            this.txtBoxKeterangan.Name = "txtBoxKeterangan";
            this.txtBoxKeterangan.Size = new System.Drawing.Size(612, 23);
            this.txtBoxKeterangan.TabIndex = 4;
            this.txtBoxKeterangan.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxKeterangan.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxKeterangan.TiraMandatory = false;
            this.txtBoxKeterangan.TiraPlaceHolder = null;
            this.txtBoxKeterangan.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // txtBoxJumlah
            // 
            this.txtBoxJumlah.BackColor = System.Drawing.Color.White;
            this.txtBoxJumlah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxJumlah.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxJumlah.Location = new System.Drawing.Point(270, 200);
            this.txtBoxJumlah.MaxLength = 255;
            this.txtBoxJumlah.Name = "txtBoxJumlah";
            this.txtBoxJumlah.Size = new System.Drawing.Size(612, 23);
            this.txtBoxJumlah.TabIndex = 3;
            this.txtBoxJumlah.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxJumlah.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxJumlah.TiraMandatory = false;
            this.txtBoxJumlah.TiraPlaceHolder = null;
            this.txtBoxJumlah.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtBoxJumlah.TextChanged += new System.EventHandler(this.txtBoxJumlah_TextChanged);
            this.txtBoxJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxJumlah_KeyPress);
            // 
            // txtBoxAddress1
            // 
            this.txtBoxAddress1.BackColor = System.Drawing.Color.White;
            this.txtBoxAddress1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxAddress1.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxAddress1.Location = new System.Drawing.Point(270, 73);
            this.txtBoxAddress1.MaxLength = 255;
            this.txtBoxAddress1.Name = "txtBoxAddress1";
            this.txtBoxAddress1.Size = new System.Drawing.Size(612, 23);
            this.txtBoxAddress1.TabIndex = 2;
            this.txtBoxAddress1.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxAddress1.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxAddress1.TiraMandatory = false;
            this.txtBoxAddress1.TiraPlaceHolder = null;
            this.txtBoxAddress1.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // txtBoxCustomerName
            // 
            this.txtBoxCustomerName.BackColor = System.Drawing.Color.White;
            this.txtBoxCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxCustomerName.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxCustomerName.Location = new System.Drawing.Point(413, 35);
            this.txtBoxCustomerName.MaxLength = 255;
            this.txtBoxCustomerName.Name = "txtBoxCustomerName";
            this.txtBoxCustomerName.Size = new System.Drawing.Size(469, 23);
            this.txtBoxCustomerName.TabIndex = 1;
            this.txtBoxCustomerName.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxCustomerName.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxCustomerName.TiraMandatory = false;
            this.txtBoxCustomerName.TiraPlaceHolder = null;
            this.txtBoxCustomerName.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            // 
            // txtBoxInvoice
            // 
            this.txtBoxInvoice.BackColor = System.Drawing.Color.White;
            this.txtBoxInvoice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxInvoice.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxInvoice.Location = new System.Drawing.Point(270, 35);
            this.txtBoxInvoice.MaxLength = 255;
            this.txtBoxInvoice.Name = "txtBoxInvoice";
            this.txtBoxInvoice.Size = new System.Drawing.Size(126, 23);
            this.txtBoxInvoice.TabIndex = 0;
            this.txtBoxInvoice.TiraBorderColor = System.Drawing.Color.Silver;
            this.txtBoxInvoice.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.txtBoxInvoice.TiraMandatory = false;
            this.txtBoxInvoice.TiraPlaceHolder = null;
            this.txtBoxInvoice.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtBoxInvoice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxInvoice_KeyDown);
            // 
            // pnlPrint
            // 
            this.pnlPrint.BackColor = System.Drawing.Color.White;
            this.pnlPrint.Controls.Add(this.panelView);
            this.pnlPrint.Controls.Add(this.rptViewer);
            this.pnlPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrint.Location = new System.Drawing.Point(0, 30);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(1112, 719);
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
            this.rptViewer.Size = new System.Drawing.Size(1098, 674);
            this.rptViewer.TabIndex = 0;
            this.rptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // AR_PrintKuitansiSementaraUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 749);
            this.Controls.Add(this.pnlPrint);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "AR_PrintKuitansiSementaraUI";
            this.Text = "AR_PrintKuitansiSementaraUI";
            this.Load += new System.EventHandler(this.AR_PrintKuitansiSementaraUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingObjPrintKuitansiSementara)).EndInit();
            this.panelTopMenu.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            this.pnlPrint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Tira.Component.TiraButton navClose;
        private Tira.Component.TiraButton navPrint;
        public System.Windows.Forms.BindingSource bindingObjPrintKuitansiSementara;
        private System.Windows.Forms.Panel panelTopMenu;
        private Tira.Component.TiraButton navView;
        private System.Windows.Forms.Panel panelView;
        private Tira.Component.TiraTextBox txtBoxTelephone;
        private Tira.Component.TiraTextBox txtBoxAddress3;
        private Tira.Component.TiraTextBox txtBoxAddress2;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblNoInvoice;
        private Tira.Component.TiraTextBox txtBoxKeterangan;
        private Tira.Component.TiraTextBox txtBoxJumlah;
        private Tira.Component.TiraTextBox txtBoxAddress1;
        private Tira.Component.TiraTextBox txtBoxCustomerName;
        private Tira.Component.TiraTextBox txtBoxInvoice;
        private System.Windows.Forms.Panel pnlPrint;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewer;
    }
}