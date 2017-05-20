using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class DocLogin
    {
        [Key]
        public int LoginId { get; set; }
        [StringLength(450)]
        [Index(IsUnique = true)]
        public string Login { get; set; }
        [Index(IsUnique = true)]
        public virtual Doctor Doctor { get; set; }
        public string Password { get; set; }
    }
}