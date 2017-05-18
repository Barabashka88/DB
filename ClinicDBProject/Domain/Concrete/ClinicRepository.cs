using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Reflection;

namespace Domain.Concrete
{
    public class ClinicRepository
    {
        private readonly ClinicContext context = new ClinicContext();

        public IEnumerable<Patient> GetAllPatients()
        {
            var patients = (from patient in context.Patients select patient);
            return patients;
        }
        public IEnumerable<Person> GetAllPeople()
        {
            var people = from person in context.Persons select person;
            return people;
        }
        public IEnumerable<DocLogin> GetAllLogins()
        {
            var logins = from log in context.DocsLogins select log;
            return logins.ToList();
        }
        public IEnumerable<Doctor> GetAllDoctors()
        {
            var docs = from doc in context.Doctors select doc;
            return docs.ToList();
        }
        public IEnumerable<Appointment> GetAllAppointments()
        {
            var appointments = from appointment in context.Appointments select appointment;
            return appointments.ToList();
        }
        public void AddPerson(Person person)
        {
            context.Persons.Add(person);
        }
        public void AddPatient(Patient patient)
        {
            context.Patients.Add(patient);
        }

        public void AddApointment(Appointment apointment)
        {
            context.Appointments.Add(apointment);
        }

        public void UpdatePatient(Patient patientObj)
        {
            context.Patients.Attach(patientObj);
            context.Entry(patientObj).State = EntityState.Modified;
            Save();
        }
        public void UpdatePerson(Person personObj)
        {
            context.Persons.Attach(personObj);
            context.Entry(personObj).State = EntityState.Modified;
            Save();
        }
        public Person GetPersonById(int personId)
        {
            return context.Persons.FirstOrDefault(x => x.PersonId == personId);
        }
        public Patient GetPatientById(int patientId)
        {
            return context.Patients.FirstOrDefault(x => x.PatientId == patientId);
        }
        public Patient GetPatientByPersonId(int personId)
        {
            return context.Patients.FirstOrDefault(x => x.Person.PersonId == personId);
        }
        public Doctor GetDoctorByLogin(string login)
        {
            return context.Doctors.FirstOrDefault(x => x.Login.Login == login);
        }
        public Doctor GetDoctorById(int doctorId)
        {
            return context.Doctors.FirstOrDefault(x => x.DoctorIs == doctorId);
        }
        public void DeletePatient(Patient patient)
        {
            context.Patients.Remove(patient);
        }
        public void DeletePerson(Person person)
        {
            context.Persons.Remove(person);
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
