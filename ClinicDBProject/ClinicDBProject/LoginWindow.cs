using Domain.Concrete;
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
    public partial class LoginWindow : Form
    {
        public ClinicRepository repository;
        private WelcomeWindow welcomeWindow;

        public LoginWindow(ClinicRepository repository)
        {
            this.repository = repository;
            InitializeComponent();
        }

        public LoginWindow(ClinicRepository repository, WelcomeWindow welcomeWindow) : this(repository)
        {
            this.welcomeWindow = welcomeWindow;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            var query = (from logins in repository.GetAllLogins()
                         join doc in repository.GetAllDoctors() on logins.Doctor equals doc
                         select logins).ToList();
            if (query[0].Password == passwordTextBox.Text && query[0].Login == loginTextBox.Text)
            {
                DocWindow form =
                    new DocWindow(repository, welcomeWindow, this)
                    {
                        docId = repository.GetDoctorByLogin(query[0].Login).DoctorIs
                    };
                form.InitializeForm();
                welcomeWindow.Hide();
                Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Данні введено неправильно");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
