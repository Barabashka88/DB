using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorIs { get; set; }
        public virtual Person Person { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        public string Specialization { get; set; }
        public virtual DocLogin Login { get; set; }
    }
}
