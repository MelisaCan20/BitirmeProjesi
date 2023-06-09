using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.Siniflar
{
    public class Sikayet
    {
        [Key]
        public int Sikayet_id { get; set; }
        public string Sikayet_icerik { get; set; }
        public int uyeId { get; set; }
        public virtual uye uye { get; set; }
        public ICollection<Cevaplar> Cevaplars { get; set; }
    }
}