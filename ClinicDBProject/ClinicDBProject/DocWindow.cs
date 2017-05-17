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
        private ClinicRepository repository;
        public int docID;
        private WelcomeWindow welcomeWindow;

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
            Doctor doc = repository.GetDoctorByID(docID);
            doctorNameLabel.Text = doc.Person.FirstName.ToString();
            doctorSurnameLabel.Text = doc.Person.LastName.ToString();
            doctorSpecializationLabel.Text = doc.Specialization.ToString();
            var query = (from patien in repository.GetAllPatients() select patien).ToList();
            patientsComboBox.DataSource = query.ToList();
            patientsComboBox.ValueMember = "PatientId";
            //patientsComboBox.DisplayMember = "FirstName";
        }
    }
}
