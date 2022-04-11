﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace KutyakozmetikaApi.Models
{
    public partial class kozmetikus
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int kozmetikusID { get; set; }
        [Required]
        [StringLength(100)]
        public string felhasznalonev { get; set; }
        [Required]
        [StringLength(100)]
        public string nev { get; set; }
        [Required]
        [StringLength(100)]
        public string jelszo { get; set; }
        [Required]
        [StringLength(100)]
        public string telefonszam { get; set; }
        [Required]
        [StringLength(100)]
        public string email { get; set; }
    }
}
