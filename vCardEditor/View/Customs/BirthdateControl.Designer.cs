namespace vCardEditor.View.Customs
{
    partial class BirthdateControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblBirtdate = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(70, 3);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(157, 20);
            this.dtpBirthdate.TabIndex = 12;
            this.dtpBirthdate.ValueChanged += new System.EventHandler(this.dtpBirthdate_ValueChanged);
            // 
            // lblBirtdate
            // 
            this.lblBirtdate.Location = new System.Drawing.Point(3, 4);
            this.lblBirtdate.Name = "lblBirtdate";
            this.lblBirtdate.Size = new System.Drawing.Size(61, 19);
            this.lblBirtdate.TabIndex = 11;
            this.lblBirtdate.Text = "Birthdate:";
            this.lblBirtdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Image = global::vCardEditor.Properties.Resources.Add;
            this.btnSwitch.Location = new System.Drawing.Point(233, 4);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(29, 18);
            this.btnSwitch.TabIndex = 13;
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // BirthdateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.lblBirtdate);
            this.Name = "BirthdateControl";
            this.Size = new System.Drawing.Size(266, 27);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        internal System.Windows.Forms.Label lblBirtdate;
        private System.Windows.Forms.Button btnSwitch;
    }
}
