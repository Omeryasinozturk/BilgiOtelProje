using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtel_Entity
{
    public class OdaDurum
    {
        public int OdaDurumID { get; set; }
        public int OdaId { get; set; }
        public int DurumKategoriId { get; set; }
        public DateTime OdaDurumilktarih { get; set; }
        public DateTime OdaDurumSonTarih { get; set; }
        public bool OdaDurumAktifMi { get; set; }
    }
}
