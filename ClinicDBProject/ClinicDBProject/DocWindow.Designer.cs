namespace ClinicDBProject
{
    partial class DocWindow
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
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.doctorSurnameLabel = new System.Windows.Forms.Label();
            this.doctorSpecializationLabel = new System.Windows.Forms.Label();
            this.patientsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.AutoSize = true;
            this.doctorNameLabel.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorNameLabel.Location = new System.Drawing.Point(37, 18);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(89, 46);
            this.doctorNameLabel.TabIndex = 0;
            this.doctorNameLabel.Text = "label1";
            // 
            // doctorSurnameLabel
            // 
            this.doctorSurnameLabel.AutoSize = true;
            this.doctorSurnameLabel.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorSurnameLabel.Location = new System.Drawing.Point(37, 53);
            this.doctorSurnameLabel.Name = "doctorSurnameLabel";
            this.doctorSurnameLabel.Size = new System.Drawing.Size(89, 46);
            this.doctorSurnameLabel.TabIndex = 1;
            this.doctorSurnameLabel.Text = "label2";
            // 
            // doctorSpecializationLabel
            // 
            this.doctorSpecializationLabel.AutoSize = true;
            this.doctorSpecializationLabel.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorSpecializationLabel.Location = new System.Drawing.Point(132, 34);
            this.doctorSpecializationLabel.Name = "doctorSpecializationLabel";
            this.doctorSpecializationLabel.Size = new System.Drawing.Size(89, 46);
            this.doctorSpecializationLabel.TabIndex = 2;
            this.doctorSpecializationLabel.Text = "label3";
            // 
            // patientsComboBox
            // 
            this.patientsComboBox.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientsComboBox.FormattingEnabled = true;
            this.patientsComboBox.Location = new System.Drawing.Point(311, 53);
            this.patientsComboBox.Name = "patientsComboBox";
            this.patientsComboBox.Size = new System.Drawing.Size(149, 41);
            this.patientsComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Виберіть пацієнта";
            // 
            // DocWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientsComboBox);
            this.Controls.Add(this.doctorSpecializationLabel);
            this.Controls.Add(this.doctorSurnameLabel);
            this.Controls.Add(this.doctorNameLabel);
            this.Name = "DocWindow";
            this.Text = "DocWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label doctorNameLabel;
        private System.Windows.Forms.Label doctorSurnameLabel;
        private System.Windows.Forms.Label doctorSpecializationLabel;
        private System.Windows.Forms.ComboBox patientsComboBox;
        private System.Windows.Forms.Label label1;
    }
}