using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace BitirmeProjesi.Models.Siniflar
{
    public class Context:DbContext
    {
        [Key]
        public DbSet<admin> Admins { get; set; }
        public DbSet<uye> Uyeler { get; set; }
        public DbSet<haberler> Haberler { get; set; }
        public DbSet<yorum>Yorumlar { get; set; }
        public DbSet<kategori> Kategoriler { get; set; }
        public DbSet<Sikayet> Sikayets { get; set; }
        public DbSet<Cevaplar> Cevaplars { get; set; }

    }
}