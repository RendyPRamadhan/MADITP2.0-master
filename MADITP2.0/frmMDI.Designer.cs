namespace MADITP2._0
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panelSearch = new System.Windows.Forms.Panel();
            this.textMenuSearch = new Tira.Component.TiraTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSide = new System.Windows.Forms.Panel();
            this.navCalculator = new FontAwesome.Sharp.IconButton();
            this.navFiscal = new FontAwesome.Sharp.IconButton();
            this.navHome = new FontAwesome.Sharp.IconButton();
            this.navBar = new FontAwesome.Sharp.IconButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.navSetting = new FontAwesome.Sharp.IconButton();
            this.navHelp = new FontAwesome.Sharp.IconButton();
            this.navExit = new FontAwesome.Sharp.IconButton();
            this.labelMenuName = new System.Windows.Forms.Label();
            this.navBack = new FontAwesome.Sharp.IconButton();
            this.panelLine = new System.Windows.Forms.Panel();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.panelSideMenu.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSide.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            this.panelSideMenu.Controls.Add(this.tvMenu);
            this.panelSideMenu.Controls.Add(this.panelSearch);
            this.panelSideMenu.Controls.Add(this.panel2);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(30, 24);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 657);
            this.panelSideMenu.TabIndex = 7;
            // 
            // tvMenu
            // 
            this.tvMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            this.tvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvMenu.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.tvMenu.ForeColor = System.Drawing.Color.White;
            this.tvMenu.ImageIndex = 0;
            this.tvMenu.ImageList = this.imageList2;
            this.tvMenu.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tvMenu.Indent = 15;
            this.tvMenu.Location = new System.Drawing.Point(0, 90);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Scrollable = false;
            this.tvMenu.SelectedImageIndex = 1;
            this.tvMenu.Size = new System.Drawing.Size(240, 567);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.tvMenu_DrawNode);
            this.tvMenu.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMenu_NodeMouseDoubleClick);
            this.tvMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tvMenu_KeyDown);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "icons8_folder_50px.png");
            this.imageList2.Images.SetKeyName(1, "icons8_opened_folder_50px.png");
            this.imageList2.Images.SetKeyName(2, "icons8_form_50px.png");
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            this.panelSearch.Controls.Add(this.textMenuSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 60);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(250, 30);
            this.panelSearch.TabIndex = 2;
            // 
            // textMenuSearch
            // 
            this.textMenuSearch.BackColor = System.Drawing.Color.White;
            this.textMenuSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMenuSearch.ForeColor = System.Drawing.Color.DimGray;
            this.textMenuSearch.Location = new System.Drawing.Point(10, 3);
            this.textMenuSearch.MaxLength = 255;
            this.textMenuSearch.Name = "textMenuSearch";
            this.textMenuSearch.Size = new System.Drawing.Size(230, 23);
            this.textMenuSearch.TabIndex = 0;
            this.textMenuSearch.Text = "Search Menu By T-Code";
            this.textMenuSearch.TiraBorderColor = System.Drawing.Color.Silver;
            this.textMenuSearch.TiraBorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(104)))), ((int)(((byte)(36)))));
            this.textMenuSearch.TiraMandatory = false;
            this.textMenuSearch.TiraPlaceHolder = "Search Menu By T-Code";
            this.textMenuSearch.TiraPlaceHolderColor = System.Drawing.Color.DimGray;
            this.textMenuSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToolStriptxtMenu_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 60);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Welcome Back ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "MADITP 2.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.panelSide.Controls.Add(this.navCalculator);
            this.panelSide.Controls.Add(this.navFiscal);
            this.panelSide.Controls.Add(this.navHome);
            this.panelSide.Controls.Add(this.navBar);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 24);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(30, 657);
            this.panelSide.TabIndex = 9;
            // 
            // navCalculator
            // 
            this.navCalculator.Dock = System.Windows.Forms.DockStyle.Top;
            this.navCalculator.FlatAppearance.BorderSize = 0;
            this.navCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navCalculator.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navCalculator.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.navCalculator.IconColor = System.Drawing.Color.White;
            this.navCalculator.IconSize = 20;
            this.navCalculator.Location = new System.Drawing.Point(0, 180);
            this.navCalculator.Name = "navCalculator";
            this.navCalculator.Rotation = 0D;
            this.navCalculator.Size = new System.Drawing.Size(30, 60);
            this.navCalculator.TabIndex = 3;
            this.navCalculator.UseVisualStyleBackColor = true;
            // 
            // navFiscal
            // 
            this.navFiscal.Dock = System.Windows.Forms.DockStyle.Top;
            this.navFiscal.FlatAppearance.BorderSize = 0;
            this.navFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navFiscal.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navFiscal.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.navFiscal.IconColor = System.Drawing.Color.White;
            this.navFiscal.IconSize = 20;
            this.navFiscal.Location = new System.Drawing.Point(0, 120);
            this.navFiscal.Name = "navFiscal";
            this.navFiscal.Rotation = 0D;
            this.navFiscal.Size = new System.Drawing.Size(30, 60);
            this.navFiscal.TabIndex = 2;
            this.navFiscal.UseVisualStyleBackColor = true;
            // 
            // navHome
            // 
            this.navHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.navHome.FlatAppearance.BorderSize = 0;
            this.navHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.navHome.IconColor = System.Drawing.Color.White;
            this.navHome.IconSize = 20;
            this.navHome.Location = new System.Drawing.Point(0, 60);
            this.navHome.Name = "navHome";
            this.navHome.Rotation = 0D;
            this.navHome.Size = new System.Drawing.Size(30, 60);
            this.navHome.TabIndex = 1;
            this.navHome.UseVisualStyleBackColor = true;
            // 
            // navBar
            // 
            this.navBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBar.FlatAppearance.BorderSize = 0;
            this.navBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navBar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navBar.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.navBar.IconColor = System.Drawing.Color.White;
            this.navBar.IconSize = 20;
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Rotation = 0D;
            this.navBar.Size = new System.Drawing.Size(30, 60);
            this.navBar.TabIndex = 0;
            this.navBar.UseVisualStyleBackColor = true;
            this.navBar.Click += new System.EventHandler(this.navBar_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.navSetting);
            this.panelTop.Controls.Add(this.navHelp);
            this.panelTop.Controls.Add(this.navExit);
            this.panelTop.Controls.Add(this.labelMenuName);
            this.panelTop.Controls.Add(this.navBack);
            this.panelTop.Controls.Add(this.panelLine);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(280, 24);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(984, 31);
            this.panelTop.TabIndex = 11;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // navSetting
            // 
            this.navSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.navSetting.FlatAppearance.BorderSize = 0;
            this.navSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navSetting.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.navSetting.IconColor = System.Drawing.Color.DimGray;
            this.navSetting.IconSize = 20;
            this.navSetting.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.navSetting.Location = new System.Drawing.Point(894, 0);
            this.navSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navSetting.Name = "navSetting";
            this.navSetting.Rotation = 0D;
            this.navSetting.Size = new System.Drawing.Size(30, 30);
            this.navSetting.TabIndex = 11;
            this.navSetting.UseVisualStyleBackColor = true;
            this.navSetting.Click += new System.EventHandler(this.navSetting_Click);
            // 
            // navHelp
            // 
            this.navHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.navHelp.FlatAppearance.BorderSize = 0;
            this.navHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navHelp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navHelp.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.navHelp.IconColor = System.Drawing.Color.DimGray;
            this.navHelp.IconSize = 20;
            this.navHelp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.navHelp.Location = new System.Drawing.Point(924, 0);
            this.navHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navHelp.Name = "navHelp";
            this.navHelp.Rotation = 0D;
            this.navHelp.Size = new System.Drawing.Size(30, 30);
            this.navHelp.TabIndex = 10;
            this.navHelp.UseVisualStyleBackColor = true;
            this.navHelp.Click += new System.EventHandler(this.navHelp_Click);
            // 
            // navExit
            // 
            this.navExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.navExit.FlatAppearance.BorderSize = 0;
            this.navExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.navExit.IconColor = System.Drawing.Color.DimGray;
            this.navExit.IconSize = 20;
            this.navExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.navExit.Location = new System.Drawing.Point(954, 0);
            this.navExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navExit.Name = "navExit";
            this.navExit.Rotation = 0D;
            this.navExit.Size = new System.Drawing.Size(30, 30);
            this.navExit.TabIndex = 9;
            this.navExit.UseVisualStyleBackColor = true;
            this.navExit.Click += new System.EventHandler(this.navExit_Click);
            // 
            // labelMenuName
            // 
            this.labelMenuName.AutoSize = true;
            this.labelMenuName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuName.ForeColor = System.Drawing.Color.Black;
            this.labelMenuName.Location = new System.Drawing.Point(36, 4);
            this.labelMenuName.Name = "labelMenuName";
            this.labelMenuName.Size = new System.Drawing.Size(45, 17);
            this.labelMenuName.TabIndex = 8;
            this.labelMenuName.Text = "Home";
            // 
            // navBack
            // 
            this.navBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBack.FlatAppearance.BorderSize = 0;
            this.navBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navBack.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.navBack.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.navBack.IconColor = System.Drawing.Color.Black;
            this.navBack.IconSize = 20;
            this.navBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.navBack.Location = new System.Drawing.Point(0, 0);
            this.navBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navBack.Name = "navBack";
            this.navBack.Rotation = 0D;
            this.navBack.Size = new System.Drawing.Size(30, 30);
            this.navBack.TabIndex = 7;
            this.navBack.UseVisualStyleBackColor = true;
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.Silver;
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLine.Location = new System.Drawing.Point(0, 30);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(984, 1);
            this.panelLine.TabIndex = 0;
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(68, 20);
            this.windowsMenu.Text = "&Windows";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newWindowToolStripMenuItem.Text = "&New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(128, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MADITP 2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSide.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.Panel panelSide;
        private FontAwesome.Sharp.IconButton navBar;
        private FontAwesome.Sharp.IconButton navCalculator;
        private FontAwesome.Sharp.IconButton navFiscal;
        private FontAwesome.Sharp.IconButton navHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSearch;
        private Tira.Component.TiraTextBox textMenuSearch;
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton navSetting;
        private FontAwesome.Sharp.IconButton navHelp;
        private FontAwesome.Sharp.IconButton navExit;
        private System.Windows.Forms.Label labelMenuName;
        private FontAwesome.Sharp.IconButton navBack;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}



