using System;
using System.Data.Entity;
using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Concrete
{
    public class ClinicContext : DbContext
    {
        public ClinicContext() : base("DBClinic") { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Analysis> Analyzes { get; set; }
        public DbSet<DocLogin> DocsLogins { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentResult> AppointmentResults { get; set; }

        static ClinicContext()
        {
            Database.SetInitializer(new ClinicDbInitializer());
        }
        public static ClinicContext Create()
        {
            return new ClinicContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
            .HasOptional(s => s.Login).WithRequired(ad => ad.Doctor);
            base.OnModelCreating(modelBuilder);
        }
    }

    public class ClinicDbInitializer : DropCreateDatabaseIfModelChanges<ClinicContext>
    {
        protected override void Seed(ClinicContext context)
        {
            var person1 = new Person
            {
                FirstName = "Валерій",
                LastName = "Пилипенко",
                Address = "Хоткевича",
                DateOfBirth = new DateTime(1997, 12, 03),
                PhoneNumber = "0938737355"
            };
            var person2 = new Person
            {
                FirstName = "Сергій",
                LastName = "Савка",
                Address = "Барановича",
                DateOfBirth = new DateTime(1993, 7, 06),
                PhoneNumber = "0923413535"
            };
            context.Persons.Add(person1);
            context.Persons.Add(person2);
            var patient = new Patient
            {
                Height = 180,
                Weight = 90,
                BloodGroup = 4,
                Person = person1
            };
            context.Patients.Add(patient);
            var doctor = new Doctor
            {
                Person = person2,
                Specialization = "Хірург"
            };
            context.Doctors.Add(doctor);
            var login = new DocLogin
            {
                Doctor = doctor,
                Login = "Serg",
                Password = "12345"
            };
            context.DocsLogins.Add(login);

            var analys1 = new Analysis
            {
                Name = "Обширний аналі крові",
                Price = 300
            };
            context.Analyzes.Add(analys1);

            var analys2 = new Analysis
            {
                Name = "МРТ",
                Price = 7000
            };
            context.Analyzes.Add(analys2);
            var drug1 = new Drug
            {
                Name = "Вікодин",
                Price = 500
            };
            context.Drugs.Add(drug1);
            var drug2 = new Drug
            {
                Name = "Лікарська марихуана",
                Price = 800
            };
            context.Drugs.Add(drug2);
            var appointment = new Appointment
            {
                Doctor = doctor,
                Patient = patient,
                Date = DateTime.Today,
                Description = "so bad"
           
            };
            var appointment2 = new Appointment
            {
                Doctor = doctor,
                Patient = patient,
                Date = DateTime.Today,
                Description = "very bad"
            };
            context.Appointments.Add(appointment);
            context.Appointments.Add(appointment2);

            var appresult = new AppointmentResult
            {
                Patient = patient,
                Diagnos = "Гепатит А",
                Analyzes = new List<Analysis>
                {
                    analys1
                }
            };
            context.AppointmentResults.Add(appresult);
            base.Seed(context);
        }
    }
}
