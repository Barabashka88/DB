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
        public DbSet<Prices> Prices { get; set; }
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
            var person3 = new Person
            {
                FirstName = "Василь",
                LastName = "Пупкін",
                Address = "Чорновола",
                DateOfBirth = new DateTime(1995, 06, 07),
                PhoneNumber = "0322222522"
            };
            var person4 = new Person
            {
                FirstName = "Іван",
                LastName = "Іваненко",
                Address = "Чорновола",
                DateOfBirth = new DateTime(1998, 06, 07),
                PhoneNumber = "0322223522"
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
            context.Persons.Add(person3);
            context.Persons.Add(person4);
            var patient = new Patient
            {
                Height = 180,
                Weight = 90,
                BloodGroup = 4,
                Person = person1
            };
            context.Patients.Add(patient);
            var patient2 = new Patient
            {
                Height = 200,
                Weight = 60,
                BloodGroup = 4,
                Person = person4
            };
            context.Patients.Add(patient2);
            var doctor = new Doctor
            {
                Person = person2,
                Specialization = "Хірург"
            };
            var doctor2 = new Doctor
            {
                Person = person3,
                Specialization = "Педіатр"
            };

            context.Doctors.Add(doctor);
            context.Doctors.Add(doctor2);
            var login = new DocLogin
            {
                Doctor = doctor,
                Login = "Serg",
                Password = "12345"
            };
            var login2 = new DocLogin
            {
                Doctor = doctor2,
                Login = "Vasia",
                Password = "12345"
            };
            context.DocsLogins.Add(login);
            context.DocsLogins.Add(login2);
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
                Date = new DateTime(2017, 04, 01),
                Description = "so bad"

            };
            var appointment2 = new Appointment
            {
                Doctor = doctor2,
                Patient = patient2,
                Date = new DateTime(2017, 02, 01),
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
                },
            };
           
            var appresult2 = new AppointmentResult
            {
                Patient = patient2,
                Diagnos = "Рак",
                Drugs = new List<Drug>
                {
                    drug1
                },
            };
            context.AppointmentResults.Add(appresult);
            context.AppointmentResults.Add(appresult2);
            var price1 = new Prices
            {
                Date = new DateTime(2017, 04, 01),
                Price = analys1.Price,
                Result = appresult
            };
            var price2= new Prices
            {
                Date = new DateTime(2017, 02, 01),
                Price = drug1.Price,
                Result = appresult2
            };
            context.Prices.Add(price2);
            context.Prices.Add(price1);
            base.Seed(context);
        }
    }
}
