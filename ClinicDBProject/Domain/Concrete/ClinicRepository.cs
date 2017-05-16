using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

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
        public void Save()
        {
            context.SaveChanges();
        }

    }
}
