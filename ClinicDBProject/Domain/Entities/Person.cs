using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(20)]
        public string LastName { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(13)]
        public string PhoneNumber { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(40)]
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        //public virtual Patient Patient { get; set; }
        //public virtual Doctor Doctor { get; set; }
    }
}
