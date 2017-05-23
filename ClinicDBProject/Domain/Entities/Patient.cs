using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }
        public int BloodGroup { get; set; }

        public virtual Person Person { get; set; }

        //public int a { get; set; }
    }
}
