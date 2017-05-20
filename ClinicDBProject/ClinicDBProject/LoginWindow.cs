using Domain.Concrete;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ClinicDBProject
{
    public partial class LoginWindow : Form
    {
        private readonly ClinicRepository _repository;
        private readonly WelcomeWindow _welcomeWindow;

        public LoginWindow(ClinicRepository repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        public LoginWindow(ClinicRepository repository, WelcomeWindow welcomeWindow) : this(repository)
        {
            this._welcomeWindow = welcomeWindow;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            var query = (from logins in _repository.GetAllLogins()
                         join doc in _repository.GetAllDoctors() on logins.Doctor equals doc
                         select logins).ToList();
            if (query[0].Password == passwordTextBox.Text && query[0].Login == loginTextBox.Text)
            {
                DocWindow form =
                    new DocWindow(_repository, _welcomeWindow)
                    {
                        DocId = _repository.GetDoctorByLogin(query[0].Login).DoctorIs
                    };
                form.InitializeForm();
                _welcomeWindow.Hide();
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
