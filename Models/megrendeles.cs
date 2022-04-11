using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace KutyakozmetikaApi.Models
{
    [Keyless]
    public partial class megrendeles
    {
        [Required]
        [StringLength(15)]
        public string foglalasNapja { get; set; }
        [Required]
        [StringLength(15)]
        public string foglalasOraja { get; set; }
        [Required]
        [StringLength(255)]
        public string felhasznalonev { get; set; }
    }
}
