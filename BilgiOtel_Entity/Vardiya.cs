﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtel_Entity
{
    public class Vardiya
    {

        public int VardiyaId { get; set; }
        public string VardiyaTipi { get; set; }
        public TimeSpan VardiyaBaslangicSaati { get; set; }
        public TimeSpan VardiyaBitisSaati { get; set; }


    }
}
