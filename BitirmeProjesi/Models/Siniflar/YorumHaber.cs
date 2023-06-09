using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.Siniflar
{
    public class YorumHaber
    {
        public IEnumerable<haberler> Deger { get; set; }
        public IEnumerable<yorum> Deger2 { get; set; }
    }
}