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
            _welcomeWindow = welcomeWindow;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            bool check = false;
            var query = (from logins in _repository.GetAllLogins()
                         join doc in _repository.GetAllDoctors() on logins.Doctor equals doc
                         select logins).ToList();
            foreach (var el in query)
            {
                if (el.Password == passwordTextBox.Text && el.Login == loginTextBox.Text)
                {
                    check = true;
                    DocWindow form =
                        new DocWindow(_repository, _welcomeWindow)
                        {
                            DocId = _repository.GetDoctorByLogin(el.Login).DoctorIs
                        };
                    form.InitializeForm();
                    _welcomeWindow.Hide();
                    Hide();
                    form.ShowDialog();
                    
                }
            }
            if (check==false)
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
