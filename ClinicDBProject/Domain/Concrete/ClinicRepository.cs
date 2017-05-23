using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using System.Data.Entity;

namespace Domain.Concrete
{
    public class ClinicRepository
    {
        private readonly ClinicContext _context = new ClinicContext();

        public IEnumerable<Patient> GetAllPatients()
        {
            var patients = (from patient in _context.Patients select patient);
            return patients;
        }
        public IEnumerable<Person> GetAllPeople()
        {
            var people = from person in _context.Persons select person;
            return people;
        }
        public IEnumerable<DocLogin> GetAllLogins()
        {
            var logins = from log in _context.DocsLogins select log;
            return logins.ToList();
        }
        public IEnumerable<Doctor> GetAllDoctors()
        {
            var docs = from doc in _context.Doctors select doc;
            return docs.ToList();
        }
        public IEnumerable<Appointment> GetAllAppointments()
        {
            var appointments = from appointment in _context.Appointments select appointment;
            return appointments.ToList();
        }
        public IEnumerable<Drug> GetAllDrugs()
        {
            var drugs = from drug in _context.Drugs select drug;
            return drugs.ToList();
        }
        public IEnumerable<Analysis> GetAllAnalyses()
        {
            var analisis = from analis in _context.Analyzes select analis;
            return analisis.ToList();
        }

        public void AddPerson(Person person)
        {
            _context.Persons.Add(person);
        }
        public void AddPatient(Patient patient)
        {
            _context.Patients.Add(patient);
        }

        public void AddApointment(Appointment apointment)
        {
            _context.Appointments.Add(apointment);
        }

        public void UpdatePatient(Patient patientObj)
        {
            _context.Patients.Attach(patientObj);
            _context.Entry(patientObj).State = EntityState.Modified;
            Save();
        }
        public void UpdatePerson(Person personObj)
        {
            _context.Persons.Attach(personObj);
            _context.Entry(personObj).State = EntityState.Modified;
            Save();
        }
        public void UpdateAppointmentResult(AppointmentResult resultObj)
        {
            _context.AppointmentResults.Attach(resultObj);
            _context.Entry(resultObj).State = EntityState.Modified;
            Save();
        }
        public Person GetPersonById(int personId)
        {
            return _context.Persons.FirstOrDefault(x => x.PersonId == personId);
        }
        public Patient GetPatientById(int patientId)
        {
            return _context.Patients.FirstOrDefault(x => x.PatientId == patientId);
        }
        public Patient GetPatientByPersonId(int personId)
        {
            return _context.Patients.FirstOrDefault(x => x.Person.PersonId == personId);
        }
        public Doctor GetDoctorByLogin(string login)
        {
            return _context.Doctors.FirstOrDefault(x => x.Login.Login == login);
        }
        public Doctor GetDoctorById(int doctorId)
        {
            return _context.Doctors.FirstOrDefault(x => x.DoctorIs == doctorId);
        }
        public AppointmentResult GetResultByPatientId(int patientId)
        {
            return _context.AppointmentResults.FirstOrDefault(x => x.Patient.PatientId == patientId);
        }
        public Analysis GetAnalysisById(int analysisId)
        {
            return _context.Analyzes.FirstOrDefault(x => x.AnalysisId == analysisId);
        }
        public Drug GetDrugsById(int drugId)
        {
            return _context.Drugs.FirstOrDefault(x => x.DrugId == drugId);
        }
        public void DeletePatient(Patient patient)
        {
            _context.Patients.Remove(patient);
        }
        public void DeletePerson(Person person)
        {
            _context.Persons.Remove(person);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}