using System;
using System.Drawing;
using System.Windows.Forms;
using Domain.Concrete;
using Domain.Entities;
using System.Linq;
using System.Threading;

namespace ClinicDBProject
{
    public partial class DiagnosWindow : Form
    {
        private readonly ClinicRepository _repository;
        public int PatientId;
        public DiagnosWindow(ClinicRepository repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        public void Initialize()
        {
            patientLabel.Text = _repository.GetPatientById(PatientId).Person.FullName;
            var query = (from an in _repository.GetAllDrugs() select an).ToList().Except(_repository.GetResultByPatientId(PatientId).Drugs);
            label3.Location = new Point(patientLabel.Location.X + patientLabel.Size.Width, patientLabel.Location.Y);
            drugComboBox.DataSource = query.ToList();
            drugComboBox.ValueMember = "DrugId";
            drugComboBox.DisplayMember = "Name";
            drugComboBox.SelectedIndex = -1;
           analysisComboBox.DataSource = _repository.GetAllAnalyses();
            analysisComboBox.ValueMember = "AnalysisId";
            analysisComboBox.DisplayMember = "Name";
            analysisComboBox.SelectedIndex = -1;
            if (_repository.GetResultByPatientId(PatientId) != null)
                diagnosTextBox.Text = _repository.GetResultByPatientId(PatientId).Diagnos;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            AppointmentResult result = _repository.GetResultByPatientId(PatientId);
           
            if (analysisComboBox.SelectedIndex != -1)
            {
                Prices prices = new Prices()
                {
                    Result = result
                };
                var analis = _repository.GetAnalysisById((int) analysisComboBox.SelectedValue);
                result.Analyzes.Add(analis);
                prices.Date = DateTime.Now;
                prices.Price = analis.Price;
                _repository.AddPrice(prices);
            }
            if (drugComboBox.SelectedIndex != -1)
            {
                Prices prices = new Prices()
                {
                    Result = result
                };
                var drug = _repository.GetDrugsById((int) drugComboBox.SelectedValue);
                result.Drugs.Add(drug);
                Thread.Sleep(1);
                prices.Date = DateTime.Now;
                prices.Price = drug.Price;
                _repository.AddPrice(prices);

            }
            result.Diagnos = diagnosTextBox.Text;
            _repository.UpdateAppointmentResult(result);
            analysisComboBox.SelectedIndex = -1;
            drugComboBox.SelectedIndex = -1;
            MessageBox.Show("Діагноз і лікування успішно додані");
            Initialize();
        }
    }
}