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
            this.patientsView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.editPatientButton = new System.Windows.Forms.Button();
            this.deletePatientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientsView)).BeginInit();
            this.SuspendLayout();
            // 
            // patientsView
            // 
            this.patientsView.AllowUserToAddRows = false;
            this.patientsView.AllowUserToDeleteRows = false;
            this.patientsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsView.Location = new System.Drawing.Point(142, 11);
            this.patientsView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientsView.Name = "patientsView";
            this.patientsView.ReadOnly = true;
            this.patientsView.RowTemplate.Height = 24;
            this.patientsView.Size = new System.Drawing.Size(394, 256);
            this.patientsView.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Mistral", 15F);
            this.backButton.Location = new System.Drawing.Point(12, 11);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 60);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addPatientButton
            // 
            this.addPatientButton.Font = new System.Drawing.Font("Mistral", 15F);
            this.addPatientButton.Location = new System.Drawing.Point(12, 75);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(125, 60);
            this.addPatientButton.TabIndex = 2;
            this.addPatientButton.Text = "Додати нового пацієнта";
            this.addPatientButton.UseVisualStyleBackColor = true;
            // 
            // editPatientButton
            // 
            this.editPatientButton.Font = new System.Drawing.Font("Mistral", 15F);
            this.editPatientButton.Location = new System.Drawing.Point(12, 141);
            this.editPatientButton.Name = "editPatientButton";
            this.editPatientButton.Size = new System.Drawing.Size(125, 60);
            this.editPatientButton.TabIndex = 4;
            this.editPatientButton.Text = "Редагувати данні";
            this.editPatientButton.UseVisualStyleBackColor = true;
            // 
            // deletePatientButton
            // 
            this.deletePatientButton.Font = new System.Drawing.Font("Mistral", 15F);
            this.deletePatientButton.Location = new System.Drawing.Point(12, 207);
            this.deletePatientButton.Name = "deletePatientButton";
            this.deletePatientButton.Size = new System.Drawing.Size(125, 60);
            this.deletePatientButton.TabIndex = 3;
            this.deletePatientButton.Text = "Видалити пацієнта";
            this.deletePatientButton.UseVisualStyleBackColor = true;
            // 
            // RegisterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 279);
            this.Controls.Add(this.editPatientButton);
            this.Controls.Add(this.deletePatientButton);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.patientsView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "RegisterWindow";
            this.Text = "RegisterWindow";
            this.Load += new System.EventHandler(this.RegisterWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView patientsView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button editPatientButton;
        private System.Windows.Forms.Button deletePatientButton;
    }
}