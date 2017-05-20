using Domain.Concrete;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicDBProject
{
    public partial class AddOrEditPatientForm : Form
    {
        private readonly ClinicRepository _repository;
        public int PatientId;
        public AddOrEditPatientForm(ClinicRepository repository )
        {
            this._repository = repository;
            InitializeComponent();
            List<int> list = new List<int> { 1, 2, 3, 4 };
            BloodComboBox.DataSource = list;
            BloodComboBox.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {            
            Person person;
            Patient patient;
            if (Text == "Новий пацієнт")
            {
                person = new Person
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    PhoneNumber = PhoneTextBox.Text,
                    Address = adressTextBox.Text,
                    DateOfBirth =Convert.ToDateTime(birthDateTimePicker.Value.ToString("dd/MM/yyyy"))
                };
                patient = new Patient
                {
                    Person = person,
                    BloodGroup = int.Parse(BloodComboBox.SelectedValue.ToString()),
                    Height = Convert.ToInt32(heightTextBox.Text),
                    Weight = double.Parse(weightTextBox.Text)
                };
                _repository.AddPerson(person);
                _repository.AddPatient(patient);
                MessageBox.Show("Пацієнта додано");
            }
            else
            {
                patient = _repository.GetPatientById(PatientId);
                person = _repository.GetPersonById(patient.Person.PersonId);
                person.FirstName = firstNameTextBox.Text;
                person.LastName = lastNameTextBox.Text;
                person.PhoneNumber = PhoneTextBox.Text;
                person.Address = adressTextBox.Text;
                person.DateOfBirth = birthDateTimePicker.Value;
                patient.Person = person;
                patient.BloodGroup = int.Parse(BloodComboBox.SelectedValue.ToString());
                patient.Height = Convert.ToInt32(heightTextBox.Text);
                patient.Weight = double.Parse(weightTextBox.Text);

                _repository.UpdatePerson(person);
                _repository.UpdatePatient(patient);
                MessageBox.Show("Пацієнта відредаговано");
            }
            _repository.Save();
            Close();
        }
    }
}
