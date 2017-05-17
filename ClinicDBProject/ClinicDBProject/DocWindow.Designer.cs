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
            this.doctorNameLabel.Location = new System.Drawing.Point(28, 15);
            this.doctorNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(70, 35);
            this.doctorNameLabel.TabIndex = 0;
            this.doctorNameLabel.Text = "label1";
            // 
            // doctorSurnameLabel
            // 
            this.doctorSurnameLabel.AutoSize = true;
            this.doctorSurnameLabel.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorSurnameLabel.Location = new System.Drawing.Point(28, 43);
            this.doctorSurnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doctorSurnameLabel.Name = "doctorSurnameLabel";
            this.doctorSurnameLabel.Size = new System.Drawing.Size(70, 35);
            this.doctorSurnameLabel.TabIndex = 1;
            this.doctorSurnameLabel.Text = "label2";
            // 
            // doctorSpecializationLabel
            // 
            this.doctorSpecializationLabel.AutoSize = true;
            this.doctorSpecializationLabel.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorSpecializationLabel.Location = new System.Drawing.Point(99, 28);
            this.doctorSpecializationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doctorSpecializationLabel.Name = "doctorSpecializationLabel";
            this.doctorSpecializationLabel.Size = new System.Drawing.Size(70, 35);
            this.doctorSpecializationLabel.TabIndex = 2;
            this.doctorSpecializationLabel.Text = "label3";
            // 
            // patientsComboBox
            // 
            this.patientsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientsComboBox.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientsComboBox.FormattingEnabled = true;
            this.patientsComboBox.Location = new System.Drawing.Point(233, 43);
            this.patientsComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientsComboBox.Name = "patientsComboBox";
            this.patientsComboBox.Size = new System.Drawing.Size(250, 35);
            this.patientsComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Виберіть пацієнта";
            // 
            // DocWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientsComboBox);
            this.Controls.Add(this.doctorSpecializationLabel);
            this.Controls.Add(this.doctorSurnameLabel);
            this.Controls.Add(this.doctorNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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