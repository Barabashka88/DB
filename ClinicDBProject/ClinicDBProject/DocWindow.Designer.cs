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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.doctorSurnameLabel = new System.Windows.Forms.Label();
            this.doctorSpecializationLabel = new System.Windows.Forms.Label();
            this.patientsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.appointmentsView = new System.Windows.Forms.DataGridView();
            this.addDescriptionButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.diagnosButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsView)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.AutoSize = true;
            this.doctorNameLabel.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorNameLabel.Location = new System.Drawing.Point(25, 18);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(89, 46);
            this.doctorNameLabel.TabIndex = 0;
            this.doctorNameLabel.Text = "label1";
            // 
            // doctorSurnameLabel
            // 
            this.doctorSurnameLabel.AutoSize = true;
            this.doctorSurnameLabel.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorSurnameLabel.Location = new System.Drawing.Point(120, 18);
            this.doctorSurnameLabel.Name = "doctorSurnameLabel";
            this.doctorSurnameLabel.Size = new System.Drawing.Size(89, 46);
            this.doctorSurnameLabel.TabIndex = 1;
            this.doctorSurnameLabel.Text = "label2";
            // 
            // doctorSpecializationLabel
            // 
            this.doctorSpecializationLabel.AutoSize = true;
            this.doctorSpecializationLabel.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorSpecializationLabel.Location = new System.Drawing.Point(68, 59);
            this.doctorSpecializationLabel.Name = "doctorSpecializationLabel";
            this.doctorSpecializationLabel.Size = new System.Drawing.Size(89, 46);
            this.doctorSpecializationLabel.TabIndex = 2;
            this.doctorSpecializationLabel.Text = "label3";
            // 
            // patientsComboBox
            // 
            this.patientsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientsComboBox.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientsComboBox.FormattingEnabled = true;
            this.patientsComboBox.Location = new System.Drawing.Point(329, 64);
            this.patientsComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientsComboBox.Name = "patientsComboBox";
            this.patientsComboBox.Size = new System.Drawing.Size(360, 41);
            this.patientsComboBox.TabIndex = 3;
            this.patientsComboBox.SelectedValueChanged += new System.EventHandler(this.patientsComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(323, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Виберіть пацієнта";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.Location = new System.Drawing.Point(516, 383);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(173, 66);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Підтвердити";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(12, 383);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(173, 66);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // appointmentsView
            // 
            this.appointmentsView.AllowUserToAddRows = false;
            this.appointmentsView.AllowUserToDeleteRows = false;
            this.appointmentsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.appointmentsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.appointmentsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appointmentsView.DefaultCellStyle = dataGridViewCellStyle1;
            this.appointmentsView.Location = new System.Drawing.Point(12, 132);
            this.appointmentsView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentsView.Name = "appointmentsView";
            this.appointmentsView.ReadOnly = true;
            this.appointmentsView.RowTemplate.Height = 24;
            this.appointmentsView.Size = new System.Drawing.Size(401, 174);
            this.appointmentsView.TabIndex = 7;
            this.appointmentsView.Visible = false;
            // 
            // addDescriptionButton
            // 
            this.addDescriptionButton.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDescriptionButton.Location = new System.Drawing.Point(419, 245);
            this.addDescriptionButton.Name = "addDescriptionButton";
            this.addDescriptionButton.Size = new System.Drawing.Size(270, 61);
            this.addDescriptionButton.TabIndex = 8;
            this.addDescriptionButton.Text = "Додати опис прийому";
            this.addDescriptionButton.UseVisualStyleBackColor = true;
            this.addDescriptionButton.Visible = false;
            this.addDescriptionButton.Click += new System.EventHandler(this.addDescriptionButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(419, 132);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(270, 107);
            this.descriptionTextBox.TabIndex = 9;
            this.descriptionTextBox.Visible = false;
            // 
            // diagnosButton
            // 
            this.diagnosButton.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosButton.Location = new System.Drawing.Point(228, 312);
            this.diagnosButton.Name = "diagnosButton";
            this.diagnosButton.Size = new System.Drawing.Size(263, 66);
            this.diagnosButton.TabIndex = 10;
            this.diagnosButton.Text = "Діагноз та лікування";
            this.diagnosButton.UseVisualStyleBackColor = true;
            this.diagnosButton.Visible = false;
            this.diagnosButton.Click += new System.EventHandler(this.diagnosButton_Click);
            // 
            // DocWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 460);
            this.Controls.Add(this.diagnosButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.addDescriptionButton);
            this.Controls.Add(this.appointmentsView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientsComboBox);
            this.Controls.Add(this.doctorSpecializationLabel);
            this.Controls.Add(this.doctorSurnameLabel);
            this.Controls.Add(this.doctorNameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DocWindow";
            this.Text = "DocWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DocWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label doctorNameLabel;
        private System.Windows.Forms.Label doctorSurnameLabel;
        private System.Windows.Forms.Label doctorSpecializationLabel;
        private System.Windows.Forms.ComboBox patientsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView appointmentsView;
        private System.Windows.Forms.Button addDescriptionButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button diagnosButton;
    }
}