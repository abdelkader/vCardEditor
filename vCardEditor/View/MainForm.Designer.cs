using vCardEditor.View.Customs;

namespace vCardEditor.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbsNew = new System.Windows.Forms.ToolStripButton();
            this.tbsOpen = new System.Windows.Forms.ToolStripButton();
            this.tbsSave = new System.Windows.Forms.ToolStripButton();
            this.tbsDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbsAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.HomePhoneLabel = new System.Windows.Forms.Label();
            this.CellularPhoneLabel = new System.Windows.Forms.Label();
            this.WorkPhoneLabel = new System.Windows.Forms.Label();
            this.gbContactDetail = new System.Windows.Forms.GroupBox();
            this.btnExportImage = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbcAddress = new vCardEditor.View.Customs.AddressTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FormattedTitleValue = new vCardEditor.View.StateTextBox();
            this.FormattedTitleLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new vCardEditor.View.StateTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.middleNameValue = new vCardEditor.View.StateTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameValue = new vCardEditor.View.StateTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FormattedNameValue = new vCardEditor.View.StateTextBox();
            this.FormattedNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.EmailAddressValue = new vCardEditor.View.StateTextBox();
            this.PersonalWebSiteLabel = new System.Windows.Forms.Label();
            this.PersonalWebSiteValue = new vCardEditor.View.StateTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HomePhoneValue = new vCardEditor.View.StateTextBox();
            this.WorkPhoneValue = new vCardEditor.View.StateTextBox();
            this.CellularPhoneValue = new vCardEditor.View.StateTextBox();
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.bsContacts = new System.Windows.Forms.BindingSource(this.components);
            this.gbNameList = new System.Windows.Forms.GroupBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.dgContacts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FormattedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cellular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifiyColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbcAddress = new vCardEditor.View.Customs.AddressTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FormattedTitleValue = new vCardEditor.View.StateTextBox();
            this.lastNameValue = new vCardEditor.View.StateTextBox();
            this.middleNameValue = new vCardEditor.View.StateTextBox();
            this.firstNameValue = new vCardEditor.View.StateTextBox();
            this.FormattedNameValue = new vCardEditor.View.StateTextBox();
            this.EmailAddressValue = new vCardEditor.View.StateTextBox();
            this.PersonalWebSiteValue = new vCardEditor.View.StateTextBox();
            this.HomePhoneValue = new vCardEditor.View.StateTextBox();
            this.WorkPhoneValue = new vCardEditor.View.StateTextBox();
            this.CellularPhoneValue = new vCardEditor.View.StateTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbContactDetail.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tbcAddress.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContacts)).BeginInit();
            this.gbNameList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tbcAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1197, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSave,
            this.miOpen,
            this.toolStripMenuItem1,
            this.miConfig,
            this.recentFilesMenuItem,
            this.miQuit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(162, 26);
            this.miSave.Text = "&Save";
            this.miSave.Click += new System.EventHandler(this.tbsSave_Click);
            // 
            // miOpen
            // 
            this.miOpen.Image = ((System.Drawing.Image)(resources.GetObject("miOpen.Image")));
            this.miOpen.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(162, 26);
            this.miOpen.Text = "&Open";
            this.miOpen.Click += new System.EventHandler(this.tbsOpen_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // miConfig
            // 
            this.miConfig.Name = "miConfig";
            this.miConfig.Size = new System.Drawing.Size(162, 26);
            this.miConfig.Text = "Preference";
            this.miConfig.Click += new System.EventHandler(this.miConfig_Click);
            // 
            // recentFilesMenuItem
            // 
            this.recentFilesMenuItem.Name = "recentFilesMenuItem";
            this.recentFilesMenuItem.Size = new System.Drawing.Size(162, 26);
            this.recentFilesMenuItem.Text = "Recent";
            // 
            // miQuit
            // 
            this.miQuit.Image = ((System.Drawing.Image)(resources.GetObject("miQuit.Image")));
            this.miQuit.Name = "miQuit";
            this.miQuit.Size = new System.Drawing.Size(162, 26);
            this.miQuit.Text = "&Quit";
            this.miQuit.Click += new System.EventHandler(this.miQuit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 26);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // imagesToolStripMenuItem
            // 
            this.imagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.countToolStripMenuItem});
            this.imagesToolStripMenuItem.Name = "imagesToolStripMenuItem";
            this.imagesToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.imagesToolStripMenuItem.Text = "Images";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // countToolStripMenuItem
            // 
            this.countToolStripMenuItem.Name = "countToolStripMenuItem";
            this.countToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.countToolStripMenuItem.Text = "Count";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // miAbout
            // 
            this.miAbout.Image = ((System.Drawing.Image)(resources.GetObject("miAbout.Image")));
            this.miAbout.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(133, 26);
            this.miAbout.Text = "&About";
            this.miAbout.Click += new System.EventHandler(this.tbsAbout_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // imagesToolStripMenuItem
            // 
            this.imagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.countToolStripMenuItem});
            this.imagesToolStripMenuItem.Name = "imagesToolStripMenuItem";
            this.imagesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.imagesToolStripMenuItem.Text = "Images";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 624);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1197, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsNew,
            this.tbsOpen,
            this.tbsSave,
            this.tbsDelete,
            this.toolStripSeparator1,
            this.tbsAbout,
            this.toolStripSeparator});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1197, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbsNew
            // 
            this.tbsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsNew.Image = ((System.Drawing.Image)(resources.GetObject("tbsNew.Image")));
            this.tbsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsNew.Name = "tbsNew";
            this.tbsNew.Size = new System.Drawing.Size(29, 24);
            this.tbsNew.Text = "&Nouveau";
            this.tbsNew.Click += new System.EventHandler(this.tbsNew_Click);
            // 
            // tbsOpen
            // 
            this.tbsOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbsOpen.Image")));
            this.tbsOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsOpen.Name = "tbsOpen";
            this.tbsOpen.Size = new System.Drawing.Size(29, 24);
            this.tbsOpen.Text = "&Open";
            this.tbsOpen.Click += new System.EventHandler(this.tbsOpen_Click);
            // 
            // tbsSave
            // 
            this.tbsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsSave.Image = ((System.Drawing.Image)(resources.GetObject("tbsSave.Image")));
            this.tbsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsSave.Name = "tbsSave";
            this.tbsSave.Size = new System.Drawing.Size(29, 24);
            this.tbsSave.Text = "&Save";
            this.tbsSave.Click += new System.EventHandler(this.tbsSave_Click);
            // 
            // tbsDelete
            // 
            this.tbsDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsDelete.Image = ((System.Drawing.Image)(resources.GetObject("tbsDelete.Image")));
            this.tbsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsDelete.Name = "tbsDelete";
            this.tbsDelete.Size = new System.Drawing.Size(29, 24);
            this.tbsDelete.Text = "Delete";
            this.tbsDelete.Click += new System.EventHandler(this.tbsDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tbsAbout
            // 
            this.tbsAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsAbout.Image = ((System.Drawing.Image)(resources.GetObject("tbsAbout.Image")));
            this.tbsAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsAbout.Name = "tbsAbout";
            this.tbsAbout.Size = new System.Drawing.Size(29, 24);
            this.tbsAbout.Text = "&?";
            this.tbsAbout.Click += new System.EventHandler(this.tbsAbout_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Title = "Open vCard File";
            // 
            // HomePhoneLabel
            // 
            this.HomePhoneLabel.Location = new System.Drawing.Point(12, 26);
            this.HomePhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HomePhoneLabel.Name = "HomePhoneLabel";
            this.HomePhoneLabel.Size = new System.Drawing.Size(60, 23);
            this.HomePhoneLabel.TabIndex = 0;
            this.HomePhoneLabel.Text = "Home :";
            this.HomePhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CellularPhoneLabel
            // 
            this.CellularPhoneLabel.Location = new System.Drawing.Point(8, 57);
            this.CellularPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CellularPhoneLabel.Name = "CellularPhoneLabel";
            this.CellularPhoneLabel.Size = new System.Drawing.Size(60, 23);
            this.CellularPhoneLabel.TabIndex = 2;
            this.CellularPhoneLabel.Text = "Cellular:";
            this.CellularPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkPhoneLabel
            // 
            this.WorkPhoneLabel.Location = new System.Drawing.Point(11, 86);
            this.WorkPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WorkPhoneLabel.Name = "WorkPhoneLabel";
            this.WorkPhoneLabel.Size = new System.Drawing.Size(60, 23);
            this.WorkPhoneLabel.TabIndex = 4;
            this.WorkPhoneLabel.Text = "Work:";
            this.WorkPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbContactDetail
            // 
            this.gbContactDetail.Controls.Add(this.btnExportImage);
            this.gbContactDetail.Controls.Add(this.btnRemoveImage);
            this.gbContactDetail.Controls.Add(this.groupBox4);
            this.gbContactDetail.Controls.Add(this.groupBox3);
            this.gbContactDetail.Controls.Add(this.groupBox2);
            this.gbContactDetail.Controls.Add(this.groupBox1);
            this.gbContactDetail.Controls.Add(this.PhotoBox);
            this.gbContactDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbContactDetail.Enabled = false;
            this.gbContactDetail.Location = new System.Drawing.Point(0, 0);
            this.gbContactDetail.Margin = new System.Windows.Forms.Padding(4);
            this.gbContactDetail.Name = "gbContactDetail";
            this.gbContactDetail.Padding = new System.Windows.Forms.Padding(4);
            this.gbContactDetail.Size = new System.Drawing.Size(796, 563);
            this.gbContactDetail.TabIndex = 3;
            this.gbContactDetail.TabStop = false;
            this.gbContactDetail.Text = "Contact Detail :";
            // 
            // btnExportImage
            // 
            this.btnExportImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportImage.BackColor = System.Drawing.SystemColors.Window;
            this.btnExportImage.Image = ((System.Drawing.Image)(resources.GetObject("btnExportImage.Image")));
            this.btnExportImage.Location = new System.Drawing.Point(744, 170);
            this.btnExportImage.Name = "btnExportImage";
            this.btnExportImage.Size = new System.Drawing.Size(21, 23);
            this.btnExportImage.TabIndex = 54;
            this.btnExportImage.UseVisualStyleBackColor = true;
            this.btnExportImage.Click += new System.EventHandler(this.btnExportImage_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveImage.BackColor = System.Drawing.SystemColors.Window;
            this.btnRemoveImage.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveImage.Image")));
            this.btnRemoveImage.Location = new System.Drawing.Point(768, 170);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(20, 23);
            this.btnRemoveImage.TabIndex = 54;
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tbcAddress);
            this.groupBox4.Location = new System.Drawing.Point(8, 190);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(780, 228);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Address:";
            // 
            // tbcAddress
            // 
            this.tbcAddress.Controls.Add(this.tabPage1);
            this.tbcAddress.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tbcAddress.Location = new System.Drawing.Point(17, 23);
            this.tbcAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbcAddress.Name = "tbcAddress";
            this.tbcAddress.Padding = new System.Drawing.Point(12, 4);
            this.tbcAddress.SelectedIndex = 0;
            this.tbcAddress.ShowToolTips = true;
            this.tbcAddress.Size = new System.Drawing.Size(739, 144);
            this.tbcAddress.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 113);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " ";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.FormattedTitleValue);
            this.groupBox3.Controls.Add(this.FormattedTitleLabel);
            this.groupBox3.Controls.Add(this.lastNameValue);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.middleNameValue);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.firstNameValue);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.FormattedNameValue);
            this.groupBox3.Controls.Add(this.FormattedNameLabel);
            this.groupBox3.Location = new System.Drawing.Point(8, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(571, 159);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Name";
            // 
            // FormattedTitleValue
            // 
            this.FormattedTitleValue.Location = new System.Drawing.Point(45, 21);
            this.FormattedTitleValue.Margin = new System.Windows.Forms.Padding(4);
            this.FormattedTitleValue.Name = "FormattedTitleValue";
            this.FormattedTitleValue.oldText = null;
            this.FormattedTitleValue.Size = new System.Drawing.Size(100, 22);
            this.FormattedTitleValue.TabIndex = 1;
            this.FormattedTitleValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.FormattedTitleValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // FormattedTitleLabel
            // 
            this.FormattedTitleLabel.Location = new System.Drawing.Point(-4, 20);
            this.FormattedTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormattedTitleLabel.Name = "FormattedTitleLabel";
            this.FormattedTitleLabel.Size = new System.Drawing.Size(52, 23);
            this.FormattedTitleLabel.TabIndex = 0;
            this.FormattedTitleLabel.Text = "Title:";
            this.FormattedTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNameValue
            // 
            this.lastNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameValue.Location = new System.Drawing.Point(395, 53);
            this.lastNameValue.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.oldText = null;
            this.lastNameValue.Size = new System.Drawing.Size(168, 22);
            this.lastNameValue.TabIndex = 9;
            this.lastNameValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.lastNameValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(341, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // middleNameValue
            // 
            this.middleNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middleNameValue.Location = new System.Drawing.Point(237, 53);
            this.middleNameValue.Margin = new System.Windows.Forms.Padding(4);
            this.middleNameValue.Name = "middleNameValue";
            this.middleNameValue.oldText = null;
            this.middleNameValue.Size = new System.Drawing.Size(95, 22);
            this.middleNameValue.TabIndex = 7;
            this.middleNameValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.middleNameValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(151, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Middle:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(45, 53);
            this.firstNameValue.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.oldText = null;
            this.firstNameValue.Size = new System.Drawing.Size(100, 22);
            this.firstNameValue.TabIndex = 5;
            this.firstNameValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.firstNameValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "First:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormattedNameValue
            // 
            this.FormattedNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormattedNameValue.Location = new System.Drawing.Point(237, 21);
            this.FormattedNameValue.Margin = new System.Windows.Forms.Padding(4);
            this.FormattedNameValue.Name = "FormattedNameValue";
            this.FormattedNameValue.oldText = null;
            this.FormattedNameValue.Size = new System.Drawing.Size(324, 22);
            this.FormattedNameValue.TabIndex = 3;
            this.FormattedNameValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.FormattedNameValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // FormattedNameLabel
            // 
            this.FormattedNameLabel.Location = new System.Drawing.Point(148, 21);
            this.FormattedNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormattedNameLabel.Name = "FormattedNameLabel";
            this.FormattedNameLabel.Size = new System.Drawing.Size(81, 23);
            this.FormattedNameLabel.TabIndex = 2;
            this.FormattedNameLabel.Text = "Full Name:";
            this.FormattedNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.EmailAddressLabel);
            this.groupBox2.Controls.Add(this.EmailAddressValue);
            this.groupBox2.Controls.Add(this.PersonalWebSiteLabel);
            this.groupBox2.Controls.Add(this.PersonalWebSiteValue);
            this.groupBox2.Location = new System.Drawing.Point(360, 426);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(420, 129);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Web : ";
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.Location = new System.Drawing.Point(8, 27);
            this.EmailAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(55, 23);
            this.EmailAddressLabel.TabIndex = 0;
            this.EmailAddressLabel.Text = "Email:";
            this.EmailAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmailAddressValue
            // 
            this.EmailAddressValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailAddressValue.Location = new System.Drawing.Point(71, 26);
            this.EmailAddressValue.Margin = new System.Windows.Forms.Padding(4);
            this.EmailAddressValue.Name = "EmailAddressValue";
            this.EmailAddressValue.oldText = null;
            this.EmailAddressValue.Size = new System.Drawing.Size(360, 22);
            this.EmailAddressValue.TabIndex = 1;
            this.EmailAddressValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.EmailAddressValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // PersonalWebSiteLabel
            // 
            this.PersonalWebSiteLabel.Location = new System.Drawing.Point(13, 55);
            this.PersonalWebSiteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PersonalWebSiteLabel.Name = "PersonalWebSiteLabel";
            this.PersonalWebSiteLabel.Size = new System.Drawing.Size(49, 23);
            this.PersonalWebSiteLabel.TabIndex = 2;
            this.PersonalWebSiteLabel.Text = "Web:";
            this.PersonalWebSiteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PersonalWebSiteValue
            // 
            this.PersonalWebSiteValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonalWebSiteValue.Location = new System.Drawing.Point(71, 55);
            this.PersonalWebSiteValue.Margin = new System.Windows.Forms.Padding(4);
            this.PersonalWebSiteValue.Name = "PersonalWebSiteValue";
            this.PersonalWebSiteValue.oldText = null;
            this.PersonalWebSiteValue.Size = new System.Drawing.Size(360, 22);
            this.PersonalWebSiteValue.TabIndex = 3;
            this.PersonalWebSiteValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.PersonalWebSiteValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.WorkPhoneLabel);
            this.groupBox1.Controls.Add(this.HomePhoneLabel);
            this.groupBox1.Controls.Add(this.HomePhoneValue);
            this.groupBox1.Controls.Add(this.WorkPhoneValue);
            this.groupBox1.Controls.Add(this.CellularPhoneLabel);
            this.groupBox1.Controls.Add(this.CellularPhoneValue);
            this.groupBox1.Location = new System.Drawing.Point(8, 426);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(344, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phones : ";
            // 
            // HomePhoneValue
            // 
            this.HomePhoneValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomePhoneValue.Location = new System.Drawing.Point(80, 25);
            this.HomePhoneValue.Margin = new System.Windows.Forms.Padding(4);
            this.HomePhoneValue.Name = "HomePhoneValue";
            this.HomePhoneValue.oldText = null;
            this.HomePhoneValue.Size = new System.Drawing.Size(229, 22);
            this.HomePhoneValue.TabIndex = 1;
            this.HomePhoneValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.HomePhoneValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // WorkPhoneValue
            // 
            this.WorkPhoneValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkPhoneValue.Location = new System.Drawing.Point(80, 89);
            this.WorkPhoneValue.Margin = new System.Windows.Forms.Padding(4);
            this.WorkPhoneValue.Name = "WorkPhoneValue";
            this.WorkPhoneValue.oldText = null;
            this.WorkPhoneValue.Size = new System.Drawing.Size(229, 22);
            this.WorkPhoneValue.TabIndex = 5;
            this.WorkPhoneValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.WorkPhoneValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // CellularPhoneValue
            // 
            this.CellularPhoneValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CellularPhoneValue.Location = new System.Drawing.Point(80, 55);
            this.CellularPhoneValue.Margin = new System.Windows.Forms.Padding(4);
            this.CellularPhoneValue.Name = "CellularPhoneValue";
            this.CellularPhoneValue.oldText = null;
            this.CellularPhoneValue.Size = new System.Drawing.Size(229, 22);
            this.CellularPhoneValue.TabIndex = 3;
            this.CellularPhoneValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.CellularPhoneValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // PhotoBox
            // 
            this.PhotoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhotoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhotoBox.Image = ((System.Drawing.Image)(resources.GetObject("PhotoBox.Image")));
            this.PhotoBox.Location = new System.Drawing.Point(603, 23);
            this.PhotoBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(185, 159);
            this.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoBox.TabIndex = 53;
            this.PhotoBox.TabStop = false;
            this.PhotoBox.Click += new System.EventHandler(this.PhotoBox_Click);
            // 
            // gbNameList
            // 
            this.gbNameList.Controls.Add(this.dgContacts);
            this.gbNameList.Controls.Add(this.btnClearFilter);
            this.gbNameList.Controls.Add(this.textBoxFilter);
            this.gbNameList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNameList.Enabled = false;
            this.gbNameList.Location = new System.Drawing.Point(0, 0);
            this.gbNameList.Margin = new System.Windows.Forms.Padding(4);
            this.gbNameList.Name = "gbNameList";
            this.gbNameList.Padding = new System.Windows.Forms.Padding(4);
            this.gbNameList.Size = new System.Drawing.Size(397, 563);
            this.gbNameList.TabIndex = 2;
            this.gbNameList.TabStop = false;
            this.gbNameList.Text = "Name List :";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFilter.Image")));
            this.btnClearFilter.Location = new System.Drawing.Point(357, 17);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(37, 27);
            this.btnClearFilter.TabIndex = 1;
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.Location = new System.Drawing.Point(8, 18);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(341, 22);
            this.textBoxFilter.TabIndex = 0;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // dgContacts
            // 
            this.dgContacts.AllowUserToAddRows = false;
            this.dgContacts.AllowUserToDeleteRows = false;
            this.dgContacts.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgContacts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgContacts.AutoGenerateColumns = false;
            this.dgContacts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgContacts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.FormattedName,
            this.FamilyName,
            this.Cellular});
            this.dgContacts.DataSource = this.bsContacts;
            this.dgContacts.Location = new System.Drawing.Point(8, 47);
            this.dgContacts.Margin = new System.Windows.Forms.Padding(4);
            this.dgContacts.MultiSelect = false;
            this.dgContacts.Name = "dgContacts";
            this.dgContacts.RowHeadersVisible = false;
            this.dgContacts.RowHeadersWidth = 51;
            this.dgContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgContacts.Size = new System.Drawing.Size(389, 508);
            this.dgContacts.TabIndex = 2;
            this.dgContacts.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgContacts_CellContextMenuStripNeeded);
            this.dgContacts.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContacts_RowLeave);
            this.dgContacts.SelectionChanged += new System.EventHandler(this.dgContacts_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "isSelected";
            this.Column1.HeaderText = " ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // FormattedName
            // 
            this.FormattedName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FormattedName.DataPropertyName = "Name";
            this.FormattedName.HeaderText = "Name";
            this.FormattedName.MinimumWidth = 6;
            this.FormattedName.Name = "FormattedName";
            this.FormattedName.ReadOnly = true;
            // 
            // FamilyName
            // 
            this.FamilyName.DataPropertyName = "FamilyName";
            this.FamilyName.HeaderText = "FamilyName";
            this.FamilyName.MinimumWidth = 6;
            this.FamilyName.Name = "FamilyName";
            this.FamilyName.ReadOnly = true;
            this.FamilyName.Visible = false;
            this.FamilyName.Width = 125;
            // 
            // Cellular
            // 
            this.Cellular.DataPropertyName = "Cellular";
            this.Cellular.HeaderText = "Cellular";
            this.Cellular.MinimumWidth = 6;
            this.Cellular.Name = "Cellular";
            this.Cellular.ReadOnly = true;
            this.Cellular.Visible = false;
            this.Cellular.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifiyColumnsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 28);
            // 
            // modifiyColumnsToolStripMenuItem
            // 
            this.modifiyColumnsToolStripMenuItem.Name = "modifiyColumnsToolStripMenuItem";
            this.modifiyColumnsToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.modifiyColumnsToolStripMenuItem.Text = "Modifiy Columns";
            this.modifiyColumnsToolStripMenuItem.Click += new System.EventHandler(this.modifiyColumnsToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 61);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbNameList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbContactDetail);
            this.splitContainer1.Size = new System.Drawing.Size(1197, 563);
            this.splitContainer1.SplitterDistance = 397;
            this.splitContainer1.TabIndex = 4;
            // 
            // exportToolStripMenuItem
            // 
            this.tbcAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcAddress.Controls.Add(this.tabPage1);
            this.tbcAddress.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tbcAddress.Location = new System.Drawing.Point(17, 23);
            this.tbcAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbcAddress.Name = "tbcAddress";
            this.tbcAddress.Padding = new System.Drawing.Point(12, 4);
            this.tbcAddress.SelectedIndex = 0;
            this.tbcAddress.ShowToolTips = true;
            this.tbcAddress.Size = new System.Drawing.Size(755, 190);
            this.tbcAddress.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(747, 159);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " ";
            // 
            // FormattedTitleValue
            // 
            this.FormattedTitleValue.Location = new System.Drawing.Point(45, 21);
            this.FormattedTitleValue.Margin = new System.Windows.Forms.Padding(4);
            this.FormattedTitleValue.Name = "FormattedTitleValue";
            this.FormattedTitleValue.oldText = null;
            this.FormattedTitleValue.Size = new System.Drawing.Size(100, 22);
            this.FormattedTitleValue.TabIndex = 1;
            this.FormattedTitleValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.FormattedTitleValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // lastNameValue
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // countToolStripMenuItem
            // 
            this.middleNameValue.Location = new System.Drawing.Point(237, 53);
            this.middleNameValue.Margin = new System.Windows.Forms.Padding(4);
            this.middleNameValue.Name = "middleNameValue";
            this.middleNameValue.oldText = null;
            this.middleNameValue.Size = new System.Drawing.Size(95, 22);
            this.middleNameValue.TabIndex = 7;
            this.middleNameValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.middleNameValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(45, 53);
            this.firstNameValue.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.oldText = null;
            this.firstNameValue.Size = new System.Drawing.Size(100, 22);
            this.firstNameValue.TabIndex = 5;
            this.firstNameValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.firstNameValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // FormattedNameValue
            // 
            this.FormattedNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormattedNameValue.Location = new System.Drawing.Point(237, 21);
            this.FormattedNameValue.Margin = new System.Windows.Forms.Padding(4);
            this.FormattedNameValue.Name = "FormattedNameValue";
            this.FormattedNameValue.oldText = null;
            this.FormattedNameValue.Size = new System.Drawing.Size(324, 22);
            this.FormattedNameValue.TabIndex = 3;
            this.FormattedNameValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.FormattedNameValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // EmailAddressValue
            // 
            this.EmailAddressValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailAddressValue.Location = new System.Drawing.Point(71, 26);
            this.EmailAddressValue.Margin = new System.Windows.Forms.Padding(4);
            this.EmailAddressValue.Name = "EmailAddressValue";
            this.EmailAddressValue.oldText = null;
            this.EmailAddressValue.Size = new System.Drawing.Size(340, 22);
            this.EmailAddressValue.TabIndex = 1;
            this.EmailAddressValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.EmailAddressValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // PersonalWebSiteValue
            // 
            this.PersonalWebSiteValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonalWebSiteValue.Location = new System.Drawing.Point(71, 55);
            this.PersonalWebSiteValue.Margin = new System.Windows.Forms.Padding(4);
            this.PersonalWebSiteValue.Name = "PersonalWebSiteValue";
            this.PersonalWebSiteValue.oldText = null;
            this.PersonalWebSiteValue.Size = new System.Drawing.Size(340, 22);
            this.PersonalWebSiteValue.TabIndex = 3;
            this.PersonalWebSiteValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.PersonalWebSiteValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // HomePhoneValue
            // 
            this.HomePhoneValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomePhoneValue.Location = new System.Drawing.Point(80, 25);
            this.HomePhoneValue.Margin = new System.Windows.Forms.Padding(4);
            this.HomePhoneValue.Name = "HomePhoneValue";
            this.HomePhoneValue.oldText = null;
            this.HomePhoneValue.Size = new System.Drawing.Size(252, 22);
            this.HomePhoneValue.TabIndex = 1;
            this.HomePhoneValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.HomePhoneValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // WorkPhoneValue
            // 
            this.WorkPhoneValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkPhoneValue.Location = new System.Drawing.Point(80, 89);
            this.WorkPhoneValue.Margin = new System.Windows.Forms.Padding(4);
            this.WorkPhoneValue.Name = "WorkPhoneValue";
            this.WorkPhoneValue.oldText = null;
            this.WorkPhoneValue.Size = new System.Drawing.Size(252, 22);
            this.WorkPhoneValue.TabIndex = 5;
            this.WorkPhoneValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.WorkPhoneValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // CellularPhoneValue
            // 
            this.CellularPhoneValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CellularPhoneValue.Location = new System.Drawing.Point(80, 55);
            this.CellularPhoneValue.Margin = new System.Windows.Forms.Padding(4);
            this.CellularPhoneValue.Name = "CellularPhoneValue";
            this.CellularPhoneValue.oldText = null;
            this.CellularPhoneValue.Size = new System.Drawing.Size(252, 22);
            this.CellularPhoneValue.TabIndex = 3;
            this.CellularPhoneValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.CellularPhoneValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 646);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "vCard Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbContactDetail.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tbcAddress.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContacts)).EndInit();
            this.gbNameList.ResumeLayout(false);
            this.gbNameList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tbcAddress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miQuit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbsOpen;
        private System.Windows.Forms.ToolStripButton tbsSave;
        private System.Windows.Forms.ToolStripButton tbsDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbsAbout;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource bsContacts;
        internal System.Windows.Forms.Label HomePhoneLabel;
        internal StateTextBox HomePhoneValue;
        internal System.Windows.Forms.Label CellularPhoneLabel;
        internal StateTextBox CellularPhoneValue;
        internal System.Windows.Forms.Label WorkPhoneLabel;
        internal StateTextBox WorkPhoneValue;
        private System.Windows.Forms.GroupBox gbContactDetail;
        private System.Windows.Forms.GroupBox gbNameList;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.DataGridView dgContacts;
        private System.Windows.Forms.Button btnClearFilter;
        internal System.Windows.Forms.PictureBox PhotoBox;
        private System.Windows.Forms.ToolStripMenuItem recentFilesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miConfig;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label EmailAddressLabel;
        internal StateTextBox EmailAddressValue;
        internal System.Windows.Forms.Label PersonalWebSiteLabel;
        internal StateTextBox PersonalWebSiteValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        internal StateTextBox FormattedNameValue;
        internal System.Windows.Forms.Label FormattedNameLabel;
        internal StateTextBox FormattedTitleValue;
        internal System.Windows.Forms.Label FormattedTitleLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        internal StateTextBox lastNameValue;
        internal System.Windows.Forms.Label label3;
        internal StateTextBox middleNameValue;
        internal System.Windows.Forms.Label label2;
        internal StateTextBox firstNameValue;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripButton tbsNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Button btnExportImage;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagesToolStripMenuItem;
        private AddressTabControl tbcAddress;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifiyColumnsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormattedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cellular;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}