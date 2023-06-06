using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_DPSDrugList")]
public partial class LuDpsdrugList
{
    [Key]
    [Column("DPSDrugId")]
    public int DpsdrugId { get; set; }

    [Column("DPSDrug")]
    [StringLength(200)]
    public string Dpsdrug { get; set; } = null!;

    [Column("DPSDrugCategory")]
    [StringLength(200)]
    public string DpsdrugCategory { get; set; } = null!;

    public bool Active { get; set; }
}
