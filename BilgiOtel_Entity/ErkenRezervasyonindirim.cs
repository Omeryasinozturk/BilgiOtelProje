using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtel_Entity
{
    public class ErkenRezervasyonindirim
    {
        public int ErkenRezindirimID { get; set; }
        public int ErkenRezGunSayisi { get; set; }
        public int ErkenRezindirimOranı { get; set; }
        public string ErkenRezAciklama { get; set; }
        public bool ErkenRezAktifMi { get; set; }

    }
}
