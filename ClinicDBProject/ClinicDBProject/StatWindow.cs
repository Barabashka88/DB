using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Domain.Concrete;
using Domain.Entities;

namespace ClinicDBProject
{
    public partial class StatWindow : Form
    {
        private readonly ClinicRepository _repository;
        private readonly Dictionary<Doctor, int> _docPatient = new Dictionary<Doctor, int>();
        public StatWindow(ClinicRepository repository)
        {
            InitializeComponent();
            _repository = repository;
            List<string> dates = new List<string> { "За останній місяць", "За останні 3 місяці", "за пів року", "за рік" };
            datesComboBox.DataSource = dates;
           
            label1.Text = "Кількість лікарів: " + repository.GetAllDoctors().Count();
            var a = repository.GetAllAppointmentResults().ToList();
            var fullprice = 0.0m;
            foreach (var el in a)
            {
                fullprice += el.GetAnalisisPrice() + el.GetDrugPrice();
            }
            label2.Text = "Прибуток: " "+fullprice;
        }

        private void InitTop5Doctors(DateTime date)
        {
            _docPatient.Clear();
            chart1.Series[0].Points.Clear();
            foreach (var doc in _repository.GetAllDoctors().ToList())
            {
                var query = (from app in _repository.GetAllAppointments()
                             where app.Doctor == doc && app.Date > date
                             select app.Patient).ToList().Distinct();
                _docPatient.Add(doc, query.Count());
            }
            patientLabel.Text = "Kількість пацієнтів: " + (from app in _repository.GetAllAppointments()
                                                           where app.Date > date select app.Patient).Count();
            var top5 = _docPatient.OrderByDescending(pair => pair.Value).Take(5);
            foreach (var el in top5)
            {
                chart1.Series[0].Points.AddXY(el.Key.Person.FullName, el.Value);
            }
        }

        private void MoneyCalc(DateTime date)
        {
            
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
            DateTime date = new DateTime();
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
            //MoneyCalc(date);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
