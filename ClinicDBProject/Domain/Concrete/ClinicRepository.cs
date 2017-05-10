using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    class ClinicRepository
    {
        private ClinicContext context;
        public ClinicRepository(ClinicContext cont)
        {
            context = cont;
        }


    }
}
