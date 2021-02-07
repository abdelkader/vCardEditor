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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbsOpen = new System.Windows.Forms.ToolStripButton();
            this.tbsSave = new System.Windows.Forms.ToolStripButton();
            this.tbsDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbsAbout = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.HomePhoneLabel = new System.Windows.Forms.Label();
            this.CellularPhoneLabel = new System.Windows.Forms.Label();
            this.WorkPhoneLabel = new System.Windows.Forms.Label();
            this.gbContactDetail = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdPostal = new System.Windows.Forms.RadioButton();
            this.rbWork = new System.Windows.Forms.RadioButton();
            this.rdHome = new System.Windows.Forms.RadioButton();
            this.Country = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.POBoxLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FormattedTitleLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FormattedNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.PersonalWebSiteLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.bsContacts = new System.Windows.Forms.BindingSource(this.components);
            this.gbNameList = new System.Windows.Forms.GroupBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.dgContacts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryValue = new vCardEditor.View.StateTextBox();
            this.StateValue = new vCardEditor.View.StateTextBox();
            this.ZipValue = new vCardEditor.View.StateTextBox();
            this.CityValue = new vCardEditor.View.StateTextBox();
            this.POBoxValue = new vCardEditor.View.StateTextBox();
            this.AddressValue = new vCardEditor.View.StateTextBox();
            this.FormattedTitleValue = new vCardEditor.View.StateTextBox();
            this.stateTextBox3 = new vCardEditor.View.StateTextBox();
            this.stateTextBox2 = new vCardEditor.View.StateTextBox();
            this.stateTextBox1 = new vCardEditor.View.StateTextBox();
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
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContacts)).BeginInit();
            this.gbNameList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen,
            this.toolStripMenuItem1,
            this.miConfig,
            this.recentFilesMenuItem,
            this.miQuit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // miOpen
            // 
            this.miOpen.Image = ((System.Drawing.Image)(resources.GetObject("miOpen.Image")));
            this.miOpen.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(130, 22);
            this.miOpen.Text = "&Open";
            this.miOpen.Click += new System.EventHandler(this.tbsOpen_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 6);
            // 
            // miConfig
            // 
            this.miConfig.Name = "miConfig";
            this.miConfig.Size = new System.Drawing.Size(130, 22);
            this.miConfig.Text = "Preference";
            this.miConfig.Click += new System.EventHandler(this.miConfig_Click);
            // 
            // recentFilesMenuItem
            // 
            this.recentFilesMenuItem.Name = "recentFilesMenuItem";
            this.recentFilesMenuItem.Size = new System.Drawing.Size(130, 22);
            this.recentFilesMenuItem.Text = "Recent";
            // 
            // miQuit
            // 
            this.miQuit.Image = ((System.Drawing.Image)(resources.GetObject("miQuit.Image")));
            this.miQuit.Name = "miQuit";
            this.miQuit.Size = new System.Drawing.Size(130, 22);
            this.miQuit.Text = "&Quit";
            this.miQuit.Click += new System.EventHandler(this.miQuit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // miAbout
            // 
            this.miAbout.Image = ((System.Drawing.Image)(resources.GetObject("miAbout.Image")));
            this.miAbout.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(107, 22);
            this.miAbout.Text = "&About";
            this.miAbout.Click += new System.EventHandler(this.tbsAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(808, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsOpen,
            this.tbsSave,
            this.tbsDelete,
            this.toolStripSeparator1,
            this.tbsAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(808, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbsOpen
            // 
            this.tbsOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbsOpen.Image")));
            this.tbsOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsOpen.Name = "tbsOpen";
            this.tbsOpen.Size = new System.Drawing.Size(23, 22);
            this.tbsOpen.Text = "&Open";
            this.tbsOpen.Click += new System.EventHandler(this.tbsOpen_Click);
            // 
            // tbsSave
            // 
            this.tbsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsSave.Image = ((System.Drawing.Image)(resources.GetObject("tbsSave.Image")));
            this.tbsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsSave.Name = "tbsSave";
            this.tbsSave.Size = new System.Drawing.Size(23, 22);
            this.tbsSave.Text = "&Save";
            this.tbsSave.Click += new System.EventHandler(this.tbsSave_Click);
            // 
            // tbsDelete
            // 
            this.tbsDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsDelete.Image = ((System.Drawing.Image)(resources.GetObject("tbsDelete.Image")));
            this.tbsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsDelete.Name = "tbsDelete";
            this.tbsDelete.Size = new System.Drawing.Size(23, 22);
            this.tbsDelete.Text = "Delete";
            this.tbsDelete.Click += new System.EventHandler(this.tbsDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbsAbout
            // 
            this.tbsAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsAbout.Image = ((System.Drawing.Image)(resources.GetObject("tbsAbout.Image")));
            this.tbsAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsAbout.Name = "tbsAbout";
            this.tbsAbout.Size = new System.Drawing.Size(23, 22);
            this.tbsAbout.Text = "&?";
            this.tbsAbout.Click += new System.EventHandler(this.tbsAbout_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "vCard Files|*.vcf";
            this.openFileDialog.Title = "Open vCard File";
            // 
            // HomePhoneLabel
            // 
            this.HomePhoneLabel.Location = new System.Drawing.Point(9, 21);
            this.HomePhoneLabel.Name = "HomePhoneLabel";
            this.HomePhoneLabel.Size = new System.Drawing.Size(45, 19);
            this.HomePhoneLabel.TabIndex = 0;
            this.HomePhoneLabel.Text = "Home :";
            this.HomePhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CellularPhoneLabel
            // 
            this.CellularPhoneLabel.Location = new System.Drawing.Point(6, 46);
            this.CellularPhoneLabel.Name = "CellularPhoneLabel";
            this.CellularPhoneLabel.Size = new System.Drawing.Size(45, 19);
            this.CellularPhoneLabel.TabIndex = 2;
            this.CellularPhoneLabel.Text = "Mobile:";
            this.CellularPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkPhoneLabel
            // 
            this.WorkPhoneLabel.Location = new System.Drawing.Point(12, 74);
            this.WorkPhoneLabel.Name = "WorkPhoneLabel";
            this.WorkPhoneLabel.Size = new System.Drawing.Size(45, 19);
            this.WorkPhoneLabel.TabIndex = 4;
            this.WorkPhoneLabel.Text = "Work:";
            this.WorkPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbContactDetail
            // 
            this.gbContactDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbContactDetail.Controls.Add(this.groupBox4);
            this.gbContactDetail.Controls.Add(this.groupBox3);
            this.gbContactDetail.Controls.Add(this.groupBox2);
            this.gbContactDetail.Controls.Add(this.groupBox1);
            this.gbContactDetail.Controls.Add(this.PhotoBox);
            this.gbContactDetail.Enabled = false;
            this.gbContactDetail.Location = new System.Drawing.Point(250, 52);
            this.gbContactDetail.Name = "gbContactDetail";
            this.gbContactDetail.Size = new System.Drawing.Size(546, 378);
            this.gbContactDetail.TabIndex = 3;
            this.gbContactDetail.TabStop = false;
            this.gbContactDetail.Text = "Contact Detail :";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.rdPostal);
            this.groupBox4.Controls.Add(this.rbWork);
            this.groupBox4.Controls.Add(this.rdHome);
            this.groupBox4.Controls.Add(this.CountryValue);
            this.groupBox4.Controls.Add(this.Country);
            this.groupBox4.Controls.Add(this.StateValue);
            this.groupBox4.Controls.Add(this.StateLabel);
            this.groupBox4.Controls.Add(this.ZipValue);
            this.groupBox4.Controls.Add(this.ZipLabel);
            this.groupBox4.Controls.Add(this.CityValue);
            this.groupBox4.Controls.Add(this.CityLabel);
            this.groupBox4.Controls.Add(this.POBoxValue);
            this.groupBox4.Controls.Add(this.POBoxLabel);
            this.groupBox4.Controls.Add(this.AddressValue);
            this.groupBox4.Controls.Add(this.AddressLabel);
            this.groupBox4.Location = new System.Drawing.Point(18, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(522, 112);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Address:";
            // 
            // rdPostal
            // 
            this.rdPostal.AutoSize = true;
            this.rdPostal.Location = new System.Drawing.Point(16, 62);
            this.rdPostal.Name = "rdPostal";
            this.rdPostal.Size = new System.Drawing.Size(54, 17);
            this.rdPostal.TabIndex = 17;
            this.rdPostal.TabStop = true;
            this.rdPostal.Text = "Postal";
            this.rdPostal.UseVisualStyleBackColor = true;
            // 
            // rbWork
            // 
            this.rbWork.AutoSize = true;
            this.rbWork.Location = new System.Drawing.Point(16, 43);
            this.rbWork.Name = "rbWork";
            this.rbWork.Size = new System.Drawing.Size(51, 17);
            this.rbWork.TabIndex = 17;
            this.rbWork.TabStop = true;
            this.rbWork.Text = "Work";
            this.rbWork.UseVisualStyleBackColor = true;
            // 
            // rdHome
            // 
            this.rdHome.AutoSize = true;
            this.rdHome.Location = new System.Drawing.Point(16, 24);
            this.rdHome.Name = "rdHome";
            this.rdHome.Size = new System.Drawing.Size(53, 17);
            this.rdHome.TabIndex = 16;
            this.rdHome.TabStop = true;
            this.rdHome.Text = "Home";
            this.rdHome.UseVisualStyleBackColor = true;
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(296, 75);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(49, 19);
            this.Country.TabIndex = 14;
            this.Country.Text = "Country:";
            this.Country.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StateLabel
            // 
            this.StateLabel.Location = new System.Drawing.Point(133, 73);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(46, 19);
            this.StateLabel.TabIndex = 12;
            this.StateLabel.Text = "State:";
            this.StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ZipLabel
            // 
            this.ZipLabel.Location = new System.Drawing.Point(425, 47);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(28, 19);
            this.ZipLabel.TabIndex = 10;
            this.ZipLabel.Text = "Zip:";
            this.ZipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CityLabel
            // 
            this.CityLabel.Location = new System.Drawing.Point(293, 47);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(43, 19);
            this.CityLabel.TabIndex = 8;
            this.CityLabel.Text = "City:";
            this.CityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // POBoxLabel
            // 
            this.POBoxLabel.Location = new System.Drawing.Point(130, 46);
            this.POBoxLabel.Name = "POBoxLabel";
            this.POBoxLabel.Size = new System.Drawing.Size(49, 19);
            this.POBoxLabel.TabIndex = 6;
            this.POBoxLabel.Text = "PO Box:";
            this.POBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddressLabel
            // 
            this.AddressLabel.Location = new System.Drawing.Point(130, 23);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(49, 19);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "Address:";
            this.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.FormattedTitleValue);
            this.groupBox3.Controls.Add(this.FormattedTitleLabel);
            this.groupBox3.Controls.Add(this.stateTextBox3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.stateTextBox2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.stateTextBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.FormattedNameValue);
            this.groupBox3.Controls.Add(this.FormattedNameLabel);
            this.groupBox3.Location = new System.Drawing.Point(18, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 80);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Name";
            // 
            // FormattedTitleLabel
            // 
            this.FormattedTitleLabel.Location = new System.Drawing.Point(-3, 16);
            this.FormattedTitleLabel.Name = "FormattedTitleLabel";
            this.FormattedTitleLabel.Size = new System.Drawing.Size(39, 19);
            this.FormattedTitleLabel.TabIndex = 2;
            this.FormattedTitleLabel.Text = "Title:";
            this.FormattedTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(256, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(120, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Middle:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "First:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormattedNameLabel
            // 
            this.FormattedNameLabel.Location = new System.Drawing.Point(106, 17);
            this.FormattedNameLabel.Name = "FormattedNameLabel";
            this.FormattedNameLabel.Size = new System.Drawing.Size(61, 19);
            this.FormattedNameLabel.TabIndex = 0;
            this.FormattedNameLabel.Text = "Full Name:";
            this.FormattedNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.EmailAddressLabel);
            this.groupBox2.Controls.Add(this.EmailAddressValue);
            this.groupBox2.Controls.Add(this.PersonalWebSiteLabel);
            this.groupBox2.Controls.Add(this.PersonalWebSiteValue);
            this.groupBox2.Location = new System.Drawing.Point(261, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 105);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Web : ";
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.Location = new System.Drawing.Point(6, 22);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(41, 19);
            this.EmailAddressLabel.TabIndex = 0;
            this.EmailAddressLabel.Text = "Email:";
            this.EmailAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PersonalWebSiteLabel
            // 
            this.PersonalWebSiteLabel.Location = new System.Drawing.Point(10, 45);
            this.PersonalWebSiteLabel.Name = "PersonalWebSiteLabel";
            this.PersonalWebSiteLabel.Size = new System.Drawing.Size(37, 19);
            this.PersonalWebSiteLabel.TabIndex = 2;
            this.PersonalWebSiteLabel.Text = "Web:";
            this.PersonalWebSiteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.groupBox1.Location = new System.Drawing.Point(22, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phones : ";
            // 
            // PhotoBox
            // 
            this.PhotoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhotoBox.Image = ((System.Drawing.Image)(resources.GetObject("PhotoBox.Image")));
            this.PhotoBox.Location = new System.Drawing.Point(401, 19);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(139, 129);
            this.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoBox.TabIndex = 53;
            this.PhotoBox.TabStop = false;
            // 
            // gbNameList
            // 
            this.gbNameList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbNameList.Controls.Add(this.btnClearFilter);
            this.gbNameList.Controls.Add(this.textBoxFilter);
            this.gbNameList.Controls.Add(this.dgContacts);
            this.gbNameList.Enabled = false;
            this.gbNameList.Location = new System.Drawing.Point(13, 52);
            this.gbNameList.Name = "gbNameList";
            this.gbNameList.Size = new System.Drawing.Size(231, 378);
            this.gbNameList.TabIndex = 2;
            this.gbNameList.TabStop = false;
            this.gbNameList.Text = "Name List :";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFilter.Image")));
            this.btnClearFilter.Location = new System.Drawing.Point(201, 14);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(28, 22);
            this.btnClearFilter.TabIndex = 1;
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(3, 15);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(193, 20);
            this.textBoxFilter.TabIndex = 0;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // dgContacts
            // 
            this.dgContacts.AllowUserToAddRows = false;
            this.dgContacts.AllowUserToDeleteRows = false;
            this.dgContacts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgContacts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgContacts.AutoGenerateColumns = false;
            this.dgContacts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgContacts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgContacts.DataSource = this.bsContacts;
            this.dgContacts.Location = new System.Drawing.Point(3, 41);
            this.dgContacts.MultiSelect = false;
            this.dgContacts.Name = "dgContacts";
            this.dgContacts.RowHeadersVisible = false;
            this.dgContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgContacts.Size = new System.Drawing.Size(225, 334);
            this.dgContacts.TabIndex = 2;
            this.dgContacts.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContacts_RowLeave);
            this.dgContacts.SelectionChanged += new System.EventHandler(this.dgContacts_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "isSelected";
            this.Column1.HeaderText = " ";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // CountryValue
            // 
            this.CountryValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryValue.Location = new System.Drawing.Point(351, 74);
            this.CountryValue.Name = "CountryValue";
            this.CountryValue.oldText = null;
            this.CountryValue.Size = new System.Drawing.Size(165, 20);
            this.CountryValue.TabIndex = 15;
            // 
            // StateValue
            // 
            this.StateValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StateValue.Location = new System.Drawing.Point(185, 73);
            this.StateValue.Name = "StateValue";
            this.StateValue.oldText = null;
            this.StateValue.Size = new System.Drawing.Size(105, 20);
            this.StateValue.TabIndex = 13;
            // 
            // ZipValue
            // 
            this.ZipValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZipValue.Location = new System.Drawing.Point(460, 48);
            this.ZipValue.Name = "ZipValue";
            this.ZipValue.oldText = null;
            this.ZipValue.Size = new System.Drawing.Size(56, 20);
            this.ZipValue.TabIndex = 11;
            // 
            // CityValue
            // 
            this.CityValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityValue.Location = new System.Drawing.Point(351, 47);
            this.CityValue.Name = "CityValue";
            this.CityValue.oldText = null;
            this.CityValue.Size = new System.Drawing.Size(68, 20);
            this.CityValue.TabIndex = 9;
            // 
            // POBoxValue
            // 
            this.POBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.POBoxValue.Location = new System.Drawing.Point(185, 48);
            this.POBoxValue.Name = "POBoxValue";
            this.POBoxValue.oldText = null;
            this.POBoxValue.Size = new System.Drawing.Size(104, 20);
            this.POBoxValue.TabIndex = 7;
            // 
            // AddressValue
            // 
            this.AddressValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressValue.Location = new System.Drawing.Point(185, 22);
            this.AddressValue.Name = "AddressValue";
            this.AddressValue.oldText = null;
            this.AddressValue.Size = new System.Drawing.Size(331, 20);
            this.AddressValue.TabIndex = 5;
            // 
            // FormattedTitleValue
            // 
            this.FormattedTitleValue.Location = new System.Drawing.Point(34, 17);
            this.FormattedTitleValue.Name = "FormattedTitleValue";
            this.FormattedTitleValue.oldText = null;
            this.FormattedTitleValue.Size = new System.Drawing.Size(76, 20);
            this.FormattedTitleValue.TabIndex = 3;
            this.FormattedTitleValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.FormattedTitleValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // stateTextBox3
            // 
            this.stateTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stateTextBox3.Location = new System.Drawing.Point(296, 43);
            this.stateTextBox3.Name = "stateTextBox3";
            this.stateTextBox3.oldText = null;
            this.stateTextBox3.Size = new System.Drawing.Size(76, 20);
            this.stateTextBox3.TabIndex = 1;
            this.stateTextBox3.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.stateTextBox3.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // stateTextBox2
            // 
            this.stateTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stateTextBox2.Location = new System.Drawing.Point(167, 43);
            this.stateTextBox2.Name = "stateTextBox2";
            this.stateTextBox2.oldText = null;
            this.stateTextBox2.Size = new System.Drawing.Size(89, 20);
            this.stateTextBox2.TabIndex = 1;
            this.stateTextBox2.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.stateTextBox2.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // stateTextBox1
            // 
            this.stateTextBox1.Location = new System.Drawing.Point(34, 43);
            this.stateTextBox1.Name = "stateTextBox1";
            this.stateTextBox1.oldText = null;
            this.stateTextBox1.Size = new System.Drawing.Size(76, 20);
            this.stateTextBox1.TabIndex = 1;
            this.stateTextBox1.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.stateTextBox1.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // FormattedNameValue
            // 
            this.FormattedNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormattedNameValue.Location = new System.Drawing.Point(167, 17);
            this.FormattedNameValue.Name = "FormattedNameValue";
            this.FormattedNameValue.oldText = null;
            this.FormattedNameValue.Size = new System.Drawing.Size(204, 20);
            this.FormattedNameValue.TabIndex = 1;
            this.FormattedNameValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.FormattedNameValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // EmailAddressValue
            // 
            this.EmailAddressValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailAddressValue.Location = new System.Drawing.Point(53, 21);
            this.EmailAddressValue.Name = "EmailAddressValue";
            this.EmailAddressValue.oldText = null;
            this.EmailAddressValue.Size = new System.Drawing.Size(220, 20);
            this.EmailAddressValue.TabIndex = 1;
            this.EmailAddressValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.EmailAddressValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // PersonalWebSiteValue
            // 
            this.PersonalWebSiteValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonalWebSiteValue.Location = new System.Drawing.Point(53, 45);
            this.PersonalWebSiteValue.Name = "PersonalWebSiteValue";
            this.PersonalWebSiteValue.oldText = null;
            this.PersonalWebSiteValue.Size = new System.Drawing.Size(220, 20);
            this.PersonalWebSiteValue.TabIndex = 3;
            this.PersonalWebSiteValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.PersonalWebSiteValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // HomePhoneValue
            // 
            this.HomePhoneValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomePhoneValue.Location = new System.Drawing.Point(60, 20);
            this.HomePhoneValue.Name = "HomePhoneValue";
            this.HomePhoneValue.oldText = null;
            this.HomePhoneValue.Size = new System.Drawing.Size(166, 20);
            this.HomePhoneValue.TabIndex = 1;
            this.HomePhoneValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.HomePhoneValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // WorkPhoneValue
            // 
            this.WorkPhoneValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkPhoneValue.Location = new System.Drawing.Point(60, 72);
            this.WorkPhoneValue.Name = "WorkPhoneValue";
            this.WorkPhoneValue.oldText = null;
            this.WorkPhoneValue.Size = new System.Drawing.Size(166, 20);
            this.WorkPhoneValue.TabIndex = 5;
            this.WorkPhoneValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.WorkPhoneValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // CellularPhoneValue
            // 
            this.CellularPhoneValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CellularPhoneValue.Location = new System.Drawing.Point(60, 45);
            this.CellularPhoneValue.Name = "CellularPhoneValue";
            this.CellularPhoneValue.oldText = null;
            this.CellularPhoneValue.Size = new System.Drawing.Size(166, 20);
            this.CellularPhoneValue.TabIndex = 3;
            this.CellularPhoneValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.CellularPhoneValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 455);
            this.Controls.Add(this.gbNameList);
            this.Controls.Add(this.gbContactDetail);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "vCard Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbContactDetail.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
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
        private System.Windows.Forms.RadioButton rbWork;
        private System.Windows.Forms.RadioButton rdHome;
        internal StateTextBox CountryValue;
        internal System.Windows.Forms.Label Country;
        internal StateTextBox StateValue;
        internal System.Windows.Forms.Label StateLabel;
        internal StateTextBox ZipValue;
        internal System.Windows.Forms.Label ZipLabel;
        internal StateTextBox CityValue;
        internal System.Windows.Forms.Label CityLabel;
        internal StateTextBox POBoxValue;
        internal System.Windows.Forms.Label POBoxLabel;
        internal StateTextBox AddressValue;
        internal System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.RadioButton rdPostal;
        internal StateTextBox stateTextBox3;
        internal System.Windows.Forms.Label label3;
        internal StateTextBox stateTextBox2;
        internal System.Windows.Forms.Label label2;
        internal StateTextBox stateTextBox1;
        internal System.Windows.Forms.Label label1;
    }
}