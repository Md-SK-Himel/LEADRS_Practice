using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_SkinComplexions")]
public partial class LuSkinComplexion
{
    [Key]
    public int SkinId { get; set; }

    [StringLength(250)]
    public string Description { get; set; } = null!;

    [StringLength(10)]
    public string Abbreviation { get; set; } = null!;

    [Column("NCICCode")]
    [StringLength(20)]
    public string Nciccode { get; set; } = null!;

    public bool Active { get; set; }
}
