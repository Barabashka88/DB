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

namespace ClinicDBProject
{
    public partial class DiagnosWindow : Form
    {
        private ClinicRepository repository;

        public DiagnosWindow()
        {
            InitializeComponent();
        }

        public DiagnosWindow(ClinicRepository repository)
        {
            this.repository = repository;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
