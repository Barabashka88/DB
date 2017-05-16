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

    }
}
