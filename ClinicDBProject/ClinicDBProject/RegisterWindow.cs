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
    public partial class RegisterWindow : Form
    {
        public WelcomeWindow form = new WelcomeWindow();
        public RegisterWindow()
        {
            InitializeComponent();
            form.Close();
        }

        private void RegisterWindow_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
