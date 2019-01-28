using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnnotatlonApp.Entity
{
    [Table("Kisiler",Schema ="dbo")]
   public  class Kisiler
    {
        [Key]
        [Column("KisiId",Order =0)]
        public Guid KisiId { get; set; }
        public Guid FirmaRefId { get; set; }
        [Column("KisiAdi")]
        [Required] // Girilmesi zorunlu olan alan
        [StringLength(40)]
        public string KisiAdi { get; set; }
        [StringLength(50)]
        public string Soyadi { get; set; }
        [Required(ErrorMessage ="mail giriniz")]
        [EmailAddress()]
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(1000)]
        public byte[] Foto { get; set; }
        [ForeignKey("FirmaRefId")]
        public Firma Firma { get; set; }

    }
}    
     