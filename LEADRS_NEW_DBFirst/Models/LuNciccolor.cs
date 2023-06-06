using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_NCICColor")]
public partial class LuNciccolor
{
    [Key]
    public int ColorId { get; set; }

    [StringLength(250)]
    public string Description { get; set; } = null!;

    [Column("NCICCode")]
    [StringLength(20)]
    public string Nciccode { get; set; } = null!;

    public bool Active { get; set; }
}
