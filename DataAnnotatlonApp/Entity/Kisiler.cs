using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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

    }
}
