using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtel_Entity
{
    public class Satis
    {
        public int SatisId { get; set; }
        public DateTime SatisOdaGirisTarihi { get; set; }
        public DateTime SatisOdaCikisTarihi { get; set; }
        public int SatisIndirim { get; set; }
        public int KartId { get; set; }
        public int OdaId { get; set; }
        public bool RezervasyonAktifMi { get; set; }
        public decimal OdaSatisTutar { get; set; }
        public decimal OdaSatisKDV { get; set; }
        public int OdaSatisOdemeTipiId { get; set; }
        public bool SatisAktifMi { get; set; }


    }
}
