using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class AppointmentResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResultId { get; set; }
        public virtual Patient Patient { get; set; }
        public string Diagnos { get; set; }

        public virtual ICollection<Analysis> Analyzes { get; set; }
        public virtual ICollection<Drug> Drugs { get; set; }

    }
}
