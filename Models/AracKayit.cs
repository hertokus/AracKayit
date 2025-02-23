using System;
using System.ComponentModel.DataAnnotations;

namespace GülsanAraçKayıt.Models
{
    public class AracKayit
    {
        public int Id { get; set; }

        [Required]
        public string Plaka { get; set; }

        public string DorsePlakasi { get; set; }

        [Required]
        public string SoforAdi { get; set; }

        [Required]
        public string GuvenlikAdi { get; set; }

        [Required]
        public string NakliyeSirketi { get; set; }

        [Required]
        public string IsletmedenGeldigiYer { get; set; }

         [DataType(DataType.DateTime)]
        public DateTime KayitTarihi { get; set; }

        public bool Onay { get; set; }

        
    }
}
