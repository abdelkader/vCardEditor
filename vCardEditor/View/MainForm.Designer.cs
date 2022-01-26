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
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tbcAddress = new System.Windows.Forms.TabControl();
            this.tbHome = new System.Windows.Forms.TabPage();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.HomeAddressValue = new vCardEditor.View.StateTextBox();
            this.POBoxLabel = new System.Windows.Forms.Label();
            this.HomeCountryValue = new vCardEditor.View.StateTextBox();
            this.HomePOBoxValue = new vCardEditor.View.StateTextBox();
            this.Country = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.HomeStateValue = new vCardEditor.View.StateTextBox();
            this.HomeCityValue = new vCardEditor.View.StateTextBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.HomeZipValue = new vCardEditor.View.StateTextBox();
            this.tbWork = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.WorkAddressValue = new vCardEditor.View.StateTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WorkCountryValue = new vCardEditor.View.StateTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WorkPOBoxValue = new vCardEditor.View.StateTextBox();
            this.WorkZipValue = new vCardEditor.View.StateTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.WorkCityValue = new vCardEditor.View.StateTextBox();
            this.WorkStateValue = new vCardEditor.View.StateTextBox();
            this.tbPostal = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.PostalAddressValue = new vCardEditor.View.StateTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PostalCountryValue = new vCardEditor.View.StateTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PostalPOBoxValue = new vCardEditor.View.StateTextBox();
            this.PostalZipValue = new vCardEditor.View.StateTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PostalCityValue = new vCardEditor.View.StateTextBox();
            this.PostalStateValue = new vCardEditor.View.StateTextBox();
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
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbContactDetail.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tbcAddress.SuspendLayout();
            this.tbHome.SuspendLayout();
            this.tbWork.SuspendLayout();
            this.tbPostal.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(130, 22);
            this.miSave.Text = "&Save";
            this.miSave.Click += new System.EventHandler(this.tbsSave_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(859, 22);
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
            this.toolStrip1.Size = new System.Drawing.Size(859, 25);
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
            this.gbContactDetail.Size = new System.Drawing.Size(597, 414);
            this.gbContactDetail.TabIndex = 3;
            this.gbContactDetail.TabStop = false;
            this.gbContactDetail.Text = "Contact Detail :";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tbcAddress);
            this.groupBox4.Location = new System.Drawing.Point(18, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(573, 148);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Address:";
            // 
            // tbcAddress
            // 
            this.tbcAddress.Controls.Add(this.tbHome);
            this.tbcAddress.Controls.Add(this.tbWork);
            this.tbcAddress.Controls.Add(this.tbPostal);
            this.tbcAddress.Location = new System.Drawing.Point(13, 19);
            this.tbcAddress.Name = "tbcAddress";
            this.tbcAddress.SelectedIndex = 0;
            this.tbcAddress.Size = new System.Drawing.Size(554, 117);
            this.tbcAddress.TabIndex = 3;
            // 
            // tbHome
            // 
            this.tbHome.BackColor = System.Drawing.SystemColors.Control;
            this.tbHome.Controls.Add(this.AddressLabel);
            this.tbHome.Controls.Add(this.HomeAddressValue);
            this.tbHome.Controls.Add(this.POBoxLabel);
            this.tbHome.Controls.Add(this.HomeCountryValue);
            this.tbHome.Controls.Add(this.HomePOBoxValue);
            this.tbHome.Controls.Add(this.Country);
            this.tbHome.Controls.Add(this.CityLabel);
            this.tbHome.Controls.Add(this.HomeStateValue);
            this.tbHome.Controls.Add(this.HomeCityValue);
            this.tbHome.Controls.Add(this.StateLabel);
            this.tbHome.Controls.Add(this.ZipLabel);
            this.tbHome.Controls.Add(this.HomeZipValue);
            this.tbHome.Location = new System.Drawing.Point(4, 22);
            this.tbHome.Name = "tbHome";
            this.tbHome.Padding = new System.Windows.Forms.Padding(3);
            this.tbHome.Size = new System.Drawing.Size(546, 91);
            this.tbHome.TabIndex = 0;
            this.tbHome.Text = "Home";
            // 
            // AddressLabel
            // 
            this.AddressLabel.Location = new System.Drawing.Point(14, 13);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(49, 19);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "Address:";
            this.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HomeAddressValue
            // 
            this.HomeAddressValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeAddressValue.Location = new System.Drawing.Point(69, 12);
            this.HomeAddressValue.Name = "HomeAddressValue";
            this.HomeAddressValue.oldText = "";
            this.HomeAddressValue.Size = new System.Drawing.Size(461, 20);
            this.HomeAddressValue.TabIndex = 5;
            // 
            // POBoxLabel
            // 
            this.POBoxLabel.Location = new System.Drawing.Point(14, 37);
            this.POBoxLabel.Name = "POBoxLabel";
            this.POBoxLabel.Size = new System.Drawing.Size(49, 19);
            this.POBoxLabel.TabIndex = 6;
            this.POBoxLabel.Text = "PO Box:";
            this.POBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HomeCountryValue
            // 
            this.HomeCountryValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeCountryValue.Location = new System.Drawing.Point(299, 64);
            this.HomeCountryValue.Name = "HomeCountryValue";
            this.HomeCountryValue.oldText = null;
            this.HomeCountryValue.Size = new System.Drawing.Size(231, 20);
            this.HomeCountryValue.TabIndex = 15;
            // 
            // HomePOBoxValue
            // 
            this.HomePOBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomePOBoxValue.Location = new System.Drawing.Point(69, 36);
            this.HomePOBoxValue.Name = "HomePOBoxValue";
            this.HomePOBoxValue.oldText = null;
            this.HomePOBoxValue.Size = new System.Drawing.Size(178, 20);
            this.HomePOBoxValue.TabIndex = 7;
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(253, 65);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(49, 19);
            this.Country.TabIndex = 14;
            this.Country.Text = "Country:";
            this.Country.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CityLabel
            // 
            this.CityLabel.Location = new System.Drawing.Point(253, 39);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(32, 19);
            this.CityLabel.TabIndex = 8;
            this.CityLabel.Text = "City:";
            this.CityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HomeStateValue
            // 
            this.HomeStateValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeStateValue.Location = new System.Drawing.Point(69, 62);
            this.HomeStateValue.Name = "HomeStateValue";
            this.HomeStateValue.oldText = null;
            this.HomeStateValue.Size = new System.Drawing.Size(178, 20);
            this.HomeStateValue.TabIndex = 13;
            // 
            // HomeCityValue
            // 
            this.HomeCityValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeCityValue.Location = new System.Drawing.Point(299, 37);
            this.HomeCityValue.Name = "HomeCityValue";
            this.HomeCityValue.oldText = null;
            this.HomeCityValue.Size = new System.Drawing.Size(96, 20);
            this.HomeCityValue.TabIndex = 9;
            // 
            // StateLabel
            // 
            this.StateLabel.Location = new System.Drawing.Point(14, 56);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(46, 19);
            this.StateLabel.TabIndex = 12;
            this.StateLabel.Text = "State:";
            this.StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ZipLabel
            // 
            this.ZipLabel.Location = new System.Drawing.Point(401, 37);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(28, 19);
            this.ZipLabel.TabIndex = 10;
            this.ZipLabel.Text = "Zip:";
            this.ZipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HomeZipValue
            // 
            this.HomeZipValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeZipValue.Location = new System.Drawing.Point(436, 38);
            this.HomeZipValue.Name = "HomeZipValue";
            this.HomeZipValue.oldText = null;
            this.HomeZipValue.Size = new System.Drawing.Size(94, 20);
            this.HomeZipValue.TabIndex = 11;
            // 
            // tbWork
            // 
            this.tbWork.BackColor = System.Drawing.SystemColors.Control;
            this.tbWork.Controls.Add(this.label9);
            this.tbWork.Controls.Add(this.WorkAddressValue);
            this.tbWork.Controls.Add(this.label8);
            this.tbWork.Controls.Add(this.WorkCountryValue);
            this.tbWork.Controls.Add(this.label5);
            this.tbWork.Controls.Add(this.WorkPOBoxValue);
            this.tbWork.Controls.Add(this.WorkZipValue);
            this.tbWork.Controls.Add(this.label7);
            this.tbWork.Controls.Add(this.label4);
            this.tbWork.Controls.Add(this.label6);
            this.tbWork.Controls.Add(this.WorkCityValue);
            this.tbWork.Controls.Add(this.WorkStateValue);
            this.tbWork.Location = new System.Drawing.Point(4, 22);
            this.tbWork.Name = "tbWork";
            this.tbWork.Padding = new System.Windows.Forms.Padding(3);
            this.tbWork.Size = new System.Drawing.Size(546, 91);
            this.tbWork.TabIndex = 1;
            this.tbWork.Text = "Work";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(15, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Address:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkAddressValue
            // 
            this.WorkAddressValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkAddressValue.Location = new System.Drawing.Point(67, 9);
            this.WorkAddressValue.Name = "WorkAddressValue";
            this.WorkAddressValue.oldText = "";
            this.WorkAddressValue.Size = new System.Drawing.Size(464, 20);
            this.WorkAddressValue.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(15, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "PO Box:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkCountryValue
            // 
            this.WorkCountryValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkCountryValue.Location = new System.Drawing.Point(300, 61);
            this.WorkCountryValue.Name = "WorkCountryValue";
            this.WorkCountryValue.oldText = null;
            this.WorkCountryValue.Size = new System.Drawing.Size(231, 20);
            this.WorkCountryValue.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "State:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkPOBoxValue
            // 
            this.WorkPOBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkPOBoxValue.Location = new System.Drawing.Point(67, 33);
            this.WorkPOBoxValue.Name = "WorkPOBoxValue";
            this.WorkPOBoxValue.oldText = null;
            this.WorkPOBoxValue.Size = new System.Drawing.Size(178, 20);
            this.WorkPOBoxValue.TabIndex = 19;
            // 
            // WorkZipValue
            // 
            this.WorkZipValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkZipValue.Location = new System.Drawing.Point(437, 35);
            this.WorkZipValue.Name = "WorkZipValue";
            this.WorkZipValue.oldText = null;
            this.WorkZipValue.Size = new System.Drawing.Size(94, 20);
            this.WorkZipValue.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(254, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Country:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(402, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Zip:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(254, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "City:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkCityValue
            // 
            this.WorkCityValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkCityValue.Location = new System.Drawing.Point(300, 34);
            this.WorkCityValue.Name = "WorkCityValue";
            this.WorkCityValue.oldText = null;
            this.WorkCityValue.Size = new System.Drawing.Size(96, 20);
            this.WorkCityValue.TabIndex = 21;
            // 
            // WorkStateValue
            // 
            this.WorkStateValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkStateValue.Location = new System.Drawing.Point(67, 59);
            this.WorkStateValue.Name = "WorkStateValue";
            this.WorkStateValue.oldText = null;
            this.WorkStateValue.Size = new System.Drawing.Size(181, 20);
            this.WorkStateValue.TabIndex = 25;
            // 
            // tbPostal
            // 
            this.tbPostal.BackColor = System.Drawing.SystemColors.Control;
            this.tbPostal.Controls.Add(this.label10);
            this.tbPostal.Controls.Add(this.PostalAddressValue);
            this.tbPostal.Controls.Add(this.label11);
            this.tbPostal.Controls.Add(this.PostalCountryValue);
            this.tbPostal.Controls.Add(this.label12);
            this.tbPostal.Controls.Add(this.PostalPOBoxValue);
            this.tbPostal.Controls.Add(this.PostalZipValue);
            this.tbPostal.Controls.Add(this.label13);
            this.tbPostal.Controls.Add(this.label14);
            this.tbPostal.Controls.Add(this.label15);
            this.tbPostal.Controls.Add(this.PostalCityValue);
            this.tbPostal.Controls.Add(this.PostalStateValue);
            this.tbPostal.Location = new System.Drawing.Point(4, 22);
            this.tbPostal.Name = "tbPostal";
            this.tbPostal.Size = new System.Drawing.Size(546, 91);
            this.tbPostal.TabIndex = 2;
            this.tbPostal.Text = "Postal";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(15, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Address:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PostalAddressValue
            // 
            this.PostalAddressValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostalAddressValue.Location = new System.Drawing.Point(67, 9);
            this.PostalAddressValue.Name = "PostalAddressValue";
            this.PostalAddressValue.oldText = "";
            this.PostalAddressValue.Size = new System.Drawing.Size(464, 20);
            this.PostalAddressValue.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(15, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 19);
            this.label11.TabIndex = 18;
            this.label11.Text = "PO Box:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PostalCountryValue
            // 
            this.PostalCountryValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostalCountryValue.Location = new System.Drawing.Point(300, 61);
            this.PostalCountryValue.Name = "PostalCountryValue";
            this.PostalCountryValue.oldText = null;
            this.PostalCountryValue.Size = new System.Drawing.Size(231, 20);
            this.PostalCountryValue.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(15, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "State:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PostalPOBoxValue
            // 
            this.PostalPOBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostalPOBoxValue.Location = new System.Drawing.Point(67, 33);
            this.PostalPOBoxValue.Name = "PostalPOBoxValue";
            this.PostalPOBoxValue.oldText = null;
            this.PostalPOBoxValue.Size = new System.Drawing.Size(181, 20);
            this.PostalPOBoxValue.TabIndex = 19;
            // 
            // PostalZipValue
            // 
            this.PostalZipValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostalZipValue.Location = new System.Drawing.Point(437, 35);
            this.PostalZipValue.Name = "PostalZipValue";
            this.PostalZipValue.oldText = null;
            this.PostalZipValue.Size = new System.Drawing.Size(94, 20);
            this.PostalZipValue.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(254, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 19);
            this.label13.TabIndex = 26;
            this.label13.Text = "Country:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(402, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 19);
            this.label14.TabIndex = 22;
            this.label14.Text = "Zip:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(254, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 19);
            this.label15.TabIndex = 20;
            this.label15.Text = "City:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PostalCityValue
            // 
            this.PostalCityValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostalCityValue.Location = new System.Drawing.Point(300, 34);
            this.PostalCityValue.Name = "PostalCityValue";
            this.PostalCityValue.oldText = null;
            this.PostalCityValue.Size = new System.Drawing.Size(96, 20);
            this.PostalCityValue.TabIndex = 21;
            // 
            // PostalStateValue
            // 
            this.PostalStateValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostalStateValue.Location = new System.Drawing.Point(67, 59);
            this.PostalStateValue.Name = "PostalStateValue";
            this.PostalStateValue.oldText = null;
            this.PostalStateValue.Size = new System.Drawing.Size(181, 20);
            this.PostalStateValue.TabIndex = 25;
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
            this.groupBox3.Location = new System.Drawing.Point(18, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 115);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Name";
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
            // FormattedTitleLabel
            // 
            this.FormattedTitleLabel.Location = new System.Drawing.Point(-3, 16);
            this.FormattedTitleLabel.Name = "FormattedTitleLabel";
            this.FormattedTitleLabel.Size = new System.Drawing.Size(39, 19);
            this.FormattedTitleLabel.TabIndex = 2;
            this.FormattedTitleLabel.Text = "Title:";
            this.FormattedTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNameValue
            // 
            this.lastNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameValue.Location = new System.Drawing.Point(296, 43);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.oldText = null;
            this.lastNameValue.Size = new System.Drawing.Size(127, 20);
            this.lastNameValue.TabIndex = 1;
            this.lastNameValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.lastNameValue.Validated += new System.EventHandler(this.Value_TextChanged);
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
            // middleNameValue
            // 
            this.middleNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middleNameValue.Location = new System.Drawing.Point(178, 43);
            this.middleNameValue.Name = "middleNameValue";
            this.middleNameValue.oldText = null;
            this.middleNameValue.Size = new System.Drawing.Size(72, 20);
            this.middleNameValue.TabIndex = 1;
            this.middleNameValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.middleNameValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(113, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Middle:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(34, 43);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.oldText = null;
            this.firstNameValue.Size = new System.Drawing.Size(76, 20);
            this.firstNameValue.TabIndex = 1;
            this.firstNameValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.firstNameValue.Validated += new System.EventHandler(this.Value_TextChanged);
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
            // FormattedNameValue
            // 
            this.FormattedNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormattedNameValue.Location = new System.Drawing.Point(178, 17);
            this.FormattedNameValue.Name = "FormattedNameValue";
            this.FormattedNameValue.oldText = null;
            this.FormattedNameValue.Size = new System.Drawing.Size(244, 20);
            this.FormattedNameValue.TabIndex = 1;
            this.FormattedNameValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.FormattedNameValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // FormattedNameLabel
            // 
            this.FormattedNameLabel.Location = new System.Drawing.Point(111, 17);
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
            this.groupBox2.Location = new System.Drawing.Point(261, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 105);
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
            // EmailAddressValue
            // 
            this.EmailAddressValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailAddressValue.Location = new System.Drawing.Point(53, 21);
            this.EmailAddressValue.Name = "EmailAddressValue";
            this.EmailAddressValue.oldText = null;
            this.EmailAddressValue.Size = new System.Drawing.Size(271, 20);
            this.EmailAddressValue.TabIndex = 1;
            this.EmailAddressValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.EmailAddressValue.Validated += new System.EventHandler(this.Value_TextChanged);
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
            // PersonalWebSiteValue
            // 
            this.PersonalWebSiteValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonalWebSiteValue.Location = new System.Drawing.Point(53, 45);
            this.PersonalWebSiteValue.Name = "PersonalWebSiteValue";
            this.PersonalWebSiteValue.oldText = null;
            this.PersonalWebSiteValue.Size = new System.Drawing.Size(271, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(22, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phones : ";
            // 
            // HomePhoneValue
            // 
            this.HomePhoneValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomePhoneValue.Location = new System.Drawing.Point(60, 20);
            this.HomePhoneValue.Name = "HomePhoneValue";
            this.HomePhoneValue.oldText = null;
            this.HomePhoneValue.Size = new System.Drawing.Size(173, 20);
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
            this.WorkPhoneValue.Size = new System.Drawing.Size(173, 20);
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
            this.CellularPhoneValue.Size = new System.Drawing.Size(173, 20);
            this.CellularPhoneValue.TabIndex = 3;
            this.CellularPhoneValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.CellularPhoneValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // PhotoBox
            // 
            this.PhotoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhotoBox.Image = ((System.Drawing.Image)(resources.GetObject("PhotoBox.Image")));
            this.PhotoBox.Location = new System.Drawing.Point(452, 19);
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
            this.gbNameList.Size = new System.Drawing.Size(231, 414);
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
            this.dgContacts.Size = new System.Drawing.Size(225, 370);
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
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 491);
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
            this.tbcAddress.ResumeLayout(false);
            this.tbHome.ResumeLayout(false);
            this.tbHome.PerformLayout();
            this.tbWork.ResumeLayout(false);
            this.tbWork.PerformLayout();
            this.tbPostal.ResumeLayout(false);
            this.tbPostal.PerformLayout();
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
        internal StateTextBox HomeCountryValue;
        internal System.Windows.Forms.Label Country;
        internal StateTextBox HomeStateValue;
        internal System.Windows.Forms.Label StateLabel;
        internal StateTextBox HomeZipValue;
        internal System.Windows.Forms.Label ZipLabel;
        internal StateTextBox HomeCityValue;
        internal System.Windows.Forms.Label CityLabel;
        internal StateTextBox HomePOBoxValue;
        internal System.Windows.Forms.Label POBoxLabel;
        internal StateTextBox HomeAddressValue;
        internal System.Windows.Forms.Label AddressLabel;
        internal StateTextBox lastNameValue;
        internal System.Windows.Forms.Label label3;
        internal StateTextBox middleNameValue;
        internal System.Windows.Forms.Label label2;
        internal StateTextBox firstNameValue;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.TabControl tbcAddress;
        private System.Windows.Forms.TabPage tbHome;
        private System.Windows.Forms.TabPage tbWork;
        internal System.Windows.Forms.Label label9;
        internal StateTextBox WorkAddressValue;
        internal System.Windows.Forms.Label label8;
        internal StateTextBox WorkCountryValue;
        internal System.Windows.Forms.Label label5;
        internal StateTextBox WorkPOBoxValue;
        internal StateTextBox WorkZipValue;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label6;
        internal StateTextBox WorkCityValue;
        internal StateTextBox WorkStateValue;
        private System.Windows.Forms.TabPage tbPostal;
        internal System.Windows.Forms.Label label10;
        internal StateTextBox PostalAddressValue;
        internal System.Windows.Forms.Label label11;
        internal StateTextBox PostalCountryValue;
        internal System.Windows.Forms.Label label12;
        internal StateTextBox PostalPOBoxValue;
        internal StateTextBox PostalZipValue;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label15;
        internal StateTextBox PostalCityValue;
        internal StateTextBox PostalStateValue;
    }
}