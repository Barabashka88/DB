using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Concrete;

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
        public DbSet<AppointmentResult> AppointmentResultsP { get; set; }

        static ClinicContext()
        {
            Database.SetInitializer<ClinicContext>(new ClinicDBInitializer());
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

    public class ClinicDBInitializer : DropCreateDatabaseIfModelChanges<ClinicContext>
    {
        protected override void Seed(ClinicContext context)
        {
            Person person1 = new Person
            {
                FirstName = "Валерій",
                LastName = "Пилипенко",
                Address = "Хоткевича",
                DateOfBirth = new DateTime(1997, 12, 03),
                PhoneNumber = "0938737355"
            };
            Person person2 = new Person
            {
                FirstName = "Сергій",
                LastName = "Савка",
                Address = "Барановича",
                DateOfBirth = new DateTime(1993, 7, 06),
                PhoneNumber = "0923413535"
            };
            context.Persons.Add(person1);
            context.Persons.Add(person2);
            Patient patient = new Patient
            {
                Height = 180,
                Weight = 90,
                BloodGroup = 4,
                Person = person1
            };
            context.Patients.Add(patient);
            Doctor doctor = new Doctor
            {
                Person = person2,
                Specialization = "Хірург"
            };
            context.Doctors.Add(doctor);
            DocLogin login = new DocLogin
            {
                Doctor = doctor,
                Login = "Serg",
                Password = "12345"
            };
            context.DocsLogins.Add(login);


            base.Seed(context);
        }
    }
}
