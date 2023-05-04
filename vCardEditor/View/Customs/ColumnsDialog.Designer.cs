
namespace vCardEditor.View.Customs
{
    partial class ColumnsDialog
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
            this.cbFamilyName = new System.Windows.Forms.CheckBox();
            this.cbCellular = new System.Windows.Forms.CheckBox();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFamilyName
            // 
            this.cbFamilyName.AutoSize = true;
            this.cbFamilyName.Location = new System.Drawing.Point(12, 39);
            this.cbFamilyName.Name = "cbFamilyName";
            this.cbFamilyName.Size = new System.Drawing.Size(107, 21);
            this.cbFamilyName.TabIndex = 5;
            this.cbFamilyName.Text = "FamilyName";
            this.cbFamilyName.UseVisualStyleBackColor = true;
            // 
            // cbCellular
            // 
            this.cbCellular.AutoSize = true;
            this.cbCellular.Location = new System.Drawing.Point(12, 66);
            this.cbCellular.Name = "cbCellular";
            this.cbCellular.Size = new System.Drawing.Size(77, 21);
            this.cbCellular.TabIndex = 4;
            this.cbCellular.Text = "Cellular";
            this.cbCellular.UseVisualStyleBackColor = true;
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Checked = true;
            this.cbName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbName.Enabled = false;
            this.cbName.Location = new System.Drawing.Point(12, 12);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(67, 21);
            this.cbName.TabIndex = 3;
            this.cbName.Text = "Name";
            this.cbName.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(190, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(109, 119);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ColumnsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 149);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbFamilyName);
            this.Controls.Add(this.cbCellular);
            this.Controls.Add(this.cbName);
            this.Name = "ColumnsDialog";
            this.Text = "Columns...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbFamilyName;
        private System.Windows.Forms.CheckBox cbCellular;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}