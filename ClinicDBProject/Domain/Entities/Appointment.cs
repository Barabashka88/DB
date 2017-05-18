using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppointmentId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
