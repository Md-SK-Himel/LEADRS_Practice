using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_EyeColor")]
public partial class LuEyeColor
{
    [Key]
    public int EyeColorId { get; set; }

    [StringLength(50)]
    public string EyeColorName { get; set; } = null!;

    [Column("NCICCode")]
    [StringLength(20)]
    public string Nciccode { get; set; } = null!;

    public bool Active { get; set; }
}
