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
        public ClinicRepository repository = new ClinicRepository();
        public WelcomeWindow()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterWindow form = new RegisterWindow(repository);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginWindow form = new LoginWindow(repository);
            
            form.ShowDialog();
            this.Show();
        }

        private void appointmentsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
