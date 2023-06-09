using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace BitirmeProjesi.Models.Siniflar
{
    public class yorum
    {
        [Key]
        public int ID { get; set; }
        public string kullanıcıadı { get; set; }
        public string acıklama { get; set; }
        public int HaberId { get; set; }
        public  virtual haberler Haber { get; set; }
    }
}
