using System;
using System.Drawing;
using System.Windows.Forms;
using Domain.Concrete;

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
            label3.Location = new Point(patientLabel.Location.X + patientLabel.Size.Width, patientLabel.Location.Y);
            drugComboBox.DataSource = _repository.GetAllDrugs();
            drugComboBox.ValueMember = "DrugId";
            drugComboBox.DisplayMember = "Name";
            drugComboBox.SelectedIndex = -1;

            analysisComboBox.DataSource = _repository.GetAllAnalyses();
            analysisComboBox.ValueMember = "AnalysisId";
            analysisComboBox.DisplayMember = "Name";
            analysisComboBox.SelectedIndex = -1;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DiagnosWindow_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}