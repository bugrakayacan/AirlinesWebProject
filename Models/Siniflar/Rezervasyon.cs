using System;

namespace airlinesSys.Models
{
    public class Rezervasyon
    {
        public string RezervasyonID { get; set; }
        public int KullanıcıID { get; set; }

        public int UcusId { get; set; }
        public string KoltukID { get; set; }
        public DateTime Tarih { get; set; }
    }
}
