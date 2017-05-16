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
        private ClinicContext context = new ClinicContext();

        public IEnumerable<Patient> GetAllPatients()
        {
            var patients = (from patient in context.Patients select patient);
            return patients.ToList();
        }
        public IEnumerable<Person> GetAllPeople()
        {
            var people = from person in context.Persons select person;
            return people.ToList();
        }
        public void AddPerson(Person person)
        {
            context.Persons.Add(person);
        }
        public void AddPatient(Patient patient)
        {
            context.Patients.Add(patient);
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
        public Person GetPersonByID(int personID)
        {
            return context.Persons.FirstOrDefault(x => x.PersonID == personID);
        }
        public Patient GetPatientByID(int patientID)
        {
            return context.Patients.FirstOrDefault(x => x.PatientID == patientID);
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
