namespace ClinicDBProject
{
    partial class DiagnosWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.patientLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.drugComboBox = new System.Windows.Forms.ComboBox();
            this.analysisComboBox = new System.Windows.Forms.ComboBox();
            this.diagnosTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "У пацієнта ";
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientLabel.Location = new System.Drawing.Point(137, 32);
            this.patientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(0, 33);
            this.patientLabel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(145, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "діагонстовано";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ліки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(323, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Аналізи";
            // 
            // drugComboBox
            // 
            this.drugComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drugComboBox.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drugComboBox.FormattingEnabled = true;
            this.drugComboBox.Location = new System.Drawing.Point(23, 347);
            this.drugComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drugComboBox.Name = "drugComboBox";
            this.drugComboBox.Size = new System.Drawing.Size(185, 35);
            this.drugComboBox.TabIndex = 5;
            // 
            // analysisComboBox
            // 
            this.analysisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.analysisComboBox.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.analysisComboBox.FormattingEnabled = true;
            this.analysisComboBox.Location = new System.Drawing.Point(329, 347);
            this.analysisComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.analysisComboBox.Name = "analysisComboBox";
            this.analysisComboBox.Size = new System.Drawing.Size(185, 35);
            this.analysisComboBox.TabIndex = 6;
            // 
            // diagnosTextBox
            // 
            this.diagnosTextBox.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diagnosTextBox.Location = new System.Drawing.Point(23, 69);
            this.diagnosTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diagnosTextBox.Multiline = true;
            this.diagnosTextBox.Name = "diagnosTextBox";
            this.diagnosTextBox.Size = new System.Drawing.Size(491, 237);
            this.diagnosTextBox.TabIndex = 7;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(329, 404);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(185, 53);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "Зберегти";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(23, 404);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(185, 53);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // DiagnosWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 471);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.diagnosTextBox);
            this.Controls.Add(this.analysisComboBox);
            this.Controls.Add(this.drugComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patientLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "DiagnosWindow";
            this.Text = "Діагностування";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox drugComboBox;
        private System.Windows.Forms.ComboBox analysisComboBox;
        private System.Windows.Forms.TextBox diagnosTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button backButton;
    }
}