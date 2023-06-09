using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.Siniflar
{
    public class kategori
    {
        [Key]
        public int ID { get; set; }
        public string KategoriAd { get; set; }
        
        public ICollection<haberler> Haberler { get; set; }
        
    }
}