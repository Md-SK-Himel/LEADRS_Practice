using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_OffenseTypeLocation")]
public partial class LuOffenseTypeLocation
{
    [Key]
    public int ZoneId { get; set; }

    [StringLength(250)]
    public string Zone { get; set; } = null!;

    public bool Active { get; set; }
}
