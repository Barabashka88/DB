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
                             ГрупаКрові = patient.BloodGroup,
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
            form.ShowDialog();
            InitializeTable();
        }

        private void editPatientButton_Click(object sender, EventArgs e)
        {
            if (patientsView.SelectedRows.Count == 1)
            {
                AddOrEditPatientForm form = new AddOrEditPatientForm(repository);
                form.Text = "Змінити данні";
                form.firstNameTextBox.Text = patientsView.SelectedRows[0].Cells[0].Value.ToString();
                form.lastNameTextBox.Text = patientsView.SelectedRows[0].Cells[1].Value.ToString();
                form.birthDateTimePicker.Value = DateTime.Parse(patientsView.SelectedRows[0].Cells[4].Value.ToString());
                form.adressTextBox.Text = patientsView.SelectedRows[0].Cells[2].Value.ToString();
                form.PhoneTextBox.Text = patientsView.SelectedRows[0].Cells[3].Value.ToString();
                form.heightTextBox.Text = patientsView.SelectedRows[0].Cells[5].Value.ToString();
                form.weightTextBox.Text = patientsView.SelectedRows[0].Cells[6].Value.ToString();
                form.BloodComboBox.SelectedIndex = form.BloodComboBox.FindString(patientsView.SelectedRows[0].Cells[7].Value.ToString());
                form.patientID = Convert.ToInt32(patientsView.SelectedRows[0].Cells[8].Value);
                form.ShowDialog();
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
