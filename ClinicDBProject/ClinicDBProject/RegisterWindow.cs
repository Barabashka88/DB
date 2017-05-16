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
            var patients = repository.GetAllPatients();
            patientsView.DataSource = patients;
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

        }
    }
}
