using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtel_Entity
{
    public class Rezervasyon
    {

        public int RezervasyonId { get; set; }
        public int MusteriId { get; set; }
        public DateTime RezervasyonGecerlilikTarihi { get; set; }
        public DateTime RezervasyonGecerlilikSonTarihi { get; set; }
        public int ErkenRezervasyonIndirim { get; set; }
        public int RezervasyonTipiId { get; set; }
        public string RezervasyonAciklama { get; set; }
        public bool RezervasyonIptalOk { get; set; }
        public bool RezervasyonTarihKontrol { get; set; }
        public int SatisId { get; set; }

    }
}
