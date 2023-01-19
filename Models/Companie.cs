using System.ComponentModel.DataAnnotations;

namespace Ungureanu_Gabriel_Sebastian_CIG7.Models
{
    public class Companie
    {
        public int ID { get; set; }
        [Display(Name = "Numele companiei")]
        public string CompanieN { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Anul infiintarii")]
        public DateTime Anulinfiintari { get; set; }
        [Display(Name = "Adresa sediului")]
        public string Adresa { get; set; }
        public ICollection<Bilet>? Bilete { get; set; }
    }
}
