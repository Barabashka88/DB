using Domain.Concrete;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Windows.Forms;

namespace ClinicDBProject
{
    public partial class AddOrEditPatientForm : Form
    {
        private readonly ClinicRepository _repository;
        public int PatientId;
        public AddOrEditPatientForm(ClinicRepository repository)
        {
            _repository = repository;
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
            bool? check=null;
            try
            {
                if (AreAllFieldsValid())
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
                            DateOfBirth = Convert.ToDateTime(birthDateTimePicker.Value.ToString("dd/MM/yyyy"))
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
                        var result = new AppointmentResult
                        {
                            Patient = patient,
                            Analyzes = new List<Analysis>(),
                            Drugs = new List<Drug>()
                        };
                        _repository.AddApointmentResult(result);

                        check = true;
                        // MessageBox.Show("Пацієнта додано");
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

                        check = false;
                        // MessageBox.Show("Пацієнта відредаговано");
                    }
                    _repository.Save();
                }
                else
                {
                    MessageBox.Show("Не всі необхідні поля заповнено , або заповнено неправильно");
                }
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("Погано введені дані");
                check = null;
            }
            if (check==true)
            {
                MessageBox.Show("Пацієнта додано");
                Close();
            }
            else if (check == false)
            {
                MessageBox.Show("Пацієнта відредаговано");
                Close();
            }
            
            
        }
        private bool AreAllFieldsValid()
        {
            double result;
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                return false;
            }
            if (!double.TryParse(heightTextBox.Text, out result))
            {
                return false;
            }
            if (!double.TryParse(weightTextBox.Text, out result))
            {
                return false;
            }
            if (BloodComboBox.SelectedValue == null)
            {
                return false;
            }
            if (birthDateTimePicker.Value > DateTime.Today)
            {
                return false;
            }
            return true;
        }
    }
}
