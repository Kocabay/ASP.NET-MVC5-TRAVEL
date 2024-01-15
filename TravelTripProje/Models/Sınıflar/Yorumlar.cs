using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Sınıflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullanıcıAdı { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
