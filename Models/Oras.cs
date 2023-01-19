using System.ComponentModel.DataAnnotations;

namespace Ungureanu_Gabriel_Sebastian_CIG7.Models
{
    public class Oras
    {
        public int ID { get; set; }
        [Display( Name = "Numele Orasului")]
        public string OrasGara { get; set; }
        public string Strada { get; set; }
        [DataType(DataType.Time)]
        [Display(Name = "Ora Deschiderii")]
        public DateTime OraDeschidere { get; set; }
        [DataType(DataType.Time)]
        [Display(Name = "Ora Inchiderii")]
        public DateTime OraInchidere { get; set; }
        public ICollection<Bilet>? Bilete { get; set; }
    }
}
