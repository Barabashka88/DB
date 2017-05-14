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
        public ClinicContext() : base("DBClinic")
        {
            Database.SetInitializer(new ClinicDBInitializer());
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Analysis> Analyzes { get; set; }
        public DbSet<DocLogin> DocsLogins { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentResult> AppointmentResultsP { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
            .HasOptional(s => s.Login).WithRequired(ad => ad.Doctor);
        }
    }

    public class ClinicDBInitializer : DropCreateDatabaseIfModelChanges<ClinicContext>
    {
        protected override void Seed(ClinicContext context)
        {
            base.Seed(context);
        }
    }
}
