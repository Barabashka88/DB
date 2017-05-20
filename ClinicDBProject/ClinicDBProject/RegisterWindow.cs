using System;
using System.Linq;
using System.Windows.Forms;
using Domain.Concrete;

namespace ClinicDBProject
{
    public partial class RegisterWindow : Form
    {
        private readonly ClinicRepository _repository;
        public RegisterWindow(ClinicRepository repository)
        {
            this._repository = repository;
            InitializeComponent();
            InitializeTable();
        }
        public void InitializeTable()
        {
            var query = (from patient in _repository.GetAllPatients()
                         join person in _repository.GetAllPeople() on patient.Person.PersonId equals person.PersonId
                         select new
                         {
                             Імя = patient.Person.FirstName,
                             Прізвище = patient.Person.LastName,
                             Адреса = patient.Person.Address,
                             Телефон = patient.Person.PhoneNumber,
                             ДатаНародження = patient.Person.DateOfBirth,
                             Ріст = patient.Height,
                             Вага = patient.Weight,
                             ГрупаКрові = patient.BloodGroup,
                             ID = patient.PatientId
                         }).ToList();
            patientsView.DataSource = query;
            patientsView.Columns[8].Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            AddOrEditPatientForm form = new AddOrEditPatientForm(_repository) {Text = "Новий пацієнт"};
            Hide();
            form.ShowDialog();
            Show();
            InitializeTable();
        }

        private void editPatientButton_Click(object sender, EventArgs e)
        {
            if (patientsView.SelectedRows.Count == 1)
            {
                AddOrEditPatientForm form = new AddOrEditPatientForm(_repository);

                form.Text = "Змінити данні";
                form.PatientId = Convert.ToInt32(patientsView.SelectedRows[0].Cells[8].Value);
                var patient = _repository.GetPatientById(form.PatientId);
                form.firstNameTextBox.Text = patient.Person.FirstName;
                form.lastNameTextBox.Text = patient.Person.LastName;
                form.birthDateTimePicker.Value = DateTime.Parse(patient.Person.DateOfBirth.ToString());
                form.adressTextBox.Text = patient.Person.Address;
                form.PhoneTextBox.Text = patient.Person.PhoneNumber;
                form.heightTextBox.Text = patient.Height.ToString();
                form.weightTextBox.Text = patient.Weight.ToString();
                form.BloodComboBox.SelectedIndex = form.BloodComboBox.FindString(patient.BloodGroup.ToString());
                Hide();
                form.ShowDialog();
                Show();
                _repository.Save();
               InitializeTable();
            }
        }

        private void deletePatientButton_Click(object sender, EventArgs e)
        {
            if (patientsView.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow item in patientsView.SelectedRows)
                {
                    int id = int.Parse(item.Cells[8].Value.ToString());
                    var query = (from patient in _repository.GetAllPatients() where patient.PatientId == id select patient).ToList();
                    _repository.DeletePerson(query[0].Person);
                    _repository.DeletePatient(query[0]);
                    _repository.Save();
                }
            }
            InitializeTable();
        }
    }
}
