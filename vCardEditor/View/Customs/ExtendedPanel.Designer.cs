
namespace vCardEditor.View.Customs
{
    partial class ExtendedPanel
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbExtended = new System.Windows.Forms.GroupBox();
            this.btnAddExtraText = new System.Windows.Forms.Button();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.menuPhone = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miCell = new System.Windows.Forms.ToolStripMenuItem();
            this.miHome = new System.Windows.Forms.ToolStripMenuItem();
            this.miWork = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWeb = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.miWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.gbExtended.SuspendLayout();
            this.menuPhone.SuspendLayout();
            this.menuWeb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbExtended
            // 
            this.gbExtended.Controls.Add(this.btnAddExtraText);
            this.gbExtended.Controls.Add(this.PanelContent);
            this.gbExtended.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbExtended.Location = new System.Drawing.Point(0, 0);
            this.gbExtended.Margin = new System.Windows.Forms.Padding(4);
            this.gbExtended.Name = "gbExtended";
            this.gbExtended.Padding = new System.Windows.Forms.Padding(4);
            this.gbExtended.Size = new System.Drawing.Size(367, 155);
            this.gbExtended.TabIndex = 3;
            this.gbExtended.TabStop = false;
            // 
            // btnAddExtraText
            // 
            this.btnAddExtraText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddExtraText.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddExtraText.Image = global::vCardEditor.Properties.Resources.Add;
            this.btnAddExtraText.Location = new System.Drawing.Point(316, -3);
            this.btnAddExtraText.Name = "btnAddExtraText";
            this.btnAddExtraText.Size = new System.Drawing.Size(39, 23);
            this.btnAddExtraText.TabIndex = 58;
            this.btnAddExtraText.UseVisualStyleBackColor = true;
            this.btnAddExtraText.Click += new System.EventHandler(this.btnAddExtraText_Click);
            // 
            // PanelContent
            // 
            this.PanelContent.AutoScroll = true;
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(4, 19);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(359, 132);
            this.PanelContent.TabIndex = 0;
            // 
            // menuPhone
            // 
            this.menuPhone.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPhone.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCell,
            this.miHome,
            this.miWork});
            this.menuPhone.Name = "contextMenuStrip1";
            this.menuPhone.Size = new System.Drawing.Size(120, 76);
            // 
            // miCell
            // 
            this.miCell.Name = "miCell";
            this.miCell.Size = new System.Drawing.Size(119, 24);
            this.miCell.Text = "Cell";
            // 
            // miHome
            // 
            this.miHome.Name = "miHome";
            this.miHome.Size = new System.Drawing.Size(119, 24);
            this.miHome.Text = "Home";
            // 
            // miWork
            // 
            this.miWork.Name = "miWork";
            this.miWork.Size = new System.Drawing.Size(119, 24);
            this.miWork.Text = "Work";
            // 
            // menuWeb
            // 
            this.menuWeb.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuWeb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEmail,
            this.miWeb});
            this.menuWeb.Name = "contextMenuStrip1";
            this.menuWeb.Size = new System.Drawing.Size(211, 80);
            // 
            // miEmail
            // 
            this.miEmail.Name = "miEmail";
            this.miEmail.Size = new System.Drawing.Size(210, 24);
            this.miEmail.Text = "Email";
            // 
            // miWeb
            // 
            this.miWeb.Name = "miWeb";
            this.miWeb.Size = new System.Drawing.Size(210, 24);
            this.miWeb.Text = "Web";
            // 
            // ExtendedPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbExtended);
            this.Name = "ExtendedPanel";
            this.Size = new System.Drawing.Size(367, 155);
            this.gbExtended.ResumeLayout(false);
            this.menuPhone.ResumeLayout(false);
            this.menuWeb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbExtended;
        private System.Windows.Forms.Button btnAddExtraText;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.ContextMenuStrip menuPhone;
        private System.Windows.Forms.ToolStripMenuItem miCell;
        private System.Windows.Forms.ToolStripMenuItem miHome;
        private System.Windows.Forms.ToolStripMenuItem miWork;
        private System.Windows.Forms.ContextMenuStrip menuWeb;
        private System.Windows.Forms.ToolStripMenuItem miEmail;
        private System.Windows.Forms.ToolStripMenuItem miWeb;
    }
}
