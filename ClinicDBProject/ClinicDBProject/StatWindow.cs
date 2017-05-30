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
using Domain.Entities;

namespace ClinicDBProject
{
    public partial class StatWindow : Form
    {
        private ClinicRepository _repository;
        Dictionary<Doctor, int> DocPatient = new Dictionary<Doctor, int>();
        public StatWindow(ClinicRepository _repository)
        {
            InitializeComponent();
            this._repository = _repository;
            List<string> Dates = new List<string> { "За останній місяць", "За останні 3 місяці", "за пів року", "за рік" };
            datesComboBox.DataSource = Dates;

        }

        private void InitTop5Doctors(DateTime date)
        {
            DocPatient.Clear();
            chart1.Series[0].Points.Clear();
            foreach (var doc in _repository.GetAllDoctors().ToList())
            {
                var query = (from app in _repository.GetAllAppointments()
                             where app.Doctor == doc && app.Date > date
                             select app.Patient).ToList().Distinct();
                DocPatient.Add(doc, query.Count());
            }
            var top5 = DocPatient.OrderByDescending(pair => pair.Value).Take(5);
            foreach (var el in top5)
            {
                chart1.Series[0].Points.AddXY(el.Key.Person.FullName, el.Value);
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

        private void patientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime date= new DateTime();
            switch (datesComboBox.SelectedIndex)
            {
                case 0:
                    date = DateTime.Now.AddMonths(-1);
                    break;
                case 1:
                    date = DateTime.Now.AddMonths(-3);
                    break;
                case 2:
                    date = DateTime.Now.AddMonths(-6);
                    break;
                case 3:
                    date = DateTime.Now.AddMonths(-12);
                    break;
            }
            InitTop5Doctors(date);

        }
    }
}
