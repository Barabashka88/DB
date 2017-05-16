using Domain.Concrete;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace ClinicDBProject
{
    public partial class AddOrEditPatientForm : Form
    {
        ClinicRepository repository = new ClinicRepository();

        public AddOrEditPatientForm()
        {
            InitializeComponent();
            List<int> list = new List<int> { 1, 2, 3, 4 };
            BloodComboBox.DataSource = list;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Person person = new Person {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                PhoneNumber = PhoneTextBox.Text,
                Address = adressTextBox.Text,
                DateOfBirth = birthDateTimePicker.Value
            };
            Patient patient = new Patient
            {
                Person = person,
                BloodGroup = int.Parse(BloodComboBox.SelectedValue.ToString()),
                Height = Convert.ToInt32(heightTextBox.Text),
                Weight = double.Parse(weightTextBox.Text)
            };
            repository.AddPerson(person);
            repository.AddPatient(patient);
            repository.Save();
            MessageBox.Show("Пацієнта додано");
            Close();
        }
    }
}
