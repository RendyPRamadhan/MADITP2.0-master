namespace MADITP2._0.Global
{
    partial class clsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonNo = new FontAwesome.Sharp.IconButton();
            this.buttonYes = new FontAwesome.Sharp.IconButton();
            this.iconDialog = new System.Windows.Forms.PictureBox();
            this.message = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDialog)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 30);
            this.panel1.TabIndex = 4;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(3, 8);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(77, 15);
            this.title.TabIndex = 2;
            this.title.Text = "Confirmation";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonNo);
            this.panel2.Controls.Add(this.buttonYes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 30);
            this.panel2.TabIndex = 5;
            // 
            // buttonNo
            // 
            this.buttonNo.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNo.FlatAppearance.BorderSize = 0;
            this.buttonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNo.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.buttonNo.IconColor = System.Drawing.Color.Black;
            this.buttonNo.IconSize = 20;
            this.buttonNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNo.Location = new System.Drawing.Point(290, 0);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Rotation = 0D;
            this.buttonNo.Size = new System.Drawing.Size(55, 30);
            this.buttonNo.TabIndex = 1;
            this.buttonNo.Text = "No";
            this.buttonNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonYes.FlatAppearance.BorderSize = 0;
            this.buttonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonYes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonYes.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.buttonYes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.buttonYes.IconSize = 20;
            this.buttonYes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonYes.Location = new System.Drawing.Point(345, 0);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Rotation = 0D;
            this.buttonYes.Size = new System.Drawing.Size(55, 30);
            this.buttonYes.TabIndex = 0;
            this.buttonYes.Text = "Yes";
            this.buttonYes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonYes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // iconDialog
            // 
            this.iconDialog.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconDialog.Image = ((System.Drawing.Image)(resources.GetObject("iconDialog.Image")));
            this.iconDialog.Location = new System.Drawing.Point(0, 30);
            this.iconDialog.Name = "iconDialog";
            this.iconDialog.Size = new System.Drawing.Size(60, 90);
            this.iconDialog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconDialog.TabIndex = 9;
            this.iconDialog.TabStop = false;
            // 
            // message
            // 
            this.message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.message.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(60, 30);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(340, 90);
            this.message.TabIndex = 10;
            this.message.Text = "Message";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.message);
            this.Controls.Add(this.iconDialog);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "clsDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clsDialog";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.clsDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconDialog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton buttonNo;
        private FontAwesome.Sharp.IconButton buttonYes;
        private System.Windows.Forms.PictureBox iconDialog;
        private System.Windows.Forms.Label message;
    }
}