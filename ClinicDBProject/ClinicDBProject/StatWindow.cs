using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Domain.Concrete;

namespace ClinicDBProject
{
    public partial class StatWindow : Form
    {
        private ClinicRepository _repository;

        public StatWindow(ClinicRepository _repository)
        {
            InitializeComponent();
            this._repository = _repository;
            Init();

        }

        private void Init()
        {
            foreach (var doc in _repository.GetAllDoctors().ToList())
            {
                var query = (from app in _repository.GetAllAppointments()
                             where app.Doctor == doc
                             select app.Patient).ToList().Distinct();
                chart1.Series[0].Points.AddXY(doc.Person.FullName, query.Count());
            }
        }
        private void StatWindow_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void appointmentsButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
