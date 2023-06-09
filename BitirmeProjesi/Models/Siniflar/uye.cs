using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.Siniflar
{
    public class uye
    {
        [Key]
        public int ID { get; set; }
        public string Adı { get; set; }

        public string sifre { get; set; }
        public ICollection<Sikayet> Sikayetler { get; set; }
    }
}