using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class DocLogin
    {
        [Key]
        public int LoginId { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(20)]
        [Index(IsUnique = true)]
        public string Login { get; set; }
        [Index(IsUnique = true)]
        public virtual Doctor Doctor { get; set; }
        public string Password { get; set; }
    }
}