using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Analysis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnalysisId { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<AppointmentResult> Results { get; set; }
    }
}