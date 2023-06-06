using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_WaterSurfaces")]
public partial class LuWaterSurface
{
    [Key]
    public int WaterSurfaceId { get; set; }

    [StringLength(250)]
    public string WaterSurface { get; set; } = null!;

    public bool Active { get; set; }
}
