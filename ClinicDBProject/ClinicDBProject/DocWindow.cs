using System;
using System.Linq;
using System.Windows.Forms;
using Domain.Concrete;
using Domain.Entities;

namespace ClinicDBProject
{
    public partial class DocWindow : Form
    {
        private readonly ClinicRepository _repository;
        public int DocId;
        private int _patientId;

        public readonly WelcomeWindow _welcomeWindow;

        public DocWindow(ClinicRepository repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        public DocWindow(ClinicRepository repository, WelcomeWindow welcomeWindow) : this(repository)
        {
            _welcomeWindow = welcomeWindow;
        }

        public void InitializeForm()
        {
            Doctor doc = _repository.GetDoctorById(DocId);
            doctorNameLabel.Text = doc.Person.FirstName;
            doctorSurnameLabel.Text = doc.Person.LastName;
            doctorSpecializationLabel.Text = doc.Specialization;
            var query = from people in _repository.GetAllPeople()
                        join patient in _repository.GetAllPatients() on people.PersonId equals patient.Person.PersonId
                        select people;
            patientsComboBox.DataSource = query.ToList();
            patientsComboBox.ValueMember = "PersonId";
            patientsComboBox.DisplayMember = "FullName";
            patientsComboBox.SelectedIndex = -1;
        }

        private void DataGridInitialize()
        {
            var query = from appoint in _repository.GetAllAppointments()
                where appoint.Patient.Person.PersonId == (int)patientsComboBox.SelectedValue
                select new
                {
                    appoint.AppointmentId,
                    Пацієнт = appoint.Patient.Person.FullName,
                    Лікар = appoint.Doctor.Person.FullName,
                    ДатаПрийому = appoint.Date,
                    Опис = appoint.Description
                };
            _patientId = _repository.GetPatientByPersonId((int)patientsComboBox.SelectedValue).PatientId;
            appointmentsView.DataSource = query.ToList();
            appointmentsView.Columns[0].Visible = false;
            appointmentsView.Visible = true;
            descriptionTextBox.Visible = true;
            addDescriptionButton.Visible = true;
            diagnosButton.Visible = true;
            tabControl1.Visible = true;
        }
        private void patientsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (patientsComboBox.SelectedIndex != -1)
            {
                if (patientsComboBox.DisplayMember == "FullName")
                {
                    
                    DataGridInitialize();
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DocWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _welcomeWindow.Show();
        }

        private void addDescriptionButton_Click(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text!=null)
            {
                Appointment appointment = new Appointment
                {
                    Date = DateTime.Today,
                    Description = descriptionTextBox.Text,
                    Doctor = _repository.GetDoctorById(DocId),
                    Patient = _repository.GetPatientByPersonId((int)patientsComboBox.SelectedValue)
                };
                _repository.AddApointment(appointment);
                _repository.Save();
                DataGridInitialize();
                descriptionTextBox.Clear();
            }
        }

        private void diagnosButton_Click(object sender, EventArgs e)
        {
            DiagnosWindow form = new DiagnosWindow(_repository);
            Hide();
            form.PatientId = _patientId;
            form.Initialize();
            form.ShowDialog();
            Show();
        }
    }
}
