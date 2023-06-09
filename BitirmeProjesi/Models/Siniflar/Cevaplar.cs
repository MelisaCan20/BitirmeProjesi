using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.Siniflar
{
    public class Cevaplar
    {
        [Key]
        public int cevap_id { get; set; }
        public string cevap_icerik { get; set; }
        public Sikayet sikayet { get; set; }
    }
}