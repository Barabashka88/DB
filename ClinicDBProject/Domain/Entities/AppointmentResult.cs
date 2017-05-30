using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class AppointmentResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResultId { get; set; }
        public virtual Patient Patient { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(150)]
        public string Diagnos { get; set; }
        public virtual ICollection<Analysis> Analyzes { get; set; }
        public virtual ICollection<Drug> Drugs { get; set; }

        public string GetAllDrugs()
        {
            StringBuilder result = new StringBuilder();
            if (Drugs != null)
            {
                foreach (var s in Drugs)
                {
                    result.Append($"{s.Name},");
                }

                if (!string.IsNullOrEmpty(result.ToString()))
                    result = result.Remove(result.Length - 1, 1);
                return result.ToString();
            }
            return null;
        }
        public string GetAllAnalisis()
        {
            StringBuilder result = new StringBuilder();
            if (Analyzes != null)
            {
                foreach (var s in Analyzes)
                {
                    result.Append($"{s.Name},");
                }
                if (!string.IsNullOrEmpty(result.ToString()))
                    result = result.Remove(result.Length - 1, 1);
                return result.ToString();
            }
            return null;
        }
        public decimal GetAnalisisPrice()
        {
            decimal res = 0m;
            foreach (var item in Analyzes)
            {
                res += item.Price;
            }
            return res;
        }
        public decimal GetDrugPrice()
        {
            decimal res = 0m;
            foreach (var item in Drugs)
            {
                res += item.Price;
            }
            return res;
        }
    }
}