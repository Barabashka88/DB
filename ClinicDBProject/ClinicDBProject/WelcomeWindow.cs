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
    public partial class WelcomeWindow : Form
    {
        private readonly ClinicRepository _repository = new ClinicRepository();
        public WelcomeWindow()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var form = new RegisterWindow(_repository);
            Hide();
            form.ShowDialog();
            Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var form = new LoginWindow(_repository,this);
            form.ShowDialog();
        }

        private void appointmentsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
