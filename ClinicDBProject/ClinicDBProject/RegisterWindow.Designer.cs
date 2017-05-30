namespace ClinicDBProject
{
    partial class RegisterWindow
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
            this.backButton = new System.Windows.Forms.Button();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.editPatientButton = new System.Windows.Forms.Button();
            this.deletePatientButton = new System.Windows.Forms.Button();
            this.patientsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.patientsView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Mistral", 15F);
            this.backButton.Location = new System.Drawing.Point(16, 14);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(167, 74);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addPatientButton
            // 
            this.addPatientButton.Font = new System.Drawing.Font("Mistral", 15F);
            this.addPatientButton.Location = new System.Drawing.Point(16, 92);
            this.addPatientButton.Margin = new System.Windows.Forms.Padding(4);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(167, 74);
            this.addPatientButton.TabIndex = 2;
            this.addPatientButton.Text = "Додати нового пацієнта";
            this.addPatientButton.UseVisualStyleBackColor = true;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // editPatientButton
            // 
            this.editPatientButton.Font = new System.Drawing.Font("Mistral", 15F);
            this.editPatientButton.Location = new System.Drawing.Point(16, 174);
            this.editPatientButton.Margin = new System.Windows.Forms.Padding(4);
            this.editPatientButton.Name = "editPatientButton";
            this.editPatientButton.Size = new System.Drawing.Size(167, 74);
            this.editPatientButton.TabIndex = 4;
            this.editPatientButton.Text = "Редагувати данні";
            this.editPatientButton.UseVisualStyleBackColor = true;
            this.editPatientButton.Click += new System.EventHandler(this.editPatientButton_Click);
            // 
            // deletePatientButton
            // 
            this.deletePatientButton.Font = new System.Drawing.Font("Mistral", 15F);
            this.deletePatientButton.Location = new System.Drawing.Point(16, 255);
            this.deletePatientButton.Margin = new System.Windows.Forms.Padding(4);
            this.deletePatientButton.Name = "deletePatientButton";
            this.deletePatientButton.Size = new System.Drawing.Size(167, 74);
            this.deletePatientButton.TabIndex = 3;
            this.deletePatientButton.Text = "Видалити пацієнта";
            this.deletePatientButton.UseVisualStyleBackColor = true;
            this.deletePatientButton.Click += new System.EventHandler(this.deletePatientButton_Click);
            // 
            // patientsView
            // 
            this.patientsView.AllowUserToAddRows = false;
            this.patientsView.AllowUserToDeleteRows = false;
            this.patientsView.AllowUserToResizeRows = false;
            this.patientsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.patientsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsView.Location = new System.Drawing.Point(189, 14);
            this.patientsView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientsView.Name = "patientsView";
            this.patientsView.ReadOnly = true;
            this.patientsView.RowTemplate.Height = 24;
            this.patientsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientsView.Size = new System.Drawing.Size(699, 315);
            this.patientsView.TabIndex = 5;
            // 
            // RegisterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 339);
            this.Controls.Add(this.patientsView);
            this.Controls.Add(this.editPatientButton);
            this.Controls.Add(this.deletePatientButton);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "RegisterWindow";
            this.Text = "Реєстрація пацієнтів";
            ((System.ComponentModel.ISupportInitialize)(this.patientsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button editPatientButton;
        private System.Windows.Forms.Button deletePatientButton;
        private System.Windows.Forms.DataGridView patientsView;
    }
}