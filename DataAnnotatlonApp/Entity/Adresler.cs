using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace DataAnnotatlonApp.Entity
{
    [Table("Adres", Schema = "dbo")]
    public  class Adresler
    {
        [Key]
        [Column("AdresId")]
        public int AdresId { get; set; }
        [StringLength(500)]
        public string Adres1 { get; set; }
        [StringLength(500)]
        public string Adres2 { get; set; }
        [Phone(ErrorMessage ="Telefon Numarasi Hatalidir.")]
        [StringLength(30)]
        public string Telefon { get; set; }
    }
}
