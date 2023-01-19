using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ungureanu_Gabriel_Sebastian_CIG7.Models
{
    public class Bilet
    {
        public int ID { get; set; }
        [Display(Name = "De la")]
        public int? OrasID { get; set; }
        public Oras? Oras { get; set; }
        public string Destinatie { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }
        [Display(Name = "Ora Plecarii")]
        [DataType(DataType.Time)]
        public DateTime OraPlecarii { get; set; }
        public int? CompanieID { get; set; }
        public Companie? Companie { get; set; }

    }
}
