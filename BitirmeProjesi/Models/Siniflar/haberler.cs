using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.Siniflar
{
    public class haberler
    {
        [Key]
        public int ID { get; set; }

        public string Baslik { get; set; }

        public string icerik { get; set; }
        public string FotoUrl { get; set; }
        public  DateTime Tarih { get; set; }
        public int kategoriId { get; set; }
        public virtual kategori Kategori { get; set; }
        public ICollection<yorum>Yorumlar { get; set; }


    }
}