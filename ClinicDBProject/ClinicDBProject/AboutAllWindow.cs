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
    public partial class AboutAllWindow : Form
    {
        private readonly ClinicRepository _repository;

        public AboutAllWindow(ClinicRepository repository)
        {
            InitializeComponent();
            _repository = repository;
            TablesInit();
        }

        public void TablesInit()
        {
            dataGridView1.DataSource = (from patient in _repository.GetAllPatients() select new
            {
                Імя = patient.Person.FullName,
                Адреса = patient.Person.Address,
                Телефон = patient.Person.PhoneNumber,
                ДатаНародження = patient.Person.DateOfBirth,
                Ріст = patient.Height,
                Вага = patient.Weight,
                ГрупаКрові = patient.BloodGroup,
            }).ToList();
            dataGridView2.DataSource = (from doctors in _repository.GetAllDoctors() select new
            {
                Імя = doctors.Person.FullName,
                Спеціалізація = doctors.Specialization

            }).ToList();
            dataGridView3.DataSource = (from app in _repository.GetAllAppointments()
                select new
                {
                    Пацієнт = app.Patient.Person.FullName,
                    Лікар = app.Doctor.Person.FullName,
                    ДатаПрийому = app.Date,
                    Опис = app.Description
                }).ToList();
            dataGridView4.DataSource = (from drug in _repository.GetAllDrugs() select new
            {
               Назва = drug.Name,
               Ціна = drug.Price
            }).ToList();
            dataGridView5.DataSource = (from analis in _repository.GetAllAnalyses() select new
            {
                Назва = analis.Name,
                Ціна = analis.Price
            }).ToList();
            dataGridView6.DataSource = (from res in _repository.GetAllAppointmentResults() select new
            {
                Пацієнт = res.Patient.Person.FullName,
                Ліки = res.GetAllDrugs(),
                Аналізи = res.GetAllAnalisis(),
                Діагноз = res.Diagnos,
                Ціна = (res.GetAnalisisPrice() + res.GetDrugPrice()).ToString()
            }).ToList();
        }
    }
}