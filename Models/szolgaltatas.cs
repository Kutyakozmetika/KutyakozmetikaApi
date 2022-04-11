using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace KutyakozmetikaApi.Models
{
    public partial class szolgaltatas
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int szolgaltatasID { get; set; }
        [Required]
        [StringLength(100)]
        public string szolgaltatasNev { get; set; }
        [Column(TypeName = "int(11)")]
        public int idotartam { get; set; }
        [Column(TypeName = "int(11)")]
        public int ar { get; set; }
    }
}
