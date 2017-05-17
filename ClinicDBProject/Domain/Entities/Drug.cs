using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Drug
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DrugID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<AppointmentResult> Results { get; set; }

    }
}
