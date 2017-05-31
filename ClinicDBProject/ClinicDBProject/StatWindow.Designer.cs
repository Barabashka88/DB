namespace ClinicDBProject
{
    partial class StatWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.appointmentsButton = new System.Windows.Forms.Button();
            this.datesComboBox = new System.Windows.Forms.ComboBox();
            this.patientLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 56);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Кількість Пацієнтів";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(907, 288);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Прибуток";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // appointmentsButton
            // 
            this.appointmentsButton.Font = new System.Drawing.Font("Mistral", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsButton.Location = new System.Drawing.Point(683, 603);
            this.appointmentsButton.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentsButton.Name = "appointmentsButton";
            this.appointmentsButton.Size = new System.Drawing.Size(236, 75);
            this.appointmentsButton.TabIndex = 3;
            this.appointmentsButton.Text = "Назад";
            this.appointmentsButton.UseVisualStyleBackColor = true;
            this.appointmentsButton.Click += new System.EventHandler(this.appointmentsButton_Click);
            // 
            // datesComboBox
            // 
            this.datesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datesComboBox.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datesComboBox.FormattingEnabled = true;
            this.datesComboBox.Location = new System.Drawing.Point(294, 11);
            this.datesComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datesComboBox.Name = "datesComboBox";
            this.datesComboBox.Size = new System.Drawing.Size(360, 41);
            this.datesComboBox.TabIndex = 4;
            this.datesComboBox.SelectedIndexChanged += new System.EventHandler(this.patientsComboBox_SelectedIndexChanged);
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientLabel.Location = new System.Drawing.Point(13, 11);
            this.patientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(0, 33);
            this.patientLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(670, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 6;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(12, 348);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Прибуток";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(907, 288);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "Прибуток";
            // 
            // StatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 691);
            this.Controls.Add(this.appointmentsButton);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientLabel);
            this.Controls.Add(this.datesComboBox);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StatWindow";
            this.Text = "StatWindow";
            this.Load += new System.EventHandler(this.StatWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button appointmentsButton;
        private System.Windows.Forms.ComboBox datesComboBox;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}