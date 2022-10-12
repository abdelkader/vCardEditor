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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1145, 28);
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
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1145, 22);
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
            this.toolStrip1.Size = new System.Drawing.Size(1145, 27);
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
            this.openFileDialog.Filter = "vCard Files|*.vcf";
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
            this.CellularPhoneLabel.Text = "Mobile:";
            this.CellularPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkPhoneLabel
            // 
            this.WorkPhoneLabel.Location = new System.Drawing.Point(16, 91);
            this.WorkPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WorkPhoneLabel.Name = "WorkPhoneLabel";
            this.WorkPhoneLabel.Size = new System.Drawing.Size(60, 23);
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
            this.gbContactDetail.Location = new System.Drawing.Point(333, 64);
            this.gbContactDetail.Margin = new System.Windows.Forms.Padding(4);
            this.gbContactDetail.Name = "gbContactDetail";
            this.gbContactDetail.Padding = new System.Windows.Forms.Padding(4);
            this.gbContactDetail.Size = new System.Drawing.Size(796, 510);
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
            this.groupBox4.Location = new System.Drawing.Point(24, 190);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(764, 182);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Address:";
            // 
            // tbcAddress
            // 
            this.tbcAddress.Controls.Add(this.tbHome);
            this.tbcAddress.Controls.Add(this.tbWork);
            this.tbcAddress.Controls.Add(this.tbPostal);
            this.tbcAddress.Location = new System.Drawing.Point(17, 23);
            this.tbcAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbcAddress.Name = "tbcAddress";
            this.tbcAddress.SelectedIndex = 0;
            this.tbcAddress.Size = new System.Drawing.Size(739, 144);
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
            this.tbHome.Location = new System.Drawing.Point(4, 25);
            this.tbHome.Margin = new System.Windows.Forms.Padding(4);
            this.tbHome.Name = "tbHome";
            this.tbHome.Padding = new System.Windows.Forms.Padding(4);
            this.tbHome.Size = new System.Drawing.Size(731, 115);
            this.tbHome.TabIndex = 0;
            this.tbHome.Text = "Home";
            // 
            // AddressLabel
            // 
            this.AddressLabel.Location = new System.Drawing.Point(19, 16);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(65, 23);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "Address:";
            this.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HomeAddressValue
            // 
            this.HomeAddressValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeAddressValue.Location = new System.Drawing.Point(92, 15);
            this.HomeAddressValue.Margin = new System.Windows.Forms.Padding(4);
            this.HomeAddressValue.Name = "HomeAddressValue";
            this.HomeAddressValue.oldText = "";
            this.HomeAddressValue.Size = new System.Drawing.Size(613, 22);
            this.HomeAddressValue.TabIndex = 5;
            // 
            // POBoxLabel
            // 
            this.POBoxLabel.Location = new System.Drawing.Point(19, 46);
            this.POBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.POBoxLabel.Name = "POBoxLabel";
            this.POBoxLabel.Size = new System.Drawing.Size(65, 23);
            this.POBoxLabel.TabIndex = 6;
            this.POBoxLabel.Text = "PO Box:";
            this.POBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HomeCountryValue
            // 
            this.HomeCountryValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeCountryValue.Location = new System.Drawing.Point(399, 79);
            this.HomeCountryValue.Margin = new System.Windows.Forms.Padding(4);
            this.HomeCountryValue.Name = "HomeCountryValue";
            this.HomeCountryValue.oldText = null;
            this.HomeCountryValue.Size = new System.Drawing.Size(307, 22);
            this.HomeCountryValue.TabIndex = 15;
            // 
            // HomePOBoxValue
            // 
            this.HomePOBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomePOBoxValue.Location = new System.Drawing.Point(92, 44);
            this.HomePOBoxValue.Margin = new System.Windows.Forms.Padding(4);
            this.HomePOBoxValue.Name = "HomePOBoxValue";
            this.HomePOBoxValue.oldText = null;
            this.HomePOBoxValue.Size = new System.Drawing.Size(236, 22);
            this.HomePOBoxValue.TabIndex = 7;
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(337, 80);
            this.Country.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(65, 23);
            this.Country.TabIndex = 14;
            this.Country.Text = "Country:";
            this.Country.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CityLabel
            // 
            this.CityLabel.Location = new System.Drawing.Point(337, 48);
            this.CityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(43, 23);
            this.CityLabel.TabIndex = 8;
            this.CityLabel.Text = "City:";
            this.CityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HomeStateValue
            // 
            this.HomeStateValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeStateValue.Location = new System.Drawing.Point(92, 76);
            this.HomeStateValue.Margin = new System.Windows.Forms.Padding(4);
            this.HomeStateValue.Name = "HomeStateValue";
            this.HomeStateValue.oldText = null;
            this.HomeStateValue.Size = new System.Drawing.Size(236, 22);
            this.HomeStateValue.TabIndex = 13;
            // 
            // HomeCityValue
            // 
            this.HomeCityValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeCityValue.Location = new System.Drawing.Point(399, 46);
            this.HomeCityValue.Margin = new System.Windows.Forms.Padding(4);
            this.HomeCityValue.Name = "HomeCityValue";
            this.HomeCityValue.oldText = null;
            this.HomeCityValue.Size = new System.Drawing.Size(127, 22);
            this.HomeCityValue.TabIndex = 9;
            // 
            // StateLabel
            // 
            this.StateLabel.Location = new System.Drawing.Point(19, 69);
            this.StateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(61, 23);
            this.StateLabel.TabIndex = 12;
            this.StateLabel.Text = "State:";
            this.StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ZipLabel
            // 
            this.ZipLabel.Location = new System.Drawing.Point(535, 46);
            this.ZipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(37, 23);
            this.ZipLabel.TabIndex = 10;
            this.ZipLabel.Text = "Zip:";
            this.ZipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HomeZipValue
            // 
            this.HomeZipValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeZipValue.Location = new System.Drawing.Point(581, 47);
            this.HomeZipValue.Margin = new System.Windows.Forms.Padding(4);
            this.HomeZipValue.Name = "HomeZipValue";
            this.HomeZipValue.oldText = null;
            this.HomeZipValue.Size = new System.Drawing.Size(124, 22);
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
            this.tbWork.Location = new System.Drawing.Point(4, 25);
            this.tbWork.Margin = new System.Windows.Forms.Padding(4);
            this.tbWork.Name = "tbWork";
            this.tbWork.Padding = new System.Windows.Forms.Padding(4);
            this.tbWork.Size = new System.Drawing.Size(731, 115);
            this.tbWork.TabIndex = 1;
            this.tbWork.Text = "Work";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(20, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Address:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkAddressValue
            // 
            this.WorkAddressValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkAddressValue.Location = new System.Drawing.Point(89, 11);
            this.WorkAddressValue.Margin = new System.Windows.Forms.Padding(4);
            this.WorkAddressValue.Name = "WorkAddressValue";
            this.WorkAddressValue.oldText = "";
            this.WorkAddressValue.Size = new System.Drawing.Size(617, 22);
            this.WorkAddressValue.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "PO Box:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkCountryValue
            // 
            this.WorkCountryValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkCountryValue.Location = new System.Drawing.Point(400, 75);
            this.WorkCountryValue.Margin = new System.Windows.Forms.Padding(4);
            this.WorkCountryValue.Name = "WorkCountryValue";
            this.WorkCountryValue.oldText = null;
            this.WorkCountryValue.Size = new System.Drawing.Size(307, 22);
            this.WorkCountryValue.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "State:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkPOBoxValue
            // 
            this.WorkPOBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkPOBoxValue.Location = new System.Drawing.Point(89, 41);
            this.WorkPOBoxValue.Margin = new System.Windows.Forms.Padding(4);
            this.WorkPOBoxValue.Name = "WorkPOBoxValue";
            this.WorkPOBoxValue.oldText = null;
            this.WorkPOBoxValue.Size = new System.Drawing.Size(236, 22);
            this.WorkPOBoxValue.TabIndex = 19;
            // 
            // WorkZipValue
            // 
            this.WorkZipValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkZipValue.Location = new System.Drawing.Point(583, 43);
            this.WorkZipValue.Margin = new System.Windows.Forms.Padding(4);
            this.WorkZipValue.Name = "WorkZipValue";
            this.WorkZipValue.oldText = null;
            this.WorkZipValue.Size = new System.Drawing.Size(124, 22);
            this.WorkZipValue.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(339, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "Country:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(536, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Zip:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(339, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "City:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkCityValue
            // 
            this.WorkCityValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkCityValue.Location = new System.Drawing.Point(400, 42);
            this.WorkCityValue.Margin = new System.Windows.Forms.Padding(4);
            this.WorkCityValue.Name = "WorkCityValue";
            this.WorkCityValue.oldText = null;
            this.WorkCityValue.Size = new System.Drawing.Size(127, 22);
            this.WorkCityValue.TabIndex = 21;
            // 
            // WorkStateValue
            // 
            this.WorkStateValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkStateValue.Location = new System.Drawing.Point(89, 73);
            this.WorkStateValue.Margin = new System.Windows.Forms.Padding(4);
            this.WorkStateValue.Name = "WorkStateValue";
            this.WorkStateValue.oldText = null;
            this.WorkStateValue.Size = new System.Drawing.Size(240, 22);
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
            this.tbPostal.Location = new System.Drawing.Point(4, 25);
            this.tbPostal.Margin = new System.Windows.Forms.Padding(4);
            this.tbPostal.Name = "tbPostal";
            this.tbPostal.Size = new System.Drawing.Size(731, 115);
            this.tbPostal.TabIndex = 2;
            this.tbPostal.Text = "Postal";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(20, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Address:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PostalAddressValue
            // 
            this.PostalAddressValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostalAddressValue.Location = new System.Drawing.Point(89, 11);
            this.PostalAddressValue.Margin = new System.Windows.Forms.Padding(4);
            this.PostalAddressValue.Name = "PostalAddressValue";
            this.PostalAddressValue.oldText = "";
            this.PostalAddressValue.Size = new System.Drawing.Size(617, 22);
            this.PostalAddressValue.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(20, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 23);
            this.label11.TabIndex = 18;
            this.label11.Text = "PO Box:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PostalCountryValue
            // 
            this.PostalCountryValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostalCountryValue.Location = new System.Drawing.Point(400, 75);
            this.PostalCountryValue.Margin = new System.Windows.Forms.Padding(4);
            this.PostalCountryValue.Name = "PostalCountryValue";
            this.PostalCountryValue.oldText = null;
            this.PostalCountryValue.Size = new System.Drawing.Size(307, 22);
            this.PostalCountryValue.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(20, 65);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "State:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PostalPOBoxValue
            // 
            this.PostalPOBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostalPOBoxValue.Location = new System.Drawing.Point(89, 41);
            this.PostalPOBoxValue.Margin = new System.Windows.Forms.Padding(4);
            this.PostalPOBoxValue.Name = "PostalPOBoxValue";
            this.PostalPOBoxValue.oldText = null;
            this.PostalPOBoxValue.Size = new System.Drawing.Size(240, 22);
            this.PostalPOBoxValue.TabIndex = 19;
            // 
            // PostalZipValue
            // 
            this.PostalZipValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostalZipValue.Location = new System.Drawing.Point(583, 43);
            this.PostalZipValue.Margin = new System.Windows.Forms.Padding(4);
            this.PostalZipValue.Name = "PostalZipValue";
            this.PostalZipValue.oldText = null;
            this.PostalZipValue.Size = new System.Drawing.Size(124, 22);
            this.PostalZipValue.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(339, 76);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 23);
            this.label13.TabIndex = 26;
            this.label13.Text = "Country:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(536, 42);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 23);
            this.label14.TabIndex = 22;
            this.label14.Text = "Zip:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(339, 44);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 23);
            this.label15.TabIndex = 20;
            this.label15.Text = "City:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PostalCityValue
            // 
            this.PostalCityValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostalCityValue.Location = new System.Drawing.Point(400, 42);
            this.PostalCityValue.Margin = new System.Windows.Forms.Padding(4);
            this.PostalCityValue.Name = "PostalCityValue";
            this.PostalCityValue.oldText = null;
            this.PostalCityValue.Size = new System.Drawing.Size(127, 22);
            this.PostalCityValue.TabIndex = 21;
            // 
            // PostalStateValue
            // 
            this.PostalStateValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostalStateValue.Location = new System.Drawing.Point(89, 73);
            this.PostalStateValue.Margin = new System.Windows.Forms.Padding(4);
            this.PostalStateValue.Name = "PostalStateValue";
            this.PostalStateValue.oldText = null;
            this.PostalStateValue.Size = new System.Drawing.Size(240, 22);
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
            this.groupBox3.Location = new System.Drawing.Point(24, 41);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(571, 142);
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
            this.FormattedTitleValue.TabIndex = 3;
            this.FormattedTitleValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.FormattedTitleValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // FormattedTitleLabel
            // 
            this.FormattedTitleLabel.Location = new System.Drawing.Point(-4, 20);
            this.FormattedTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormattedTitleLabel.Name = "FormattedTitleLabel";
            this.FormattedTitleLabel.Size = new System.Drawing.Size(52, 23);
            this.FormattedTitleLabel.TabIndex = 2;
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
            this.lastNameValue.TabIndex = 1;
            this.lastNameValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.lastNameValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(341, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 0;
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
            this.middleNameValue.TabIndex = 1;
            this.middleNameValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.middleNameValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(151, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 0;
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
            this.firstNameValue.TabIndex = 1;
            this.firstNameValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.firstNameValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 0;
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
            this.FormattedNameValue.TabIndex = 1;
            this.FormattedNameValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.FormattedNameValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // FormattedNameLabel
            // 
            this.FormattedNameLabel.Location = new System.Drawing.Point(148, 21);
            this.FormattedNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormattedNameLabel.Name = "FormattedNameLabel";
            this.FormattedNameLabel.Size = new System.Drawing.Size(81, 23);
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
            this.groupBox2.Location = new System.Drawing.Point(348, 373);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(440, 129);
            this.groupBox2.TabIndex = 2;
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
            this.groupBox1.Location = new System.Drawing.Point(29, 373);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(377, 129);
            this.groupBox1.TabIndex = 1;
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
            this.PhotoBox.Image = ((System.Drawing.Image)(resources.GetObject("PhotoBox.Image")));
            this.PhotoBox.Location = new System.Drawing.Point(603, 23);
            this.PhotoBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(185, 159);
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
            this.gbNameList.Location = new System.Drawing.Point(17, 64);
            this.gbNameList.Margin = new System.Windows.Forms.Padding(4);
            this.gbNameList.Name = "gbNameList";
            this.gbNameList.Padding = new System.Windows.Forms.Padding(4);
            this.gbNameList.Size = new System.Drawing.Size(308, 510);
            this.gbNameList.TabIndex = 2;
            this.gbNameList.TabStop = false;
            this.gbNameList.Text = "Name List :";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFilter.Image")));
            this.btnClearFilter.Location = new System.Drawing.Point(268, 17);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(37, 27);
            this.btnClearFilter.TabIndex = 1;
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(4, 18);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(256, 22);
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
            this.dgContacts.Location = new System.Drawing.Point(4, 50);
            this.dgContacts.Margin = new System.Windows.Forms.Padding(4);
            this.dgContacts.MultiSelect = false;
            this.dgContacts.Name = "dgContacts";
            this.dgContacts.RowHeadersVisible = false;
            this.dgContacts.RowHeadersWidth = 51;
            this.dgContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgContacts.Size = new System.Drawing.Size(300, 455);
            this.dgContacts.TabIndex = 2;
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
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 604);
            this.Controls.Add(this.gbNameList);
            this.Controls.Add(this.gbContactDetail);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripButton tbsNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    }
}