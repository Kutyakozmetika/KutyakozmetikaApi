using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace KutyakozmetikaApi.Models
{
    public partial class kutya
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int kutyaID { get; set; }
        [Required]
        [StringLength(255)]
        public string agresszivE { get; set; }
        [Required]
        [StringLength(255)]
        public string eletkor { get; set; }
        [Required]
        [StringLength(255)]
        public string fajta { get; set; }
        [Required]
        [StringLength(255)]
        public string tulajNev { get; set; }
    }
}
