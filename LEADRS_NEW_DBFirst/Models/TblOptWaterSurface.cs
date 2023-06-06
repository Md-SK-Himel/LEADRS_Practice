using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Water_Surfaces", Schema = "DUI")]
public partial class TblOptWaterSurface
{
    [Key]
    public int WaterSurfaceId { get; set; }

    [StringLength(50)]
    public string? WaterSurfaceDesc { get; set; }

    public bool Active { get; set; }
}
