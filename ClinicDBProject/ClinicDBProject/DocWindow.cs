using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Concrete;
using Domain.Entities;

namespace ClinicDBProject
{
    public partial class DocWindow : Form
    {
        private LoginWindow loginWindow;
        private readonly ClinicRepository repository;
        public int docId;
        public int patientId;

        private readonly WelcomeWindow welcomeWindow;

        public DocWindow(ClinicRepository repository)
        {
            this.repository = repository;
            InitializeComponent();
        }
        public DocWindow(ClinicRepository repository, WelcomeWindow welcomeWindow, LoginWindow loginWindow) : this(repository)
        {
            this.welcomeWindow = welcomeWindow;
            this.loginWindow = loginWindow;
        }
        public void InitializeForm()
        {
            Doctor doc = repository.GetDoctorById(docId);
            doctorNameLabel.Text = doc.Person.FirstName;
            doctorSurnameLabel.Text = doc.Person.LastName;
            doctorSpecializationLabel.Text = doc.Specialization;
            var query = from people in repository.GetAllPeople()
                        join patient in repository.GetAllPatients() on people.PersonId equals patient.Person.PersonId
                        select people;
            patientsComboBox.DataSource = query.ToList();
            patientsComboBox.ValueMember = "PersonId";
            patientsComboBox.DisplayMember = "FullName";
            patientsComboBox.SelectedIndex = -1;
        }

        private void DataGridInitialize()
        {
            var query = from appoint in repository.GetAllAppointments()
                where appoint.Patient.Person.PersonId == (int)patientsComboBox.SelectedValue
                select new
                {
                    appoint.AppointmentId,
                    Пацієнт = appoint.Patient.Person.FullName,
                    Лікар = appoint.Doctor.Person.FullName,
                    ДатаПрийому = appoint.Date,
                    Опис = appoint.Description
                };
            patientId = repository.GetPatientByPersonId((int)patientsComboBox.SelectedValue).PatientId;
            appointmentsView.DataSource = query.ToList();
            appointmentsView.Columns[0].Visible = false;
            appointmentsView.Visible = true;
            descriptionTextBox.Visible = true;
            addDescriptionButton.Visible = true;
            diagnosButton.Visible = true;
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
            welcomeWindow.Show();
        }

        private void addDescriptionButton_Click(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text!=null)
            {
                Appointment appointment = new Appointment
                {
                    Date = DateTime.Today,
                    Description = descriptionTextBox.Text,
                    Doctor = repository.GetDoctorById(docId),
                    Patient = repository.GetPatientByPersonId((int)patientsComboBox.SelectedValue)
                };
                repository.AddApointment(appointment);
                repository.Save();
                DataGridInitialize();
            }
        }

        private void diagnosButton_Click(object sender, EventArgs e)
        {
            DiagnosWindow form = new DiagnosWindow(repository);
            Hide();
            form.patientID = patientId;
            form.Initialize();
            form.ShowDialog();
            Show();
        }
    }
}
