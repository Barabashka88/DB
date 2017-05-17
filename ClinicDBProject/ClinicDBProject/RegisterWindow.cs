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
    public partial class RegisterWindow : Form
    {
        public ClinicRepository repository;
        public RegisterWindow(ClinicRepository repository)
        {
            this.repository = repository;
            InitializeComponent();
            InitializeTable();
        }
        public void InitializeTable()
        {
            var query = (from patient in repository.GetAllPatients()
                         join person in repository.GetAllPeople() on patient.Person.PersonID equals person.PersonID
                         select new
                         {
                             Імя = patient.Person.FirstName,
                             Прізвище = patient.Person.LastName,
                             Адреса = patient.Person.Address,
                             Телефон = patient.Person.PhoneNumber,
                             Дата_народження = patient.Person.DateOfBirth,
                             Ріст = patient.Height,
                             Вага = patient.Weight,
                             Група_Крові = patient.BloodGroup,
                             ID = patient.PatientID
                         }).ToList();
            patientsView.DataSource = query;
            patientsView.Columns[8].Visible = false;
        }
        private void RegisterWindow_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            AddOrEditPatientForm form = new AddOrEditPatientForm(repository);
            form.Text = "Новий пацієнт";
            this.Hide();
            form.ShowDialog();
            this.Show();
            InitializeTable();
        }

        private void editPatientButton_Click(object sender, EventArgs e)
        {
            if (patientsView.SelectedRows.Count == 1)
            {
                AddOrEditPatientForm form = new AddOrEditPatientForm(repository);

                form.Text = "Змінити данні";
                form.patientID = Convert.ToInt32(patientsView.SelectedRows[0].Cells[8].Value);
                var patient = repository.GetPatientByID(form.patientID);
                form.firstNameTextBox.Text = patient.Person.FirstName.ToString();
                form.lastNameTextBox.Text = patient.Person.LastName.ToString();
                form.birthDateTimePicker.Value = DateTime.Parse(patient.Person.DateOfBirth.ToString());
                form.adressTextBox.Text = patient.Person.Address.ToString();
                form.PhoneTextBox.Text = patient.Person.PhoneNumber.ToString();
                form.heightTextBox.Text = patient.Height.ToString();
                form.weightTextBox.Text = patient.Weight.ToString();
                form.BloodComboBox.SelectedIndex = form.BloodComboBox.FindString(patient.BloodGroup.ToString());
                this.Hide();
                form.ShowDialog();
                this.Show();
                repository.Save();
               InitializeTable();
            }
        }

        private void deletePatientButton_Click(object sender, EventArgs e)
        {
            if (patientsView.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow item in this.patientsView.SelectedRows)
                {
                    int id = int.Parse(item.Cells[8].Value.ToString());
                    var query = (from patient in repository.GetAllPatients() where patient.PatientID == id select patient).ToList();
                    repository.DeletePerson(query[0].Person);
                    repository.DeletePatient(query[0]);
                    repository.Save();
                }
            }
            InitializeTable();
        }
    }
}
