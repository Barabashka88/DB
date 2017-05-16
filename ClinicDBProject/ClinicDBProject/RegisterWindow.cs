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
        ClinicRepository repository = new ClinicRepository();
            public RegisterWindow()
        {
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
                            Ріст = patient.Height,
                            Вага = patient.Weight,
                            ГрупаКрові = patient.BloodGroup,
                        }).ToList();
            patientsView.DataSource = query;
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
            AddOrEditPatientForm form = new AddOrEditPatientForm();
            form.Text = "Новий пацієнт";
            form.ShowDialog();
            InitializeTable();
        }

        private void editPatientButton_Click(object sender, EventArgs e)
        {

        }
    }
}
