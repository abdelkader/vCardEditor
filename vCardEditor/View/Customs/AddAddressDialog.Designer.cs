
namespace vCardEditor.View.Customs
{
    partial class AddAddressDialog
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
            this.cbHome = new System.Windows.Forms.CheckBox();
            this.cbWork = new System.Windows.Forms.CheckBox();
            this.cbPostal = new System.Windows.Forms.CheckBox();
            this.cbDomestic = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbInternational = new System.Windows.Forms.CheckBox();
            this.cbCustom = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbHome
            // 
            this.cbHome.AutoSize = true;
            this.cbHome.Location = new System.Drawing.Point(12, 12);
            this.cbHome.Name = "cbHome";
            this.cbHome.Size = new System.Drawing.Size(67, 21);
            this.cbHome.TabIndex = 0;
            this.cbHome.Text = "Home";
            this.cbHome.UseVisualStyleBackColor = true;
            // 
            // cbWork
            // 
            this.cbWork.AutoSize = true;
            this.cbWork.Location = new System.Drawing.Point(12, 40);
            this.cbWork.Name = "cbWork";
            this.cbWork.Size = new System.Drawing.Size(63, 21);
            this.cbWork.TabIndex = 1;
            this.cbWork.Text = "Work";
            this.cbWork.UseVisualStyleBackColor = true;
            // 
            // cbPostal
            // 
            this.cbPostal.AutoSize = true;
            this.cbPostal.Location = new System.Drawing.Point(12, 67);
            this.cbPostal.Name = "cbPostal";
            this.cbPostal.Size = new System.Drawing.Size(69, 21);
            this.cbPostal.TabIndex = 2;
            this.cbPostal.Text = "Postal";
            this.cbPostal.UseVisualStyleBackColor = true;
            // 
            // cbDomestic
            // 
            this.cbDomestic.AutoSize = true;
            this.cbDomestic.Location = new System.Drawing.Point(12, 94);
            this.cbDomestic.Name = "cbDomestic";
            this.cbDomestic.Size = new System.Drawing.Size(88, 21);
            this.cbDomestic.TabIndex = 3;
            this.cbDomestic.Text = "Domestic";
            this.cbDomestic.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(95, 187);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(176, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbInternational
            // 
            this.cbInternational.AutoSize = true;
            this.cbInternational.Location = new System.Drawing.Point(12, 121);
            this.cbInternational.Name = "cbInternational";
            this.cbInternational.Size = new System.Drawing.Size(108, 21);
            this.cbInternational.TabIndex = 9;
            this.cbInternational.Text = "International";
            this.cbInternational.UseVisualStyleBackColor = true;
            // 
            // cbCustom
            // 
            this.cbCustom.AutoSize = true;
            this.cbCustom.Location = new System.Drawing.Point(12, 148);
            this.cbCustom.Name = "cbCustom";
            this.cbCustom.Size = new System.Drawing.Size(81, 21);
            this.cbCustom.TabIndex = 10;
            this.cbCustom.Text = "Custom:";
            this.cbCustom.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 11;
            // 
            // AddAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 223);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbCustom);
            this.Controls.Add(this.cbInternational);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbDomestic);
            this.Controls.Add(this.cbPostal);
            this.Controls.Add(this.cbWork);
            this.Controls.Add(this.cbHome);
            this.Name = "AddAddress";
            this.Text = "Address Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbHome;
        private System.Windows.Forms.CheckBox cbWork;
        private System.Windows.Forms.CheckBox cbPostal;
        private System.Windows.Forms.CheckBox cbDomestic;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbInternational;
        private System.Windows.Forms.CheckBox cbCustom;
        private System.Windows.Forms.TextBox textBox1;
    }
}