using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.Siniflar
{
    public class admin
    {
        [Key]
        public int ID { get; set; }
        public string kullanıcıAdı { get; set; }

        public string sifre { get; set; }
    }
}
