using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace KutyakozmetikaApi.Models
{
    [Keyless]
    [Index(nameof(kozmetikusID), Name = "kozmetikusID")]
    [Index(nameof(szolgaltatasID), Name = "szolgaltatasID")]
    public partial class kezeles
    {
        [Column(TypeName = "int(11)")]
        public int kozmetikusID { get; set; }
        [Column(TypeName = "int(11)")]
        public int szolgaltatasID { get; set; }
        [Column(TypeName = "int(11)")]
        public int ar { get; set; }

        [ForeignKey(nameof(kozmetikusID))]
        public virtual kozmetikus kozmetikus { get; set; }
        [ForeignKey(nameof(szolgaltatasID))]
        public virtual szolgaltatas szolgaltatas { get; set; }
    }
}
