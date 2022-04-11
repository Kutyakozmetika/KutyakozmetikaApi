using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace KutyakozmetikaApi.Models
{
    [Index(nameof(felhasznaloID), Name = "felhasznaloID")]
    public partial class kutya
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int kutyaID { get; set; }
        [Required]
        [MaxLength(1)]
        public byte[] agresszivE { get; set; }
        [Column(TypeName = "tinyint(4)")]
        public sbyte eletkor { get; set; }
        [Required]
        [StringLength(100)]
        public string fajta { get; set; }
        [Column(TypeName = "int(11)")]
        public int felhasznaloID { get; set; }

        [ForeignKey(nameof(felhasznaloID))]
        [InverseProperty("kutya")]
        public virtual felhasznalo felhasznalo { get; set; }
    }
}
