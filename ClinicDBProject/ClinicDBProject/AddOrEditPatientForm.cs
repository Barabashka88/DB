using Domain.Concrete;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicDBProject
{
    public partial class AddOrEditPatientForm : Form
    {
        public ClinicRepository repository;
        public int patientID;
        public AddOrEditPatientForm(ClinicRepository repository )
        {
            this.repository = repository;
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
                repository.AddPerson(person);
                repository.AddPatient(patient);
                MessageBox.Show("Пацієнта додано");
            }
            else
            {
                patient = repository.GetPatientById(patientID);
                person = repository.GetPersonById(patient.Person.PersonId);
                person.FirstName = firstNameTextBox.Text;
                person.LastName = lastNameTextBox.Text;
                person.PhoneNumber = PhoneTextBox.Text;
                person.Address = adressTextBox.Text;
                person.DateOfBirth = birthDateTimePicker.Value;
                patient.Person = person;
                patient.BloodGroup = int.Parse(BloodComboBox.SelectedValue.ToString());
                patient.Height = Convert.ToInt32(heightTextBox.Text);
                patient.Weight = double.Parse(weightTextBox.Text);

                repository.UpdatePerson(person);
                repository.UpdatePatient(patient);
                MessageBox.Show("Пацієнта відредаговано");
            }
            repository.Save();
            Close();
        }
    }
}
